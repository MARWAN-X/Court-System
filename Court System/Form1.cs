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
            cmd.Connection = conn;
            cmd.CommandText = "login";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Username", txt_username.Text);
            cmd.Parameters.Add("Password", OracleDbType.Varchar2, ParamaterDirection.Output);
            cmd.ExecuteNonQuery();
            if (cmd.Parameters["Password"].Value.ToString == txt_password.Text)
            {
                conn.Dispose();
                Menu menuForm = new Menu();
                this.Hide();
                menuForm.Show();
                
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }
    }
}
