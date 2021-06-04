﻿
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
            this.btn_back = new System.Windows.Forms.Button();
            this.cmb_case_room_name = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_case_name
            // 
            this.txt_case_name.Location = new System.Drawing.Point(467, 99);
            this.txt_case_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_case_name.Name = "txt_case_name";
            this.txt_case_name.Size = new System.Drawing.Size(293, 22);
            this.txt_case_name.TabIndex = 2;
            // 
            // txt_case_description
            // 
            this.txt_case_description.Location = new System.Drawing.Point(467, 150);
            this.txt_case_description.Margin = new System.Windows.Forms.Padding(4);
            this.txt_case_description.Name = "txt_case_description";
            this.txt_case_description.Size = new System.Drawing.Size(293, 22);
            this.txt_case_description.TabIndex = 3;
            // 
            // cmb_case_status
            // 
            this.cmb_case_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_case_status.FormattingEnabled = true;
            this.cmb_case_status.Location = new System.Drawing.Point(467, 212);
            this.cmb_case_status.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_case_status.Name = "cmb_case_status";
            this.cmb_case_status.Size = new System.Drawing.Size(293, 24);
            this.cmb_case_status.TabIndex = 4;
            // 
            // lbl_case_id
            // 
            this.lbl_case_id.AutoSize = true;
            this.lbl_case_id.Location = new System.Drawing.Point(294, 57);
            this.lbl_case_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_case_id.Name = "lbl_case_id";
            this.lbl_case_id.Size = new System.Drawing.Size(57, 17);
            this.lbl_case_id.TabIndex = 5;
            this.lbl_case_id.Text = "Case ID";
            // 
            // lbl_case_name
            // 
            this.lbl_case_name.AutoSize = true;
            this.lbl_case_name.Location = new System.Drawing.Point(294, 108);
            this.lbl_case_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_case_name.Name = "lbl_case_name";
            this.lbl_case_name.Size = new System.Drawing.Size(81, 17);
            this.lbl_case_name.TabIndex = 6;
            this.lbl_case_name.Text = "Case Name";
            // 
            // lbl_case_description
            // 
            this.lbl_case_description.AutoSize = true;
            this.lbl_case_description.Location = new System.Drawing.Point(294, 158);
            this.lbl_case_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_case_description.Name = "lbl_case_description";
            this.lbl_case_description.Size = new System.Drawing.Size(115, 17);
            this.lbl_case_description.TabIndex = 7;
            this.lbl_case_description.Text = "Case Description";
            // 
            // lbl_case_status
            // 
            this.lbl_case_status.AutoSize = true;
            this.lbl_case_status.Location = new System.Drawing.Point(294, 222);
            this.lbl_case_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_case_status.Name = "lbl_case_status";
            this.lbl_case_status.Size = new System.Drawing.Size(84, 17);
            this.lbl_case_status.TabIndex = 8;
            this.lbl_case_status.Text = "Case Status";
            // 
            // lbl_case_date
            // 
            this.lbl_case_date.AutoSize = true;
            this.lbl_case_date.Location = new System.Drawing.Point(294, 295);
            this.lbl_case_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_case_date.Name = "lbl_case_date";
            this.lbl_case_date.Size = new System.Drawing.Size(74, 17);
            this.lbl_case_date.TabIndex = 10;
            this.lbl_case_date.Text = "Case Date";
            // 
            // lbl_case_room_name
            // 
            this.lbl_case_room_name.AutoSize = true;
            this.lbl_case_room_name.Location = new System.Drawing.Point(294, 364);
            this.lbl_case_room_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_case_room_name.Name = "lbl_case_room_name";
            this.lbl_case_room_name.Size = new System.Drawing.Size(83, 17);
            this.lbl_case_room_name.TabIndex = 12;
            this.lbl_case_room_name.Text = "Court Name";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(382, 421);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 13;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(575, 421);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(759, 421);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cmb_case_id
            // 
            this.cmb_case_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_case_id.FormattingEnabled = true;
            this.cmb_case_id.Location = new System.Drawing.Point(467, 50);
            this.cmb_case_id.Name = "cmb_case_id";
            this.cmb_case_id.Size = new System.Drawing.Size(293, 24);
            this.cmb_case_id.TabIndex = 16;
            this.cmb_case_id.SelectedIndexChanged += new System.EventHandler(this.cmb_case_id_SelectedIndexChanged);
            // 
            // case_date
            // 
            this.case_date.Location = new System.Drawing.Point(467, 288);
            this.case_date.Margin = new System.Windows.Forms.Padding(4);
            this.case_date.Name = "case_date";
            this.case_date.Size = new System.Drawing.Size(293, 22);
            this.case_date.TabIndex = 9;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(101, 29);
            this.btn_back.TabIndex = 17;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // cmb_case_room_name
            // 
            this.cmb_case_room_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_case_room_name.FormattingEnabled = true;
            this.cmb_case_room_name.Location = new System.Drawing.Point(467, 364);
            this.cmb_case_room_name.Name = "cmb_case_room_name";
            this.cmb_case_room_name.Size = new System.Drawing.Size(293, 24);
            this.cmb_case_room_name.TabIndex = 18;
            // 
            // Cases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Court_System.Properties.Resources.photo_1568092806323_8ec13dfa9b92;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.cmb_case_room_name);
            this.Controls.Add(this.btn_back);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cases";
            this.Text = "Cases";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cases_FormClosing);
            this.Load += new System.EventHandler(this.Cases_Load);
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
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox cmb_case_room_name;
    }
}