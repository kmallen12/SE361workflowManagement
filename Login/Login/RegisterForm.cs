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

namespace Login
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();       
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=C:\USERS\VAGRANT\SOURCE\REPOS\WORKFLOWMANAGEMENT\LOGIN\LOGIN\USERS.MDF;Integrated Security = True;";
            SqlCommand com;
            SqlConnection con;
            string str = "INSERT INTO [dbo].[UsersTable] ( [FirstName], [LastName], [UserType], [Email], [UserName], [Password]) VALUES ('Testy', 'Westy', 'Administrator', 'test@troywiegand.com', 'testfromtest', 'password2')";
            con = new SqlConnection(connStr);
            con.Open();
            com = new SqlCommand(str, con);
            com.ExecuteNonQuery();
            MessageBox.Show("VICTORY");
            con.Close();
            MessageBox.Show("LAMER VICTORY!");
        }
    }
}
