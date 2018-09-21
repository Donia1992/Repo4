namespace Teeth
{
    partial class Home
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patienterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjälpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggaUtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "09:00\tPatient 1:\t\tGuldtandsinstallation",
            "10:30\tPatient 2:\t\tGuldtandsavinstallation",
            "13:00\tPatient 3:\t\tGuldtandsblekning",
            "14:45\tPatient 4:\t\tTandköttsrengöring"});
            this.listBox1.Location = new System.Drawing.Point(23, 76);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(264, 121);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detta händer idag";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.patienterToolStripMenuItem,
            this.schemaToolStripMenuItem,
            this.hjälpToolStripMenuItem,
            this.loggaUtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(620, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // patienterToolStripMenuItem
            // 
            this.patienterToolStripMenuItem.Name = "patienterToolStripMenuItem";
            this.patienterToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.patienterToolStripMenuItem.Text = "Patienter";
            this.patienterToolStripMenuItem.Click += new System.EventHandler(this.patienterToolStripMenuItem_Click);
            // 
            // schemaToolStripMenuItem
            // 
            this.schemaToolStripMenuItem.Name = "schemaToolStripMenuItem";
            this.schemaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.schemaToolStripMenuItem.Text = "Schema";
            this.schemaToolStripMenuItem.Click += new System.EventHandler(this.schemaToolStripMenuItem_Click);
            // 
            // hjälpToolStripMenuItem
            // 
            this.hjälpToolStripMenuItem.Name = "hjälpToolStripMenuItem";
            this.hjälpToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.hjälpToolStripMenuItem.Text = "Röntgenbilder";
            this.hjälpToolStripMenuItem.Click += new System.EventHandler(this.hjälpToolStripMenuItem_Click);
            // 
            // loggaUtToolStripMenuItem
            // 
            this.loggaUtToolStripMenuItem.Name = "loggaUtToolStripMenuItem";
            this.loggaUtToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.loggaUtToolStripMenuItem.Text = "Logga ut";
            this.loggaUtToolStripMenuItem.Click += new System.EventHandler(this.loggaUtToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nyheter från verksamheten";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "19/09-2018:\tVi börjar få ont om gummihandskar.",
            "20/09-2018:\tNya gummihandskar beställda."});
            this.listBox2.Location = new System.Drawing.Point(331, 76);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(263, 121);
            this.listBox2.TabIndex = 4;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(620, 245);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patienterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hjälpToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ToolStripMenuItem loggaUtToolStripMenuItem;
    }
}