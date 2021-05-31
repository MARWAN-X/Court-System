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
            this.SuspendLayout();
            // 
            // view_btn
            // 
            this.view_btn.Location = new System.Drawing.Point(778, 63);
            this.view_btn.Name = "view_btn";
            this.view_btn.Size = new System.Drawing.Size(75, 23);
            this.view_btn.TabIndex = 0;
            this.view_btn.Text = "View";
            this.view_btn.UseVisualStyleBackColor = true;
            this.view_btn.Click += new System.EventHandler(this.view_btn_Click);
            // 
            // cmb_names
            // 
            this.cmb_names.FormattingEnabled = true;
            this.cmb_names.Location = new System.Drawing.Point(434, 60);
            this.cmb_names.Name = "cmb_names";
            this.cmb_names.Size = new System.Drawing.Size(121, 21);
            this.cmb_names.TabIndex = 1;
            // 
            // CourtID_lbl
            // 
            this.CourtID_lbl.AutoSize = true;
            this.CourtID_lbl.Location = new System.Drawing.Point(199, 63);
            this.CourtID_lbl.Name = "CourtID_lbl";
            this.CourtID_lbl.Size = new System.Drawing.Size(63, 13);
            this.CourtID_lbl.TabIndex = 2;
            this.CourtID_lbl.Text = "Court Name";
            // 
            // Court
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 450);
            this.Controls.Add(this.CourtID_lbl);
            this.Controls.Add(this.cmb_names);
            this.Controls.Add(this.view_btn);
            this.Name = "Court";
            this.Text = "Court";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button view_btn;
        private System.Windows.Forms.ComboBox cmb_names;
        private System.Windows.Forms.Label CourtID_lbl;
    }
}