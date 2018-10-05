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

    public partial class PatientBooking : Form
    {

        class Patient
        {
            public string firstname;
            public string lastname;
            public string address;
            public string zip;
            public string city;
        }

        public PatientBooking()
        {
            InitializeComponent();

            /*
            listView1.Items.Add("Patient 1    Anders Nilsson          Gröna gatan 12          333 33    Linköping", 1);
            listView1.Items.Add("Patient 2    Anna Andersson          Stengatan 5             55 999    Linköping", 2);
            listView1.Items.Add("Patient 3    Erik Olsson             Trädgårdsvägen 25       11 223    Linköping", 3);
            listView1.Items.Add("Patient 4    Chen Lee                Stjärnvägen 8           11 223    Linköping", 3);
            */

            // List Patients

            listView1.View = View.Details;
            listView1.Columns.Add("Firstname");
            listView1.Columns.Add("Lastname");           
            listView1.Columns.Add("Address");
            listView1.Columns.Add("Zip");
            listView1.Columns.Add("City");

            List<Patient> patients = new List<Patient>
            {
                new Patient() { firstname = "Nils", lastname = "Andersson", address = "Grönagatan 5", zip = "33 333", city = "Linköping" },
                new Patient() { firstname = "Julia", lastname = "Svensson", address = "Trädgårdsgatan 15", zip = "33 333", city = "Linköping" },
                new Patient() { firstname = "Chen", lastname = "Lee", address = "Blomkålsgatan 11", zip = "33 333", city = "Linköping" },
                new Patient() { firstname = "Mike", lastname = "O'Sullivan", address = "Storagatan 8", zip = "33 333", city = "Linköping" }
            };

            foreach(var p in patients)
            {
                ListViewItem lvi1 = new ListViewItem();
                lvi1.Text = p.firstname.Trim();
                lvi1.SubItems.Add(p.lastname.Trim());
                lvi1.SubItems.Add(p.address.Trim());
                lvi1.SubItems.Add(p.zip.Trim());
                lvi1.SubItems.Add(p.city.Trim());
                listView1.Items.Add(lvi1);
            }

            // Add a Patient

            listView2.View = View.Details;
            listView2.Columns.Add("Firstname");
            listView2.Columns.Add("Lastname");          
            listView2.Columns.Add("Dentist");
            listView2.Columns.Add("Day");
            listView2.Columns.Add("Time");
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Customer_FormClosed(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Program.hem.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem lvi1 = new ListViewItem();

            lvi1.Text = textBox1.Text.Trim();
            lvi1.SubItems.Add(textBox2.Text.Trim());           
            lvi1.SubItems.Add(textBox3.Text.Trim());
            lvi1.SubItems.Add(textBox4.Text.Trim());
            lvi1.SubItems.Add(textBox5.Text.Trim());
            
            listView2.Items.Add(lvi1);
        }
    }
}
