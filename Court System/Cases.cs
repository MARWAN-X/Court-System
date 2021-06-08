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
        int case_ID;
        OracleConnection conn;
        Boolean isInserted = false;
        int contrj = 0;
        List<String> victims, prisoners, vic_Law, pri_law;
        public Cases()
        {
            InitializeComponent();
        }
        private void hide_case()
        {
            btn_back.Hide();
            btn_delete.Hide();
            btn_insert.Hide();
            btn_update.Hide();
            lbl_case_date.Hide();
            lbl_case_description.Hide();
            lbl_case_id.Hide(); 
            lbl_case_name.Hide(); 
            lbl_case_room_name.Hide(); 
            lbl_case_status.Hide();
            txt_case_description.Hide();
            txt_case_name.Hide();
            cmb_case_id.Hide();
            cmb_case_room_name.Hide();
            cmb_case_status.Hide();
            case_date.Hide();
        }
        private void hide_extra()
        {
            btn_Finish.Hide();
            btn_judge_id.Hide();
            btn_Prisoner_id.Hide();
            btn_Prisoner_lawyer.Hide();
            btn_Victim_id.Hide(); 
            btn_Victim_lawyer.Hide(); 
            lbl_judge_id.Hide();
            lbl_Prisoner_id.Hide();
            lbl_Pri_laywer.Hide();
            lbl_victim_id.Hide();
            lbl_vic_lawyer.Hide();
            txt_Judge_id.Hide();
            txt_Prisoner_id.Hide();
            txt_Prisoner_lawyer.Hide();
            txt_Victim_id.Hide();
            txt_Victim_lawyer.Hide();
        }

        private void show_extra()
        {
            btn_Finish.Show();
            btn_judge_id.Show();
            btn_Prisoner_id.Show();
            btn_Prisoner_lawyer.Show();
            btn_Victim_id.Show();
            btn_Victim_lawyer.Show();
            lbl_judge_id.Show();
            lbl_Prisoner_id.Show();
            lbl_Pri_laywer.Show();
            lbl_victim_id.Show();
            lbl_vic_lawyer.Show();
            txt_Judge_id.Show();
            txt_Prisoner_id.Show();
            txt_Prisoner_lawyer.Show();
            txt_Victim_id.Show();
            txt_Victim_lawyer.Show();
        }
        private void show_case()
        {
            btn_back.Show();
            btn_delete.Show();
            btn_insert.Show();
            btn_update.Show();
            lbl_case_date.Show();
            lbl_case_description.Show();
            lbl_case_id.Show();
            lbl_case_name.Show();
            lbl_case_room_name.Show();
            lbl_case_status.Show();
            txt_case_description.Show();
            txt_case_name.Show();
            cmb_case_id.Show();
            cmb_case_room_name.Show();
            cmb_case_status.Show();
            case_date.Show();
        }
        private void Cases_Load(object sender, EventArgs e)
        {
            victims = new List<String>();
            prisoners = new List<String>();
            vic_Law = new List<String>();
            pri_law = new List<String>();
            conn = new OracleConnection(db);
            conn.Open();
            hide_extra();
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
            cmb_case_status.Items.Add("pending");
            cmb_case_status.Items.Add("in-progress");
            cmb_case_status.Items.Add("closed");


            conn = new OracleConnection(db);
            conn.Open();
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Court";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {
                cmb_case_room_name.Items.Add(dr2["C_RoomName"]);
            }
            dr2.Close();
        }

        private bool check_boxes()
        {
            bool emptyy = false;
            if (txt_case_name.Text == String.Empty)
                emptyy = true;
            if (txt_case_description.Text == String.Empty)
                emptyy = true;
            if (cmb_case_status.SelectedItem == null)
                emptyy = true;
            if (cmb_case_room_name.Text == String.Empty)
                emptyy = true;

            return emptyy;
        }
        private void btn_insert_Click(object sender, EventArgs e)
        {
           
            if (check_boxes() == false)
            {
                /*OracleCommand c2 = new OracleCommand();
                c2.Connection = conn;
                c2.CommandText = "validate_insert";
                c2.CommandType = CommandType.StoredProcedure;
                c2.Parameters.Add("dat", case_date.Value);
                c2.Parameters.Add("room", cmb_case_room_name.Text);
                c2.Parameters.Add("cnt", OracleDbType.Int32, ParameterDirection.Output);
                c2.ExecuteNonQuery();
                if (Convert.ToInt32(c2.Parameters["cnt"].Value.ToString()) >= 5)
                {
                    MessageBox.Show(cmb_case_room_name + " is full this day\n");
                    return;
                }*/
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
                c1.Parameters.Add("CROOMNAME", cmb_case_room_name.Text);
                c1.ExecuteNonQuery();
                cmb_case_id.Text = String.Empty;
                txt_case_name.Text = String.Empty;
                txt_case_description.Text = String.Empty;
                cmb_case_status.Text = String.Empty;
                case_date.Value = DateTime.Now;
                cmb_case_room_name.Text = String.Empty;
                cmb_case_id.Items.Add(newID.ToString());
                cmb_case_id.SelectedIndex = -1;
                cmb_case_status.SelectedIndex = -1;
                MessageBox.Show("Case Info inserted successfully\n your Case ID: " + newID);
                case_ID = newID;
                hide_case();
                show_extra();

                isInserted = true;
              
            }
            else
            {
                MessageBox.Show("Please fill all your data");
            }
        }

        private void cmb_case_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_case_id.SelectedItem != null)
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
                    cmb_case_room_name.Text = dr[4].ToString();
                }
                dr.Close();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            

            cmd.Connection = conn;
            cmd.CommandText = "DELETE_CASE";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("CID", cmb_case_id.SelectedItem.ToString());
            cmd.ExecuteNonQuery();

            cmb_case_id.Text = String.Empty;
            txt_case_name.Text = String.Empty;
            txt_case_description.Text = String.Empty;
            cmb_case_status.Text = String.Empty;
            case_date.Value = DateTime.Now;
            cmb_case_room_name.Text = String.Empty;
            cmb_case_status.SelectedIndex = -1;
            cmb_case_id.Items.RemoveAt(cmb_case_id.SelectedIndex);
            MessageBox.Show("Delete is done successfully");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (check_boxes() == false)
            {
               
                if (cmb_case_id.SelectedItem != null)
                {
                    string cmdstr = "select * from CASES where CASE_ID=:cid";
                    OracleDataAdapter adapter = new OracleDataAdapter(cmdstr, db);

                    adapter.SelectCommand.Parameters.Add("cid", cmb_case_id.SelectedItem.ToString());
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    ds.Tables[0].Rows[0][1] = txt_case_name.Text;
                    ds.Tables[0].Rows[0][2] = txt_case_description.Text;
                    ds.Tables[0].Rows[0][3] = cmb_case_status.Text;
                    ds.Tables[0].Rows[0][4] = case_date.Value;
                    ds.Tables[0].Rows[0][5] = cmb_case_room_name.Text;
                    OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
                    adapter.Update(ds.Tables[0]);
                    MessageBox.Show("Update is Done Successfully");
                    case_ID = Int32.Parse(cmb_case_id.Text);
                    hide_case();
                    lbl_judge_id.Show();
                    txt_Judge_id.Show();
                    btn_Finish.Show();
                    btn_judge_id.Show();
                }
                else
                    MessageBox.Show("Please choose Case ID to Update");

          
            }
            else
            {
                MessageBox.Show("Please fill all your data");
            }
        }

        private void Cases_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Menu menuForm = new Menu();
            this.Hide();
            menuForm.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {
            Boolean ok = false;
            if (isInserted && contrj == 0)
            {
                MessageBox.Show("Please enter Judge");
                ok = true;
                return;
            }
            if (victims.Count > 0 && vic_Law.Count == 0)
            {
                MessageBox.Show("Please enter victim lawyers");
                ok = true;
            }
            if (victims.Count == 0 && vic_Law.Count > 0)
            {
                MessageBox.Show("Please enter victims");
                ok = true;
            }
            if (prisoners.Count == 0 && pri_law.Count > 0)
            {
                MessageBox.Show("Please enter prisoners");
                ok = true;
            }
            if (prisoners.Count > 0 && pri_law.Count == 0)
            {
                MessageBox.Show("Please enter prisoners lawyers");
                ok = true;
            }
            if (ok)
            {
                /*  hide_extra();
                  show_case();
                  victims.Clear();
                  prisoners.Clear();
                  vic_Law.Clear();
                  pri_law.Clear();

                  isInserted = false;
                  contrj = 0;*/

                return;
            }
            int successVic = 0;
            for (int i = 0; i < victims.Count; i++)
            {
                for (int j = 0; j < vic_Law.Count; j++)
                {
                    long vicID = long.Parse(victims[i]);
                    long vicLawID = long.Parse(vic_Law[j]);
                    OracleCommand c1 = new OracleCommand();
                    c1.Connection = conn;
                    c1.CommandText = "INSERT INTO Represent VALUES(:VID, :LID, :CID)";
                    c1.CommandType = CommandType.Text;
                    c1.Parameters.Add("VID", vicID);
                    c1.Parameters.Add("JID", vicLawID);
                    c1.Parameters.Add("CID", case_ID);
                    try
                    {
                        c1.ExecuteNonQuery();
                        successVic++;
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            int successPri = 0;
            for (int i = 0; i < prisoners.Count; i++)
            {
                for (int j = 0; j < pri_law.Count; j++)
                {
                    long pID = long.Parse(prisoners[i]);
                    long pLawID = long.Parse(pri_law[j]);
                    OracleCommand c1 = new OracleCommand();
                    c1.Connection = conn;
                    c1.CommandText = "INSERT INTO defends VALUES(:PID,:LID, :CID)";
                    c1.CommandType = CommandType.Text;
                    c1.Parameters.Add("PID", pID);
                    c1.Parameters.Add("JID", pLawID);
                    c1.Parameters.Add("CID", case_ID);
                    try
                    {
                        c1.ExecuteNonQuery();
                        successPri++;
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            MessageBox.Show("Victim and lawyers relationships added successfully: " + successVic +
                            "\nPrisoners and lawyers relationships added successfully: " + successPri);
            hide_extra();
            show_case();
            victims.Clear();
            prisoners.Clear();
            vic_Law.Clear();
            pri_law.Clear();

            isInserted = false;
            contrj = 0;
        }

        private void btn_Victim_lawyer_Click(object sender, EventArgs e)
        {
            if (txt_Victim_lawyer.Text.Length != 14)
            {
                MessageBox.Show("Please enter valid SSN");
                txt_Victim_lawyer.Clear();
                return;
            }
            try
            {
                long test = long.Parse(txt_Victim_lawyer.Text);
                vic_Law.Add(txt_Victim_lawyer.Text);
                txt_Victim_lawyer.Clear();
            }
            catch
            {
                MessageBox.Show("Please enter valid SSN");
                txt_Victim_lawyer.Clear();
                return;
            }
        }

        private void btn_Prisoner_lawyer_Click(object sender, EventArgs e)
        {
            if (txt_Prisoner_lawyer.Text.Length != 14)
            {
                MessageBox.Show("Please enter valid SSN");
                txt_Prisoner_lawyer.Clear();
                return;
            }
            try
            {
                long test = long.Parse(txt_Prisoner_lawyer.Text);
                pri_law.Add(txt_Prisoner_lawyer.Text);
                txt_Prisoner_lawyer.Clear();
            }
            catch
            {
                MessageBox.Show("Please enter valid SSN");
                txt_Prisoner_lawyer.Clear();
                return;
            }
        }

        private void btn_judge_id_Click(object sender, EventArgs e)
        {
            if (txt_Judge_id.Text.Length != 14)
            {
                MessageBox.Show("Please enter valid SSN");
                txt_Judge_id.Clear();
                return;
            }
           
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from judges where J_SSN = :id";
            c.Parameters.Add("id", txt_Judge_id.Text);
            try
            {
                long test = long.Parse(txt_Judge_id.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid SSN");
                txt_Judge_id.Clear();
                return;
            }

            OracleDataReader dr = c.ExecuteReader();
            try
            {
                dr.Read();
                OracleCommand c1 = new OracleCommand();
                c1.Connection = conn;
                c1.CommandText = "INSERT INTO Judging VALUES(:JID,:CID)";
                c1.CommandType = CommandType.Text;
                c1.Parameters.Add("JID", long.Parse(txt_Judge_id.Text));
                c1.Parameters.Add("CID", case_ID);
                c1.ExecuteNonQuery();
                MessageBox.Show("Judge assigned to Case successfully");
            }
            catch
            {
                MessageBox.Show("Please enter Valid SSN");
                txt_Judge_id.Clear();
                return;
            }
            txt_Judge_id.Text = "";
            dr.Close();
            contrj++;
        }

        private void btn_Prisoner_id_Click(object sender, EventArgs e)
        {
            if (txt_Prisoner_id.Text.Length != 14)
            {
                MessageBox.Show("Please enter valid SSN");
                txt_Prisoner_id.Clear();
                return;
            }
            try
            {
                long test = long.Parse(txt_Prisoner_id.Text);
                prisoners.Add(txt_Prisoner_id.Text);
                txt_Prisoner_id.Clear();
            }
            catch
            {
                MessageBox.Show("Please enter valid SSN");
                txt_Prisoner_id.Clear();
                return;
            }
        }

        private void btn_Victim_id_Click(object sender, EventArgs e)
        {
            if (txt_Victim_id.Text.Length != 14)
            {
                MessageBox.Show("Please enter valid SSN");
                txt_Victim_id.Clear();
                return;
            }
            try
            {
                long test = long.Parse(txt_Victim_id.Text);
                victims.Add(txt_Victim_id.Text);
                txt_Victim_id.Clear();
            }
            catch
            {
                MessageBox.Show("Please enter valid SSN");
                txt_Victim_id.Clear();
                return;
            }
        }
    }
}
