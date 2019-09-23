namespace DomainColoring
{
    partial class SaveImageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.outputDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.imageFormatOutput = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ImageWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imageHeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.outputButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.progressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputDirectory
            // 
            this.outputDirectory.Location = new System.Drawing.Point(37, 51);
            this.outputDirectory.Name = "outputDirectory";
            this.outputDirectory.Size = new System.Drawing.Size(451, 20);
            this.outputDirectory.TabIndex = 0;
            this.outputDirectory.Text = "C:\\Users\\bart.gebka\\Desktop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Output Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "File Name";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(37, 100);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(297, 20);
            this.fileName.TabIndex = 3;
            this.fileName.Text = "output";
            // 
            // imageFormatOutput
            // 
            this.imageFormatOutput.FormattingEnabled = true;
            this.imageFormatOutput.Items.AddRange(new object[] {
            "BMP",
            "JPG",
            "PNG",
            "TIFF",
            "GIF"});
            this.imageFormatOutput.Location = new System.Drawing.Point(352, 100);
            this.imageFormatOutput.Name = "imageFormatOutput";
            this.imageFormatOutput.Size = new System.Drawing.Size(136, 21);
            this.imageFormatOutput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "OutputFormat";
            // 
            // ImageWidth
            // 
            this.ImageWidth.Location = new System.Drawing.Point(37, 149);
            this.ImageWidth.Name = "ImageWidth";
            this.ImageWidth.Size = new System.Drawing.Size(108, 20);
            this.ImageWidth.TabIndex = 6;
            this.ImageWidth.Text = "1024";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Width";
            // 
            // imageHeight
            // 
            this.imageHeight.Location = new System.Drawing.Point(171, 149);
            this.imageHeight.Name = "imageHeight";
            this.imageHeight.Size = new System.Drawing.Size(108, 20);
            this.imageHeight.TabIndex = 8;
            this.imageHeight.Text = "1024";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Height";
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(310, 147);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(178, 23);
            this.outputButton.TabIndex = 10;
            this.outputButton.Text = "Output";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(34, 186);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 11;
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(40, 186);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(0, 13);
            this.progressLabel.TabIndex = 12;
            // 
            // SaveImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 217);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.imageHeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ImageWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imageFormatOutput);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputDirectory);
            this.Name = "SaveImageForm";
            this.Text = "SaveImageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.ComboBox imageFormatOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ImageWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox imageHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label progressLabel;
    }
}