
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
            this.pictureBoxChoose = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChoose)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Judges
            // 
            this.btn_Judges.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Judges.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Judges.Location = new System.Drawing.Point(360, 172);
            this.btn_Judges.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Judges.Name = "btn_Judges";
            this.btn_Judges.Size = new System.Drawing.Size(341, 66);
            this.btn_Judges.TabIndex = 1;
            this.btn_Judges.Text = "Judges";
            this.btn_Judges.UseVisualStyleBackColor = false;
            this.btn_Judges.Click += new System.EventHandler(this.btn_Judges_Click);
            // 
            // btn_court
            // 
            this.btn_court.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_court.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_court.Location = new System.Drawing.Point(360, 284);
            this.btn_court.Margin = new System.Windows.Forms.Padding(4);
            this.btn_court.Name = "btn_court";
            this.btn_court.Size = new System.Drawing.Size(341, 66);
            this.btn_court.TabIndex = 2;
            this.btn_court.Text = "Court";
            this.btn_court.UseVisualStyleBackColor = false;
            this.btn_court.Click += new System.EventHandler(this.btn_court_Click);
            // 
            // btn_Cases
            // 
            this.btn_Cases.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Cases.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cases.Location = new System.Drawing.Point(360, 63);
            this.btn_Cases.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cases.Name = "btn_Cases";
            this.btn_Cases.Size = new System.Drawing.Size(341, 66);
            this.btn_Cases.TabIndex = 3;
            this.btn_Cases.Text = "Cases";
            this.btn_Cases.UseVisualStyleBackColor = false;
            this.btn_Cases.Click += new System.EventHandler(this.btn_Cases_Click);
            // 
            // pictureBoxChoose
            // 
            this.pictureBoxChoose.Image = global::Court_System.Properties.Resources.choosePicTwo;
            this.pictureBoxChoose.Location = new System.Drawing.Point(64, 156);
            this.pictureBoxChoose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxChoose.Name = "pictureBoxChoose";
            this.pictureBoxChoose.Size = new System.Drawing.Size(184, 214);
            this.pictureBoxChoose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxChoose.TabIndex = 5;
            this.pictureBoxChoose.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(535, 390);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(333, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Crystal Report";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(360, 438);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(341, 66);
            this.button1.TabIndex = 8;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(745, 526);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBoxChoose);
            this.Controls.Add(this.btn_Cases);
            this.Controls.Add(this.btn_court);
            this.Controls.Add(this.btn_Judges);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChoose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Judges;
        private System.Windows.Forms.Button btn_court;
        private System.Windows.Forms.Button btn_Cases;
        private System.Windows.Forms.PictureBox pictureBoxChoose;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}