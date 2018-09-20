using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Teeth
{
    public partial class XRay : Form
    {
        string path, originPath;
        public XRay()
        {
            InitializeComponent();
            FillComboBox();
        }

        private void choosePictureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            path = originPath;
            path += choosePictureComboBox.SelectedItem;
            pictureBox1.Image = Image.FromFile(path);
        }

        private void XRay_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Program.hem.Show();
            
        }

        private void FillComboBox()
        {
            //DirectoryInfo("")
            System.Console.WriteLine(Application.StartupPath);
            string parent = Directory.GetParent(Application.StartupPath).ToString();
            string grandParent = Directory.GetParent(parent).ToString();
            grandParent += "\\Pictures\\";
            originPath = grandParent;
            DirectoryInfo di = new DirectoryInfo(grandParent);
            FileInfo[] files = di.GetFiles("*.jpg");

            choosePictureComboBox.DataSource = files;
            choosePictureComboBox.DisplayMember = "X-rays";

        }
    }
}
