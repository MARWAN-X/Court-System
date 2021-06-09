
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
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_Judge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_JudgeID
            // 
            this.txt_JudgeID.Location = new System.Drawing.Point(304, 30);
            this.txt_JudgeID.Name = "txt_JudgeID";
            this.txt_JudgeID.Size = new System.Drawing.Size(147, 20);
            this.txt_JudgeID.TabIndex = 0;
            this.txt_JudgeID.TextChanged += new System.EventHandler(this.txt_JudgeID_TextChanged);
            // 
            // lbl_JudgeID
            // 
            this.lbl_JudgeID.AutoSize = true;
            this.lbl_JudgeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_JudgeID.Location = new System.Drawing.Point(163, 34);
            this.lbl_JudgeID.Name = "lbl_JudgeID";
            this.lbl_JudgeID.Size = new System.Drawing.Size(70, 16);
            this.lbl_JudgeID.TabIndex = 1;
            this.lbl_JudgeID.Text = "Judge ID";
            this.lbl_JudgeID.Click += new System.EventHandler(this.lbl_JudgeID_Click);
            // 
            // lbl_f_name
            // 
            this.lbl_f_name.AutoSize = true;
            this.lbl_f_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_f_name.Location = new System.Drawing.Point(165, 75);
            this.lbl_f_name.Name = "lbl_f_name";
            this.lbl_f_name.Size = new System.Drawing.Size(83, 16);
            this.lbl_f_name.TabIndex = 1;
            this.lbl_f_name.Text = "First Name";
            // 
            // lbl_l_name
            // 
            this.lbl_l_name.AutoSize = true;
            this.lbl_l_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_l_name.Location = new System.Drawing.Point(166, 108);
            this.lbl_l_name.Name = "lbl_l_name";
            this.lbl_l_name.Size = new System.Drawing.Size(82, 16);
            this.lbl_l_name.TabIndex = 1;
            this.lbl_l_name.Text = "Last Name";
            // 
            // lbl_rank
            // 
            this.lbl_rank.AutoSize = true;
            this.lbl_rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rank.Location = new System.Drawing.Point(166, 144);
            this.lbl_rank.Name = "lbl_rank";
            this.lbl_rank.Size = new System.Drawing.Size(44, 16);
            this.lbl_rank.TabIndex = 1;
            this.lbl_rank.Text = "Rank";
            this.lbl_rank.Click += new System.EventHandler(this.lbl_rank_Click);
            // 
            // lbl_birthdate
            // 
            this.lbl_birthdate.AutoSize = true;
            this.lbl_birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_birthdate.Location = new System.Drawing.Point(165, 178);
            this.lbl_birthdate.Name = "lbl_birthdate";
            this.lbl_birthdate.Size = new System.Drawing.Size(70, 16);
            this.lbl_birthdate.TabIndex = 1;
            this.lbl_birthdate.Text = "Birthdate";
            this.lbl_birthdate.Click += new System.EventHandler(this.lbl_birthdate_Click);
            // 
            // lbl_phoneNo
            // 
            this.lbl_phoneNo.AutoSize = true;
            this.lbl_phoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phoneNo.Location = new System.Drawing.Point(166, 212);
            this.lbl_phoneNo.Name = "lbl_phoneNo";
            this.lbl_phoneNo.Size = new System.Drawing.Size(110, 16);
            this.lbl_phoneNo.TabIndex = 1;
            this.lbl_phoneNo.Text = "Phone Number";
            this.lbl_phoneNo.Click += new System.EventHandler(this.lbl_phoneNo_Click);
            // 
            // lbl_birthdate_val
            // 
            this.lbl_birthdate_val.AutoSize = true;
            this.lbl_birthdate_val.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_birthdate_val.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_birthdate_val.Location = new System.Drawing.Point(303, 181);
            this.lbl_birthdate_val.Name = "lbl_birthdate_val";
            this.lbl_birthdate_val.Size = new System.Drawing.Size(55, 13);
            this.lbl_birthdate_val.TabIndex = 1;
            this.lbl_birthdate_val.Text = "";
            // 
            // lbl_phoneNumber_val
            // 
            this.lbl_phoneNumber_val.AutoSize = true;
            this.lbl_phoneNumber_val.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_phoneNumber_val.Location = new System.Drawing.Point(303, 215);
            this.lbl_phoneNumber_val.Name = "lbl_phoneNumber_val";
            this.lbl_phoneNumber_val.Size = new System.Drawing.Size(55, 13);
            this.lbl_phoneNumber_val.TabIndex = 1;
            this.lbl_phoneNumber_val.Text = "";
            // 
            // lbl_f_name_val
            // 
            this.lbl_f_name_val.AutoSize = true;
            this.lbl_f_name_val.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_f_name_val.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_f_name_val.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_f_name_val.Location = new System.Drawing.Point(303, 75);
            this.lbl_f_name_val.Name = "lbl_f_name_val";
            this.lbl_f_name_val.Size = new System.Drawing.Size(55, 13);
            this.lbl_f_name_val.TabIndex = 1;
            this.lbl_f_name_val.Text = "";
            // 
            // lbl_l_name_val
            // 
            this.lbl_l_name_val.AutoSize = true;
            this.lbl_l_name_val.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_l_name_val.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_l_name_val.Location = new System.Drawing.Point(303, 111);
            this.lbl_l_name_val.Name = "lbl_l_name_val";
            this.lbl_l_name_val.Size = new System.Drawing.Size(55, 13);
            this.lbl_l_name_val.TabIndex = 1;
            this.lbl_l_name_val.Text = "";
            // 
            // lbl_rank_val
            // 
            this.lbl_rank_val.AutoSize = true;
            this.lbl_rank_val.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_rank_val.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_rank_val.Location = new System.Drawing.Point(303, 147);
            this.lbl_rank_val.Name = "lbl_rank_val";
            this.lbl_rank_val.Size = new System.Drawing.Size(55, 13);
            this.lbl_rank_val.TabIndex = 1;
            this.lbl_rank_val.Text = "";
            // 
            // btn_get_info
            // 
            this.btn_get_info.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_get_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_get_info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_get_info.Location = new System.Drawing.Point(503, 23);
            this.btn_get_info.Name = "btn_get_info";
            this.btn_get_info.Size = new System.Drawing.Size(87, 32);
            this.btn_get_info.TabIndex = 3;
            this.btn_get_info.Text = "Get Info";
            this.btn_get_info.UseVisualStyleBackColor = false;
            this.btn_get_info.Click += new System.EventHandler(this.btn_get_info_Click);
            // 
            // data_Judge
            // 
            this.data_Judge.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_Judge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Judge.Location = new System.Drawing.Point(53, 271);
            this.data_Judge.Name = "data_Judge";
            this.data_Judge.RowHeadersWidth = 51;
            this.data_Judge.Size = new System.Drawing.Size(644, 235);
            this.data_Judge.TabIndex = 5;
           // this.data_Judge.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Judge_CellContentClick);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::Court_System.Properties.Resources.arrowBackTwo;
            this.pictureBoxBack.Location = new System.Drawing.Point(20, 11);
            this.pictureBoxBack.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(38, 39);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 13;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Judges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 531);
            this.Controls.Add(this.pictureBoxBack);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Judges_FormClosing);
            this.Load += new System.EventHandler(this.Judges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Judge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxBack;
    }
}