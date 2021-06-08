
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
            this.pictureBoxChoose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChoose)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Judges
            // 
            this.btn_Judges.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Judges.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Judges.Location = new System.Drawing.Point(270, 140);
            this.btn_Judges.Name = "btn_Judges";
            this.btn_Judges.Size = new System.Drawing.Size(256, 54);
            this.btn_Judges.TabIndex = 1;
            this.btn_Judges.Text = "Judges";
            this.btn_Judges.UseVisualStyleBackColor = false;
            this.btn_Judges.Click += new System.EventHandler(this.btn_Judges_Click);
            // 
            // btn_court
            // 
            this.btn_court.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_court.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_court.Location = new System.Drawing.Point(270, 231);
            this.btn_court.Name = "btn_court";
            this.btn_court.Size = new System.Drawing.Size(256, 54);
            this.btn_court.TabIndex = 2;
            this.btn_court.Text = "Court";
            this.btn_court.UseVisualStyleBackColor = false;
            this.btn_court.Click += new System.EventHandler(this.btn_court_Click);
            // 
            // btn_Cases
            // 
            this.btn_Cases.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Cases.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cases.Location = new System.Drawing.Point(270, 51);
            this.btn_Cases.Name = "btn_Cases";
            this.btn_Cases.Size = new System.Drawing.Size(256, 54);
            this.btn_Cases.TabIndex = 3;
            this.btn_Cases.Text = "Cases";
            this.btn_Cases.UseVisualStyleBackColor = false;
            this.btn_Cases.Click += new System.EventHandler(this.btn_Cases_Click);
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.Location = new System.Drawing.Point(270, 327);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(256, 54);
            this.btn_report.TabIndex = 4;
            this.btn_report.Text = "Crystal Report";
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // pictureBoxChoose
            // 
            this.pictureBoxChoose.Image = global::Court_System.Properties.Resources.choosePicTwo;
            this.pictureBoxChoose.Location = new System.Drawing.Point(48, 127);
            this.pictureBoxChoose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxChoose.Name = "pictureBoxChoose";
            this.pictureBoxChoose.Size = new System.Drawing.Size(138, 174);
            this.pictureBoxChoose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxChoose.TabIndex = 5;
            this.pictureBoxChoose.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(559, 427);
            this.Controls.Add(this.pictureBoxChoose);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_Cases);
            this.Controls.Add(this.btn_court);
            this.Controls.Add(this.btn_Judges);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChoose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Judges;
        private System.Windows.Forms.Button btn_court;
        private System.Windows.Forms.Button btn_Cases;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.PictureBox pictureBoxChoose;
    }
}