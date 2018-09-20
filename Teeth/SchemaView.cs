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
    public partial class SchemaView : Form
    {
        public SchemaView()
        {
            InitializeComponent();
        }

        private void SchemaView_Load(object sender, EventArgs e)
        {
            lblDay1.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            DateTime dt = monthCalendar1.SelectionRange.Start;
            dt = dt.AddDays(1);
            lblDay2.Text = dt.ToShortDateString();
            dt = dt.AddDays(1);
            lblDay3.Text = dt.ToShortDateString();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            lblDay1.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            DateTime dt = monthCalendar1.SelectionRange.Start;
            dt = dt.AddDays(1);
            lblDay2.Text = dt.ToShortDateString();
            dt = dt.AddDays(1);
            lblDay3.Text = dt.ToShortDateString();
        }
    }
}
