
namespace Court_System
{
    partial class Log_In_Form
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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.MaskedTextBox();
            this.lbl_SSN = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(487, 161);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(171, 22);
            this.txt_username.TabIndex = 0;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(487, 324);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(171, 22);
            this.txt_password.TabIndex = 1;
            // 
            // lbl_SSN
            // 
            this.lbl_SSN.AutoSize = true;
            this.lbl_SSN.Location = new System.Drawing.Point(268, 161);
            this.lbl_SSN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SSN.Name = "lbl_SSN";
            this.lbl_SSN.Size = new System.Drawing.Size(36, 17);
            this.lbl_SSN.TabIndex = 2;
            this.lbl_SSN.Text = "SSN";
            this.lbl_SSN.Click += new System.EventHandler(this.lbl_username_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(268, 327);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(69, 17);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 425);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Log_In_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_SSN);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Log_In_Form";
            this.Text = "Log In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Log_In_Form_FormClosing);
            this.Load += new System.EventHandler(this.Log_In_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.MaskedTextBox txt_password;
        private System.Windows.Forms.Label lbl_SSN;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button button1;
    }
}

