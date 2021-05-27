﻿using System;
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
            cmd.Text = "select count(*) from PoliceIT where PIT_Username =:username AND PIT_Password=:password";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("username", txt_username.Text);
            cmd.Parameters.Add("password", txt_password.Text);
            int numberOfMatchedRows = cmd.ExecuteNonQuery();
            if (numberOfMatchedRows == 1)
            {
                Menu menuForm = new Menu();
                this.Hide();
                menuForm.Show();
                conn.Dispose();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }
    }
}
