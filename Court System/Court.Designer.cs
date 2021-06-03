namespace Court_System
{
    partial class Court
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
            this.view_btn = new System.Windows.Forms.Button();
            this.cmb_names = new System.Windows.Forms.ComboBox();
            this.CourtID_lbl = new System.Windows.Forms.Label();
            this.txt_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // view_btn
            // 
            this.view_btn.Location = new System.Drawing.Point(1037, 78);
            this.view_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.view_btn.Name = "view_btn";
            this.view_btn.Size = new System.Drawing.Size(100, 28);
            this.view_btn.TabIndex = 0;
            this.view_btn.Text = "View";
            this.view_btn.UseVisualStyleBackColor = true;
            this.view_btn.Click += new System.EventHandler(this.view_btn_Click);
            // 
            // cmb_names
            // 
            this.cmb_names.FormattingEnabled = true;
            this.cmb_names.Location = new System.Drawing.Point(579, 74);
            this.cmb_names.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_names.Name = "cmb_names";
            this.cmb_names.Size = new System.Drawing.Size(160, 24);
            this.cmb_names.TabIndex = 1;
            this.cmb_names.SelectedIndexChanged += new System.EventHandler(this.cmb_names_SelectedIndexChanged);
            // 
            // CourtID_lbl
            // 
            this.CourtID_lbl.AutoSize = true;
            this.CourtID_lbl.Location = new System.Drawing.Point(265, 78);
            this.CourtID_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CourtID_lbl.Name = "CourtID_lbl";
            this.CourtID_lbl.Size = new System.Drawing.Size(83, 17);
            this.CourtID_lbl.TabIndex = 2;
            this.CourtID_lbl.Text = "Court Name";
            // 
            // txt_back
            // 
            this.txt_back.Location = new System.Drawing.Point(16, 65);
            this.txt_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_back.Name = "txt_back";
            this.txt_back.Size = new System.Drawing.Size(100, 28);
            this.txt_back.TabIndex = 3;
            this.txt_back.Text = "back";
            this.txt_back.UseVisualStyleBackColor = true;
            this.txt_back.Click += new System.EventHandler(this.txt_back_Click);
            // 
            // Court
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 554);
            this.Controls.Add(this.txt_back);
            this.Controls.Add(this.CourtID_lbl);
            this.Controls.Add(this.cmb_names);
            this.Controls.Add(this.view_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Court";
            this.Text = "Court";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Court_FormClosing);
            this.Load += new System.EventHandler(this.Court_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button view_btn;
        private System.Windows.Forms.ComboBox cmb_names;
        private System.Windows.Forms.Label CourtID_lbl;
        private System.Windows.Forms.Button txt_back;
    }
}