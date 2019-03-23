using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WorkFlowManagement
{
    public partial class LoginForm : Form
    {
        DatabaseManager objDatabaseManager = new DatabaseManager();
        CurrentUser objCurrentUser;
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        // Closes Login window and opens Create Account window
        private void linkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm formRegister = new RegisterForm();
            formRegister.ShowDialog();
        }
             
        private void btnLogin_Click(object sender, EventArgs e)
        {

            string UserType = objDatabaseManager.LoginFromDb(txtUsername?.Text, txtPassword?.Text);

            if (String.IsNullOrEmpty(UserType))
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("Incorrect Username or Password! \n Please try again.");
            }

            if (!String.IsNullOrEmpty(UserType))
            {
                MessageBox.Show("You are logged in " + txtUsername.Text);
                objCurrentUser = new CurrentUser(txtUsername.Text,UserType);
                this.Hide();

                HomePage formHomePage = new HomePage(objCurrentUser);
                formHomePage.ShowDialog();
            }
        }
    }
}
