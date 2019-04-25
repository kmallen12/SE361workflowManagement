using System;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace WorkFlowManagement
{
    public partial class HomePage : Form
    {
        /// DATE: 2/25/19
        /// DESCRIPTION: Homepage for application. Knows who the user is.

        CurrentUser objCurrentUser;
        public ToolTip ttUserFeedback = new ToolTip();
        HelpMessage HelpMessage = new HelpMessage();

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
            BottomRightGraphic BottomGraphic = new BottomRightGraphic(this);
            BottomGraphic.Show();

            TabHolder newTabHolder = new TabHolder(LoggedInUser, this);
            newTabHolder.Show();
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

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (objCurrentUser.UserTypeID == 1)
            {
                HelpMessage.ShowAdministrator();
            }
            else if (objCurrentUser.UserTypeID == 2)
            {
                HelpMessage.ShowStockiest();
            }
            else if(objCurrentUser.UserTypeID == 3)
            {
                HelpMessage.ShowProductManager();
            }
            else if (objCurrentUser.UserTypeID == 4)
            {
                HelpMessage.ShowQualityAnalyzer();
            }
            else if (objCurrentUser.UserTypeID == 5)
            {
                HelpMessage.ShowDeliveryManager();
            }
            else if (objCurrentUser.UserTypeID == 6)
            {
                HelpMessage.ShowReportManager();
            }
        }
    }
}