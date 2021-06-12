using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using CrystalDecisions.Shared; 

namespace Court_System
{
    public partial class Report_form2 : Form
    {
        CrystalReport2 cr;
        string db = "Data source=orcl; User Id=hr; Password=hr";
        OracleConnection conn;
        public Report_form2()
        {
            InitializeComponent();
        }
        private void Report_form2_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport2();
            cr.Refresh();
            conn = new OracleConnection(db);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select CASE_ID from CASES";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menuForm = new Menu();
            this.Hide();
            menuForm.Show();
        }


        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            Menu menuForm = new Menu();
            this.Hide();
            menuForm.Show();
        }

        

        private void btn_Generate_Click(object sender, EventArgs e)
        {

            cr.SetParameterValue(0, comboBox1.SelectedItem);
            crystalReportViewer1.ReportSource = cr;
        }

        
    }
}
