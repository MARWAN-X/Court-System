
namespace Court_System
{
    partial class Cases
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
            this.txt_case_name = new System.Windows.Forms.TextBox();
            this.txt_case_description = new System.Windows.Forms.TextBox();
            this.cmb_case_status = new System.Windows.Forms.ComboBox();
            this.lbl_case_id = new System.Windows.Forms.Label();
            this.lbl_case_name = new System.Windows.Forms.Label();
            this.lbl_case_description = new System.Windows.Forms.Label();
            this.lbl_case_status = new System.Windows.Forms.Label();
            this.lbl_case_date = new System.Windows.Forms.Label();
            this.lbl_case_room_name = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.cmb_case_id = new System.Windows.Forms.ComboBox();
            this.case_date = new System.Windows.Forms.DateTimePicker();
            this.cmb_case_room_name = new System.Windows.Forms.ComboBox();
            this.lbl_judge_id = new System.Windows.Forms.Label();
            this.lbl_victim_id = new System.Windows.Forms.Label();
            this.lbl_Prisoner_id = new System.Windows.Forms.Label();
            this.lbl_vic_lawyer = new System.Windows.Forms.Label();
            this.lbl_Pri_laywer = new System.Windows.Forms.Label();
            this.txt_Judge_id = new System.Windows.Forms.TextBox();
            this.txt_Victim_id = new System.Windows.Forms.TextBox();
            this.txt_Victim_lawyer = new System.Windows.Forms.TextBox();
            this.txt_Prisoner_id = new System.Windows.Forms.TextBox();
            this.txt_Prisoner_lawyer = new System.Windows.Forms.TextBox();
            this.btn_judge_id = new System.Windows.Forms.Button();
            this.btn_Prisoner_id = new System.Windows.Forms.Button();
            this.btn_Victim_lawyer = new System.Windows.Forms.Button();
            this.btn_Prisoner_lawyer = new System.Windows.Forms.Button();
            this.btn_Finish = new System.Windows.Forms.Button();
            this.btn_Victim_id = new System.Windows.Forms.Button();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_case_name
            // 
            this.txt_case_name.Location = new System.Drawing.Point(353, 93);
            this.txt_case_name.Name = "txt_case_name";
            this.txt_case_name.Size = new System.Drawing.Size(221, 20);
            this.txt_case_name.TabIndex = 2;
            // 
            // txt_case_description
            // 
            this.txt_case_description.Location = new System.Drawing.Point(353, 136);
            this.txt_case_description.Name = "txt_case_description";
            this.txt_case_description.Size = new System.Drawing.Size(221, 20);
            this.txt_case_description.TabIndex = 3;
            // 
            // cmb_case_status
            // 
            this.cmb_case_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_case_status.FormattingEnabled = true;
            this.cmb_case_status.Location = new System.Drawing.Point(353, 174);
            this.cmb_case_status.Name = "cmb_case_status";
            this.cmb_case_status.Size = new System.Drawing.Size(221, 21);
            this.cmb_case_status.TabIndex = 4;
            // 
            // lbl_case_id
            // 
            this.lbl_case_id.AutoSize = true;
            this.lbl_case_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_case_id.Location = new System.Drawing.Point(204, 60);
            this.lbl_case_id.Name = "lbl_case_id";
            this.lbl_case_id.Size = new System.Drawing.Size(63, 16);
            this.lbl_case_id.TabIndex = 5;
            this.lbl_case_id.Text = "Case ID";
            // 
            // lbl_case_name
            // 
            this.lbl_case_name.AutoSize = true;
            this.lbl_case_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_case_name.Location = new System.Drawing.Point(204, 97);
            this.lbl_case_name.Name = "lbl_case_name";
            this.lbl_case_name.Size = new System.Drawing.Size(89, 16);
            this.lbl_case_name.TabIndex = 6;
            this.lbl_case_name.Text = "Case Name";
            this.lbl_case_name.Click += new System.EventHandler(this.lbl_case_name_Click);
            // 
            // lbl_case_description
            // 
            this.lbl_case_description.AutoSize = true;
            this.lbl_case_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_case_description.Location = new System.Drawing.Point(204, 137);
            this.lbl_case_description.Name = "lbl_case_description";
            this.lbl_case_description.Size = new System.Drawing.Size(127, 16);
            this.lbl_case_description.TabIndex = 7;
            this.lbl_case_description.Text = "Case Description";
            this.lbl_case_description.Click += new System.EventHandler(this.lbl_case_description_Click);
            // 
            // lbl_case_status
            // 
            this.lbl_case_status.AutoSize = true;
            this.lbl_case_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_case_status.Location = new System.Drawing.Point(204, 179);
            this.lbl_case_status.Name = "lbl_case_status";
            this.lbl_case_status.Size = new System.Drawing.Size(91, 16);
            this.lbl_case_status.TabIndex = 8;
            this.lbl_case_status.Text = "Case Status";
            // 
            // lbl_case_date
            // 
            this.lbl_case_date.AutoSize = true;
            this.lbl_case_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_case_date.Location = new System.Drawing.Point(204, 221);
            this.lbl_case_date.Name = "lbl_case_date";
            this.lbl_case_date.Size = new System.Drawing.Size(81, 16);
            this.lbl_case_date.TabIndex = 10;
            this.lbl_case_date.Text = "Case Date";
            // 
            // lbl_case_room_name
            // 
            this.lbl_case_room_name.AutoSize = true;
            this.lbl_case_room_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_case_room_name.Location = new System.Drawing.Point(204, 255);
            this.lbl_case_room_name.Name = "lbl_case_room_name";
            this.lbl_case_room_name.Size = new System.Drawing.Size(89, 16);
            this.lbl_case_room_name.TabIndex = 12;
            this.lbl_case_room_name.Text = "Court Name";
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(212, 342);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(2);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(69, 28);
            this.btn_insert.TabIndex = 13;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(353, 342);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(73, 28);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(500, 342);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(67, 28);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cmb_case_id
            // 
            this.cmb_case_id.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmb_case_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_case_id.FormattingEnabled = true;
            this.cmb_case_id.Location = new System.Drawing.Point(353, 55);
            this.cmb_case_id.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_case_id.Name = "cmb_case_id";
            this.cmb_case_id.Size = new System.Drawing.Size(221, 21);
            this.cmb_case_id.TabIndex = 16;
            this.cmb_case_id.SelectedIndexChanged += new System.EventHandler(this.cmb_case_id_SelectedIndexChanged);
            // 
            // case_date
            // 
            this.case_date.Location = new System.Drawing.Point(353, 217);
            this.case_date.Name = "case_date";
            this.case_date.Size = new System.Drawing.Size(221, 20);
            this.case_date.TabIndex = 9;
            // 
            // cmb_case_room_name
            // 
            this.cmb_case_room_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_case_room_name.FormattingEnabled = true;
            this.cmb_case_room_name.Location = new System.Drawing.Point(353, 250);
            this.cmb_case_room_name.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_case_room_name.Name = "cmb_case_room_name";
            this.cmb_case_room_name.Size = new System.Drawing.Size(221, 21);
            this.cmb_case_room_name.TabIndex = 18;
            // 
            // lbl_judge_id
            // 
            this.lbl_judge_id.AutoSize = true;
            this.lbl_judge_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_judge_id.Location = new System.Drawing.Point(11, 64);
            this.lbl_judge_id.Name = "lbl_judge_id";
            this.lbl_judge_id.Size = new System.Drawing.Size(70, 16);
            this.lbl_judge_id.TabIndex = 20;
            this.lbl_judge_id.Text = "Judge ID";
            // 
            // lbl_victim_id
            // 
            this.lbl_victim_id.AutoSize = true;
            this.lbl_victim_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_victim_id.Location = new System.Drawing.Point(12, 108);
            this.lbl_victim_id.Name = "lbl_victim_id";
            this.lbl_victim_id.Size = new System.Drawing.Size(69, 16);
            this.lbl_victim_id.TabIndex = 21;
            this.lbl_victim_id.Text = "Victim ID";
            // 
            // lbl_Prisoner_id
            // 
            this.lbl_Prisoner_id.AutoSize = true;
            this.lbl_Prisoner_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Prisoner_id.Location = new System.Drawing.Point(11, 155);
            this.lbl_Prisoner_id.Name = "lbl_Prisoner_id";
            this.lbl_Prisoner_id.Size = new System.Drawing.Size(85, 16);
            this.lbl_Prisoner_id.TabIndex = 22;
            this.lbl_Prisoner_id.Text = "Prisoner ID";
            // 
            // lbl_vic_lawyer
            // 
            this.lbl_vic_lawyer.AutoSize = true;
            this.lbl_vic_lawyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vic_lawyer.Location = new System.Drawing.Point(12, 203);
            this.lbl_vic_lawyer.Name = "lbl_vic_lawyer";
            this.lbl_vic_lawyer.Size = new System.Drawing.Size(115, 16);
            this.lbl_vic_lawyer.TabIndex = 23;
            this.lbl_vic_lawyer.Text = "Victim\'s Lawyer";
            // 
            // lbl_Pri_laywer
            // 
            this.lbl_Pri_laywer.AutoSize = true;
            this.lbl_Pri_laywer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pri_laywer.Location = new System.Drawing.Point(12, 250);
            this.lbl_Pri_laywer.Name = "lbl_Pri_laywer";
            this.lbl_Pri_laywer.Size = new System.Drawing.Size(131, 16);
            this.lbl_Pri_laywer.TabIndex = 24;
            this.lbl_Pri_laywer.Text = "Prisoner\'s Lawyer";
            // 
            // txt_Judge_id
            // 
            this.txt_Judge_id.Location = new System.Drawing.Point(152, 60);
            this.txt_Judge_id.Name = "txt_Judge_id";
            this.txt_Judge_id.Size = new System.Drawing.Size(100, 20);
            this.txt_Judge_id.TabIndex = 25;
            // 
            // txt_Victim_id
            // 
            this.txt_Victim_id.Location = new System.Drawing.Point(152, 104);
            this.txt_Victim_id.Name = "txt_Victim_id";
            this.txt_Victim_id.Size = new System.Drawing.Size(100, 20);
            this.txt_Victim_id.TabIndex = 26;
            // 
            // txt_Victim_lawyer
            // 
            this.txt_Victim_lawyer.Location = new System.Drawing.Point(152, 199);
            this.txt_Victim_lawyer.Name = "txt_Victim_lawyer";
            this.txt_Victim_lawyer.Size = new System.Drawing.Size(100, 20);
            this.txt_Victim_lawyer.TabIndex = 27;
            this.txt_Victim_lawyer.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_Prisoner_id
            // 
            this.txt_Prisoner_id.Location = new System.Drawing.Point(152, 151);
            this.txt_Prisoner_id.Name = "txt_Prisoner_id";
            this.txt_Prisoner_id.Size = new System.Drawing.Size(100, 20);
            this.txt_Prisoner_id.TabIndex = 28;
            // 
            // txt_Prisoner_lawyer
            // 
            this.txt_Prisoner_lawyer.Location = new System.Drawing.Point(152, 246);
            this.txt_Prisoner_lawyer.Name = "txt_Prisoner_lawyer";
            this.txt_Prisoner_lawyer.Size = new System.Drawing.Size(100, 20);
            this.txt_Prisoner_lawyer.TabIndex = 29;
            // 
            // btn_judge_id
            // 
            this.btn_judge_id.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_judge_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_judge_id.Location = new System.Drawing.Point(300, 60);
            this.btn_judge_id.Name = "btn_judge_id";
            this.btn_judge_id.Size = new System.Drawing.Size(75, 23);
            this.btn_judge_id.TabIndex = 30;
            this.btn_judge_id.Text = "Add";
            this.btn_judge_id.UseVisualStyleBackColor = false;
            this.btn_judge_id.Click += new System.EventHandler(this.btn_judge_id_Click);
            // 
            // btn_Prisoner_id
            // 
            this.btn_Prisoner_id.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Prisoner_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Prisoner_id.Location = new System.Drawing.Point(300, 149);
            this.btn_Prisoner_id.Name = "btn_Prisoner_id";
            this.btn_Prisoner_id.Size = new System.Drawing.Size(75, 23);
            this.btn_Prisoner_id.TabIndex = 32;
            this.btn_Prisoner_id.Text = "Add";
            this.btn_Prisoner_id.UseVisualStyleBackColor = false;
            this.btn_Prisoner_id.Click += new System.EventHandler(this.btn_Prisoner_id_Click);
            // 
            // btn_Victim_lawyer
            // 
            this.btn_Victim_lawyer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Victim_lawyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Victim_lawyer.Location = new System.Drawing.Point(300, 197);
            this.btn_Victim_lawyer.Name = "btn_Victim_lawyer";
            this.btn_Victim_lawyer.Size = new System.Drawing.Size(75, 23);
            this.btn_Victim_lawyer.TabIndex = 33;
            this.btn_Victim_lawyer.Text = "Add";
            this.btn_Victim_lawyer.UseVisualStyleBackColor = false;
            this.btn_Victim_lawyer.Click += new System.EventHandler(this.btn_Victim_lawyer_Click);
            // 
            // btn_Prisoner_lawyer
            // 
            this.btn_Prisoner_lawyer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Prisoner_lawyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Prisoner_lawyer.Location = new System.Drawing.Point(300, 243);
            this.btn_Prisoner_lawyer.Name = "btn_Prisoner_lawyer";
            this.btn_Prisoner_lawyer.Size = new System.Drawing.Size(75, 23);
            this.btn_Prisoner_lawyer.TabIndex = 34;
            this.btn_Prisoner_lawyer.Text = "Add";
            this.btn_Prisoner_lawyer.UseVisualStyleBackColor = false;
            this.btn_Prisoner_lawyer.Click += new System.EventHandler(this.btn_Prisoner_lawyer_Click);
            // 
            // btn_Finish
            // 
            this.btn_Finish.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Finish.Location = new System.Drawing.Point(164, 309);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(75, 28);
            this.btn_Finish.TabIndex = 35;
            this.btn_Finish.Text = "Finish";
            this.btn_Finish.UseVisualStyleBackColor = false;
            this.btn_Finish.Click += new System.EventHandler(this.btn_Finish_Click);
            // 
            // btn_Victim_id
            // 
            this.btn_Victim_id.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Victim_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Victim_id.Location = new System.Drawing.Point(300, 101);
            this.btn_Victim_id.Name = "btn_Victim_id";
            this.btn_Victim_id.Size = new System.Drawing.Size(75, 23);
            this.btn_Victim_id.TabIndex = 36;
            this.btn_Victim_id.Text = "Add";
            this.btn_Victim_id.UseVisualStyleBackColor = false;
            this.btn_Victim_id.Click += new System.EventHandler(this.btn_Victim_id_Click);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::Court_System.Properties.Resources.arrowBackTwo;
            this.pictureBoxBack.Location = new System.Drawing.Point(15, 11);
            this.pictureBoxBack.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(38, 39);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 37;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Cases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 448);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.btn_Victim_id);
            this.Controls.Add(this.btn_Finish);
            this.Controls.Add(this.btn_Prisoner_lawyer);
            this.Controls.Add(this.btn_Victim_lawyer);
            this.Controls.Add(this.btn_Prisoner_id);
            this.Controls.Add(this.btn_judge_id);
            this.Controls.Add(this.txt_Prisoner_lawyer);
            this.Controls.Add(this.txt_Prisoner_id);
            this.Controls.Add(this.txt_Victim_lawyer);
            this.Controls.Add(this.txt_Victim_id);
            this.Controls.Add(this.txt_Judge_id);
            this.Controls.Add(this.lbl_Pri_laywer);
            this.Controls.Add(this.lbl_vic_lawyer);
            this.Controls.Add(this.lbl_Prisoner_id);
            this.Controls.Add(this.lbl_victim_id);
            this.Controls.Add(this.lbl_judge_id);
            this.Controls.Add(this.cmb_case_room_name);
            this.Controls.Add(this.cmb_case_id);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.lbl_case_room_name);
            this.Controls.Add(this.lbl_case_date);
            this.Controls.Add(this.case_date);
            this.Controls.Add(this.lbl_case_status);
            this.Controls.Add(this.lbl_case_description);
            this.Controls.Add(this.lbl_case_name);
            this.Controls.Add(this.lbl_case_id);
            this.Controls.Add(this.cmb_case_status);
            this.Controls.Add(this.txt_case_description);
            this.Controls.Add(this.txt_case_name);
            this.Name = "Cases";
            this.Text = "Cases";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cases_FormClosing);
            this.Load += new System.EventHandler(this.Cases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_case_name;
        private System.Windows.Forms.TextBox txt_case_description;
        private System.Windows.Forms.ComboBox cmb_case_status;
        private System.Windows.Forms.Label lbl_case_id;
        private System.Windows.Forms.Label lbl_case_name;
        private System.Windows.Forms.Label lbl_case_description;
        private System.Windows.Forms.Label lbl_case_status;
        private System.Windows.Forms.Label lbl_case_date;
        private System.Windows.Forms.Label lbl_case_room_name;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cmb_case_id;
        private System.Windows.Forms.DateTimePicker case_date;
        private System.Windows.Forms.ComboBox cmb_case_room_name;
        private System.Windows.Forms.Label lbl_judge_id;
        private System.Windows.Forms.Label lbl_victim_id;
        private System.Windows.Forms.Label lbl_Prisoner_id;
        private System.Windows.Forms.Label lbl_vic_lawyer;
        private System.Windows.Forms.Label lbl_Pri_laywer;
        private System.Windows.Forms.TextBox txt_Judge_id;
        private System.Windows.Forms.TextBox txt_Victim_id;
        private System.Windows.Forms.TextBox txt_Victim_lawyer;
        private System.Windows.Forms.TextBox txt_Prisoner_id;
        private System.Windows.Forms.TextBox txt_Prisoner_lawyer;
        private System.Windows.Forms.Button btn_judge_id;
        private System.Windows.Forms.Button btn_Prisoner_id;
        private System.Windows.Forms.Button btn_Victim_lawyer;
        private System.Windows.Forms.Button btn_Prisoner_lawyer;
        private System.Windows.Forms.Button btn_Finish;
        private System.Windows.Forms.Button btn_Victim_id;
        private System.Windows.Forms.PictureBox pictureBoxBack;
    }
}