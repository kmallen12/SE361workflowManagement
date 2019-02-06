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

namespace WorkflowManagement 
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();       
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
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

        private Boolean isValidPassword(string p)
        {
            if (p.Length < 5)
                return false;

            if (p.Contains(",") || p.Contains("'") || p.Contains('"') || p.Contains(".") || p.Contains(";"))
                return false;

            return true;
        }

        private Boolean CheckValidUser()
        {
            if (!isValidPassword(txtPassword.Text))
            {
                MessageBox.Show("Password must be at least 5 characters and can not include , \' \" . ; ");
                txtPassword.Text = "";
                txtVerifyPassword.Text = "";
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
            string connStr = "tcp:workflowdatabase.database.windows.net,1433; Initial Catalog = WorkFlowDatabase; Persist Security Info = False; User ID = OCOTOD; Password =FairBanks152; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30";
            SqlCommand com;
            SqlConnection con;
            string str;
            Boolean success_flag=true;

            if (CheckValidUser())
            {
               str = "INSERT INTO [dbo].[UsersTable] ( [FirstName], [LastName], [UserType], [Email], [UserName], [Password]) VALUES ('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + cboxUserType.Text + "','" + txtEmail.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "')";
            }
            else return;
            
            con = new SqlConnection(connStr);
            con.Open();
            com = new SqlCommand(str, con);
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
    }
}
