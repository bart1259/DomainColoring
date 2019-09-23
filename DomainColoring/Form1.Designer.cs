namespace DomainColoring
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.graphBox = new System.Windows.Forms.PictureBox();
            this.modValueSlider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exponentSlider = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.zoomInButton = new System.Windows.Forms.Button();
            this.zoomOutButton = new System.Windows.Forms.Button();
            this.qualityTrackBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.upArrowButton = new System.Windows.Forms.Button();
            this.downArrowButton = new System.Windows.Forms.Button();
            this.rightArrowButton = new System.Windows.Forms.Button();
            this.leftArrowButton = new System.Windows.Forms.Button();
            this.xCenter = new System.Windows.Forms.TextBox();
            this.yCenter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.complexExpression = new System.Windows.Forms.TextBox();
            this.autoGenerate = new System.Windows.Forms.CheckBox();
            this.zoomLevel = new System.Windows.Forms.TextBox();
            this.exportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.graphBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modValueSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exponentSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualityTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(704, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // graphBox
            // 
            this.graphBox.Location = new System.Drawing.Point(12, 12);
            this.graphBox.Name = "graphBox";
            this.graphBox.Size = new System.Drawing.Size(674, 488);
            this.graphBox.TabIndex = 1;
            this.graphBox.TabStop = false;
            this.graphBox.Visible = false;
            // 
            // modValueSlider
            // 
            this.modValueSlider.LargeChange = 1000;
            this.modValueSlider.Location = new System.Drawing.Point(694, 99);
            this.modValueSlider.Maximum = 5000;
            this.modValueSlider.Minimum = 1;
            this.modValueSlider.Name = "modValueSlider";
            this.modValueSlider.Size = new System.Drawing.Size(257, 45);
            this.modValueSlider.SmallChange = 1000;
            this.modValueSlider.TabIndex = 1000;
            this.modValueSlider.TickFrequency = 500;
            this.modValueSlider.Value = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(705, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Magnitude Line Spacing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(705, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1001;
            this.label2.Text = "ExponentialDecay";
            // 
            // exponentSlider
            // 
            this.exponentSlider.LargeChange = 1000;
            this.exponentSlider.Location = new System.Drawing.Point(694, 147);
            this.exponentSlider.Maximum = 1000;
            this.exponentSlider.Minimum = 1;
            this.exponentSlider.Name = "exponentSlider";
            this.exponentSlider.Size = new System.Drawing.Size(257, 45);
            this.exponentSlider.SmallChange = 1000;
            this.exponentSlider.TabIndex = 100;
            this.exponentSlider.TickFrequency = 100;
            this.exponentSlider.Value = 175;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(705, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1002;
            this.label3.Text = "Zoom";
            // 
            // zoomInButton
            // 
            this.zoomInButton.Location = new System.Drawing.Point(706, 198);
            this.zoomInButton.Name = "zoomInButton";
            this.zoomInButton.Size = new System.Drawing.Size(116, 23);
            this.zoomInButton.TabIndex = 1003;
            this.zoomInButton.Text = "Zoom In";
            this.zoomInButton.UseVisualStyleBackColor = true;
            this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
            // 
            // zoomOutButton
            // 
            this.zoomOutButton.Location = new System.Drawing.Point(835, 198);
            this.zoomOutButton.Name = "zoomOutButton";
            this.zoomOutButton.Size = new System.Drawing.Size(116, 23);
            this.zoomOutButton.TabIndex = 1004;
            this.zoomOutButton.Text = "Zoom Out";
            this.zoomOutButton.UseVisualStyleBackColor = true;
            this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
            // 
            // qualityTrackBar
            // 
            this.qualityTrackBar.LargeChange = 100;
            this.qualityTrackBar.Location = new System.Drawing.Point(692, 386);
            this.qualityTrackBar.Maximum = 500;
            this.qualityTrackBar.Minimum = 1;
            this.qualityTrackBar.Name = "qualityTrackBar";
            this.qualityTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.qualityTrackBar.RightToLeftLayout = true;
            this.qualityTrackBar.Size = new System.Drawing.Size(257, 45);
            this.qualityTrackBar.SmallChange = 10;
            this.qualityTrackBar.TabIndex = 1005;
            this.qualityTrackBar.TickFrequency = 100;
            this.qualityTrackBar.Value = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(703, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 1006;
            this.label4.Text = "Quality";
            // 
            // upArrowButton
            // 
            this.upArrowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upArrowButton.Location = new System.Drawing.Point(750, 292);
            this.upArrowButton.Name = "upArrowButton";
            this.upArrowButton.Size = new System.Drawing.Size(34, 34);
            this.upArrowButton.TabIndex = 1007;
            this.upArrowButton.Text = "↑";
            this.upArrowButton.UseVisualStyleBackColor = true;
            this.upArrowButton.Click += new System.EventHandler(this.upArrowButton_Click);
            // 
            // downArrowButton
            // 
            this.downArrowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downArrowButton.Location = new System.Drawing.Point(750, 332);
            this.downArrowButton.Name = "downArrowButton";
            this.downArrowButton.Size = new System.Drawing.Size(34, 34);
            this.downArrowButton.TabIndex = 1008;
            this.downArrowButton.Text = "↓";
            this.downArrowButton.UseVisualStyleBackColor = true;
            this.downArrowButton.Click += new System.EventHandler(this.downArrowButton_Click);
            // 
            // rightArrowButton
            // 
            this.rightArrowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightArrowButton.Location = new System.Drawing.Point(790, 311);
            this.rightArrowButton.Name = "rightArrowButton";
            this.rightArrowButton.Size = new System.Drawing.Size(34, 34);
            this.rightArrowButton.TabIndex = 1009;
            this.rightArrowButton.Text = "→";
            this.rightArrowButton.UseVisualStyleBackColor = true;
            this.rightArrowButton.Click += new System.EventHandler(this.rightArrowButton_Click);
            // 
            // leftArrowButton
            // 
            this.leftArrowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftArrowButton.Location = new System.Drawing.Point(710, 311);
            this.leftArrowButton.Name = "leftArrowButton";
            this.leftArrowButton.Size = new System.Drawing.Size(34, 34);
            this.leftArrowButton.TabIndex = 1010;
            this.leftArrowButton.Text = "←";
            this.leftArrowButton.UseVisualStyleBackColor = true;
            this.leftArrowButton.Click += new System.EventHandler(this.leftArrowButton_Click);
            // 
            // xCenter
            // 
            this.xCenter.Location = new System.Drawing.Point(863, 303);
            this.xCenter.Name = "xCenter";
            this.xCenter.Size = new System.Drawing.Size(88, 20);
            this.xCenter.TabIndex = 1011;
            this.xCenter.Text = "0.000";
            this.xCenter.TextChanged += new System.EventHandler(this.xCenter_TextChanged);
            // 
            // yCenter
            // 
            this.yCenter.Location = new System.Drawing.Point(863, 332);
            this.yCenter.Name = "yCenter";
            this.yCenter.Size = new System.Drawing.Size(88, 20);
            this.yCenter.TabIndex = 1012;
            this.yCenter.Text = "0.000";
            this.yCenter.TextChanged += new System.EventHandler(this.yCenter_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(840, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 1013;
            this.label5.Text = "X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(840, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 1014;
            this.label6.Text = "Y:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(706, 434);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 1015;
            // 
            // complexExpression
            // 
            this.complexExpression.Location = new System.Drawing.Point(706, 38);
            this.complexExpression.Name = "complexExpression";
            this.complexExpression.Size = new System.Drawing.Size(245, 20);
            this.complexExpression.TabIndex = 1016;
            this.complexExpression.Text = "sin(z) + z^2";
            // 
            // autoGenerate
            // 
            this.autoGenerate.AutoSize = true;
            this.autoGenerate.Checked = true;
            this.autoGenerate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoGenerate.Location = new System.Drawing.Point(704, 433);
            this.autoGenerate.Name = "autoGenerate";
            this.autoGenerate.Size = new System.Drawing.Size(95, 17);
            this.autoGenerate.TabIndex = 1017;
            this.autoGenerate.Text = "Auto Generate";
            this.autoGenerate.UseVisualStyleBackColor = true;
            // 
            // zoomLevel
            // 
            this.zoomLevel.Location = new System.Drawing.Point(710, 237);
            this.zoomLevel.Name = "zoomLevel";
            this.zoomLevel.Size = new System.Drawing.Size(237, 20);
            this.zoomLevel.TabIndex = 1018;
            this.zoomLevel.Text = "16.000";
            this.zoomLevel.TextChanged += new System.EventHandler(this.zoomLevel_TextChanged);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(704, 477);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(243, 23);
            this.exportButton.TabIndex = 1019;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 512);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.zoomLevel);
            this.Controls.Add(this.autoGenerate);
            this.Controls.Add(this.complexExpression);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yCenter);
            this.Controls.Add(this.xCenter);
            this.Controls.Add(this.leftArrowButton);
            this.Controls.Add(this.rightArrowButton);
            this.Controls.Add(this.downArrowButton);
            this.Controls.Add(this.upArrowButton);
            this.Controls.Add(this.qualityTrackBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zoomOutButton);
            this.Controls.Add(this.zoomInButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exponentSlider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modValueSlider);
            this.Controls.Add(this.graphBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.graphBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modValueSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exponentSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualityTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox graphBox;
        private System.Windows.Forms.TrackBar modValueSlider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar exponentSlider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button zoomInButton;
        private System.Windows.Forms.Button zoomOutButton;
        private System.Windows.Forms.TrackBar qualityTrackBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button upArrowButton;
        private System.Windows.Forms.Button downArrowButton;
        private System.Windows.Forms.Button rightArrowButton;
        private System.Windows.Forms.Button leftArrowButton;
        private System.Windows.Forms.TextBox xCenter;
        private System.Windows.Forms.TextBox yCenter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox complexExpression;
        private System.Windows.Forms.CheckBox autoGenerate;
        private System.Windows.Forms.TextBox zoomLevel;
        private System.Windows.Forms.Button exportButton;
    }
}

