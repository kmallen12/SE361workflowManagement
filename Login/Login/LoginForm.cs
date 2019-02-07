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
            this.AcceptButton = btnLogin;
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
            string UserType="";
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "tcp:workflowdatabase.database.windows.net,1433"; 
            builder.UserID = "OCOTOD";            
            builder.Password = "FairBanks152";     
            builder.InitialCatalog = "WorkFlowDatabase";
           SqlConnection con = new SqlConnection(builder.ConnectionString);

            string str="SELECT UserType "+ "FROM  [dbo].[UsersTable]"+
                        "WHERE UserName = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "'";
            Boolean success_flag = false;
            con.Open();
            SqlCommand com = new SqlCommand(str, con);

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                
                UserType=reader[0].ToString();
                if(UserType != "" )
                    success_flag = true;
            }
            
            if(!success_flag)
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                success_flag = false;
                MessageBox.Show("Incorrect Username or Password! \n Please try again.");
            }

            if (success_flag)
            {
                MessageBox.Show("You are logged in " + txtUsername.Text);
                if(UserType == "Administrator" || UserType == "Stockiest" ){

                StockForm formStock = new StockForm();
                Hide();
                formStock.ShowDialog();
                 }  
            }
        }
    }
}
