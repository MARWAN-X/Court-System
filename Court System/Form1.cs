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

namespace Court_System
{
    public partial class Log_In_Form : Form
    {
        string db = "Data source=orcl; User Id=hr; Password=hr";
        OracleConnection conn;


        public Log_In_Form()
        {
            InitializeComponent();
        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }

        private void Log_In_Form_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(db);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            try
            {
                long test = long.Parse(txt_username.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid SSN");
                return;
            }
            cmd.Connection = conn;
            cmd.CommandText = "login";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("SSN", txt_username.Text);
            cmd.Parameters.Add("Password1", txt_password.Text);
            cmd.Parameters.Add("ret", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            if (Convert.ToInt32(cmd.Parameters["ret"].Value.ToString()) == 1)
            {
                conn.Dispose();
                Menu menuForm = new Menu();
                this.Hide();
                menuForm.Show();    
            }
            else
            {
                MessageBox.Show("Wrong SSN or Password");
            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
