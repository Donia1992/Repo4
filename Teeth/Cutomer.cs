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
    public partial class Cutomer : Form
    {
        public Cutomer()
        {
            InitializeComponent();
        }

        private void Cutomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Home hm = new Home();
            hm.Show();
        }
    }
}
