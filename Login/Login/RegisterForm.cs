using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WorkFlowManagement 
{
    public partial class RegisterForm : Form
    {
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
            } catch
            {
                return false;
            }
        }


        private Boolean CheckValidUser()
        {
            Password validateStrength = new Password();

            if (validateStrength.DeterminePasswordStrength(txtPassword.Text) < 0)
            {
                MessageBox.Show("Password is not Strong enough!");
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
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "tcp:workflowdatabase.database.windows.net,1433"; 
                builder.UserID = "OCOTOD";            
                builder.Password = "FairBanks152";     
                builder.InitialCatalog = "WorkFlowDatabase";
           SqlConnection con = new SqlConnection(builder.ConnectionString);

            string str;
            Boolean success_flag=true;

            if (CheckValidUser())
            {
               Password objPassword = new Password();
                string encrptedPassword = objPassword.encryptPassword(txtPassword.Text);
               str = "INSERT INTO [dbo].[UsersTable] ( [FirstName], [LastName], [UserType], [Email], [UserName], [Password]) VALUES ('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + cboxUserType.Text + "','" + txtEmail.Text + "','" + txtUsername.Text + "','" + encrptedPassword + "')";
            }
            else return;
            
            con.Open();
            SqlCommand com = new SqlCommand(str, con);
            try
            {
                com.ExecuteNonQuery();
            }
            catch(SqlException EX)
            {
                if(EX.Number == 2627)
                {
                    MessageBox.Show("That Username is already taken. Sorry! Try again.");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtVerifyPassword.Text = "";
                    success_flag = false;
                }
            }

           
            con.Close();

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
            Password Strength = new Password();
            int passStrength = Strength.DeterminePasswordStrength(txtPassword.Text)+64;

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
