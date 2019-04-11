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
            if (objCurrentUser.UserTypeID == 1) return; //administrator has access to all 

            if (objCurrentUser.UserTypeID != 2)
            {
                ttUserFeedback.SetToolTip(btnStockGenerateReport, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                ttUserFeedback.SetToolTip(btnStockMaterials, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                ttUserFeedback.SetToolTip(btnStockUpdate, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                
                ttUserFeedback.SetToolTip(btnStockInventorySum, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                ttUserFeedback.SetToolTip(button2, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");

                button2.ForeColor = Color.DarkGray;

                btnStockInventorySum.ForeColor = Color.DarkGray;

                btnStockGenerateReport.ForeColor = Color.DarkGray;
                btnStockMaterials.ForeColor = Color.DarkGray;
                btnStockUpdate.ForeColor = Color.DarkGray;

            }

            if (objCurrentUser.UserTypeID != 3)
            {
                ttUserFeedback.SetToolTip(btnProductsView, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                ttUserFeedback.SetToolTip(btn_AddProduct, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                
                ttUserFeedback.SetToolTip(btn_ManageProductOrders, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                ttUserFeedback.SetToolTip(btn_ManageProductOrders, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                ttUserFeedback.SetToolTip(btnReManufacture, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                ttUserFeedback.SetToolTip(btn_StockOrderStatus, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
        
                    
                btnProductsView.ForeColor = Color.DarkGray;
                btn_AddProduct.ForeColor = Color.DarkGray;
                
                btnReorderStock.ForeColor = Color.DarkGray;
                btnReManufacture.ForeColor = Color.DarkGray;

                btn_ManageProductOrders.ForeColor = Color.DarkGray;
                btn_StockOrderStatus.ForeColor = Color.DarkGray;

            }

            if (objCurrentUser.UserTypeID != 4)
            {
                ttUserFeedback.SetToolTip(ProductOrder_btn, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                ttUserFeedback.SetToolTip(btn_ProductOrders, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                ttUserFeedback.SetToolTip(btnQAViewProd, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                ttUserFeedback.SetToolTip(btnQAUpdateProdStatus, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");

                
                    
                //fill with buttons for QA user
                btnQAViewProd.ForeColor = Color.DarkGray;
                btnQAUpdateProdStatus.ForeColor = Color.DarkGray;
                ProductOrder_btn.ForeColor = Color.DarkGray;
                btn_ProductOrders.ForeColor = Color.DarkGray;


            }

            if (objCurrentUser.UserTypeID != 5)
            {
                ttUserFeedback.SetToolTip(btnDelProductStatusReport, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                ttUserFeedback.SetToolTip(btnDelRouteProduct, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                ttUserFeedback.SetToolTip(btnDelViewProduct, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                ttUserFeedback.SetToolTip(btnDelViewQualProducts, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");


                //fill with buttons for DM user
                btnDelProductStatusReport.ForeColor = Color.DarkGray;
                btnDelRouteProduct.ForeColor = Color.DarkGray;
                btnDelViewProduct.ForeColor = Color.DarkGray;
                btnDelViewQualProducts.ForeColor = Color.DarkGray; 
            }

            if (objCurrentUser.UserTypeID != 6)
            {
                //Stock Tab Feedback
                if (objCurrentUser.UserTypeID != 2)
                {
                    ttUserFeedback.SetToolTip(btnStockMaterials, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                    ttUserFeedback.SetToolTip(btnStockUpdate, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");

                    btnStockMaterials.ForeColor = Color.DarkGray;
                    btnStockUpdate.ForeColor = Color.DarkGray;
                }

                if (objCurrentUser.UserTypeID != 3)
                {
                    
                        
                        
                    ttUserFeedback.SetToolTip(btnRepDefectedProducts, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                    ttUserFeedback.SetToolTip(btnRepProductsInProgress, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                    ttUserFeedback.SetToolTip(btnRepQualifiedProducts, "You do not have access to this feature as a " + objCurrentUser.UserType + ".");
                    btnRepDefectedProducts.ForeColor = Color.DarkGray;
                    btnRepProductsInProgress.ForeColor = Color.DarkGray;
                    btnRepQualifiedProducts.ForeColor = Color.DarkGray;

                }


                //Product Tab Feedback


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

        private void btnRepDefectedProducts_Click(object sender, EventArgs e)
        {
            RemanufactureForm formReport = new RemanufactureForm();
            if (objCurrentUser.canView(formReport))
            {
                formReport.ShowDialog();
            }
            else
            {
                formReport.Dispose();
                MessageBox.Show("You do not have access for the Remanufacture Products Form.\nContact your local Reports Manager.");
            }
        }

        private void btnQAViewProd_Click(object sender, EventArgs e)
        {
            ViewProductsForm btnViewProducts = new ViewProductsForm();
            if (objCurrentUser.canView(btnViewProducts))
            {
                btnViewProducts.ShowDialog();
            }
            else
            {
                btnViewProducts.Dispose();
                MessageBox.Show("You do not have access for the View Products Form.\nContact your local Quality Analyzer.");
            }
        }

        private void btnQAUpdateProdStatus_Click(object sender, EventArgs e)
        {
            CheckQuality checkQualityForm = new CheckQuality();
            if (objCurrentUser.canView(checkQualityForm))
            {
                checkQualityForm.ShowDialog();
            }
            else
            {
                checkQualityForm.Dispose();
                MessageBox.Show("You do not have access for the View Products Form.\nContact your local Quality Analyzer.");
            }
        }

        private void ProductOrder_btn_Click(object sender, EventArgs e)
        {
           
            CreateProductOrder ProductOrders = new CreateProductOrder();
            if(objCurrentUser.canView(ProductOrders))
                ProductOrders.ShowDialog();
            else
            {
                ProductOrders.Dispose();
                MessageBox.Show("You do not have access for the ProductOrderForm.\nContact your local Product Manager.");
            }
        }

        private void btn_ManageProductOrders_Click(object sender, EventArgs e)
        {
            ManageProductOrders ProductOrders = new ManageProductOrders();
            if(objCurrentUser.canView(ProductOrders))
                ProductOrders.ShowDialog();
            else
            {
                ProductOrders.Dispose();
                MessageBox.Show("You do not have access for the ManageProductOrders.\nContact your local Product Manager.");
            }
        }

        private void btnRepStockRawMaterials_Click(object sender, EventArgs e)
        {
            StockSummaryForm formStock = new StockSummaryForm();
            if (objCurrentUser.canView(formStock))
            {
                formStock.ShowDialog();
            }
            else
            {
                formStock.Dispose();
                MessageBox.Show("You do not have access for the Stock View Form.\nContact your local Stockiest or Report Manager.");
            }
        }

        private void btnRepQualifiedProducts_Click(object sender, EventArgs e)
        {
            ViewQualifiedProducts vqpForm = new ViewQualifiedProducts();

            StockSummaryForm formStock = new StockSummaryForm();
            if (objCurrentUser.canView(vqpForm))
            {
                vqpForm.ShowDialog();
            }
            else
            {
                vqpForm.Dispose();
                MessageBox.Show("You do not have access for the Qualified Products Form.\nContact your local Product or Report Manager.");
            }
        }

        

        private void btnDelProductStatusReport_Click(object sender, EventArgs e)
        {
            ProductStatusReportForm psrForm =new ProductStatusReportForm();
            if (objCurrentUser.canView(psrForm))
            {
                psrForm.ShowDialog();
            }
            else
            {
                psrForm.Dispose();
                MessageBox.Show("You do not have access for the Product Status Form.\nContact your local Delivery Manager.");
            }
        }

        private void btnDelViewQualProducts_Click(object sender, EventArgs e)
        {
            ViewQualifiedProducts vqpForm = new ViewQualifiedProducts();
            if (objCurrentUser.canView(vqpForm))
            {
                vqpForm.ShowDialog();
            }
            else
            {
                vqpForm.Dispose();
                MessageBox.Show("You do not have access for the View Product Quality Form.\nContact your local Delivery Manager.");
            }
        }

        private void btnReorderStock_Click(object sender, EventArgs e)
        {
            CreateStockOrder StockOrder = new CreateStockOrder();
            if (objCurrentUser.canView(StockOrder))
            {
                StockOrder.ShowDialog();
            }
            else
            {
                StockOrder.Dispose();
                MessageBox.Show("You do not have access for the ReOrder Stock Form.\nContact your local Product Manager.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageStockOrders Orders = new ManageStockOrders();
            if (objCurrentUser.canView(Orders))
            {
                Orders.ShowDialog();
            }
            else
            {
                Orders.Dispose();
                MessageBox.Show("You do not have access for the Manage Stock Orders Form.\nContact your local Stockiest.");
            }
        }

        private void btnStockInventorySum_Click(object sender, EventArgs e)
        {
            StockSummaryForm SummaryForm = new StockSummaryForm();
            if (objCurrentUser.canView(SummaryForm))
            {
                SummaryForm.ShowDialog();
            }
            else
            {
                SummaryForm.Dispose();
                MessageBox.Show("You do not have access for the Stock Inventory Sum Form.\nContact your local Stockiest.");
            }
        }

        private void btn_StockOrderStatus_Click(object sender, EventArgs e)
        {
            ViewStockOrders OrderStatus = new ViewStockOrders();
            if (objCurrentUser.canView(OrderStatus))
            {
                OrderStatus.ShowDialog();
            }
            else
            {
                OrderStatus.Dispose();
                MessageBox.Show("You do not have access for the Stock Order Status Form.\nContact your local Product Manager.");
            }
        }

        private void btn_ProductOrders_Click(object sender, EventArgs e)
        {
            ViewProductOrders ViewOrder = new ViewProductOrders();
            if (objCurrentUser.canView(ViewOrder))
            {
                ViewOrder.ShowDialog();
            }
            else
            {
                ViewOrder.Dispose();
                MessageBox.Show("You do not have access for the Product Order Status Form.\nContact your local Quality Manager.");
            }
        }
    }
}