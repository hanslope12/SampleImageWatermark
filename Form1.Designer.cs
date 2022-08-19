namespace SampleImageWatermark
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button Upload;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Save = new System.Windows.Forms.Button();
            this.WaterMarkText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TopLeftButton = new System.Windows.Forms.Button();
            this.TopMiddleButton = new System.Windows.Forms.Button();
            this.TopRightButton = new System.Windows.Forms.Button();
            this.BottomLeftButton = new System.Windows.Forms.Button();
            this.BottomMiddleButton = new System.Windows.Forms.Button();
            this.BottomRightButton = new System.Windows.Forms.Button();
            Upload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Upload
            // 
            Upload.Location = new System.Drawing.Point(122, 493);
            Upload.Name = "Upload";
            Upload.Size = new System.Drawing.Size(362, 29);
            Upload.TabIndex = 1;
            Upload.Text = "Select a picture";
            Upload.UseVisualStyleBackColor = true;
            Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(685, 486);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Save
            // 
            this.Save.Enabled = false;
            this.Save.Location = new System.Drawing.Point(940, 686);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(94, 29);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // WaterMarkText
            // 
            this.WaterMarkText.Location = new System.Drawing.Point(828, 540);
            this.WaterMarkText.Multiline = true;
            this.WaterMarkText.Name = "WaterMarkText";
            this.WaterMarkText.Size = new System.Drawing.Size(333, 128);
            this.WaterMarkText.TabIndex = 4;
            this.WaterMarkText.TextChanged += new System.EventHandler(this.WaterMarkText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(714, 600);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "WatermarkText";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 600);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "WaterMark side";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(693, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(685, 486);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // TopLeftButton
            // 
            this.TopLeftButton.Enabled = false;
            this.TopLeftButton.Location = new System.Drawing.Point(22, 639);
            this.TopLeftButton.Name = "TopLeftButton";
            this.TopLeftButton.Size = new System.Drawing.Size(111, 29);
            this.TopLeftButton.TabIndex = 14;
            this.TopLeftButton.Text = "Top Left";
            this.TopLeftButton.UseVisualStyleBackColor = true;
            this.TopLeftButton.Click += new System.EventHandler(this.TopLeftButton_Click);
            // 
            // TopMiddleButton
            // 
            this.TopMiddleButton.Enabled = false;
            this.TopMiddleButton.Location = new System.Drawing.Point(190, 639);
            this.TopMiddleButton.Name = "TopMiddleButton";
            this.TopMiddleButton.Size = new System.Drawing.Size(127, 29);
            this.TopMiddleButton.TabIndex = 15;
            this.TopMiddleButton.Text = "Top Middle";
            this.TopMiddleButton.UseVisualStyleBackColor = true;
            this.TopMiddleButton.Click += new System.EventHandler(this.TopMiddleButton_Click);
            // 
            // TopRightButton
            // 
            this.TopRightButton.Enabled = false;
            this.TopRightButton.Location = new System.Drawing.Point(412, 639);
            this.TopRightButton.Name = "TopRightButton";
            this.TopRightButton.Size = new System.Drawing.Size(115, 29);
            this.TopRightButton.TabIndex = 16;
            this.TopRightButton.Text = "Top Right";
            this.TopRightButton.UseVisualStyleBackColor = true;
            this.TopRightButton.Click += new System.EventHandler(this.TopRightButton_Click);
            // 
            // BottomLeftButton
            // 
            this.BottomLeftButton.Enabled = false;
            this.BottomLeftButton.Location = new System.Drawing.Point(22, 715);
            this.BottomLeftButton.Name = "BottomLeftButton";
            this.BottomLeftButton.Size = new System.Drawing.Size(111, 29);
            this.BottomLeftButton.TabIndex = 17;
            this.BottomLeftButton.Text = "Bottom Left";
            this.BottomLeftButton.UseVisualStyleBackColor = true;
            this.BottomLeftButton.Click += new System.EventHandler(this.BottomLeftButton_Click);
            // 
            // BottomMiddleButton
            // 
            this.BottomMiddleButton.Enabled = false;
            this.BottomMiddleButton.Location = new System.Drawing.Point(190, 715);
            this.BottomMiddleButton.Name = "BottomMiddleButton";
            this.BottomMiddleButton.Size = new System.Drawing.Size(127, 29);
            this.BottomMiddleButton.TabIndex = 18;
            this.BottomMiddleButton.Text = "Bottom Middle";
            this.BottomMiddleButton.UseVisualStyleBackColor = true;
            this.BottomMiddleButton.Click += new System.EventHandler(this.BottomMiddleButton_Click);
            // 
            // BottomRightButton
            // 
            this.BottomRightButton.Enabled = false;
            this.BottomRightButton.Location = new System.Drawing.Point(412, 715);
            this.BottomRightButton.Name = "BottomRightButton";
            this.BottomRightButton.Size = new System.Drawing.Size(115, 29);
            this.BottomRightButton.TabIndex = 19;
            this.BottomRightButton.Text = "Bottom Right";
            this.BottomRightButton.UseVisualStyleBackColor = true;
            this.BottomRightButton.Click += new System.EventHandler(this.BottomRightButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 774);
            this.Controls.Add(this.BottomRightButton);
            this.Controls.Add(this.BottomMiddleButton);
            this.Controls.Add(this.BottomLeftButton);
            this.Controls.Add(this.TopRightButton);
            this.Controls.Add(this.TopMiddleButton);
            this.Controls.Add(this.TopLeftButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WaterMarkText);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(Upload);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Upload;
        private PictureBox pictureBox1;
        private Button Save;
        private TextBox WaterMarkText;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private Button TopLeftButton;
        private Button TopMiddleButton;
        private Button TopRightButton;
        private Button BottomLeftButton;
        private Button BottomMiddleButton;
        private Button BottomRightButton;
    }
}