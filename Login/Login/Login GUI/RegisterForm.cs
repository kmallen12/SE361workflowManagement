using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace WorkFlowManagement 
{
    public partial class RegisterForm : Form
    {
        //Update: 3/26/2019 - Cowen Shears - I fixed some bugs for the MessageBox in CheckValidUser().

        DatabaseManager objDatabaseManager = new DatabaseManager();
        CheckEntry objCheckEntry = new CheckEntry();
        Password objPassword = new Password();
        private List<string> userTypes;
        string output;
        private ToolTip ttPasswordHelp = new ToolTip();

        public RegisterForm()
        {
            InitializeComponent();      
            this.AcceptButton = btnRegister;

            //load User Types from database into the user type dropdown list
            //This function creates a list of user types and then adds 
            //each item in the list as an Item in the dropdown list tool.
            userTypes = new List<string>();
            userTypes = objDatabaseManager.LoadUserTypes();
            foreach (var type in userTypes)
            {
                cboxUserType.Items.Add(type);
            }
            ttPasswordHelp.SetToolTip(lblPasswordHelp, "Passwords must be at least 8 Characters\nAnd meet 3 of the four conditions:\n- Contain one UpperCase Letter\n- Conatin one LowerCase Letter\n- Contain one Number\n- Contain one Symbol(./, !#$& etc..)");
        }

        private Boolean CheckValidUser()
        {
            bool addUser = true;
            bool showMessage = true;
            //This series of if statements checks to see if required textboxes are null.
            //If null, the corresponding label is added to the output string.
            if (objCheckEntry.isNull(txtFirstName.Text, lblFirstName.Text))
            {
                output += "\n " + lblFirstName.Text;
                addUser = false;
            }

            if (objCheckEntry.isNull(txtLastName.Text, lblLastName.Text))
            {
                output += "\n " + lblLastName.Text;
                addUser = false;
            }

            if (objCheckEntry.isNull(cboxUserType.Text, lblUserType.Text))
            {
                output += "\n User Type";
                addUser = false;
            }

            if (objCheckEntry.isNull(txtEmail.Text, lblEmail.Text))
            {
                output += "\n " + lblEmail.Text;
                addUser = false;
            }
            else
            {
                if (!objCheckEntry.isValidEmail(txtEmail.Text))
                {
                    txtEmail.Text = "";
                    output += "\n " + lblEmail.Text;
                    addUser = false;
                    showMessage = false;
                }
            }

            if (objCheckEntry.isNull(txtUsername.Text, lblUsername.Text))
            {
                output += "\n " + lblUsername.Text;
                addUser = false;
            }

            if (objCheckEntry.isNull(txtPassword.Text, lblPassword.Text))
            {
                output += "\n " + lblPassword.Text;
                addUser = false;
            }
            else
            {
                if (objPassword.DeterminePasswordStrength(txtPassword.Text) < 0)
                {
                    MessageBox.Show("Password is not Strong enough!");
                    txtPassword.Text = "";
                    txtVerifyPassword.Text = "";
                    addUser = false;
                    showMessage = false;
                }
            }

            if (objCheckEntry.isNull(txtVerifyPassword.Text, lblVerifyPw.Text))
            {
                output += "\n " + lblVerifyPw.Text;
                addUser = false;
            }
            else
            {
                if (txtPassword.Text != txtVerifyPassword.Text)
                {
                    MessageBox.Show("Password and Verify Password must match!");
                    txtPassword.Text = "";
                    txtVerifyPassword.Text = "";
                    addUser = false;
                    showMessage = false;
                }
            }
            
            if (showMessage == true && addUser == false) MessageBox.Show("The following fields must contain a value: " + output);
            output = "";

            return addUser;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Boolean success_flag=true;

            if (CheckValidUser())
            {
                try
                {
                    string encryptedPassword = objPassword.encryptPassword(txtPassword.Text);
                    objDatabaseManager.InsertUser(txtFirstName.Text, txtLastName.Text, cboxUserType.Text, 
                        txtEmail.Text, txtUsername.Text, encryptedPassword);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm formLogin = new LoginForm();
            formLogin.ShowDialog();
        }

        private void lblPasswordHelp_Click(object sender, EventArgs e)
        {
            ttPasswordHelp.SetToolTip(lblPasswordHelp, "Passwords must be at least 8 Characters\nAnd meet 3 of the four conditions:\n- Contain one UpperCase Letter\n- Conatin one LowerCase Letter\n- Contain one Number\n- Contain one Symbol(./, !#$& etc..)");
            ttPasswordHelp.ShowAlways = true;
        }
    }
}
