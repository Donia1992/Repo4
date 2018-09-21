using System;
using System.Collections;
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
        ListViewItem item = new ListViewItem();
        List<string> names = new List<string> { "E.Lindholm DMD", " ", "V.Örnsköld DMD", "Ö.Kritoma DMD", "S.Karlborg CDA", " ", "S.Lövkrans CDA", " ", "K.Bernard DMD", " ", "K.Nolbeck CDA", "F.Älvs DMD", " ", " "};

        public SchemaView()
        {
            InitializeComponent();
        }

        private void SchemaView_Load(object sender, EventArgs e)
        {
            UpdateDate();
            UpdateList();                   

        }

        public void Add(string col1, string col2, string col3)
        {
            String[] row = { col1, col2, col3 };
            ListViewItem item = new ListViewItem(row);
            listViewCalender.Items.Add(item);
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            UpdateDate();
            UpdateList();
        }

        public void UpdateDate()
        {
            DateTime dt = monthCalendar1.SelectionRange.Start;
            lblYear.Text = dt.Year.ToString();
            lblDay1.Text = dt.ToString("M");
            dt = dt.AddDays(1);
            lblDay2.Text = dt.ToString("M");
            dt = dt.AddDays(1);
            lblDay3.Text = dt.ToString("M");
        }

        public void UpdateList()
        {
            listViewCalender.Items.Clear();

            item.Text = "";
            item.SubItems.Add("");
            item.SubItems.Add("");

            listViewCalender.Items.Add(item);

            Random rd = new Random();
            string day1 = "";
            string day2 = "";
            string day3 = "";

            for (int i = 0; i < 19; i++)
            {
                int index = rd.Next(1, names.Count-2);
                day1 = names[index];
                day2 = names[index+2];
                day3 = names[index-1];
                Add(day1, day2, day3);
            }
        }
    }
}
