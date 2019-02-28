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
    public partial class HomePage : Form
    {
        /// AUTHOR: Cowen Shears
        /// DATE: 2/11/19
        /// DESCRIPTION: Homepage for application. Knows who the user is, 
        /// and has buttons set up in a tab system that link to other pages with functionality.
        /// Currently - listing all buttons/links we have made.
        /// Future - want to only display buttons/links for those pertinent to the user's type.

        CurrentUser objCurrentUser = new CurrentUser();
        public HomePage() 
        {
            InitializeComponent();
            //Set panels to correct initial visibility.
            pnlStock.Visible = true;
            pnlProducts.Visible = false;
            pnlReports.Visible = false;
            lblUsername.Text = "";
            lblUserType.Text = "";
        }
        
        public HomePage(CurrentUser LoggedInUser)
        {
            InitializeComponent();

            objCurrentUser = LoggedInUser;

            pnlStock.Visible = true;
            pnlProducts.Visible = false;
            pnlReports.Visible = false;
            lblUsername.Text = objCurrentUser.GetUsername();
            lblUserType.Text = objCurrentUser.GetUserType();
        }

        private void tabHome_Selected(object sender, TabControlEventArgs e)
        {
            //Changes the visibility of the pages. Using panels instead of included tabpages currently.
            if (tabHome.SelectedTab == tabHome.TabPages["tabStock"])//specific tabname
            {
                pnlStock.Visible = true;
                pnlProducts.Visible = false;
                pnlReports.Visible = false;
            }
            else if (tabHome.SelectedTab == tabHome.TabPages["tabProducts"])
            {
                pnlStock.Visible = false;
                pnlProducts.Visible = true;
                pnlReports.Visible = false;
            }
            else if (tabHome.SelectedTab == tabHome.TabPages["tabReports"])
            {
                pnlStock.Visible = false;
                pnlProducts.Visible = false;
                pnlReports.Visible = true;
            }
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

        private void btnStockiestHomepage_Click(object sender, EventArgs e)
        {
            if (objCurrentUser.GetUserType() == "Administrator" || objCurrentUser.GetUserType() == "Stockiest")
            {
                StockForm formStock = new StockForm();
                formStock.ShowDialog();
            }
        }

        private void btnStockMaterials_Click(object sender, EventArgs e)
        {
            AddMaterialForm formMaterial = new AddMaterialForm();
            formMaterial.ShowDialog();
        }

        private void btnStockUpdate_Click(object sender, EventArgs e)
        {
            UpdateStock formStock = new UpdateStock();
            formStock.ShowDialog();
        }

        private void btnStockGenerateReport_Click(object sender, EventArgs e)
        {
            StockReportForm formReport = new StockReportForm();
            formReport.ShowDialog();
        }
    }
}