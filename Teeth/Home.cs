using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teeth
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loggaUtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.enlogin.Show();
        }

        private void hjälpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            XRay xRay = new XRay();
            xRay.Show();
        }

        private void schemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            SchemaView sw = new SchemaView();
            sw.Show();
        }

        private void patienterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Customer ct = new Customer();
            ct.Show();
        }
    }
}
