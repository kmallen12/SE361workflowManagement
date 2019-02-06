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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Closes Login window and opens Create Account window
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm formRegister = new RegisterForm();
            formRegister.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string connStr = @"Server=tcp:workflowdatabase.database.windows.net,1433;
                                   Initial Catalog = WorkFlowDatabase;
                                   Persist Security Info = False;
                                   User ID = OCOTOD;
                                   Password = FairBanks152;
                                   MultipleActiveResultSets = False;
                                   Encrypt = True;
                                   TrustServerCertificate = False;
                                   Connection Timeout = 30;";
            SqlCommand com;
            SqlConnection con;
            string str="SELECT UserName, Password "+ "FROM  [dbo].[UsersTable]"+
                        "WHERE UserName = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "'";
            Boolean success_flag = true;
            con = new SqlConnection(connStr);
            con.Open();
            MessageBox.Show("connected to db");
            com = new SqlCommand(str, con);

            SqlDataReader reader = com.ExecuteReader();

            if (reader.HasRows)
            {
                success_flag = true;
            }
            else
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                success_flag = false;
                MessageBox.Show("Incorrect Username or Password! \n Please try again.");
            }

            if (success_flag)
            {
                MessageBox.Show("You are logged in " + txtUsername.Text);
            }
        }
    }
}
