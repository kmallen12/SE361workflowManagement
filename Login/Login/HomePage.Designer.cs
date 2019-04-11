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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblUserType = new System.Windows.Forms.Label();
            this.workFlowDatabaseDataSet1 = new Login.WorkFlowDatabaseDataSet();
            this.tabBar = new System.Windows.Forms.TabControl();
            this.tabStock = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btnStockInventorySum = new System.Windows.Forms.Button();
            this.lblStockHmpg = new System.Windows.Forms.Label();
            this.btnStockUpdate = new System.Windows.Forms.Button();
            this.btnStockGenerateReport = new System.Windows.Forms.Button();
            this.btnStockMaterials = new System.Windows.Forms.Button();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.btn_ManageProductOrders = new System.Windows.Forms.Button();
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblStockReport = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRepDefectedProducts = new System.Windows.Forms.Button();
            this.btnRepQualifiedProducts = new System.Windows.Forms.Button();
            this.btnRepProductsInProgress = new System.Windows.Forms.Button();
            this.btnRepStockRawMaterials = new System.Windows.Forms.Button();
            this.btnRepStockWarehouseCapacity = new System.Windows.Forms.Button();
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
            this.lblUsername.Location = new System.Drawing.Point(607, 36);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUsername.Size = new System.Drawing.Size(187, 13);
            this.lblUsername.TabIndex = 13;
            this.lblUsername.Text = "User";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogOut.Location = new System.Drawing.Point(719, 10);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
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
            this.lblUserType.Location = new System.Drawing.Point(610, 49);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserType.Size = new System.Drawing.Size(184, 13);
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
            this.tabBar.Location = new System.Drawing.Point(1, 65);
            this.tabBar.Name = "tabBar";
            this.tabBar.SelectedIndex = 0;
            this.tabBar.Size = new System.Drawing.Size(805, 384);
            this.tabBar.TabIndex = 15;
            // 
            // tabStock
            // 
            this.tabStock.Controls.Add(this.button2);
            this.tabStock.Controls.Add(this.btnStockInventorySum);
            this.tabStock.Controls.Add(this.lblStockHmpg);
            this.tabStock.Controls.Add(this.btnStockUpdate);
            this.tabStock.Controls.Add(this.btnStockGenerateReport);
            this.tabStock.Controls.Add(this.btnStockMaterials);
            this.tabStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStock.Location = new System.Drawing.Point(4, 27);
            this.tabStock.Name = "tabStock";
            this.tabStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabStock.Size = new System.Drawing.Size(797, 353);
            this.tabStock.TabIndex = 0;
            this.tabStock.Text = "Stock";
            this.tabStock.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(292, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 56);
            this.button2.TabIndex = 10;
            this.button2.Text = "Manage Stock Orders";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStockInventorySum
            // 
            this.btnStockInventorySum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockInventorySum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStockInventorySum.Location = new System.Drawing.Point(292, 53);
            this.btnStockInventorySum.Name = "btnStockInventorySum";
            this.btnStockInventorySum.Size = new System.Drawing.Size(173, 56);
            this.btnStockInventorySum.TabIndex = 9;
            this.btnStockInventorySum.Text = "Stock Inventory Summary";
            this.btnStockInventorySum.UseVisualStyleBackColor = true;
            this.btnStockInventorySum.Click += new System.EventHandler(this.btnStockInventorySum_Click);
            // 
            // lblStockHmpg
            // 
            this.lblStockHmpg.AutoSize = true;
            this.lblStockHmpg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockHmpg.Location = new System.Drawing.Point(9, 13);
            this.lblStockHmpg.Name = "lblStockHmpg";
            this.lblStockHmpg.Size = new System.Drawing.Size(254, 29);
            this.lblStockHmpg.TabIndex = 8;
            this.lblStockHmpg.Text = "Stockiest Dashboard";
            // 
            // btnStockUpdate
            // 
            this.btnStockUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockUpdate.Location = new System.Drawing.Point(14, 127);
            this.btnStockUpdate.Name = "btnStockUpdate";
            this.btnStockUpdate.Size = new System.Drawing.Size(173, 52);
            this.btnStockUpdate.TabIndex = 7;
            this.btnStockUpdate.Text = "View/Update Stock";
            this.btnStockUpdate.UseVisualStyleBackColor = true;
            this.btnStockUpdate.Click += new System.EventHandler(this.btnStockUpdate_Click_1);
            // 
            // btnStockGenerateReport
            // 
            this.btnStockGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockGenerateReport.Location = new System.Drawing.Point(14, 196);
            this.btnStockGenerateReport.Name = "btnStockGenerateReport";
            this.btnStockGenerateReport.Size = new System.Drawing.Size(173, 60);
            this.btnStockGenerateReport.TabIndex = 6;
            this.btnStockGenerateReport.Text = "Generate Report";
            this.btnStockGenerateReport.UseVisualStyleBackColor = true;
            this.btnStockGenerateReport.Click += new System.EventHandler(this.btnStockGenerateReport_Click_1);
            // 
            // btnStockMaterials
            // 
            this.btnStockMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockMaterials.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStockMaterials.Location = new System.Drawing.Point(14, 53);
            this.btnStockMaterials.Name = "btnStockMaterials";
            this.btnStockMaterials.Size = new System.Drawing.Size(173, 56);
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
            this.tabProducts.Location = new System.Drawing.Point(4, 27);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(797, 353);
            this.tabProducts.TabIndex = 1;
            this.tabProducts.Text = "Products";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // btn_ManageProductOrders
            // 
            this.btn_ManageProductOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageProductOrders.Location = new System.Drawing.Point(210, 130);
            this.btn_ManageProductOrders.Name = "btn_ManageProductOrders";
            this.btn_ManageProductOrders.Size = new System.Drawing.Size(174, 52);
            this.btn_ManageProductOrders.TabIndex = 14;
            this.btn_ManageProductOrders.Text = "Manage Product Orders";
            this.btn_ManageProductOrders.UseVisualStyleBackColor = true;
            this.btn_ManageProductOrders.Click += new System.EventHandler(this.btn_ManageProductOrders_Click);
            // 
            // btnReManufacture
            // 
            this.btnReManufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReManufacture.Location = new System.Drawing.Point(210, 200);
            this.btnReManufacture.Name = "btnReManufacture";
            this.btnReManufacture.Size = new System.Drawing.Size(174, 58);
            this.btnReManufacture.TabIndex = 13;
            this.btnReManufacture.Text = "Defective Products to Re-Manufacture";
            this.btnReManufacture.UseVisualStyleBackColor = true;
            this.btnReManufacture.Click += new System.EventHandler(this.btnReManufacture_Click);
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddProduct.Location = new System.Drawing.Point(210, 55);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(174, 58);
            this.btn_AddProduct.TabIndex = 12;
            this.btn_AddProduct.Text = "Add Product";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btnReorderStock
            // 
            this.btnReorderStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReorderStock.Location = new System.Drawing.Point(14, 273);
            this.btnReorderStock.Name = "btnReorderStock";
            this.btnReorderStock.Size = new System.Drawing.Size(173, 56);
            this.btnReorderStock.TabIndex = 11;
            this.btnReorderStock.Text = "Order Stock";
            this.btnReorderStock.UseVisualStyleBackColor = true;
            this.btnReorderStock.Click += new System.EventHandler(this.btnReorderStock_Click);
            // 
            // lblProductHomepg
            // 
            this.lblProductHomepg.AutoSize = true;
            this.lblProductHomepg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductHomepg.Location = new System.Drawing.Point(9, 12);
            this.lblProductHomepg.Name = "lblProductHomepg";
            this.lblProductHomepg.Size = new System.Drawing.Size(346, 29);
            this.lblProductHomepg.TabIndex = 10;
            this.lblProductHomepg.Text = "Product Manager Dashboard";
            // 
            // btnProductUpdateStatus
            // 
            this.btnProductUpdateStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductUpdateStatus.Location = new System.Drawing.Point(14, 200);
            this.btnProductUpdateStatus.Name = "btnProductUpdateStatus";
            this.btnProductUpdateStatus.Size = new System.Drawing.Size(174, 60);
            this.btnProductUpdateStatus.TabIndex = 9;
            this.btnProductUpdateStatus.Text = "Update Product Status";
            this.btnProductUpdateStatus.UseVisualStyleBackColor = true;
            // 
            // btnProductQuality
            // 
            this.btnProductQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductQuality.Location = new System.Drawing.Point(14, 130);
            this.btnProductQuality.Name = "btnProductQuality";
            this.btnProductQuality.Size = new System.Drawing.Size(174, 52);
            this.btnProductQuality.TabIndex = 8;
            this.btnProductQuality.Text = "Check Product Quality";
            this.btnProductQuality.UseVisualStyleBackColor = true;
            // 
            // btnProductsView
            // 
            this.btnProductsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductsView.Location = new System.Drawing.Point(14, 55);
            this.btnProductsView.Name = "btnProductsView";
            this.btnProductsView.Size = new System.Drawing.Size(174, 58);
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
            this.tabQuality.Location = new System.Drawing.Point(4, 27);
            this.tabQuality.Name = "tabQuality";
            this.tabQuality.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuality.Size = new System.Drawing.Size(797, 353);
            this.tabQuality.TabIndex = 2;
            this.tabQuality.Text = "Quality";
            this.tabQuality.UseVisualStyleBackColor = true;
            // 
            // ProductOrder_btn
            // 
            this.ProductOrder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductOrder_btn.Location = new System.Drawing.Point(22, 218);
            this.ProductOrder_btn.Name = "ProductOrder_btn";
            this.ProductOrder_btn.Size = new System.Drawing.Size(174, 58);
            this.ProductOrder_btn.TabIndex = 14;
            this.ProductOrder_btn.Text = "Create Product Order";
            this.ProductOrder_btn.UseVisualStyleBackColor = true;
            this.ProductOrder_btn.Click += new System.EventHandler(this.ProductOrder_btn_Click);
            // 
            // btnQAUpdateProdStatus
            // 
            this.btnQAUpdateProdStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQAUpdateProdStatus.Location = new System.Drawing.Point(22, 136);
            this.btnQAUpdateProdStatus.Name = "btnQAUpdateProdStatus";
            this.btnQAUpdateProdStatus.Size = new System.Drawing.Size(174, 58);
            this.btnQAUpdateProdStatus.TabIndex = 13;
            this.btnQAUpdateProdStatus.Text = "Update Product Status";
            this.btnQAUpdateProdStatus.UseVisualStyleBackColor = true;
            this.btnQAUpdateProdStatus.Click += new System.EventHandler(this.btnQAUpdateProdStatus_Click);
            // 
            // btnQAViewProd
            // 
            this.btnQAViewProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQAViewProd.Location = new System.Drawing.Point(22, 57);
            this.btnQAViewProd.Name = "btnQAViewProd";
            this.btnQAViewProd.Size = new System.Drawing.Size(174, 58);
            this.btnQAViewProd.TabIndex = 12;
            this.btnQAViewProd.Text = "View Products";
            this.btnQAViewProd.UseVisualStyleBackColor = true;
            this.btnQAViewProd.Click += new System.EventHandler(this.btnQAViewProd_Click);
            // 
            // lblQAdashboard
            // 
            this.lblQAdashboard.AutoSize = true;
            this.lblQAdashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQAdashboard.Location = new System.Drawing.Point(7, 13);
            this.lblQAdashboard.Name = "lblQAdashboard";
            this.lblQAdashboard.Size = new System.Drawing.Size(375, 29);
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
            this.tabDelivery.Location = new System.Drawing.Point(4, 27);
            this.tabDelivery.Name = "tabDelivery";
            this.tabDelivery.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelivery.Size = new System.Drawing.Size(797, 353);
            this.tabDelivery.TabIndex = 3;
            this.tabDelivery.Text = "Delivery";
            this.tabDelivery.UseVisualStyleBackColor = true;
            // 
            // btnDelProductStatusReport
            // 
            this.btnDelProductStatusReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelProductStatusReport.Location = new System.Drawing.Point(22, 290);
            this.btnDelProductStatusReport.Name = "btnDelProductStatusReport";
            this.btnDelProductStatusReport.Size = new System.Drawing.Size(174, 58);
            this.btnDelProductStatusReport.TabIndex = 13;
            this.btnDelProductStatusReport.Text = "Product Status Report";
            this.btnDelProductStatusReport.UseVisualStyleBackColor = true;
            this.btnDelProductStatusReport.Click += new System.EventHandler(this.btnDelProductStatusReport_Click);
            // 
            // btnDelViewQualProducts
            // 
            this.btnDelViewQualProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelViewQualProducts.Location = new System.Drawing.Point(22, 215);
            this.btnDelViewQualProducts.Name = "btnDelViewQualProducts";
            this.btnDelViewQualProducts.Size = new System.Drawing.Size(174, 58);
            this.btnDelViewQualProducts.TabIndex = 12;
            this.btnDelViewQualProducts.Text = "View Qualified Products";
            this.btnDelViewQualProducts.UseVisualStyleBackColor = true;
            this.btnDelViewQualProducts.Click += new System.EventHandler(this.btnDelViewQualProducts_Click);
            // 
            // btnDelRouteProduct
            // 
            this.btnDelRouteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelRouteProduct.Location = new System.Drawing.Point(22, 139);
            this.btnDelRouteProduct.Name = "btnDelRouteProduct";
            this.btnDelRouteProduct.Size = new System.Drawing.Size(174, 58);
            this.btnDelRouteProduct.TabIndex = 11;
            this.btnDelRouteProduct.Text = "Route Products";
            this.btnDelRouteProduct.UseVisualStyleBackColor = true;
            this.btnDelRouteProduct.Click += new System.EventHandler(this.btnDelRouteProduct_Click);
            // 
            // btnDelViewProduct
            // 
            this.btnDelViewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelViewProduct.Location = new System.Drawing.Point(22, 60);
            this.btnDelViewProduct.Name = "btnDelViewProduct";
            this.btnDelViewProduct.Size = new System.Drawing.Size(174, 58);
            this.btnDelViewProduct.TabIndex = 10;
            this.btnDelViewProduct.Text = "View Products";
            this.btnDelViewProduct.UseVisualStyleBackColor = true;
            this.btnDelViewProduct.Click += new System.EventHandler(this.btnDelViewProduct_Click);
            // 
            // lblDdashboard
            // 
            this.lblDdashboard.AutoSize = true;
            this.lblDdashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDdashboard.Location = new System.Drawing.Point(7, 17);
            this.lblDdashboard.Name = "lblDdashboard";
            this.lblDdashboard.Size = new System.Drawing.Size(384, 29);
            this.lblDdashboard.TabIndex = 9;
            this.lblDdashboard.Text = "Delivery Department Dashboard";
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.label2);
            this.tabReports.Controls.Add(this.lblProduct);
            this.tabReports.Controls.Add(this.lblStockReport);
            this.tabReports.Controls.Add(this.label1);
            this.tabReports.Controls.Add(this.btnRepDefectedProducts);
            this.tabReports.Controls.Add(this.btnRepQualifiedProducts);
            this.tabReports.Controls.Add(this.btnRepProductsInProgress);
            this.tabReports.Controls.Add(this.btnRepStockRawMaterials);
            this.tabReports.Controls.Add(this.btnRepStockWarehouseCapacity);
            this.tabReports.Location = new System.Drawing.Point(4, 27);
            this.tabReports.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabReports.Name = "tabReports";
            this.tabReports.Size = new System.Drawing.Size(797, 353);
            this.tabReports.TabIndex = 4;
            this.tabReports.Text = "Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(27, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "(Items with Low/High Inventory)";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(233, 57);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(132, 18);
            this.lblProduct.TabIndex = 14;
            this.lblProduct.Text = "Product Reports";
            // 
            // lblStockReport
            // 
            this.lblStockReport.AutoSize = true;
            this.lblStockReport.Location = new System.Drawing.Point(51, 57);
            this.lblStockReport.Name = "lblStockReport";
            this.lblStockReport.Size = new System.Drawing.Size(117, 18);
            this.lblStockReport.TabIndex = 13;
            this.lblStockReport.Text = "Stock Reports";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reports Generation Dashboard";
            // 
            // btnRepDefectedProducts
            // 
            this.btnRepDefectedProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepDefectedProducts.Location = new System.Drawing.Point(212, 234);
            this.btnRepDefectedProducts.Name = "btnRepDefectedProducts";
            this.btnRepDefectedProducts.Size = new System.Drawing.Size(173, 60);
            this.btnRepDefectedProducts.TabIndex = 11;
            this.btnRepDefectedProducts.Text = "Defective Products";
            this.btnRepDefectedProducts.UseVisualStyleBackColor = true;
            this.btnRepDefectedProducts.Click += new System.EventHandler(this.btnRepDefectedProducts_Click);
            // 
            // btnRepQualifiedProducts
            // 
            this.btnRepQualifiedProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepQualifiedProducts.Location = new System.Drawing.Point(212, 153);
            this.btnRepQualifiedProducts.Name = "btnRepQualifiedProducts";
            this.btnRepQualifiedProducts.Size = new System.Drawing.Size(173, 60);
            this.btnRepQualifiedProducts.TabIndex = 10;
            this.btnRepQualifiedProducts.Text = "Qualified Products";
            this.btnRepQualifiedProducts.UseVisualStyleBackColor = true;
            this.btnRepQualifiedProducts.Click += new System.EventHandler(this.btnRepQualifiedProducts_Click);
            // 
            // btnRepProductsInProgress
            // 
            this.btnRepProductsInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepProductsInProgress.Location = new System.Drawing.Point(212, 78);
            this.btnRepProductsInProgress.Name = "btnRepProductsInProgress";
            this.btnRepProductsInProgress.Size = new System.Drawing.Size(173, 60);
            this.btnRepProductsInProgress.TabIndex = 9;
            this.btnRepProductsInProgress.Text = "Products In Progress";
            this.btnRepProductsInProgress.UseVisualStyleBackColor = true;
            this.btnRepProductsInProgress.Click += new System.EventHandler(this.btnRepProductsInProgress_Click);
            // 
            // btnRepStockRawMaterials
            // 
            this.btnRepStockRawMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepStockRawMaterials.Location = new System.Drawing.Point(20, 153);
            this.btnRepStockRawMaterials.Name = "btnRepStockRawMaterials";
            this.btnRepStockRawMaterials.Size = new System.Drawing.Size(173, 60);
            this.btnRepStockRawMaterials.TabIndex = 8;
            this.btnRepStockRawMaterials.Text = "Stock Inventory";
            this.btnRepStockRawMaterials.UseVisualStyleBackColor = true;
            this.btnRepStockRawMaterials.Click += new System.EventHandler(this.btnRepStockRawMaterials_Click);
            // 
            // btnRepStockWarehouseCapacity
            // 
            this.btnRepStockWarehouseCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepStockWarehouseCapacity.Location = new System.Drawing.Point(20, 78);
            this.btnRepStockWarehouseCapacity.Name = "btnRepStockWarehouseCapacity";
            this.btnRepStockWarehouseCapacity.Size = new System.Drawing.Size(173, 60);
            this.btnRepStockWarehouseCapacity.TabIndex = 7;
            this.btnRepStockWarehouseCapacity.Text = "Warehouse Capacity";
            this.btnRepStockWarehouseCapacity.UseVisualStyleBackColor = true;
            this.btnRepStockWarehouseCapacity.Click += new System.EventHandler(this.btnRepStockWarehouseCapacity_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.OCOTODWorkflow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabBar);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblStockReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStockInventorySum;
        private System.Windows.Forms.Button button2;
    }
}