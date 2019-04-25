using System;
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
            int UserTypeID = objDatabaseManager.GetUserTypeID(UserType);
            if (String.IsNullOrEmpty(UserType))
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("Incorrect Username or Password! \n Please try again.");
            }

            if (!String.IsNullOrEmpty(UserType))
            {
                objCurrentUser = new CurrentUser(txtUsername.Text,UserType,UserTypeID);
                this.Hide();

                HomePage formHomePage = new HomePage(objCurrentUser);
                formHomePage.ShowDialog();
            }
        }
    }
}
