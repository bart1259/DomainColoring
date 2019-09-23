using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomainColoring
{
    public partial class SaveImageForm : Form
    {
        Form1 originalForm;

        //Get a refrence to the original form to get
        //access to the complex function
        public SaveImageForm(Form1 form)
        {
            originalForm = form;
            InitializeComponent();
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            //Clear any error messages
            SetErrorMessage("");
            //Set the progress to working
            progressLabel.Text = "Working...";
            
            //A refresh is needed in order for the label text to change in the GUI.
            //This is not normally needed but is needed here because the GUI update thread
            //will be busy rendering the image
            Refresh();
        
            int width;
            int height;
            //Parse the width
            if (int.TryParse(ImageWidth.Text,out width) == false)
            {
                SetErrorMessage("Could not parse width");
                return;
            }

            //Parse the height
            if (int.TryParse(imageHeight.Text, out height) == false)
            {
                SetErrorMessage("Could not parse height");
                return;
            }

            //Ensure output type is valid
            if (imageFormatOutput.SelectedItem == null)
            {
                SetErrorMessage("Please select an image output format");
                return;
            }

            //Get output image format
            ImageFormat imgFormat = GetImageFormatFromString((string)imageFormatOutput.SelectedItem);

            //Ensure image export directory exists
            if (System.IO.Directory.Exists(outputDirectory.Text) == false)
            {
                SetErrorMessage( "Path does not exist");
                return;
            }

            //Try generating the image
            Bitmap generatedImage;
            try
            {
                //Generate image with highest resolution
                generatedImage = originalForm.GenerateImage(width, height,1);
            }
            catch (Exception)
            {
                SetErrorMessage( "Could not generate image");
                return;
            }

            //Try saving the image
            try
            {
                //Save Image
                string savePath = outputDirectory.Text + "\\" + fileName.Text + "." + imgFormat.ToString();
                generatedImage.Save(savePath, imgFormat);
            }
            catch (Exception)
            {
                SetErrorMessage("Could not output image");
                return;
            }

            //Clear error
            SetErrorMessage("");
            progressLabel.Text = "Done";

        }
        
        //Sets the message error
        private void SetErrorMessage(string errorMessage)
        {
            //If the error message is not blank (It is not getting cleared)
            //Set the progress label to empty so it does not interfere with the
            //error label
            if (errorMessage != "")
            {
                progressLabel.Text = "";
            }
            //Set the error label text
            errorLabel.Text = errorMessage;
        }

        //Converts string to an image format
        private ImageFormat GetImageFormatFromString(string str)
        {
            if (str == "BMP")
                return ImageFormat.Bmp;
            else if (str == "JPG")
                return ImageFormat.Jpeg;
            else if (str == "PNG")
                return ImageFormat.Png;
            else if (str == "TIFF")
                return ImageFormat.Tiff;
            else if (str == "Gif")
                return ImageFormat.Gif;

            //This should never execute
            return null;
        }
    }
}
