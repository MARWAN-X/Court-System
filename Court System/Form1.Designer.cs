
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
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(218, 293);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(171, 22);
            this.txt_username.TabIndex = 0;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(218, 339);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(171, 22);
            this.txt_password.TabIndex = 1;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_password_MaskInputRejected);
            // 
            // lbl_SSN
            // 
            this.lbl_SSN.AutoSize = true;
            this.lbl_SSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SSN.Location = new System.Drawing.Point(80, 295);
            this.lbl_SSN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SSN.Name = "lbl_SSN";
            this.lbl_SSN.Size = new System.Drawing.Size(46, 20);
            this.lbl_SSN.TabIndex = 2;
            this.lbl_SSN.Text = "SSN";
            this.lbl_SSN.Click += new System.EventHandler(this.lbl_username_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(80, 341);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(91, 20);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(173, 436);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Image = global::Court_System.Properties.Resources.LoginIcon;
            this.pictureBoxLogin.Location = new System.Drawing.Point(149, 85);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(149, 138);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogin.TabIndex = 5;
            this.pictureBoxLogin.TabStop = false;
            // 
            // Log_In_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(470, 532);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_SSN);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Log_In_Form";
            this.Text = "Log In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Log_In_Form_FormClosing);
            this.Load += new System.EventHandler(this.Log_In_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.MaskedTextBox txt_password;
        private System.Windows.Forms.Label lbl_SSN;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
    }
}

