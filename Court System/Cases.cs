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
    public partial class Cases : Form
    {
        string db = "Data source=orcl; User Id=hr; Password=hr";
        OracleConnection conn;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public Cases()
        {
            InitializeComponent();
        }


        private void btn_insert_Click(object sender, EventArgs e)
        {
            int maxID, newID;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GETCASEID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            try
            {
                maxID = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
                newID = maxID + 1;
            }
            catch
            {
                newID = 1;
            }
            OracleCommand c1 = new OracleCommand();
            c1.Connection = conn;
            c1.CommandText = "INSERT INTO CASES VALUES(:CID,:CNAME,:CDESC,:CSTATUS,:CDATE,:CROOMNAME)";
            c1.CommandType = CommandType.Text;
            c1.Parameters.Add("CID", newID);
            c1.Parameters.Add("CNAME", txt_case_name.Text);
            c1.Parameters.Add("CDESC", txt_case_description.Text);
            c1.Parameters.Add("CSTATUS", cmb_case_status.Text);
            c1.Parameters.Add("CDATE", case_date.Value);
            c1.Parameters.Add("CROOMNAME", txt_case_room_name.Text);
            c1.ExecuteNonQuery();
            MessageBox.Show("Case Info inserted successfully");
            cmb_case_id.Items.Add(newID.ToString());
        }

        private void Cases_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(db);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select CASE_ID from CASES";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_case_id.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void cmb_case_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select CASE_NAME,CASE_DESCRIPTION,CASE_STATUS,CASE_DATE,C_ROOMNAME from CASES where CASE_ID=:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", cmb_case_id.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_case_name.Text = dr[0].ToString();
                txt_case_description.Text = dr[1].ToString();
                cmb_case_status.Text = dr[2].ToString();
                case_date.Value = Convert.ToDateTime(dr[3].ToString());
                txt_case_room_name.Text = dr[4].ToString();
            }
            dr.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "DELETE_CASE";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("CID", cmb_case_id.SelectedItem.ToString());
            // why r= -1 ?
            // 
            cmd.ExecuteNonQuery();

            cmb_case_id.Text = String.Empty;
            txt_case_name.Text = String.Empty;
            txt_case_description.Text = String.Empty;
            cmb_case_status.Text = String.Empty;
            case_date.Value = DateTime.Now;
            txt_case_room_name.Text = String.Empty;
            cmb_case_id.Items.RemoveAt(cmb_case_id.SelectedIndex);
            MessageBox.Show("Delete is done successfully");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string constr = "Data source=orcl; User Id=hr; Password=hr";
            string cmdstr = "select * from CASES where CASE_ID=:cid";
            OracleDataAdapter adapter = new OracleDataAdapter(cmdstr, constr);

            adapter.SelectCommand.Parameters.Add("cid", cmb_case_id.SelectedItem.ToString());
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            ds.Tables[0].Rows[0][1] = txt_case_name.Text;
            ds.Tables[0].Rows[0][2] = txt_case_description.Text;
            ds.Tables[0].Rows[0][3] = cmb_case_status.Text;
            ds.Tables[0].Rows[0][4] = case_date.Value;
            ds.Tables[0].Rows[0][5] = txt_case_room_name.Text;
            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Update is Done Successfully");
        }

        private void Cases_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
