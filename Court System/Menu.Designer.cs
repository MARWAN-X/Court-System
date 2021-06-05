
namespace Court_System
{
    partial class Menu
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
            this.btn_Judges = new System.Windows.Forms.Button();
            this.btn_court = new System.Windows.Forms.Button();
            this.btn_Cases = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Judges
            // 
            this.btn_Judges.Location = new System.Drawing.Point(264, 118);
            this.btn_Judges.Name = "btn_Judges";
            this.btn_Judges.Size = new System.Drawing.Size(256, 54);
            this.btn_Judges.TabIndex = 1;
            this.btn_Judges.Text = "Judges";
            this.btn_Judges.UseVisualStyleBackColor = true;
            this.btn_Judges.Click += new System.EventHandler(this.btn_Judges_Click);
            // 
            // btn_court
            // 
            this.btn_court.Location = new System.Drawing.Point(264, 215);
            this.btn_court.Name = "btn_court";
            this.btn_court.Size = new System.Drawing.Size(256, 54);
            this.btn_court.TabIndex = 2;
            this.btn_court.Text = "Court";
            this.btn_court.UseVisualStyleBackColor = true;
            this.btn_court.Click += new System.EventHandler(this.btn_court_Click);
            // 
            // btn_Cases
            // 
            this.btn_Cases.Location = new System.Drawing.Point(264, 29);
            this.btn_Cases.Name = "btn_Cases";
            this.btn_Cases.Size = new System.Drawing.Size(256, 54);
            this.btn_Cases.TabIndex = 3;
            this.btn_Cases.Text = "Cases";
            this.btn_Cases.UseVisualStyleBackColor = true;
            this.btn_Cases.Click += new System.EventHandler(this.btn_Cases_Click);
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(264, 317);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(256, 54);
            this.btn_report.TabIndex = 4;
            this.btn_report.Text = "Crystal Report";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Court_System.Properties.Resources._4144272;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 449);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_Cases);
            this.Controls.Add(this.btn_court);
            this.Controls.Add(this.btn_Judges);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Judges;
        private System.Windows.Forms.Button btn_court;
        private System.Windows.Forms.Button btn_Cases;
        private System.Windows.Forms.Button btn_report;
    }
}