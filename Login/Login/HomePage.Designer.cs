namespace WorkFlowManagement
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblUserType = new System.Windows.Forms.Label();
            this.workFlowDatabaseDataSet1 = new Login.WorkFlowDatabaseDataSet();
            this.tabBar = new System.Windows.Forms.TabControl();
            this.tabStock = new System.Windows.Forms.TabPage();
            this.lblStockHmpg = new System.Windows.Forms.Label();
            this.btnStockUpdate = new System.Windows.Forms.Button();
            this.btnStockGenerateReport = new System.Windows.Forms.Button();
            this.btnStockMaterials = new System.Windows.Forms.Button();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.btnReManufacture = new System.Windows.Forms.Button();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.btnReorderStock = new System.Windows.Forms.Button();
            this.lblProductHomepg = new System.Windows.Forms.Label();
            this.btnProductUpdateStatus = new System.Windows.Forms.Button();
            this.btnProductQuality = new System.Windows.Forms.Button();
            this.btnProductsView = new System.Windows.Forms.Button();
            this.tabQuality = new System.Windows.Forms.TabPage();
            this.ProductOrder_btn = new System.Windows.Forms.Button();
            this.btnQAUpdateProdStatus = new System.Windows.Forms.Button();
            this.btnQAViewProd = new System.Windows.Forms.Button();
            this.lblQAdashboard = new System.Windows.Forms.Label();
            this.tabDelivery = new System.Windows.Forms.TabPage();
            this.btnDelProductStatusReport = new System.Windows.Forms.Button();
            this.btnDelViewQualProducts = new System.Windows.Forms.Button();
            this.btnDelRouteProduct = new System.Windows.Forms.Button();
            this.btnDelViewProduct = new System.Windows.Forms.Button();
            this.lblDdashboard = new System.Windows.Forms.Label();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRepDefectedProducts = new System.Windows.Forms.Button();
            this.btnRepQualifiedProducts = new System.Windows.Forms.Button();
            this.btnRepProductsInProgress = new System.Windows.Forms.Button();
            this.btnRepStockRawMaterials = new System.Windows.Forms.Button();
            this.btnRepStockWarehouseCapacity = new System.Windows.Forms.Button();
            this.btn_ManageProductOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet1)).BeginInit();
            this.tabBar.SuspendLayout();
            this.tabStock.SuspendLayout();
            this.tabProducts.SuspendLayout();
            this.tabQuality.SuspendLayout();
            this.tabDelivery.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(910, 55);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUsername.Size = new System.Drawing.Size(280, 20);
            this.lblUsername.TabIndex = 13;
            this.lblUsername.Text = "User";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogOut.Location = new System.Drawing.Point(1079, 15);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(112, 35);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblUserType
            // 
            this.lblUserType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserType.BackColor = System.Drawing.Color.Transparent;
            this.lblUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.ForeColor = System.Drawing.Color.White;
            this.lblUserType.Location = new System.Drawing.Point(915, 75);
            this.lblUserType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserType.Size = new System.Drawing.Size(276, 20);
            this.lblUserType.TabIndex = 14;
            this.lblUserType.Text = "UserType";
            this.lblUserType.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // workFlowDatabaseDataSet1
            // 
            this.workFlowDatabaseDataSet1.DataSetName = "WorkFlowDatabaseDataSet";
            this.workFlowDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabBar
            // 
            this.tabBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabBar.Controls.Add(this.tabStock);
            this.tabBar.Controls.Add(this.tabProducts);
            this.tabBar.Controls.Add(this.tabQuality);
            this.tabBar.Controls.Add(this.tabDelivery);
            this.tabBar.Controls.Add(this.tabReports);
            this.tabBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBar.Location = new System.Drawing.Point(1, 100);
            this.tabBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabBar.Name = "tabBar";
            this.tabBar.SelectedIndex = 0;
            this.tabBar.Size = new System.Drawing.Size(1207, 591);
            this.tabBar.TabIndex = 15;
            // 
            // tabStock
            // 
            this.tabStock.Controls.Add(this.lblStockHmpg);
            this.tabStock.Controls.Add(this.btnStockUpdate);
            this.tabStock.Controls.Add(this.btnStockGenerateReport);
            this.tabStock.Controls.Add(this.btnStockMaterials);
            this.tabStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStock.Location = new System.Drawing.Point(4, 38);
            this.tabStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabStock.Name = "tabStock";
            this.tabStock.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabStock.Size = new System.Drawing.Size(1199, 549);
            this.tabStock.TabIndex = 0;
            this.tabStock.Text = "Stock";
            this.tabStock.UseVisualStyleBackColor = true;
            // 
            // lblStockHmpg
            // 
            this.lblStockHmpg.AutoSize = true;
            this.lblStockHmpg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockHmpg.Location = new System.Drawing.Point(14, 20);
            this.lblStockHmpg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockHmpg.Name = "lblStockHmpg";
            this.lblStockHmpg.Size = new System.Drawing.Size(368, 40);
            this.lblStockHmpg.TabIndex = 8;
            this.lblStockHmpg.Text = "Stockiest Dashboard";
            // 
            // btnStockUpdate
            // 
            this.btnStockUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockUpdate.Location = new System.Drawing.Point(21, 195);
            this.btnStockUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStockUpdate.Name = "btnStockUpdate";
            this.btnStockUpdate.Size = new System.Drawing.Size(260, 80);
            this.btnStockUpdate.TabIndex = 7;
            this.btnStockUpdate.Text = "View/Update Stock";
            this.btnStockUpdate.UseVisualStyleBackColor = true;
            this.btnStockUpdate.Click += new System.EventHandler(this.btnStockUpdate_Click_1);
            // 
            // btnStockGenerateReport
            // 
            this.btnStockGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockGenerateReport.Location = new System.Drawing.Point(21, 302);
            this.btnStockGenerateReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStockGenerateReport.Name = "btnStockGenerateReport";
            this.btnStockGenerateReport.Size = new System.Drawing.Size(260, 92);
            this.btnStockGenerateReport.TabIndex = 6;
            this.btnStockGenerateReport.Text = "Generate Report";
            this.btnStockGenerateReport.UseVisualStyleBackColor = true;
            this.btnStockGenerateReport.Click += new System.EventHandler(this.btnStockGenerateReport_Click_1);
            // 
            // btnStockMaterials
            // 
            this.btnStockMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockMaterials.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStockMaterials.Location = new System.Drawing.Point(21, 82);
            this.btnStockMaterials.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStockMaterials.Name = "btnStockMaterials";
            this.btnStockMaterials.Size = new System.Drawing.Size(260, 86);
            this.btnStockMaterials.TabIndex = 5;
            this.btnStockMaterials.Text = "Add Raw Materials";
            this.btnStockMaterials.UseVisualStyleBackColor = true;
            this.btnStockMaterials.Click += new System.EventHandler(this.btnStockMaterials_Click_1);
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.btn_ManageProductOrders);
            this.tabProducts.Controls.Add(this.btnReManufacture);
            this.tabProducts.Controls.Add(this.btn_AddProduct);
            this.tabProducts.Controls.Add(this.btnReorderStock);
            this.tabProducts.Controls.Add(this.lblProductHomepg);
            this.tabProducts.Controls.Add(this.btnProductUpdateStatus);
            this.tabProducts.Controls.Add(this.btnProductQuality);
            this.tabProducts.Controls.Add(this.btnProductsView);
            this.tabProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProducts.Location = new System.Drawing.Point(4, 38);
            this.tabProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabProducts.Size = new System.Drawing.Size(1199, 549);
            this.tabProducts.TabIndex = 1;
            this.tabProducts.Text = "Products";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // btnReManufacture
            // 
            this.btnReManufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReManufacture.Location = new System.Drawing.Point(772, 85);
            this.btnReManufacture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReManufacture.Name = "btnReManufacture";
            this.btnReManufacture.Size = new System.Drawing.Size(261, 89);
            this.btnReManufacture.TabIndex = 13;
            this.btnReManufacture.Text = "Defective Products to Re-Manufacture";
            this.btnReManufacture.UseVisualStyleBackColor = true;
            this.btnReManufacture.Click += new System.EventHandler(this.btnReManufacture_Click);
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddProduct.Location = new System.Drawing.Point(315, 85);
            this.btn_AddProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(261, 89);
            this.btn_AddProduct.TabIndex = 12;
            this.btn_AddProduct.Text = "Add Product";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btnReorderStock
            // 
            this.btnReorderStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReorderStock.Location = new System.Drawing.Point(21, 420);
            this.btnReorderStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReorderStock.Name = "btnReorderStock";
            this.btnReorderStock.Size = new System.Drawing.Size(260, 86);
            this.btnReorderStock.TabIndex = 11;
            this.btnReorderStock.Text = "Reorder Stock";
            this.btnReorderStock.UseVisualStyleBackColor = true;
            // 
            // lblProductHomepg
            // 
            this.lblProductHomepg.AutoSize = true;
            this.lblProductHomepg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductHomepg.Location = new System.Drawing.Point(14, 19);
            this.lblProductHomepg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductHomepg.Name = "lblProductHomepg";
            this.lblProductHomepg.Size = new System.Drawing.Size(504, 40);
            this.lblProductHomepg.TabIndex = 10;
            this.lblProductHomepg.Text = "Product Manager Dashboard";
            // 
            // btnProductUpdateStatus
            // 
            this.btnProductUpdateStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductUpdateStatus.Location = new System.Drawing.Point(21, 308);
            this.btnProductUpdateStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProductUpdateStatus.Name = "btnProductUpdateStatus";
            this.btnProductUpdateStatus.Size = new System.Drawing.Size(261, 92);
            this.btnProductUpdateStatus.TabIndex = 9;
            this.btnProductUpdateStatus.Text = "Update Product Status";
            this.btnProductUpdateStatus.UseVisualStyleBackColor = true;
            // 
            // btnProductQuality
            // 
            this.btnProductQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductQuality.Location = new System.Drawing.Point(21, 200);
            this.btnProductQuality.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProductQuality.Name = "btnProductQuality";
            this.btnProductQuality.Size = new System.Drawing.Size(261, 80);
            this.btnProductQuality.TabIndex = 8;
            this.btnProductQuality.Text = "Check Product Quality";
            this.btnProductQuality.UseVisualStyleBackColor = true;
            // 
            // btnProductsView
            // 
            this.btnProductsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductsView.Location = new System.Drawing.Point(21, 85);
            this.btnProductsView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProductsView.Name = "btnProductsView";
            this.btnProductsView.Size = new System.Drawing.Size(261, 89);
            this.btnProductsView.TabIndex = 7;
            this.btnProductsView.Text = "View Products";
            this.btnProductsView.UseVisualStyleBackColor = true;
            this.btnProductsView.Click += new System.EventHandler(this.btnProductsView_Click);
            // 
            // tabQuality
            // 
            this.tabQuality.Controls.Add(this.ProductOrder_btn);
            this.tabQuality.Controls.Add(this.btnQAUpdateProdStatus);
            this.tabQuality.Controls.Add(this.btnQAViewProd);
            this.tabQuality.Controls.Add(this.lblQAdashboard);
            this.tabQuality.Location = new System.Drawing.Point(4, 38);
            this.tabQuality.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabQuality.Name = "tabQuality";
            this.tabQuality.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabQuality.Size = new System.Drawing.Size(1199, 549);
            this.tabQuality.TabIndex = 2;
            this.tabQuality.Text = "Quality";
            this.tabQuality.UseVisualStyleBackColor = true;
            // 
            // ProductOrder_btn
            // 
            this.ProductOrder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductOrder_btn.Location = new System.Drawing.Point(33, 336);
            this.ProductOrder_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductOrder_btn.Name = "ProductOrder_btn";
            this.ProductOrder_btn.Size = new System.Drawing.Size(261, 89);
            this.ProductOrder_btn.TabIndex = 14;
            this.ProductOrder_btn.Text = "Create ProductOrder";
            this.ProductOrder_btn.UseVisualStyleBackColor = true;
            this.ProductOrder_btn.Click += new System.EventHandler(this.ProductOrder_btn_Click);
            // 
            // btnQAUpdateProdStatus
            // 
            this.btnQAUpdateProdStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQAUpdateProdStatus.Location = new System.Drawing.Point(33, 209);
            this.btnQAUpdateProdStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQAUpdateProdStatus.Name = "btnQAUpdateProdStatus";
            this.btnQAUpdateProdStatus.Size = new System.Drawing.Size(261, 89);
            this.btnQAUpdateProdStatus.TabIndex = 13;
            this.btnQAUpdateProdStatus.Text = "Update Product Status";
            this.btnQAUpdateProdStatus.UseVisualStyleBackColor = true;
            this.btnQAUpdateProdStatus.Click += new System.EventHandler(this.btnQAUpdateProdStatus_Click);
            // 
            // btnQAViewProd
            // 
            this.btnQAViewProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQAViewProd.Location = new System.Drawing.Point(33, 88);
            this.btnQAViewProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQAViewProd.Name = "btnQAViewProd";
            this.btnQAViewProd.Size = new System.Drawing.Size(261, 89);
            this.btnQAViewProd.TabIndex = 12;
            this.btnQAViewProd.Text = "View Products";
            this.btnQAViewProd.UseVisualStyleBackColor = true;
            this.btnQAViewProd.Click += new System.EventHandler(this.btnQAViewProd_Click);
            // 
            // lblQAdashboard
            // 
            this.lblQAdashboard.AutoSize = true;
            this.lblQAdashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQAdashboard.Location = new System.Drawing.Point(10, 20);
            this.lblQAdashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQAdashboard.Name = "lblQAdashboard";
            this.lblQAdashboard.Size = new System.Drawing.Size(549, 40);
            this.lblQAdashboard.TabIndex = 9;
            this.lblQAdashboard.Text = "Quality Assessment Dashboard";
            // 
            // tabDelivery
            // 
            this.tabDelivery.Controls.Add(this.btnDelProductStatusReport);
            this.tabDelivery.Controls.Add(this.btnDelViewQualProducts);
            this.tabDelivery.Controls.Add(this.btnDelRouteProduct);
            this.tabDelivery.Controls.Add(this.btnDelViewProduct);
            this.tabDelivery.Controls.Add(this.lblDdashboard);
            this.tabDelivery.Location = new System.Drawing.Point(4, 38);
            this.tabDelivery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabDelivery.Name = "tabDelivery";
            this.tabDelivery.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabDelivery.Size = new System.Drawing.Size(1199, 549);
            this.tabDelivery.TabIndex = 3;
            this.tabDelivery.Text = "Delivery";
            this.tabDelivery.UseVisualStyleBackColor = true;
            // 
            // btnDelProductStatusReport
            // 
            this.btnDelProductStatusReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelProductStatusReport.Location = new System.Drawing.Point(33, 446);
            this.btnDelProductStatusReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelProductStatusReport.Name = "btnDelProductStatusReport";
            this.btnDelProductStatusReport.Size = new System.Drawing.Size(261, 89);
            this.btnDelProductStatusReport.TabIndex = 13;
            this.btnDelProductStatusReport.Text = "Product Status Report";
            this.btnDelProductStatusReport.UseVisualStyleBackColor = true;
            // 
            // btnDelViewQualProducts
            // 
            this.btnDelViewQualProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelViewQualProducts.Location = new System.Drawing.Point(33, 331);
            this.btnDelViewQualProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelViewQualProducts.Name = "btnDelViewQualProducts";
            this.btnDelViewQualProducts.Size = new System.Drawing.Size(261, 89);
            this.btnDelViewQualProducts.TabIndex = 12;
            this.btnDelViewQualProducts.Text = "View Qualified Products";
            this.btnDelViewQualProducts.UseVisualStyleBackColor = true;
            // 
            // btnDelRouteProduct
            // 
            this.btnDelRouteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelRouteProduct.Location = new System.Drawing.Point(33, 214);
            this.btnDelRouteProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelRouteProduct.Name = "btnDelRouteProduct";
            this.btnDelRouteProduct.Size = new System.Drawing.Size(261, 89);
            this.btnDelRouteProduct.TabIndex = 11;
            this.btnDelRouteProduct.Text = "Route Products";
            this.btnDelRouteProduct.UseVisualStyleBackColor = true;
            this.btnDelRouteProduct.Click += new System.EventHandler(this.btnDelRouteProduct_Click);
            // 
            // btnDelViewProduct
            // 
            this.btnDelViewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelViewProduct.Location = new System.Drawing.Point(33, 92);
            this.btnDelViewProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelViewProduct.Name = "btnDelViewProduct";
            this.btnDelViewProduct.Size = new System.Drawing.Size(261, 89);
            this.btnDelViewProduct.TabIndex = 10;
            this.btnDelViewProduct.Text = "View Products";
            this.btnDelViewProduct.UseVisualStyleBackColor = true;
            this.btnDelViewProduct.Click += new System.EventHandler(this.btnDelViewProduct_Click);
            // 
            // lblDdashboard
            // 
            this.lblDdashboard.AutoSize = true;
            this.lblDdashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDdashboard.Location = new System.Drawing.Point(10, 26);
            this.lblDdashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDdashboard.Name = "lblDdashboard";
            this.lblDdashboard.Size = new System.Drawing.Size(560, 40);
            this.lblDdashboard.TabIndex = 9;
            this.lblDdashboard.Text = "Delivery Department Dashboard";
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.label1);
            this.tabReports.Controls.Add(this.btnRepDefectedProducts);
            this.tabReports.Controls.Add(this.btnRepQualifiedProducts);
            this.tabReports.Controls.Add(this.btnRepProductsInProgress);
            this.tabReports.Controls.Add(this.btnRepStockRawMaterials);
            this.tabReports.Controls.Add(this.btnRepStockWarehouseCapacity);
            this.tabReports.Location = new System.Drawing.Point(4, 38);
            this.tabReports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabReports.Name = "tabReports";
            this.tabReports.Size = new System.Drawing.Size(1199, 549);
            this.tabReports.TabIndex = 4;
            this.tabReports.Text = "Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reports Department Dashboard";
            // 
            // btnRepDefectedProducts
            // 
            this.btnRepDefectedProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepDefectedProducts.Location = new System.Drawing.Point(352, 356);
            this.btnRepDefectedProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRepDefectedProducts.Name = "btnRepDefectedProducts";
            this.btnRepDefectedProducts.Size = new System.Drawing.Size(260, 92);
            this.btnRepDefectedProducts.TabIndex = 11;
            this.btnRepDefectedProducts.Text = "Defected Products";
            this.btnRepDefectedProducts.UseVisualStyleBackColor = true;
            this.btnRepDefectedProducts.Click += new System.EventHandler(this.btnRepDefectedProducts_Click);
            // 
            // btnRepQualifiedProducts
            // 
            this.btnRepQualifiedProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepQualifiedProducts.Location = new System.Drawing.Point(352, 236);
            this.btnRepQualifiedProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRepQualifiedProducts.Name = "btnRepQualifiedProducts";
            this.btnRepQualifiedProducts.Size = new System.Drawing.Size(260, 92);
            this.btnRepQualifiedProducts.TabIndex = 10;
            this.btnRepQualifiedProducts.Text = "Qualified Products";
            this.btnRepQualifiedProducts.UseVisualStyleBackColor = true;
            // 
            // btnRepProductsInProgress
            // 
            this.btnRepProductsInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepProductsInProgress.Location = new System.Drawing.Point(352, 120);
            this.btnRepProductsInProgress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRepProductsInProgress.Name = "btnRepProductsInProgress";
            this.btnRepProductsInProgress.Size = new System.Drawing.Size(260, 92);
            this.btnRepProductsInProgress.TabIndex = 9;
            this.btnRepProductsInProgress.Text = "Products In Progress";
            this.btnRepProductsInProgress.UseVisualStyleBackColor = true;
            // 
            // btnRepStockRawMaterials
            // 
            this.btnRepStockRawMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepStockRawMaterials.Location = new System.Drawing.Point(30, 236);
            this.btnRepStockRawMaterials.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRepStockRawMaterials.Name = "btnRepStockRawMaterials";
            this.btnRepStockRawMaterials.Size = new System.Drawing.Size(260, 92);
            this.btnRepStockRawMaterials.TabIndex = 8;
            this.btnRepStockRawMaterials.Text = "Stock Raw Materials Inventory";
            this.btnRepStockRawMaterials.UseVisualStyleBackColor = true;
            // 
            // btnRepStockWarehouseCapacity
            // 
            this.btnRepStockWarehouseCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepStockWarehouseCapacity.Location = new System.Drawing.Point(30, 120);
            this.btnRepStockWarehouseCapacity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRepStockWarehouseCapacity.Name = "btnRepStockWarehouseCapacity";
            this.btnRepStockWarehouseCapacity.Size = new System.Drawing.Size(260, 92);
            this.btnRepStockWarehouseCapacity.TabIndex = 7;
            this.btnRepStockWarehouseCapacity.Text = "Stock Warehouse Capacity Report";
            this.btnRepStockWarehouseCapacity.UseVisualStyleBackColor = true;
            this.btnRepStockWarehouseCapacity.Click += new System.EventHandler(this.btnRepStockWarehouseCapacity_Click);
            // 
            // btn_ManageProductOrders
            // 
            this.btn_ManageProductOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageProductOrders.Location = new System.Drawing.Point(315, 200);
            this.btn_ManageProductOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ManageProductOrders.Name = "btn_ManageProductOrders";
            this.btn_ManageProductOrders.Size = new System.Drawing.Size(261, 80);
            this.btn_ManageProductOrders.TabIndex = 14;
            this.btn_ManageProductOrders.Text = "Manage Product Orders";
            this.btn_ManageProductOrders.UseVisualStyleBackColor = true;
            this.btn_ManageProductOrders.Click += new System.EventHandler(this.btn_ManageProductOrders_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.OCOTODWorkflow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tabBar);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogOut);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomePage";
            this.Text = "OCOTOD | Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet1)).EndInit();
            this.tabBar.ResumeLayout(false);
            this.tabStock.ResumeLayout(false);
            this.tabStock.PerformLayout();
            this.tabProducts.ResumeLayout(false);
            this.tabProducts.PerformLayout();
            this.tabQuality.ResumeLayout(false);
            this.tabQuality.PerformLayout();
            this.tabDelivery.ResumeLayout(false);
            this.tabDelivery.PerformLayout();
            this.tabReports.ResumeLayout(false);
            this.tabReports.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblUserType;
        private Login.WorkFlowDatabaseDataSet workFlowDatabaseDataSet1;
        private System.Windows.Forms.TabControl tabBar;
        private System.Windows.Forms.TabPage tabStock;
        private System.Windows.Forms.Label lblStockHmpg;
        private System.Windows.Forms.Button btnStockUpdate;
        private System.Windows.Forms.Button btnStockGenerateReport;
        private System.Windows.Forms.Button btnStockMaterials;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.Button btnReorderStock;
        private System.Windows.Forms.Label lblProductHomepg;
        private System.Windows.Forms.Button btnProductUpdateStatus;
        private System.Windows.Forms.Button btnProductQuality;
        private System.Windows.Forms.Button btnProductsView;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.TabPage tabQuality;
        private System.Windows.Forms.TabPage tabDelivery;
        private System.Windows.Forms.Label lblQAdashboard;
        private System.Windows.Forms.Label lblDdashboard;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.Button btnRepDefectedProducts;
        private System.Windows.Forms.Button btnRepQualifiedProducts;
        private System.Windows.Forms.Button btnRepProductsInProgress;
        private System.Windows.Forms.Button btnRepStockRawMaterials;
        private System.Windows.Forms.Button btnRepStockWarehouseCapacity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelProductStatusReport;
        private System.Windows.Forms.Button btnDelViewQualProducts;
        private System.Windows.Forms.Button btnDelRouteProduct;
        private System.Windows.Forms.Button btnDelViewProduct;
        private System.Windows.Forms.Button btnReManufacture;
        private System.Windows.Forms.Button btnQAUpdateProdStatus;
        private System.Windows.Forms.Button btnQAViewProd;
        private System.Windows.Forms.Button ProductOrder_btn;
        private System.Windows.Forms.Button btn_ManageProductOrders;
    }
}