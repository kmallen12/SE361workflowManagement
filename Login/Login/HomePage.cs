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
            objCurrentUser = LoggedInUser;
            lblUsername.Text = objCurrentUser.Username;
            lblUserType.Text = objCurrentUser.UserType;
            SetAccessibility();
        }

        private void SetAccessibility()
        {
            //Grays out inaccessable buttons and displays tooltips for user based on UserType.
            if (objCurrentUser.UserType == "Administrator") return; //administrator has access to all 

            if (objCurrentUser.UserType != "Stockiest")
            {
                ttUserFeedback.SetToolTip(btnStockGenerateReport, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                ttUserFeedback.SetToolTip(btnStockMaterials, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                ttUserFeedback.SetToolTip(btnStockUpdate, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");

                btnStockGenerateReport.ForeColor = Color.DarkGray;
                btnStockMaterials.ForeColor = Color.DarkGray;
                btnStockUpdate.ForeColor = Color.DarkGray;

            }

            if (objCurrentUser.UserType != "Product Manager")
            {
                ttUserFeedback.SetToolTip(btnProductsView, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                ttUserFeedback.SetToolTip(btn_AddProduct, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                ttUserFeedback.SetToolTip(btnProductQuality, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                ttUserFeedback.SetToolTip(btnProductUpdateStatus, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                ttUserFeedback.SetToolTip(btnReorderStock, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");

                btnProductsView.ForeColor = Color.DarkGray;
                btn_AddProduct.ForeColor = Color.DarkGray;
                btnProductQuality.ForeColor = Color.DarkGray;
                btnProductUpdateStatus.ForeColor = Color.DarkGray;
                btnReorderStock.ForeColor = Color.DarkGray;
                btnReManufacture.ForeColor = Color.DarkGray;
            }

            if (objCurrentUser.UserType != "Quality Analyzer")
            {
                //fill with buttons for QA user
            }

            if (objCurrentUser.UserType != "Delivery Manager")
            {
                //fill with buttons for DM user
                btnDelProductStatusReport.ForeColor = Color.DarkGray;
                btnDelRouteProduct.ForeColor = Color.DarkGray;
                btnDelViewProduct.ForeColor = Color.DarkGray;
                btnDelViewQualProducts.ForeColor = Color.DarkGray; 
            }

            if (objCurrentUser.UserType != "Report Manager")
            {
                //Stock Tab Feedback
                if (objCurrentUser.UserType != "Stockiest")
                {
                    ttUserFeedback.SetToolTip(btnStockMaterials, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                    ttUserFeedback.SetToolTip(btnStockUpdate, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");

                    btnStockMaterials.ForeColor = Color.DarkGray;
                    btnStockUpdate.ForeColor = Color.DarkGray;
                }
               

                //Product Tab Feedback
                ttUserFeedback.SetToolTip(btnProductQuality, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");

                btnProductQuality.ForeColor = Color.DarkGray;

                //Gray out Report tabs
                btnRepStockWarehouseCapacity.ForeColor = Color.DarkGray;
                btnRepStockRawMaterials.ForeColor = Color.DarkGray;
                btnRepProductsInProgress.ForeColor = Color.DarkGray;
                btnRepQualifiedProducts.ForeColor = Color.DarkGray;
                btnRepDefectedProducts.ForeColor = Color.DarkGray;
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
                MessageBox.Show("You do not have access for the Stock Materials Form.\nContact your local Stockiest.");
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
                MessageBox.Show("You do not have access for the Stock View/Update Form.\nContact your local Stockiest.");
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
                MessageBox.Show("You do not have access for the Stock Report Form.\nContact your local Stockiest.");
            }
        }

        private void btnProductsView_Click(object sender, EventArgs e)
        {
            ViewProducts btnViewProducts = new ViewProducts();
            if (objCurrentUser.canView(btnViewProducts))
            {
                btnViewProducts.ShowDialog();
            }
            else
            {
                btnViewProducts.Dispose();
                MessageBox.Show("You do not have access for the View Products Form.\nContact your local Product Manager.");
            }
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            AddProduct AddProduct = new AddProduct();
            if (objCurrentUser.canView(AddProduct))
            {
                AddProduct.ShowDialog();
            }
            else
            {
                AddProduct.Dispose();
                MessageBox.Show("You do not have access for the Add Products Form.\nContact your local Product Manager.");
            }
        }

        private void btnDelViewProduct_Click(object sender, EventArgs e)
        {
            ViewProductsForm btnViewProducts = new ViewProductsForm();
            if (objCurrentUser.canView(btnViewProducts))
            {
                btnViewProducts.ShowDialog();
            }
            else
            {
                btnViewProducts.Dispose();
                MessageBox.Show("You do not have access for the View Products Form.\nContact your local Product Manager.");
            }
        }

        private void btnRepStockWarehouseCapacity_Click(object sender, EventArgs e)
        {
            StockReportForm formReport = new StockReportForm();
            if (objCurrentUser.canView(formReport))
            {
                formReport.ShowDialog();
            }
            else
            {
                formReport.Dispose();
                MessageBox.Show("You do not have access for the Stock Report Form.\nContact your local Report Manager.");
            }
        }

        private void btnDelRouteProduct_Click(object sender, EventArgs e)
        {
            RouteProducts formReport = new RouteProducts();
            if (objCurrentUser.canView(formReport))
            {
                formReport.ShowDialog();
            }
            else
            {
                formReport.Dispose();
                MessageBox.Show("You do not have access for the Route Products Form.\nContact your local Report Manager.");
            }
        }

        private void btnReManufacture_Click(object sender, EventArgs e)
        {
            RemanufactureForm formReport = new RemanufactureForm();
            if (objCurrentUser.canView(formReport))
            {
                formReport.ShowDialog();
            }
            else
            {
                formReport.Dispose();
                MessageBox.Show("You do not have access for the Remanufacture Products Form.\nContact your local Product Manager.");
            }
        }
    }
}