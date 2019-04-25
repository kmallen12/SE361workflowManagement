namespace WorkFlowManagement
{
    partial class TabHolder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabHolder));
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
            this.btn_StockOrderStatus = new System.Windows.Forms.Button();
            this.btnReManufacture = new System.Windows.Forms.Button();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.btnReorderStock = new System.Windows.Forms.Button();
            this.lblProductHomepg = new System.Windows.Forms.Label();
            this.btnProductsView = new System.Windows.Forms.Button();
            this.tabQuality = new System.Windows.Forms.TabPage();
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
            // workFlowDatabaseDataSet1
            // 
            this.workFlowDatabaseDataSet1.DataSetName = "WorkFlowDatabaseDataSet";
            this.workFlowDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabBar
            // 
            resources.ApplyResources(this.tabBar, "tabBar");
            this.tabBar.Controls.Add(this.tabStock);
            this.tabBar.Controls.Add(this.tabProducts);
            this.tabBar.Controls.Add(this.tabQuality);
            this.tabBar.Controls.Add(this.tabDelivery);
            this.tabBar.Controls.Add(this.tabReports);
            this.tabBar.Name = "tabBar";
            this.tabBar.SelectedIndex = 0;
            // 
            // tabStock
            // 
            this.tabStock.BackColor = System.Drawing.Color.Transparent;
            this.tabStock.BackgroundImage = global::Login.Properties.Resources.BckBlue;
            this.tabStock.Controls.Add(this.button2);
            this.tabStock.Controls.Add(this.btnStockInventorySum);
            this.tabStock.Controls.Add(this.lblStockHmpg);
            this.tabStock.Controls.Add(this.btnStockUpdate);
            this.tabStock.Controls.Add(this.btnStockGenerateReport);
            this.tabStock.Controls.Add(this.btnStockMaterials);
            resources.ApplyResources(this.tabStock, "tabStock");
            this.tabStock.Name = "tabStock";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStockInventorySum
            // 
            resources.ApplyResources(this.btnStockInventorySum, "btnStockInventorySum");
            this.btnStockInventorySum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStockInventorySum.Name = "btnStockInventorySum";
            this.btnStockInventorySum.UseVisualStyleBackColor = true;
            this.btnStockInventorySum.Click += new System.EventHandler(this.btnStockInventorySum_Click);
            // 
            // lblStockHmpg
            // 
            resources.ApplyResources(this.lblStockHmpg, "lblStockHmpg");
            this.lblStockHmpg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStockHmpg.Name = "lblStockHmpg";
            // 
            // btnStockUpdate
            // 
            resources.ApplyResources(this.btnStockUpdate, "btnStockUpdate");
            this.btnStockUpdate.Name = "btnStockUpdate";
            this.btnStockUpdate.UseVisualStyleBackColor = true;
            this.btnStockUpdate.Click += new System.EventHandler(this.btnStockUpdate_Click);
            // 
            // btnStockGenerateReport
            // 
            resources.ApplyResources(this.btnStockGenerateReport, "btnStockGenerateReport");
            this.btnStockGenerateReport.Name = "btnStockGenerateReport";
            this.btnStockGenerateReport.UseVisualStyleBackColor = true;
            this.btnStockGenerateReport.Click += new System.EventHandler(this.btnStockGenerateReport_Click);
            // 
            // btnStockMaterials
            // 
            resources.ApplyResources(this.btnStockMaterials, "btnStockMaterials");
            this.btnStockMaterials.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStockMaterials.Name = "btnStockMaterials";
            this.btnStockMaterials.UseVisualStyleBackColor = true;
            this.btnStockMaterials.Click += new System.EventHandler(this.btnStockMaterials_Click);
            // 
            // tabProducts
            // 
            this.tabProducts.BackgroundImage = global::Login.Properties.Resources.BckBlue;
            this.tabProducts.Controls.Add(this.btn_StockOrderStatus);
            this.tabProducts.Controls.Add(this.btnReManufacture);
            this.tabProducts.Controls.Add(this.btn_AddProduct);
            this.tabProducts.Controls.Add(this.btnReorderStock);
            this.tabProducts.Controls.Add(this.lblProductHomepg);
            this.tabProducts.Controls.Add(this.btnProductsView);
            resources.ApplyResources(this.tabProducts, "tabProducts");
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Click += new System.EventHandler(this.tabProducts_Click);
            // 
            // btn_StockOrderStatus
            // 
            resources.ApplyResources(this.btn_StockOrderStatus, "btn_StockOrderStatus");
            this.btn_StockOrderStatus.Name = "btn_StockOrderStatus";
            this.btn_StockOrderStatus.UseVisualStyleBackColor = true;
            this.btn_StockOrderStatus.Click += new System.EventHandler(this.btn_StockOrderStatus_Click);
            // 
            // btnReManufacture
            // 
            resources.ApplyResources(this.btnReManufacture, "btnReManufacture");
            this.btnReManufacture.Name = "btnReManufacture";
            this.btnReManufacture.UseVisualStyleBackColor = true;
            this.btnReManufacture.Click += new System.EventHandler(this.btnReManufacture_Click);
            // 
            // btn_AddProduct
            // 
            resources.ApplyResources(this.btn_AddProduct, "btn_AddProduct");
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btnReorderStock
            // 
            resources.ApplyResources(this.btnReorderStock, "btnReorderStock");
            this.btnReorderStock.Name = "btnReorderStock";
            this.btnReorderStock.UseVisualStyleBackColor = true;
            this.btnReorderStock.Click += new System.EventHandler(this.btnReorderStock_Click);
            // 
            // lblProductHomepg
            // 
            resources.ApplyResources(this.lblProductHomepg, "lblProductHomepg");
            this.lblProductHomepg.BackColor = System.Drawing.Color.Transparent;
            this.lblProductHomepg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProductHomepg.Name = "lblProductHomepg";
            // 
            // btnProductsView
            // 
            resources.ApplyResources(this.btnProductsView, "btnProductsView");
            this.btnProductsView.Name = "btnProductsView";
            this.btnProductsView.UseVisualStyleBackColor = true;
            this.btnProductsView.Click += new System.EventHandler(this.btnProductsView_Click);
            // 
            // tabQuality
            // 
            this.tabQuality.BackgroundImage = global::Login.Properties.Resources.BckBlue;
            this.tabQuality.Controls.Add(this.btnQAUpdateProdStatus);
            this.tabQuality.Controls.Add(this.btnQAViewProd);
            this.tabQuality.Controls.Add(this.lblQAdashboard);
            resources.ApplyResources(this.tabQuality, "tabQuality");
            this.tabQuality.Name = "tabQuality";
            // 
            // btnQAUpdateProdStatus
            // 
            resources.ApplyResources(this.btnQAUpdateProdStatus, "btnQAUpdateProdStatus");
            this.btnQAUpdateProdStatus.Name = "btnQAUpdateProdStatus";
            this.btnQAUpdateProdStatus.UseVisualStyleBackColor = true;
            this.btnQAUpdateProdStatus.Click += new System.EventHandler(this.btnQAUpdateProdStatus_Click);
            // 
            // btnQAViewProd
            // 
            resources.ApplyResources(this.btnQAViewProd, "btnQAViewProd");
            this.btnQAViewProd.Name = "btnQAViewProd";
            this.btnQAViewProd.UseVisualStyleBackColor = true;
            this.btnQAViewProd.Click += new System.EventHandler(this.btnQAViewProd_Click);
            // 
            // lblQAdashboard
            // 
            resources.ApplyResources(this.lblQAdashboard, "lblQAdashboard");
            this.lblQAdashboard.BackColor = System.Drawing.Color.Transparent;
            this.lblQAdashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQAdashboard.Name = "lblQAdashboard";
            // 
            // tabDelivery
            // 
            this.tabDelivery.BackgroundImage = global::Login.Properties.Resources.BckBlue;
            this.tabDelivery.Controls.Add(this.btnDelProductStatusReport);
            this.tabDelivery.Controls.Add(this.btnDelViewQualProducts);
            this.tabDelivery.Controls.Add(this.btnDelRouteProduct);
            this.tabDelivery.Controls.Add(this.btnDelViewProduct);
            this.tabDelivery.Controls.Add(this.lblDdashboard);
            resources.ApplyResources(this.tabDelivery, "tabDelivery");
            this.tabDelivery.Name = "tabDelivery";
            // 
            // btnDelProductStatusReport
            // 
            resources.ApplyResources(this.btnDelProductStatusReport, "btnDelProductStatusReport");
            this.btnDelProductStatusReport.Name = "btnDelProductStatusReport";
            this.btnDelProductStatusReport.UseVisualStyleBackColor = true;
            this.btnDelProductStatusReport.Click += new System.EventHandler(this.btnDelProductStatusReport_Click);
            // 
            // btnDelViewQualProducts
            // 
            resources.ApplyResources(this.btnDelViewQualProducts, "btnDelViewQualProducts");
            this.btnDelViewQualProducts.Name = "btnDelViewQualProducts";
            this.btnDelViewQualProducts.UseVisualStyleBackColor = true;
            this.btnDelViewQualProducts.Click += new System.EventHandler(this.btnDelViewQualProducts_Click);
            // 
            // btnDelRouteProduct
            // 
            resources.ApplyResources(this.btnDelRouteProduct, "btnDelRouteProduct");
            this.btnDelRouteProduct.Name = "btnDelRouteProduct";
            this.btnDelRouteProduct.UseVisualStyleBackColor = true;
            this.btnDelRouteProduct.Click += new System.EventHandler(this.btnDelRouteProduct_Click);
            // 
            // btnDelViewProduct
            // 
            resources.ApplyResources(this.btnDelViewProduct, "btnDelViewProduct");
            this.btnDelViewProduct.Name = "btnDelViewProduct";
            this.btnDelViewProduct.UseVisualStyleBackColor = true;
            this.btnDelViewProduct.Click += new System.EventHandler(this.btnDelViewProduct_Click);
            // 
            // lblDdashboard
            // 
            resources.ApplyResources(this.lblDdashboard, "lblDdashboard");
            this.lblDdashboard.BackColor = System.Drawing.Color.Transparent;
            this.lblDdashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDdashboard.Name = "lblDdashboard";
            // 
            // tabReports
            // 
            this.tabReports.BackgroundImage = global::Login.Properties.Resources.BckBlue;
            this.tabReports.Controls.Add(this.lblProduct);
            this.tabReports.Controls.Add(this.lblStockReport);
            this.tabReports.Controls.Add(this.label1);
            this.tabReports.Controls.Add(this.btnRepDefectedProducts);
            this.tabReports.Controls.Add(this.btnRepQualifiedProducts);
            this.tabReports.Controls.Add(this.btnRepProductsInProgress);
            this.tabReports.Controls.Add(this.btnRepStockRawMaterials);
            this.tabReports.Controls.Add(this.btnRepStockWarehouseCapacity);
            resources.ApplyResources(this.tabReports, "tabReports");
            this.tabReports.Name = "tabReports";
            // 
            // lblProduct
            // 
            resources.ApplyResources(this.lblProduct, "lblProduct");
            this.lblProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProduct.Name = "lblProduct";
            // 
            // lblStockReport
            // 
            resources.ApplyResources(this.lblStockReport, "lblStockReport");
            this.lblStockReport.BackColor = System.Drawing.Color.Transparent;
            this.lblStockReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStockReport.Name = "lblStockReport";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Name = "label1";
            // 
            // btnRepDefectedProducts
            // 
            resources.ApplyResources(this.btnRepDefectedProducts, "btnRepDefectedProducts");
            this.btnRepDefectedProducts.Name = "btnRepDefectedProducts";
            this.btnRepDefectedProducts.UseVisualStyleBackColor = true;
            this.btnRepDefectedProducts.Click += new System.EventHandler(this.btnRepDefectedProducts_Click);
            // 
            // btnRepQualifiedProducts
            // 
            resources.ApplyResources(this.btnRepQualifiedProducts, "btnRepQualifiedProducts");
            this.btnRepQualifiedProducts.Name = "btnRepQualifiedProducts";
            this.btnRepQualifiedProducts.UseVisualStyleBackColor = true;
            this.btnRepQualifiedProducts.Click += new System.EventHandler(this.btnRepQualifiedProducts_Click);
            // 
            // btnRepProductsInProgress
            // 
            resources.ApplyResources(this.btnRepProductsInProgress, "btnRepProductsInProgress");
            this.btnRepProductsInProgress.Name = "btnRepProductsInProgress";
            this.btnRepProductsInProgress.UseVisualStyleBackColor = true;
            this.btnRepProductsInProgress.Click += new System.EventHandler(this.btnRepProductsInProgress_Click_1);
            // 
            // btnRepStockRawMaterials
            // 
            resources.ApplyResources(this.btnRepStockRawMaterials, "btnRepStockRawMaterials");
            this.btnRepStockRawMaterials.Name = "btnRepStockRawMaterials";
            this.btnRepStockRawMaterials.UseVisualStyleBackColor = true;
            this.btnRepStockRawMaterials.Click += new System.EventHandler(this.btnRepStockRawMaterials_Click);
            // 
            // btnRepStockWarehouseCapacity
            // 
            resources.ApplyResources(this.btnRepStockWarehouseCapacity, "btnRepStockWarehouseCapacity");
            this.btnRepStockWarehouseCapacity.Name = "btnRepStockWarehouseCapacity";
            this.btnRepStockWarehouseCapacity.UseVisualStyleBackColor = true;
            this.btnRepStockWarehouseCapacity.Click += new System.EventHandler(this.btnRepStockWarehouseCapacity_Click);
            // 
            // TabHolder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.tabBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TabHolder";
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
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblStockReport;
        private System.Windows.Forms.Button btnStockInventorySum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_StockOrderStatus;
    }
}