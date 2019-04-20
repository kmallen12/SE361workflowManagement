using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkFlowManagement
{
    public partial class TabHolder : Form
    {
        CurrentUser objCurrentUser;
        public ToolTip ttUserFeedback = new ToolTip();
        HomePage Home;
        public TabHolder()
        {
            InitializeComponent();
            
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        public TabHolder(CurrentUser LoggedInUser, HomePage H)
        {
            InitializeComponent();
            objCurrentUser = LoggedInUser;
            
            Home = H;
            this.MdiParent = Home;
            //So we dont delete the tabs on the first form opened.
            Form Dummy = new Form();
            Dummy.MdiParent = Home;
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
        private void btnStockMaterials_Click_1(object sender, EventArgs e)
        {
            AddMaterialForm formMaterial = new AddMaterialForm();
            if (objCurrentUser.canView(formMaterial))
            {
                Home.MdiChildren.Last<Form>().Close();

                formMaterial.MdiParent = Home;
                formMaterial.Show();
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
                Home.MdiChildren.Last<Form>().Close();

                formStock.MdiParent = Home;
                formStock.Show();
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
                Home.MdiChildren.Last<Form>().Close();

                formReport.MdiParent = Home;
                formReport.Show();
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

                Home.MdiChildren.Last<Form>().Close();

                btnViewProducts.MdiParent = Home;
                btnViewProducts.Show();

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
                Home.MdiChildren.Last<Form>().Close();

                AddProduct.MdiParent = Home;
                AddProduct.Show();
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
                Home.MdiChildren.Last<Form>().Close();

                btnViewProducts.MdiParent = Home;
                btnViewProducts.Show();
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
                Home.MdiChildren.Last<Form>().Close();

                formReport.MdiParent = Home;
                formReport.Show();
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
                Home.MdiChildren.Last<Form>().Close();
                
                formReport.MdiParent = Home;
                formReport.Show();
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
                Home.MdiChildren.Last<Form>().Close();

                formReport.MdiParent = Home;
                formReport.Show();
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
                Home.MdiChildren.Last<Form>().Close();

                formReport.MdiParent = Home;
                formReport.Show();
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
                Home.MdiChildren.Last<Form>().Close();
                
                btnViewProducts.MdiParent=Home;
                btnViewProducts.Show();
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
                Home.MdiChildren.Last<Form>().Close();

                checkQualityForm.MdiParent = Home;
                checkQualityForm.Show();
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
            if (objCurrentUser.canView(ProductOrders))
            {
                Home.MdiChildren.Last<Form>().Close();

                ProductOrders.MdiParent = Home;
                ProductOrders.Show();
            }
            else
            {
                ProductOrders.Dispose();
                MessageBox.Show("You do not have access for the ProductOrderForm.\nContact your local Product Manager.");
            }
        }

        private void btn_ManageProductOrders_Click(object sender, EventArgs e)
        {
            ManageProductOrders ProductOrders = new ManageProductOrders();
            if (objCurrentUser.canView(ProductOrders))
            {
                Home.MdiChildren.Last<Form>().Close();

                ProductOrders.MdiParent = Home;
                ProductOrders.Show();
            }

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
                Home.MdiChildren.Last<Form>().Close();

                formStock.MdiParent = Home;
                formStock.Show();
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
                Home.MdiChildren.Last<Form>().Close();

                vqpForm.MdiParent = Home;
                vqpForm.Show();
            }
            else
            {
                vqpForm.Dispose();
                MessageBox.Show("You do not have access for the Qualified Products Form.\nContact your local Product or Report Manager.");
            }
        }



        private void btnDelProductStatusReport_Click(object sender, EventArgs e)
        {
            ProductStatusReportForm psrForm = new ProductStatusReportForm();
            if (objCurrentUser.canView(psrForm))
            {
                Home.MdiChildren.Last<Form>().Close();

                psrForm.MdiParent = Home;
                psrForm.Show();
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
                Home.MdiChildren.Last<Form>().Close();

                vqpForm.MdiParent = Home;
                vqpForm.Show();
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
                Home.MdiChildren.Last<Form>().Close();

                StockOrder.MdiParent = Home;
                StockOrder.Show();
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
                Home.MdiChildren.Last<Form>().Close();

                Orders.MdiParent = Home;
                Orders.Show();
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
                Home.MdiChildren.Last<Form>().Close();

                SummaryForm.MdiParent = Home;
                SummaryForm.Show();
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
                Home.MdiChildren.Last<Form>().Close();

                OrderStatus.MdiParent = Home;
                OrderStatus.Show();
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
                Home.MdiChildren.Last<Form>().Close();

                ViewOrder.MdiParent = Home;
                ViewOrder.Show();
            }
            else
            {
                ViewOrder.Dispose();
                MessageBox.Show("You do not have access for the Product Order Status Form.\nContact your local Quality Manager.");
            }
        }

        
    }
}

