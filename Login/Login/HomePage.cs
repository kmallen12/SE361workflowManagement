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
        /// EDITED BY: Mary Hermann 2/28/19

        CurrentUser objCurrentUser;
        public HomePage() 
        {
            InitializeComponent();
            lblUsername.Text = string.Empty;
            lblUserType.Text = string.Empty;
        }
        
        public HomePage(CurrentUser LoggedInUser)
        {
            InitializeComponent();
            objCurrentUser = LoggedInUser;
            lblUsername.Text = objCurrentUser.Username;
            lblUserType.Text = objCurrentUser.UserType;
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

        private void btnStockMaterials_Click_1(object sender, EventArgs e)
        {
            AddMaterialForm formMaterial = new AddMaterialForm();
            if (objCurrentUser.canView(formMaterial))
            {
                formMaterial.ShowDialog();
            }
            else
            {
                formMaterial.Dispose();
                MessageBox.Show("You do not have access for the Stock Materials Form.");
            }
        }
        private void btnStockUpdate_Click_1(object sender, EventArgs e)
        {
            UpdateStockForm formStock = new UpdateStockForm();
            if (objCurrentUser.canView(formStock))
            {
                formStock.ShowDialog();
            }
            else
            {
                formStock.Dispose();
                MessageBox.Show("You do not have access for the Stock View/Update Form.");
            }
        }
        private void btnStockGenerateReport_Click_1(object sender, EventArgs e)
        {
            StockReportForm formReport = new StockReportForm();
            if (objCurrentUser.canView(formReport))
            {
                formReport.ShowDialog();
            }
            else
            {
                formReport.Dispose();
                MessageBox.Show("You do not have access for the Stock Report Form.");
            }
        }

        private void btnProductsView_Click(object sender, EventArgs e)
        {
            ViewProducts btnViewProducts = new ViewProducts();
            btnViewProducts.ShowDialog();
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            AddProduct AddProduct = new AddProduct();
            AddProduct.ShowDialog();
        }
    }
}