
namespace Court_System
{
    partial class Report_form
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
            this.lbl_Case_ID = new System.Windows.Forms.Label();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Case_ID
            // 
            this.lbl_Case_ID.AutoSize = true;
            this.lbl_Case_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Case_ID.Location = new System.Drawing.Point(703, 20);
            this.lbl_Case_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Case_ID.Name = "lbl_Case_ID";
            this.lbl_Case_ID.Size = new System.Drawing.Size(105, 24);
            this.lbl_Case_ID.TabIndex = 0;
            this.lbl_Case_ID.Text = "Case Date";
            this.lbl_Case_ID.Click += new System.EventHandler(this.lbl_Case_ID_Click);
            // 
            // btn_Generate
            // 
            this.btn_Generate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generate.Location = new System.Drawing.Point(1148, 11);
            this.btn_Generate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(139, 39);
            this.btn_Generate.TabIndex = 2;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = false;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Location = new System.Drawing.Point(3, 58);
            this.crystalReportViewer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.Size = new System.Drawing.Size(2082, 736);
            this.crystalReportViewer.TabIndex = 3;
            this.crystalReportViewer.ToolPanelWidth = 267;
            this.crystalReportViewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(849, 20);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::Court_System.Properties.Resources.arrowBackTwo;
            this.pictureBoxBack.Location = new System.Drawing.Point(36, 4);
            this.pictureBoxBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(51, 48);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 38;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // Report_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1924, 805);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.crystalReportViewer);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.lbl_Case_ID);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Report_form";
            this.Text = "First Crystal Report";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Case_ID;
        private System.Windows.Forms.Button btn_Generate;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBoxBack;
    }
}