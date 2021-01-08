namespace Fractal_Julia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ResetOriginalButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.EquationTextBox = new System.Windows.Forms.TextBox();
            this.ZoomTrackBar = new System.Windows.Forms.TrackBar();
            this.EquationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 800);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDoubleClick);
            // 
            // ResetOriginalButton
            // 
            this.ResetOriginalButton.Location = new System.Drawing.Point(900, 756);
            this.ResetOriginalButton.Name = "ResetOriginalButton";
            this.ResetOriginalButton.Size = new System.Drawing.Size(100, 23);
            this.ResetOriginalButton.TabIndex = 1;
            this.ResetOriginalButton.Text = "Reset to Original";
            this.ResetOriginalButton.UseVisualStyleBackColor = true;
            this.ResetOriginalButton.Click += new System.EventHandler(this.ResetOriginalButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(1007, 756);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(100, 23);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // EquationTextBox
            // 
            this.EquationTextBox.Location = new System.Drawing.Point(924, 85);
            this.EquationTextBox.Name = "EquationTextBox";
            this.EquationTextBox.Size = new System.Drawing.Size(100, 20);
            this.EquationTextBox.TabIndex = 3;
            this.EquationTextBox.Text = "-0.4 - 0.59i";
            // 
            // ZoomTrackBar
            // 
            this.ZoomTrackBar.Location = new System.Drawing.Point(900, 205);
            this.ZoomTrackBar.Minimum = 1;
            this.ZoomTrackBar.Name = "ZoomTrackBar";
            this.ZoomTrackBar.Size = new System.Drawing.Size(202, 45);
            this.ZoomTrackBar.TabIndex = 4;
            this.ZoomTrackBar.Value = 1;
            // 
            // EquationButton
            // 
            this.EquationButton.Location = new System.Drawing.Point(1030, 83);
            this.EquationButton.Name = "EquationButton";
            this.EquationButton.Size = new System.Drawing.Size(100, 23);
            this.EquationButton.TabIndex = 5;
            this.EquationButton.Text = "Enter";
            this.EquationButton.UseVisualStyleBackColor = true;
            this.EquationButton.Click += new System.EventHandler(this.EquationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(896, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Different C-Vale:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(898, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "C=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(897, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Zoom into or Shift the Fractal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(898, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 52);
            this.label4.TabIndex = 9;
            this.label4.Text = "Double click on the picturebox to shift and \r\nzoom into that point. Use slider to" +
    " indicate \r\nby what factor you would like to zoom in.  \r\nYou can only zoom in or" +
    " shift once.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(897, 734);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Reset Factal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(927, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 39);
            this.label6.TabIndex = 11;
            this.label6.Text = "Julia Fractal";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1175, 781);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "By Jay";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(823, 322);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 400);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox2_MouseDoubleClick);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox2_MouseMove);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(899, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "Double click on the Madelbrot Set to use the\r\npoint as the C-value of the Julia S" +
    "et.\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(897, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Use Madelbrot Set:";
            // 
            // cValueLabel
            // 
            this.cValueLabel.AutoSize = true;
            this.cValueLabel.Location = new System.Drawing.Point(899, 297);
            this.cValueLabel.Name = "cValueLabel";
            this.cValueLabel.Size = new System.Drawing.Size(44, 13);
            this.cValueLabel.TabIndex = 17;
            this.cValueLabel.Text = "C-Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 800);
            this.Controls.Add(this.cValueLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EquationButton);
            this.Controls.Add(this.ZoomTrackBar);
            this.Controls.Add(this.EquationTextBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ResetOriginalButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Julia Fractal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ResetOriginalButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox EquationTextBox;
        private System.Windows.Forms.TrackBar ZoomTrackBar;
        private System.Windows.Forms.Button EquationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label cValueLabel;
    }
}

