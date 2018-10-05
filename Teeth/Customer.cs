using System.Windows.Forms;

namespace Teeth
{
    public partial class Customer : Form
    {
        public Customer()
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
