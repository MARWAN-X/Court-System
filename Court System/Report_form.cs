using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace Court_System
{
    public partial class Report_form : Form
    {
        CrystalReport1 cr;
        public Report_form()
        {
            InitializeComponent();
        }

        private void lbl_Case_ID_Click(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            cr = new CrystalReport1();
            cr.Refresh();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0,Convert.ToDateTime(dateTimePicker1.Text));
            crystalReportViewer.ReportSource = cr;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Menu menuForm = new Menu();
            this.Hide();
            menuForm.Show();
        }
    }
}
