using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WorkFlowManagement 
{
    public partial class RegisterForm : Form
    {
        DatabaseManager q = new DatabaseManager();
        Password objPassword = new Password();
        public RegisterForm()
        {
            InitializeComponent();      
            this.AcceptButton = btnRegister;
        }

        private Boolean isValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            } catch {
                return false;
            }
        }

        private Boolean CheckValidUser()
        {
            
            if (objPassword.DeterminePasswordStrength(txtPassword.Text) < 0)
            {
                MessageBox.Show("Password is not Strong enough!");
                return false;
            }

            if(txtPassword.Text != txtVerifyPassword.Text)
            {
                MessageBox.Show("Password and Verify Password must match!");
                txtPassword.Text = "";
                txtVerifyPassword.Text = "";
                return false;
            }

            if (!isValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please Use a Valid Email!");
                txtEmail.Text = "";
                return false;
            }

            return true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Boolean success_flag=true;

            if (CheckValidUser())
            {
                try
                {
                    
                    string encrptedPassword = objPassword.encryptPassword(txtPassword.Text);
                    q.InsertUser(txtFirstName.Text, txtLastName.Text, cboxUserType.Text, 
                        txtEmail.Text, txtUsername.Text, encrptedPassword);
                }
                catch (SqlException EX)
                {
                    if (EX.Number == 2627)
                    {
                        MessageBox.Show("That Username is already taken. Sorry! Try again.");
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        txtVerifyPassword.Text = "";
                        success_flag = false;
                    }
                    else
                    {
                        MessageBox.Show("Error: " + EX);
                    }
                }
                
            }
            else return;

            if (success_flag)
            {
                MessageBox.Show("New User " + txtUsername.Text + " created!");
                this.Hide();
                LoginForm formLogin = new LoginForm();
                formLogin.ShowDialog();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
           
            int passStrength = objPassword.DeterminePasswordStrength(txtPassword.Text)+64;

            if (passStrength-64 < progressBar1.Minimum)
            {
                progressBar1.Value =  passStrength/ 8;
            }
            else if(passStrength > progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Maximum;
            }
            else  {
                progressBar1.Value = passStrength;
            }
        }
      
    }
}
