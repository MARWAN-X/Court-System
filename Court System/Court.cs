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
    public partial class Court : Form
    {

        string db = "Data source=orcl;User Id=hr; password=hr";
        OracleConnection conn;

        public Court()
        {
            InitializeComponent();
        }


        private void view_btn_Click(object sender, EventArgs e)
        {

        }

        private void Court_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(db);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Court";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_names.Items.Add(dr["C_RoomName"]);
            }
            dr.Close();

            //   conn.Dispose();
        }

        private void cmb_names_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_back_Click(object sender, EventArgs e)
        {
            Menu menuForm = new Menu();
            this.Hide();
            menuForm.Show();
        }

        private void Court_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
