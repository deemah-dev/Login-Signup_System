namespace LoginSystemWinForm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPSignUp = new System.Windows.Forms.TabPage();
            this.txtbSignPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbSignUsername = new System.Windows.Forms.TextBox();
            this.btnRestartSignUp = new System.Windows.Forms.Button();
            this.btnShowSignPassword = new System.Windows.Forms.Button();
            this.txtbSignLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbSignFirstName = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.tabPLogIn = new System.Windows.Forms.TabPage();
            this.btnRestartLogin = new System.Windows.Forms.Button();
            this.btnShowLoginPassword = new System.Windows.Forms.Button();
            this.txtbLoginPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbLoginUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.LblLockScreenMessage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPSignUp.SuspendLayout();
            this.tabPLogIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPSignUp);
            this.tabControl1.Controls.Add(this.tabPLogIn);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(539, 626);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPSignUp
            // 
            this.tabPSignUp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPSignUp.Controls.Add(this.txtbSignPassword);
            this.tabPSignUp.Controls.Add(this.label8);
            this.tabPSignUp.Controls.Add(this.label9);
            this.tabPSignUp.Controls.Add(this.txtbSignUsername);
            this.tabPSignUp.Controls.Add(this.btnRestartSignUp);
            this.tabPSignUp.Controls.Add(this.btnShowSignPassword);
            this.tabPSignUp.Controls.Add(this.txtbSignLastName);
            this.tabPSignUp.Controls.Add(this.label3);
            this.tabPSignUp.Controls.Add(this.label2);
            this.tabPSignUp.Controls.Add(this.label1);
            this.tabPSignUp.Controls.Add(this.txtbSignFirstName);
            this.tabPSignUp.Controls.Add(this.btnSignUp);
            this.tabPSignUp.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPSignUp.Location = new System.Drawing.Point(4, 25);
            this.tabPSignUp.Name = "tabPSignUp";
            this.tabPSignUp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPSignUp.Size = new System.Drawing.Size(531, 597);
            this.tabPSignUp.TabIndex = 0;
            this.tabPSignUp.Text = "Sign Up";
            this.tabPSignUp.Leave += new System.EventHandler(this.tabPSignUp_Leave);
            // 
            // txtbSignPassword
            // 
            this.txtbSignPassword.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSignPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbSignPassword.Location = new System.Drawing.Point(193, 393);
            this.txtbSignPassword.Name = "txtbSignPassword";
            this.txtbSignPassword.Size = new System.Drawing.Size(194, 35);
            this.txtbSignPassword.TabIndex = 33;
            this.txtbSignPassword.UseSystemPasswordChar = true;
            this.txtbSignPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxes_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(19, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 27);
            this.label8.TabIndex = 32;
            this.label8.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(19, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 27);
            this.label9.TabIndex = 31;
            this.label9.Text = "Username";
            // 
            // txtbSignUsername
            // 
            this.txtbSignUsername.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSignUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbSignUsername.Location = new System.Drawing.Point(193, 307);
            this.txtbSignUsername.Name = "txtbSignUsername";
            this.txtbSignUsername.Size = new System.Drawing.Size(194, 35);
            this.txtbSignUsername.TabIndex = 30;
            this.txtbSignUsername.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxes_Validating);
            // 
            // btnRestartSignUp
            // 
            this.btnRestartSignUp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRestartSignUp.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartSignUp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRestartSignUp.Location = new System.Drawing.Point(287, 483);
            this.btnRestartSignUp.Name = "btnRestartSignUp";
            this.btnRestartSignUp.Size = new System.Drawing.Size(173, 65);
            this.btnRestartSignUp.TabIndex = 28;
            this.btnRestartSignUp.Text = "Reset";
            this.btnRestartSignUp.UseVisualStyleBackColor = false;
            this.btnRestartSignUp.Click += new System.EventHandler(this.btnRestartSignUp_Click);
            // 
            // btnShowSignPassword
            // 
            this.btnShowSignPassword.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowSignPassword.Font = new System.Drawing.Font("Lucida Calligraphy", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSignPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.btnShowSignPassword.Location = new System.Drawing.Point(393, 400);
            this.btnShowSignPassword.Name = "btnShowSignPassword";
            this.btnShowSignPassword.Size = new System.Drawing.Size(132, 28);
            this.btnShowSignPassword.TabIndex = 27;
            this.btnShowSignPassword.Text = "Show Password";
            this.btnShowSignPassword.UseVisualStyleBackColor = false;
            this.btnShowSignPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowPassword_MouseDown);
            this.btnShowSignPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShowPassword_MouseUp);
            // 
            // txtbSignLastName
            // 
            this.txtbSignLastName.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSignLastName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbSignLastName.Location = new System.Drawing.Point(193, 217);
            this.txtbSignLastName.Name = "txtbSignLastName";
            this.txtbSignLastName.Size = new System.Drawing.Size(194, 35);
            this.txtbSignLastName.TabIndex = 26;
            this.txtbSignLastName.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxes_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(121, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 48);
            this.label3.TabIndex = 25;
            this.label3.Text = "Sign Up Screen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(19, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 27);
            this.label2.TabIndex = 24;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(19, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 27);
            this.label1.TabIndex = 23;
            this.label1.Text = "First Name";
            // 
            // txtbSignFirstName
            // 
            this.txtbSignFirstName.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSignFirstName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbSignFirstName.Location = new System.Drawing.Point(193, 130);
            this.txtbSignFirstName.Name = "txtbSignFirstName";
            this.txtbSignFirstName.Size = new System.Drawing.Size(194, 35);
            this.txtbSignFirstName.TabIndex = 22;
            this.txtbSignFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxes_Validating);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSignUp.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSignUp.Location = new System.Drawing.Point(108, 483);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(173, 65);
            this.btnSignUp.TabIndex = 21;
            this.btnSignUp.Text = "SignUp";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // tabPLogIn
            // 
            this.tabPLogIn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPLogIn.Controls.Add(this.LblLockScreenMessage);
            this.tabPLogIn.Controls.Add(this.btnRestartLogin);
            this.tabPLogIn.Controls.Add(this.btnShowLoginPassword);
            this.tabPLogIn.Controls.Add(this.txtbLoginPassword);
            this.tabPLogIn.Controls.Add(this.label5);
            this.tabPLogIn.Controls.Add(this.label6);
            this.tabPLogIn.Controls.Add(this.label7);
            this.tabPLogIn.Controls.Add(this.txtbLoginUsername);
            this.tabPLogIn.Controls.Add(this.btnLogin);
            this.tabPLogIn.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPLogIn.Location = new System.Drawing.Point(4, 25);
            this.tabPLogIn.Name = "tabPLogIn";
            this.tabPLogIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPLogIn.Size = new System.Drawing.Size(531, 597);
            this.tabPLogIn.TabIndex = 1;
            this.tabPLogIn.Text = "Log In";
            this.tabPLogIn.Leave += new System.EventHandler(this.tabPLogIn_Leave);
            // 
            // btnRestartLogin
            // 
            this.btnRestartLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRestartLogin.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRestartLogin.Location = new System.Drawing.Point(287, 483);
            this.btnRestartLogin.Name = "btnRestartLogin";
            this.btnRestartLogin.Size = new System.Drawing.Size(173, 65);
            this.btnRestartLogin.TabIndex = 28;
            this.btnRestartLogin.Text = "Reset";
            this.btnRestartLogin.UseVisualStyleBackColor = false;
            this.btnRestartLogin.Click += new System.EventHandler(this.btnRestartLogin_Click);
            // 
            // btnShowLoginPassword
            // 
            this.btnShowLoginPassword.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowLoginPassword.Font = new System.Drawing.Font("Lucida Calligraphy", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowLoginPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.btnShowLoginPassword.Location = new System.Drawing.Point(393, 303);
            this.btnShowLoginPassword.Name = "btnShowLoginPassword";
            this.btnShowLoginPassword.Size = new System.Drawing.Size(132, 28);
            this.btnShowLoginPassword.TabIndex = 27;
            this.btnShowLoginPassword.Text = "Show Password";
            this.btnShowLoginPassword.UseVisualStyleBackColor = false;
            this.btnShowLoginPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShowPassword_MouseDown);
            this.btnShowLoginPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShowPassword_MouseUp);
            // 
            // txtbLoginPassword
            // 
            this.txtbLoginPassword.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbLoginPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbLoginPassword.Location = new System.Drawing.Point(193, 299);
            this.txtbLoginPassword.Name = "txtbLoginPassword";
            this.txtbLoginPassword.Size = new System.Drawing.Size(194, 35);
            this.txtbLoginPassword.TabIndex = 26;
            this.txtbLoginPassword.UseSystemPasswordChar = true;
            this.txtbLoginPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxes_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(121, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 48);
            this.label5.TabIndex = 25;
            this.label5.Text = "Login Screen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(19, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 27);
            this.label6.TabIndex = 24;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(19, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 27);
            this.label7.TabIndex = 23;
            this.label7.Text = "Username";
            // 
            // txtbLoginUsername
            // 
            this.txtbLoginUsername.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbLoginUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbLoginUsername.Location = new System.Drawing.Point(193, 205);
            this.txtbLoginUsername.Name = "txtbLoginUsername";
            this.txtbLoginUsername.Size = new System.Drawing.Size(194, 35);
            this.txtbLoginUsername.TabIndex = 22;
            this.txtbLoginUsername.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxes_Validating);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(108, 483);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(173, 65);
            this.btnLogin.TabIndex = 21;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LblLockScreenMessage
            // 
            this.LblLockScreenMessage.AutoSize = true;
            this.LblLockScreenMessage.Font = new System.Drawing.Font("Lucida Calligraphy", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLockScreenMessage.ForeColor = System.Drawing.Color.Red;
            this.LblLockScreenMessage.Location = new System.Drawing.Point(101, 136);
            this.LblLockScreenMessage.Name = "LblLockScreenMessage";
            this.LblLockScreenMessage.Size = new System.Drawing.Size(0, 17);
            this.LblLockScreenMessage.TabIndex = 29;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(563, 650);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(126, 50);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formTheme1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.tabControl1.ResumeLayout(false);
            this.tabPSignUp.ResumeLayout(false);
            this.tabPSignUp.PerformLayout();
            this.tabPLogIn.ResumeLayout(false);
            this.tabPLogIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPSignUp;
        private System.Windows.Forms.TabPage tabPLogIn;
        private System.Windows.Forms.Button btnRestartSignUp;
        private System.Windows.Forms.Button btnShowSignPassword;
        private System.Windows.Forms.TextBox txtbSignLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbSignFirstName;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnRestartLogin;
        private System.Windows.Forms.Button btnShowLoginPassword;
        private System.Windows.Forms.TextBox txtbLoginPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbLoginUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtbSignPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbSignUsername;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label LblLockScreenMessage;
        private System.Windows.Forms.Timer timer1;
    }
}

