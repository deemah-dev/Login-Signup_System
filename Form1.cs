using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystemWinForm
{
    public partial class Form1 : Form
    {
        private string path = "C:\\Users\\user\\source\\repos\\LoginSystemWinForm\\LoginSystemWinForm\\LoginFile.txt";
        private byte CountFailedTries = 0;
        private byte SecondCounter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ValidateTextBox(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                e.Cancel = true;
                ((TextBox)sender).Focus();
                errorProvider1.SetError(((TextBox)sender), "This Box Should Have A Value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(((TextBox)sender), "");
            }
        }

        private void TextBoxes_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(sender, e);
        }

        private string EncryptText(string Text)
        {
            var sb = new StringBuilder(Text.Length);
            foreach (char letter in Text)
                sb.Append((char)((byte)letter + 5));
            return sb.ToString();
        }

        private string GetPasswordEncrypted()
        {
            return EncryptText(txtbSignPassword.Text);
        }

        private void StoreUserInFile()
        {
            using (var sw = new StreamWriter(path, true))
            {
                sw.Write(txtbSignFirstName.Text + "#//#");
                sw.Write(txtbSignLastName.Text + "#//#");
                sw.Write(txtbSignUsername.Text + "#//#");
                sw.Write(GetPasswordEncrypted());
                sw.WriteLine();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            StoreUserInFile();
            MessageBox.Show("Sign Up Done Successfully", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CleanSignUpScreen()
        {
            txtbSignFirstName.Clear();
            txtbSignLastName.Clear();
            txtbSignUsername.Clear();
            txtbSignPassword.Clear();
        }

        private void btnRestartSignUp_Click(object sender, EventArgs e)
        {
            CleanSignUpScreen();
        }

        private void btnShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            if(((Button)sender) == btnShowSignPassword)
                txtbSignPassword.UseSystemPasswordChar = false;
            else if (((Button)sender) == btnShowLoginPassword)
                txtbLoginPassword.UseSystemPasswordChar = false;
        }

        private void btnShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            if (((Button)sender) == btnShowSignPassword)
                txtbSignPassword.UseSystemPasswordChar = true;
            else if (((Button)sender) == btnShowLoginPassword)
                txtbLoginPassword.UseSystemPasswordChar = true;
        }

        private string DecryptText(string Text)
        {
            var sb = new StringBuilder(Text.Length);
            foreach (var letter in Text)
                sb.Append((char)((byte)letter - 5));
            return sb.ToString();
        }

        private string GetPasswordDecrypted()
        {
            return DecryptText(txtbSignPassword.Text);
        }

        private bool FindUser()
        {
            string[] Lines = File.ReadAllLines(path);
            foreach (var line in Lines)
            {
                if (line.Contains(txtbLoginUsername.Text))
                {
                    if (line.Contains(GetPasswordDecrypted()))
                        return true;
                }
            }
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool IsFoundUser = FindUser();
            if (IsFoundUser)
                MessageBox.Show("Login Done Successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Login Failed", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CountFailedTries++;
            }
        }

        private void CleanLoginScreen()
        {
            txtbLoginUsername.Clear();
            txtbLoginPassword.Clear();
        }

        private void btnRestartLogin_Click(object sender, EventArgs e)
        {
            CleanLoginScreen();
        }

        private void tabPSignUp_Leave(object sender, EventArgs e)
        {
            CleanSignUpScreen();
        }

        private void tabPLogIn_Leave(object sender, EventArgs e)
        {
            CleanLoginScreen();
        }

        private void EnabledLoginScreen(bool IsEnabled)
        {
            txtbLoginUsername.Enabled = IsEnabled;
            txtbLoginPassword.Enabled = IsEnabled;
            btnLogin.Enabled = IsEnabled;
            btnRestartLogin.Enabled = IsEnabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CountFailedTries >= 3)
            {
                SecondCounter++;
                LblLockScreenMessage.Text = "You are locked, try again after 10 Seconds : " + SecondCounter.ToString();
                EnabledLoginScreen(false);
                if (SecondCounter == 10)
                {
                    LblLockScreenMessage.Text = "";
                    EnabledLoginScreen(true);
                    CountFailedTries = 0;
                    SecondCounter = 0;
                }
            }
        }
    }
}