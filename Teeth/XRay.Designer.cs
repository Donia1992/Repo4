namespace Teeth
{
    partial class XRay
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
            this.choosePictureComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // choosePictureComboBox
            // 
            this.choosePictureComboBox.FormattingEnabled = true;
            this.choosePictureComboBox.Location = new System.Drawing.Point(41, 85);
            this.choosePictureComboBox.Name = "choosePictureComboBox";
            this.choosePictureComboBox.Size = new System.Drawing.Size(121, 21);
            this.choosePictureComboBox.TabIndex = 1;
            this.choosePictureComboBox.SelectedIndexChanged += new System.EventHandler(this.choosePictureComboBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(203, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(770, 531);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // XRay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(1000, 602);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.choosePictureComboBox);
            this.Name = "XRay";
            this.Text = "X-ray viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox choosePictureComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}