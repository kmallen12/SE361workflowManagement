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

namespace WorkFlowManagement
{
    public partial class HomePage : Form
    {
        /// AUTHOR: Cowen Shears
        /// DATE: 2/25/19
        /// DESCRIPTION: Homepage for application. Knows who the user is.
        /// EDITED BY: Mary Hermann 2/27/19

        CurrentUser objCurrentUser;
        public HomePage() 
        {
            InitializeComponent();
            //Set panels to correct initial visibility.
            pnlStock.Visible = true;
            pnlProducts.Visible = false;
            lblUsername.Text = string.Empty;
            lblUserType.Text = string.Empty;
        }
        
        public HomePage(CurrentUser LoggedInUser)
        {
            InitializeComponent();

            objCurrentUser = LoggedInUser;

            pnlStock.Visible = true;
            pnlProducts.Visible = false;
            lblUsername.Text = objCurrentUser.Username;
            lblUserType.Text = objCurrentUser.UserType;
        }

        private void tabHome_Selected(object sender, TabControlEventArgs e)
        {
            //Changes the visibility of the pages. Using panels instead of included tabpages currently.
            if (tabHome.SelectedTab == tabHome.TabPages["tabStock"])
            {
                pnlStock.Visible = true;
                pnlProducts.Visible = false;
            }
            if (tabHome.SelectedTab == tabHome.TabPages["tabProducts"])
            {
                pnlStock.Visible = false;
                pnlProducts.Visible = true;
            }
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            objCurrentUser.Username = string.Empty;
            objCurrentUser.UserType = string.Empty;
            Hide();
            LoginForm formLogin = new LoginForm();
            formLogin.ShowDialog();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);    
            Application.Exit();
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