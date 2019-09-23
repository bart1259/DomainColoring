using DynamicExpresso;
using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomainColoring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private Bitmap image;
        private float zoomWidth = 16.000f;
        private float xPosition = 0.0f;
        private float yPosition = 0.0f;
        private float sensitivity = 0.1f;
        //The lambda equation that contains the complex function logic
        private Lambda complexEquation;
        //Have refrence to the image form that handles outputing the image
        private SaveImageForm saveImageForm;

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(new ComplexNumber(1,1) ^ new ComplexNumber(1,1));

            UpdateImage();
        }


        private void UpdateImage()
        {
            //Generate an image with the resolution dictated by the quality bar
            image = GenerateImage(graphBox.Size.Width, graphBox.Size.Height, (int)Math.Round(Math.Pow(2, qualityTrackBar.Value / 100.0)));
            Refresh();
        }

        //Generates and returns the generated image
        public Bitmap GenerateImage(int width, int height, int skipNum)
        {

            if (CreateExpressionFromString(complexExpression.Text) == false)
            {
                //Failed to compile expression
                Console.WriteLine("Failed to interpret expression: " + complexExpression.Text);
                errorLabel.Text = "Failed to interpret expression";
                return null;
            }

            Bitmap bitMap = new Bitmap(width, height);

            float modValue = modValueSlider.Value / 1000.0f;

            //Create a handle to the graphics of the bitmap
            //This is only used if the quality is relativly low
            Graphics g = Graphics.FromImage(bitMap);


            for (int x = 0; x < width; x+= skipNum)
            {
                for (int y = 0; y < height; y+= skipNum)
                {

                    //Get the value of the complex number from the inputed function
                    //The input must be transformed based on the position, zoom, and 
                    //final resolution of the image
                    ComplexNumber result = (ComplexNumber)complexEquation.Invoke(new ComplexNumber(
                        (x - (width / 2)) * (zoomWidth / (width)) + xPosition,
                        (y - (height / 2)) * (zoomWidth / (width)) + yPosition));
                    //Get the color corresponding to the result using domain coloring
                    Color col = ColorFromHSV(result.argument, 1, 0.5 + (Math.Pow(result.magnitude, exponentSlider.Value / 1000.0) % modValue / (modValue * 2)));


                    g.FillRectangle(new SolidBrush(col), new Rectangle(x, y, (int)Math.Ceiling((double)skipNum), (int)Math.Ceiling((double)skipNum)));
                    //Continue after drawing the bitmap
                    continue;
                }
            }
            //The way the image is generated means that it has to 
            bitMap.RotateFlip(RotateFlipType.RotateNoneFlipY);

            Console.WriteLine("Done");

            return bitMap;
        }


        //Override the paint component
        protected override void OnPaint(PaintEventArgs e)
        {
            //Draw the form normally
            base.OnPaint(e);
            if (image != null)
            {
                //Draw the graph ontop of the form where the graph box is
                e.Graphics.DrawImage(image,graphBox.Location.X ,graphBox.Location.Y);
            }

        }

        //Converts a HSV color to a c# RGB color
        //credit: https://stackoverflow.com/questions/1335426/is-there-a-built-in-c-net-system-api-for-hsv-to-rgb/17766043
        public static Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }

        private void zoomInButton_Click(object sender, EventArgs e)
        {
            //Zoom in
            zoomWidth -= zoomWidth * 0.1f;
            //Update the position text and possibly regenrate the image
            UpdatePosition();
        }

        private void zoomOutButton_Click(object sender, EventArgs e)
        {
            //Zoom out
            zoomWidth += zoomWidth * 0.1f;
            //Update the position text and possibly regenrate the image
            UpdatePosition();
        }


        private void UpdatePosition(bool updateText = true)
        {
            if (updateText)
            {
                //Update all the text in the 
                xCenter.Text = xPosition.ToString("0.000");
                yCenter.Text = yPosition.ToString("0.000");
                zoomLevel.Text = zoomWidth.ToString("0.000");
            }


            if (autoGenerate.Checked)
                UpdateImage();
        }

        private void yCenter_TextChanged(object sender, EventArgs e)
        {

            //See if the YCenter is a valid number
            if (float.TryParse(yCenter.Text, out yPosition) == false)
            {
                errorLabel.Text = "Y Position is invalid";
                return;
            }

            //Reset error label text
            errorLabel.Text = "";

            UpdatePosition(false);
        }

        private void xCenter_TextChanged(object sender, EventArgs e)
        {
            //See if the XCenter is a valid number
            if (float.TryParse(xCenter.Text, out xPosition) == false)
            {
                errorLabel.Text = "X Position is invalid";
                return;
            }

            //Reset error label text
            errorLabel.Text = "";

            UpdatePosition(false);
        }

        private void zoomLevel_TextChanged(object sender, EventArgs e)
        {
            //See if the XCenter is a valid number
            if (float.TryParse(zoomLevel.Text, out zoomWidth) == false || zoomWidth <= 0)
            {
                errorLabel.Text = "Zoom value is invalid";
                return;
            }

            //Reset error label text
            errorLabel.Text = "";

            UpdatePosition(false);
        }

        //Creates a function from a string
        //Returns weather or not it was successful
        private bool CreateExpressionFromString(string expres)
        {

            try
            {
                //Create common functions
                Func<ComplexNumber, ComplexNumber> sin = (x) => ComplexNumber.Sine(x);
                Func<ComplexNumber, ComplexNumber> cos = (x) => ComplexNumber.Cosine(x);
                Func<ComplexNumber, ComplexNumber> tan = (x) => ComplexNumber.Tangent(x);

                //Create the code interpreter
                var interpreter = new Interpreter();

                //Add functions and constant variables to interpreter
                interpreter.SetFunction("sin", sin);
                interpreter.SetFunction("cos", cos);
                interpreter.SetFunction("tan", tan);
                interpreter.SetVariable("i", ComplexNumber.i);
                interpreter.SetVariable("pi", Math.PI);

                string expression = expres;
                complexEquation = interpreter.Parse(expression, new Parameter("z", typeof(ComplexNumber)));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        //Button control that exports the image
        private void exportButton_Click(object sender, EventArgs e)
        {
            //Open a new form if there is not one open already
            if(saveImageForm == null || saveImageForm.IsDisposed)
            {
                saveImageForm = new SaveImageForm(this);
                saveImageForm.Show();
            }
        }


        //Movment button controls
        //Moves the camera in the appropriate direction proprotinatly
        //to the sensitivity and the zoom width.

        private void upArrowButton_Click(object sender, EventArgs e)
        {
            yPosition += zoomWidth * sensitivity;
            UpdatePosition();
        }

        private void downArrowButton_Click(object sender, EventArgs e)
        {
            yPosition -= zoomWidth * sensitivity;
            UpdatePosition();
        }

        private void rightArrowButton_Click(object sender, EventArgs e)
        {
            xPosition += zoomWidth * sensitivity;
            UpdatePosition();
        }

        private void leftArrowButton_Click(object sender, EventArgs e)
        {
            xPosition -= zoomWidth * sensitivity;
            UpdatePosition();
        }
    }
}
