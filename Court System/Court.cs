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
        OracleDataAdapter adapter;
        DataSet ds;

        public Court()
        {
            InitializeComponent();
        }


        private void Court_Load(object sender, EventArgs e)
        {
            case_date_search.Hide();
            cmb_names.Hide();
            btn_view.Hide();
            data_court.Hide();
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

    
        private void cmb_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(db);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            if ((string)cmb_search.SelectedItem == "Court Name")
            {
                cmb_names.Show();
                case_date_search.Hide();
                cmb_names.Items.Clear();
                cmd.CommandText = "select * from Court";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb_names.Items.Add(dr["C_RoomName"]);
                }
                dr.Close();
            }
            else if ((string)cmb_search.SelectedItem == "Case Date")
            {
                case_date_search.Show();
                cmb_names.Hide();
                btn_view.Show();
            }
        }

        private void cmb_names_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_view.Show();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            data_court.Show();
            string cmdstr = "";
            if (cmb_names.Visible)
            {
                cmdstr = "select * from cases where c_roomname = :d";
                adapter = new OracleDataAdapter(cmdstr, db);
                adapter.SelectCommand.Parameters.Add("d", (string)cmb_names.SelectedItem);
            }
            else if (case_date_search.Visible)
            {
                cmdstr = "select * from cases where :d <= case_date AND case_date < :nxt_d";
                adapter = new OracleDataAdapter(cmdstr, db);
                DateTime dt = case_date_search.Value.Date;
                adapter.SelectCommand.Parameters.Add("d", dt);
                dt = dt.AddDays(1);
                adapter.SelectCommand.Parameters.Add("nxt_d", dt);
            }

            ds = new DataSet();
            adapter.Fill(ds);
            data_court.DataSource = ds.Tables[0];
        }
    }
}
