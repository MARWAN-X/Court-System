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
    public partial class Judges : Form
    {
        string ordb = "Data source=orcl;User Id=hr; password=hr";
        OracleConnection conn;
        public Judges()
        {
            InitializeComponent();
        }

        private void btn_get_info_Click(object sender, EventArgs e)
        {
            data_Judge.Rows.Clear();
            lbl_f_name_val.Text = "";
            lbl_l_name_val.Text = "";
            lbl_phoneNumber_val.Text = "";
            lbl_rank_val.Text = "";
            lbl_birthdate_val.Text = "";
            if (txt_JudgeID.Text.Length!=14)
            {
                MessageBox.Show("Please enter valid SSN");
                return;
            }
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from judges where J_SSN = :id";
            c.Parameters.Add("id", txt_JudgeID.Text);
            try
            {
                long test = long.Parse(txt_JudgeID.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid SSN");
                return;
            }
            data_Judge.Show();
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                lbl_f_name_val.Text = dr["J_fname"].ToString();
                lbl_l_name_val.Text = dr["J_lname"].ToString();
                lbl_phoneNumber_val.Text = dr["J_phonenumber"].ToString();
                lbl_rank_val.Text = dr["J_rank"].ToString();
                lbl_birthdate_val.Text = dr["J_birthdate"].ToString();
            }
            dr.Close();
            OracleCommand cc = new OracleCommand();
            cc.Connection = conn;
            cc.CommandText = "get_cases";
            cc.CommandType = CommandType.StoredProcedure;
            cc.Parameters.Add("id", txt_JudgeID.Text);
            cc.Parameters.Add("back", OracleDbType.RefCursor, ParameterDirection.Output);
            
            OracleDataReader d = cc.ExecuteReader();
            data_Judge.Columns.Add("Case ID", "Case ID");
            data_Judge.Columns.Add("Case Name", "Case Name");
            data_Judge.Columns.Add("Case Description", "Case Description");
            data_Judge.Columns.Add("Case Status", "Case Status");
            data_Judge.Columns.Add("Case Date", "Case Date");
            data_Judge.Columns.Add("Case Room Name", "Case Room Name");
            while (d.Read())
            {
                data_Judge.Rows.Add(d[0].ToString(), d[1].ToString(), d[2].ToString(),
                                    d[3].ToString(),d[4].ToString(), d[5].ToString());
            }

            d.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Menu menuForm = new Menu();
            this.Hide();
            menuForm.Show();
        }

        private void Judges_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void Judges_Load(object sender, EventArgs e)
        {
            data_Judge.Hide();
        }

        private void txt_JudgeID_TextChanged(object sender, EventArgs e)
        {

        }
        //12345768912346
    }
}
