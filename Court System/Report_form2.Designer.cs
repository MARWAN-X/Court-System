
namespace Court_System
{
    partial class Report_form2
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.lbl_Case_ID = new System.Windows.Forms.Label();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.AllowDrop = true;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.crystalReportViewer1.Location = new System.Drawing.Point(1, 73);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1325, 724);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(677, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // btn_Generate
            // 
            this.btn_Generate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generate.Location = new System.Drawing.Point(957, 17);
            this.btn_Generate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(139, 39);
            this.btn_Generate.TabIndex = 5;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = false;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // lbl_Case_ID
            // 
            this.lbl_Case_ID.AutoSize = true;
            this.lbl_Case_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Case_ID.Location = new System.Drawing.Point(544, 25);
            this.lbl_Case_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Case_ID.Name = "lbl_Case_ID";
            this.lbl_Case_ID.Size = new System.Drawing.Size(82, 24);
            this.lbl_Case_ID.TabIndex = 6;
            this.lbl_Case_ID.Text = "Case ID";
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::Court_System.Properties.Resources.arrowBackTwo;
            this.pictureBoxBack.Location = new System.Drawing.Point(40, 18);
            this.pictureBoxBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(51, 48);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 39;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // Report_form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 790);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.lbl_Case_ID);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Report_form2";
            this.Text = "Second Crystal Report";
            this.Load += new System.EventHandler(this.Report_form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Label lbl_Case_ID;
        private System.Windows.Forms.PictureBox pictureBoxBack;
    }
}