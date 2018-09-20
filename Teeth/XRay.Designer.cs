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
            this.choosePictureComboBox.Location = new System.Drawing.Point(55, 105);
            this.choosePictureComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.choosePictureComboBox.Name = "choosePictureComboBox";
            this.choosePictureComboBox.Size = new System.Drawing.Size(160, 24);
            this.choosePictureComboBox.TabIndex = 1;
            this.choosePictureComboBox.SelectedIndexChanged += new System.EventHandler(this.choosePictureComboBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(271, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1027, 654);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // XRay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(1333, 741);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.choosePictureComboBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "XRay";
            this.Text = "X-ray viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.XRay_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox choosePictureComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}