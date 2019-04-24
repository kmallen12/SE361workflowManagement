﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace WorkFlowManagement
{
    public partial class HomePage : Form
    {
        /// DATE: 2/25/19
        /// DESCRIPTION: Homepage for application. Knows who the user is.
        /// LAST UPDATE BY: Cowen Shears 3/26/19

        CurrentUser objCurrentUser;
        public ToolTip ttUserFeedback = new ToolTip();
        public HomePage() 
        {
            InitializeComponent();
            lblUsername.Text = string.Empty;
            lblUserType.Text = string.Empty;
            
        }

        //fixes flickering
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public HomePage(CurrentUser LoggedInUser)
        {
            InitializeComponent();
            
            
            lblUsername.BackColor = Color.FromArgb(25, 20, 100);
            lblUserType.BackColor = Color.FromArgb(25, 20, 100);
            //lblUserType.BackColor = Color.FromArgb(20, 15, 75);
            objCurrentUser = LoggedInUser;
            lblUsername.Text = objCurrentUser.Username;
            lblUserType.Text = objCurrentUser.UserType;
            this.IsMdiContainer = true;
            TabHolder newTabHolder = new TabHolder(LoggedInUser, this);
            
            newTabHolder.Show();
        }

        private void lblUserType_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            objCurrentUser.Username = "";
            objCurrentUser.UserType = "";
            Hide();
            LoginForm formLogin = new LoginForm();
            formLogin.ShowDialog();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
    }
}