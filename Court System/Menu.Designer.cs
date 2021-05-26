
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
            this.SuspendLayout();
            // 
            // btn_Judges
            // 
            this.btn_Judges.Location = new System.Drawing.Point(264, 183);
            this.btn_Judges.Name = "btn_Judges";
            this.btn_Judges.Size = new System.Drawing.Size(256, 54);
            this.btn_Judges.TabIndex = 1;
            this.btn_Judges.Text = "Judges";
            this.btn_Judges.UseVisualStyleBackColor = true;
            // 
            // btn_court
            // 
            this.btn_court.Location = new System.Drawing.Point(264, 312);
            this.btn_court.Name = "btn_court";
            this.btn_court.Size = new System.Drawing.Size(256, 54);
            this.btn_court.TabIndex = 2;
            this.btn_court.Text = "Court";
            this.btn_court.UseVisualStyleBackColor = true;
            // 
            // btn_Cases
            // 
            this.btn_Cases.Location = new System.Drawing.Point(264, 69);
            this.btn_Cases.Name = "btn_Cases";
            this.btn_Cases.Size = new System.Drawing.Size(256, 54);
            this.btn_Cases.TabIndex = 3;
            this.btn_Cases.Text = "Cases";
            this.btn_Cases.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Cases);
            this.Controls.Add(this.btn_court);
            this.Controls.Add(this.btn_Judges);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Judges;
        private System.Windows.Forms.Button btn_court;
        private System.Windows.Forms.Button btn_Cases;
    }
}