
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
            this.txt_case_id = new System.Windows.Forms.TextBox();
            this.txt_case_name = new System.Windows.Forms.TextBox();
            this.txt_case_description = new System.Windows.Forms.TextBox();
            this.cmb_case_status = new System.Windows.Forms.ComboBox();
            this.lbl_case_id = new System.Windows.Forms.Label();
            this.lbl_case_name = new System.Windows.Forms.Label();
            this.lbl_case_description = new System.Windows.Forms.Label();
            this.lbl_case_status = new System.Windows.Forms.Label();
            this.case_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_case_date = new System.Windows.Forms.Label();
            this.txt_case_room_name = new System.Windows.Forms.TextBox();
            this.lbl_case_room_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_case_id
            // 
            this.txt_case_id.Location = new System.Drawing.Point(283, 38);
            this.txt_case_id.Name = "txt_case_id";
            this.txt_case_id.Size = new System.Drawing.Size(221, 20);
            this.txt_case_id.TabIndex = 0;
            // 
            // txt_case_name
            // 
            this.txt_case_name.Location = new System.Drawing.Point(283, 79);
            this.txt_case_name.Name = "txt_case_name";
            this.txt_case_name.Size = new System.Drawing.Size(221, 20);
            this.txt_case_name.TabIndex = 2;
            // 
            // txt_case_description
            // 
            this.txt_case_description.Location = new System.Drawing.Point(283, 120);
            this.txt_case_description.Name = "txt_case_description";
            this.txt_case_description.Size = new System.Drawing.Size(221, 20);
            this.txt_case_description.TabIndex = 3;
            // 
            // cmb_case_status
            // 
            this.cmb_case_status.FormattingEnabled = true;
            this.cmb_case_status.Location = new System.Drawing.Point(283, 171);
            this.cmb_case_status.Name = "cmb_case_status";
            this.cmb_case_status.Size = new System.Drawing.Size(221, 21);
            this.cmb_case_status.TabIndex = 4;
            // 
            // lbl_case_id
            // 
            this.lbl_case_id.AutoSize = true;
            this.lbl_case_id.Location = new System.Drawing.Point(153, 45);
            this.lbl_case_id.Name = "lbl_case_id";
            this.lbl_case_id.Size = new System.Drawing.Size(45, 13);
            this.lbl_case_id.TabIndex = 5;
            this.lbl_case_id.Text = "Case ID";
            this.lbl_case_id.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_case_name
            // 
            this.lbl_case_name.AutoSize = true;
            this.lbl_case_name.Location = new System.Drawing.Point(153, 86);
            this.lbl_case_name.Name = "lbl_case_name";
            this.lbl_case_name.Size = new System.Drawing.Size(62, 13);
            this.lbl_case_name.TabIndex = 6;
            this.lbl_case_name.Text = "Case Name";
            // 
            // lbl_case_description
            // 
            this.lbl_case_description.AutoSize = true;
            this.lbl_case_description.Location = new System.Drawing.Point(153, 127);
            this.lbl_case_description.Name = "lbl_case_description";
            this.lbl_case_description.Size = new System.Drawing.Size(87, 13);
            this.lbl_case_description.TabIndex = 7;
            this.lbl_case_description.Text = "Case Description";
            this.lbl_case_description.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_case_status
            // 
            this.lbl_case_status.AutoSize = true;
            this.lbl_case_status.Location = new System.Drawing.Point(153, 179);
            this.lbl_case_status.Name = "lbl_case_status";
            this.lbl_case_status.Size = new System.Drawing.Size(64, 13);
            this.lbl_case_status.TabIndex = 8;
            this.lbl_case_status.Text = "Case Satuts";
            // 
            // case_date
            // 
            this.case_date.Location = new System.Drawing.Point(283, 232);
            this.case_date.Name = "case_date";
            this.case_date.Size = new System.Drawing.Size(221, 20);
            this.case_date.TabIndex = 9;
            // 
            // lbl_case_date
            // 
            this.lbl_case_date.AutoSize = true;
            this.lbl_case_date.Location = new System.Drawing.Point(153, 238);
            this.lbl_case_date.Name = "lbl_case_date";
            this.lbl_case_date.Size = new System.Drawing.Size(57, 13);
            this.lbl_case_date.TabIndex = 10;
            this.lbl_case_date.Text = "Case Date";
            // 
            // txt_case_room_name
            // 
            this.txt_case_room_name.Location = new System.Drawing.Point(283, 287);
            this.txt_case_room_name.Name = "txt_case_room_name";
            this.txt_case_room_name.Size = new System.Drawing.Size(221, 20);
            this.txt_case_room_name.TabIndex = 11;
            // 
            // lbl_case_room_name
            // 
            this.lbl_case_room_name.AutoSize = true;
            this.lbl_case_room_name.Location = new System.Drawing.Point(153, 294);
            this.lbl_case_room_name.Name = "lbl_case_room_name";
            this.lbl_case_room_name.Size = new System.Drawing.Size(93, 13);
            this.lbl_case_room_name.TabIndex = 12;
            this.lbl_case_room_name.Text = "Case Room Name";
            // 
            // Cases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_case_room_name);
            this.Controls.Add(this.txt_case_room_name);
            this.Controls.Add(this.lbl_case_date);
            this.Controls.Add(this.case_date);
            this.Controls.Add(this.lbl_case_status);
            this.Controls.Add(this.lbl_case_description);
            this.Controls.Add(this.lbl_case_name);
            this.Controls.Add(this.lbl_case_id);
            this.Controls.Add(this.cmb_case_status);
            this.Controls.Add(this.txt_case_description);
            this.Controls.Add(this.txt_case_name);
            this.Controls.Add(this.txt_case_id);
            this.Name = "Cases";
            this.Text = "Cases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_case_id;
        private System.Windows.Forms.TextBox txt_case_name;
        private System.Windows.Forms.TextBox txt_case_description;
        private System.Windows.Forms.ComboBox cmb_case_status;
        private System.Windows.Forms.Label lbl_case_id;
        private System.Windows.Forms.Label lbl_case_name;
        private System.Windows.Forms.Label lbl_case_description;
        private System.Windows.Forms.Label lbl_case_status;
        private System.Windows.Forms.DateTimePicker case_date;
        private System.Windows.Forms.Label lbl_case_date;
        private System.Windows.Forms.TextBox txt_case_room_name;
        private System.Windows.Forms.Label lbl_case_room_name;
    }
}