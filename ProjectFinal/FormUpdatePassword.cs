
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinal
{
    public partial class FormUpdatePassword : Form
    {
        User u;
        UseDB udb;
        bool isCurrentPasswordVisible = false;
        bool isNewPasswordVisible = false;
        bool isConfirmPasswordVisible = false;

        User U
        { get { return u; } set { this.u = value; } }
        public FormUpdatePassword()
        {
            InitializeComponent();
        }

        internal FormUpdatePassword(User user, UseDB udb): this()
        {
            try
            {
                this.U = user;
                this.udb = udb;
            }
            catch (Exception exc)
            {
                MessageBox.Show($"An error occured. Error: {exc.Message}", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void FormUpdatePassword_Load(object sender, EventArgs e)
        {
            this.txtUserId.Text = this.U.Id;

            if(this.isCurrentPasswordVisible)
                this.txtCurrentPassword.PasswordChar = '\0';
            else
                this.txtCurrentPassword.PasswordChar = '*';

            if (this.isNewPasswordVisible)
                this.txtNewPassword.PasswordChar = '\0';
            else
                this.txtNewPassword.PasswordChar = '*';

            if (this.isConfirmPasswordVisible)
                this.txtConfirmPassword.PasswordChar = '\0';
            else
                this.txtConfirmPassword.PasswordChar = '*';
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtCurrentPassword.Text == this.U.Password)
                {
                    if (string.IsNullOrEmpty(this.txtNewPassword.Text) || (string.IsNullOrEmpty(this.txtConfirmPassword.Text)))
                    {
                        MessageBox.Show("Enter all fields", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (this.txtNewPassword.Text == this.txtConfirmPassword.Text)
                        {
                            int result = udb.executeQuery($"update [User] set UPassword = '{this.txtNewPassword.Text}' where UId = '{this.U.Id}'");
                            if (result == 1)
                            {
                                MessageBox.Show("Password updated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                this.Close();
                            }
                                
                            else
                                MessageBox.Show("An error occured", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            this.txtNewPassword.Clear();
                            this.txtConfirmPassword.Clear();
                            MessageBox.Show("New password an confirmed password do not match. Try again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                    MessageBox.Show("Incorrect password. Try again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception exc)
            {
                MessageBox.Show($"An error occured. Error: {exc.Message}", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnShowHideCurrPass_Click(object sender, EventArgs e)
        {
            if(isCurrentPasswordVisible)
            {
                isCurrentPasswordVisible = false;
                this.txtCurrentPassword.PasswordChar = '\0';
            }
            else
            {
                isCurrentPasswordVisible = true;
                this.txtCurrentPassword.PasswordChar = '*';
            }
        }

        private void btnShowHideNewPass_Click(object sender, EventArgs e)
        {
            if (isNewPasswordVisible)
            {
                isNewPasswordVisible = false;
                this.txtNewPassword.PasswordChar = '\0';
            }
            else
            {
                isNewPasswordVisible = true;
                this.txtNewPassword.PasswordChar = '*';
            }
        }

        private void btnShowHideConfirmPass_Click(object sender, EventArgs e)
        {
            if (isConfirmPasswordVisible)
            {
                isConfirmPasswordVisible = false;
                this.txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                isConfirmPasswordVisible = true;
                this.txtConfirmPassword.PasswordChar = '*';
            }
        }
    }
}
