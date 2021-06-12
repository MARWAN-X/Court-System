using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Court_System
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Cases_Click(object sender, EventArgs e)
        {
            Cases casesForm = new Cases();
            this.Hide();
            casesForm.Show();
        }

        private void btn_Judges_Click(object sender, EventArgs e)
        {
            Judges judgesForm = new Judges();
            this.Hide();
            judgesForm.Show();
        }

        private void btn_court_Click(object sender, EventArgs e)
        {
            Court courtForm = new Court();
            this.Hide();
            courtForm.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("First Crystal Report");
            comboBox1.Items.Add("Second Crystal Report");
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            Report_form rf = new Report_form();
            this.Hide();
            rf.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "First Crystal Report")
            {
                Report_form rf = new Report_form();
                this.Hide();
                rf.Show();
            }
            else if (comboBox1.SelectedItem == "Second Crystal Report")
            {
                Report_form2 rf = new Report_form2();
                this.Hide();
                rf.Show();
            }
            else
                MessageBox.Show("Please choose Crystal Report");
        }
    }
}
