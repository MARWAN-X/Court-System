
namespace Court_System
{
    partial class Judges
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_JudgeID = new System.Windows.Forms.TextBox();
            this.lbl_JudgeID = new System.Windows.Forms.Label();
            this.lbl_f_name = new System.Windows.Forms.Label();
            this.lbl_l_name = new System.Windows.Forms.Label();
            this.lbl_rank = new System.Windows.Forms.Label();
            this.lbl_birthdate = new System.Windows.Forms.Label();
            this.lbl_phoneNo = new System.Windows.Forms.Label();
            this.lbl_birthdate_val = new System.Windows.Forms.Label();
            this.lbl_phoneNumber_val = new System.Windows.Forms.Label();
            this.lbl_f_name_val = new System.Windows.Forms.Label();
            this.lbl_l_name_val = new System.Windows.Forms.Label();
            this.lbl_rank_val = new System.Windows.Forms.Label();
            this.btn_get_info = new System.Windows.Forms.Button();
            this.data_Judge = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_Judge)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_JudgeID
            // 
            this.txt_JudgeID.Location = new System.Drawing.Point(370, 30);
            this.txt_JudgeID.Name = "txt_JudgeID";
            this.txt_JudgeID.Size = new System.Drawing.Size(147, 20);
            this.txt_JudgeID.TabIndex = 0;
            this.txt_JudgeID.TextChanged += new System.EventHandler(this.txt_JudgeID_TextChanged);
            // 
            // lbl_JudgeID
            // 
            this.lbl_JudgeID.AutoSize = true;
            this.lbl_JudgeID.Location = new System.Drawing.Point(269, 37);
            this.lbl_JudgeID.Name = "lbl_JudgeID";
            this.lbl_JudgeID.Size = new System.Drawing.Size(50, 13);
            this.lbl_JudgeID.TabIndex = 1;
            this.lbl_JudgeID.Text = "Judge ID";
            // 
            // lbl_f_name
            // 
            this.lbl_f_name.AutoSize = true;
            this.lbl_f_name.Location = new System.Drawing.Point(269, 79);
            this.lbl_f_name.Name = "lbl_f_name";
            this.lbl_f_name.Size = new System.Drawing.Size(57, 13);
            this.lbl_f_name.TabIndex = 1;
            this.lbl_f_name.Text = "First Name";
            this.lbl_f_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_l_name
            // 
            this.lbl_l_name.AutoSize = true;
            this.lbl_l_name.Location = new System.Drawing.Point(269, 125);
            this.lbl_l_name.Name = "lbl_l_name";
            this.lbl_l_name.Size = new System.Drawing.Size(58, 13);
            this.lbl_l_name.TabIndex = 1;
            this.lbl_l_name.Text = "Last Name";
            this.lbl_l_name.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_rank
            // 
            this.lbl_rank.AutoSize = true;
            this.lbl_rank.Location = new System.Drawing.Point(269, 172);
            this.lbl_rank.Name = "lbl_rank";
            this.lbl_rank.Size = new System.Drawing.Size(33, 13);
            this.lbl_rank.TabIndex = 1;
            this.lbl_rank.Text = "Rank";
            // 
            // lbl_birthdate
            // 
            this.lbl_birthdate.AutoSize = true;
            this.lbl_birthdate.Location = new System.Drawing.Point(269, 213);
            this.lbl_birthdate.Name = "lbl_birthdate";
            this.lbl_birthdate.Size = new System.Drawing.Size(49, 13);
            this.lbl_birthdate.TabIndex = 1;
            this.lbl_birthdate.Text = "Birthdate";
            // 
            // lbl_phoneNo
            // 
            this.lbl_phoneNo.AutoSize = true;
            this.lbl_phoneNo.Location = new System.Drawing.Point(269, 257);
            this.lbl_phoneNo.Name = "lbl_phoneNo";
            this.lbl_phoneNo.Size = new System.Drawing.Size(78, 13);
            this.lbl_phoneNo.TabIndex = 1;
            this.lbl_phoneNo.Text = "Phone Number";
            this.lbl_phoneNo.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_birthdate_val
            // 
            this.lbl_birthdate_val.AutoSize = true;
            this.lbl_birthdate_val.Location = new System.Drawing.Point(408, 213);
            this.lbl_birthdate_val.Name = "lbl_birthdate_val";
            this.lbl_birthdate_val.Size = new System.Drawing.Size(0, 13);
            this.lbl_birthdate_val.TabIndex = 1;
            // 
            // lbl_phoneNumber_val
            // 
            this.lbl_phoneNumber_val.AutoSize = true;
            this.lbl_phoneNumber_val.Location = new System.Drawing.Point(408, 257);
            this.lbl_phoneNumber_val.Name = "lbl_phoneNumber_val";
            this.lbl_phoneNumber_val.Size = new System.Drawing.Size(0, 13);
            this.lbl_phoneNumber_val.TabIndex = 1;
            // 
            // lbl_f_name_val
            // 
            this.lbl_f_name_val.AutoSize = true;
            this.lbl_f_name_val.Location = new System.Drawing.Point(401, 79);
            this.lbl_f_name_val.Name = "lbl_f_name_val";
            this.lbl_f_name_val.Size = new System.Drawing.Size(0, 13);
            this.lbl_f_name_val.TabIndex = 1;
            this.lbl_f_name_val.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_l_name_val
            // 
            this.lbl_l_name_val.AutoSize = true;
            this.lbl_l_name_val.Location = new System.Drawing.Point(401, 125);
            this.lbl_l_name_val.Name = "lbl_l_name_val";
            this.lbl_l_name_val.Size = new System.Drawing.Size(0, 13);
            this.lbl_l_name_val.TabIndex = 1;
            this.lbl_l_name_val.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_rank_val
            // 
            this.lbl_rank_val.AutoSize = true;
            this.lbl_rank_val.Location = new System.Drawing.Point(408, 172);
            this.lbl_rank_val.Name = "lbl_rank_val";
            this.lbl_rank_val.Size = new System.Drawing.Size(0, 13);
            this.lbl_rank_val.TabIndex = 1;
            // 
            // btn_get_info
            // 
            this.btn_get_info.Location = new System.Drawing.Point(608, 27);
            this.btn_get_info.Name = "btn_get_info";
            this.btn_get_info.Size = new System.Drawing.Size(75, 23);
            this.btn_get_info.TabIndex = 3;
            this.btn_get_info.Text = "Get Info";
            this.btn_get_info.UseVisualStyleBackColor = true;
            this.btn_get_info.Click += new System.EventHandler(this.btn_get_info_Click);
            // 
            // data_Judge
            // 
            this.data_Judge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Judge.Location = new System.Drawing.Point(182, 302);
            this.data_Judge.Name = "data_Judge";
            this.data_Judge.Size = new System.Drawing.Size(645, 253);
            this.data_Judge.TabIndex = 5;
            // 
            // Judges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 603);
            this.Controls.Add(this.data_Judge);
            this.Controls.Add(this.btn_get_info);
            this.Controls.Add(this.lbl_phoneNo);
            this.Controls.Add(this.lbl_birthdate);
            this.Controls.Add(this.lbl_phoneNumber_val);
            this.Controls.Add(this.lbl_birthdate_val);
            this.Controls.Add(this.lbl_rank_val);
            this.Controls.Add(this.lbl_rank);
            this.Controls.Add(this.lbl_l_name_val);
            this.Controls.Add(this.lbl_l_name);
            this.Controls.Add(this.lbl_f_name_val);
            this.Controls.Add(this.lbl_f_name);
            this.Controls.Add(this.lbl_JudgeID);
            this.Controls.Add(this.txt_JudgeID);
            this.Name = "Judges";
            this.Text = "Judges";
            this.Load += new System.EventHandler(this.Judges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Judge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_JudgeID;
        private System.Windows.Forms.Label lbl_JudgeID;
        private System.Windows.Forms.Label lbl_f_name;
        private System.Windows.Forms.Label lbl_l_name;
        private System.Windows.Forms.Label lbl_rank;
        private System.Windows.Forms.Label lbl_birthdate;
        private System.Windows.Forms.Label lbl_phoneNo;
        private System.Windows.Forms.Label lbl_birthdate_val;
        private System.Windows.Forms.Label lbl_phoneNumber_val;
        private System.Windows.Forms.Label lbl_f_name_val;
        private System.Windows.Forms.Label lbl_l_name_val;
        private System.Windows.Forms.Label lbl_rank_val;
        private System.Windows.Forms.Button btn_get_info;
        private System.Windows.Forms.DataGridView data_Judge;
    }
}