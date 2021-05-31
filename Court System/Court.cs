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
        string db = "Data source=orcl; User Id=hr; Password=hr";
        OracleConnection conn;

        public Court()
        {
            InitializeComponent();
        }

        private void Court_Form_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(db);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select C_RoomName from Court";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteQuery();
            while(dr.Read())
            {
                cmb_names.Items.Add(dr[0]);
            }
            dr.Close();
            conn.dispose();
        }
        private void view_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
