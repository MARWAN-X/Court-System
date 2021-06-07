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
            this.cmb_names = new System.Windows.Forms.ComboBox();
            this.data_court = new System.Windows.Forms.DataGridView();
            this.cmb_search = new System.Windows.Forms.ComboBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.case_date_search = new System.Windows.Forms.DateTimePicker();
            this.btn_view = new System.Windows.Forms.Button();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_court)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_names
            // 
            this.cmb_names.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_names.FormattingEnabled = true;
            this.cmb_names.Location = new System.Drawing.Point(345, 101);
            this.cmb_names.Name = "cmb_names";
            this.cmb_names.Size = new System.Drawing.Size(121, 21);
            this.cmb_names.TabIndex = 1;
            this.cmb_names.SelectedIndexChanged += new System.EventHandler(this.cmb_names_SelectedIndexChanged);
            // 
            // data_court
            // 
            this.data_court.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_court.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_court.Location = new System.Drawing.Point(34, 184);
            this.data_court.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.data_court.Name = "data_court";
            this.data_court.RowHeadersWidth = 51;
            this.data_court.RowTemplate.Height = 24;
            this.data_court.Size = new System.Drawing.Size(637, 256);
            this.data_court.TabIndex = 4;
            // 
            // cmb_search
            // 
            this.cmb_search.FormattingEnabled = true;
            this.cmb_search.Items.AddRange(new object[] {
            "Court Name",
            "Case Date"});
            this.cmb_search.Location = new System.Drawing.Point(105, 101);
            this.cmb_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.Size = new System.Drawing.Size(115, 21);
            this.cmb_search.TabIndex = 5;
            this.cmb_search.SelectedIndexChanged += new System.EventHandler(this.cmb_search_SelectedIndexChanged);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.Location = new System.Drawing.Point(104, 70);
            this.lbl_search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(86, 17);
            this.lbl_search.TabIndex = 6;
            this.lbl_search.Text = "Search by:";
            // 
            // case_date_search
            // 
            this.case_date_search.Location = new System.Drawing.Point(245, 102);
            this.case_date_search.Name = "case_date_search";
            this.case_date_search.Size = new System.Drawing.Size(221, 20);
            this.case_date_search.TabIndex = 10;
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_view.Location = new System.Drawing.Point(506, 94);
            this.btn_view.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(56, 30);
            this.btn_view.TabIndex = 11;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::Court_System.Properties.Resources.arrowBackTwo;
            this.pictureBoxBack.Location = new System.Drawing.Point(16, 20);
            this.pictureBoxBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(38, 39);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 12;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Court
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(706, 458);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.case_date_search);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.cmb_search);
            this.Controls.Add(this.data_court);
            this.Controls.Add(this.cmb_names);
            this.Name = "Court";
            this.Text = "Court";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Court_FormClosing);
            this.Load += new System.EventHandler(this.Court_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_court)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_names;
        private System.Windows.Forms.DataGridView data_court;
        private System.Windows.Forms.ComboBox cmb_search;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.DateTimePicker case_date_search;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.PictureBox pictureBoxBack;
    }
}