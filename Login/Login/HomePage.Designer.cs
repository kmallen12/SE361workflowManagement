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
            this.btnReorderStck = new System.Windows.Forms.Button();
            this.lblProductHomepg = new System.Windows.Forms.Label();
            this.btnProductUpdateStatus = new System.Windows.Forms.Button();
            this.btnProductQuality = new System.Windows.Forms.Button();
            this.btnProductsView = new System.Windows.Forms.Button();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet1)).BeginInit();
            this.tabBar.SuspendLayout();
            this.tabStock.SuspendLayout();
            this.tabProducts.SuspendLayout();
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
            this.tabBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBar.Location = new System.Drawing.Point(1, 65);
            this.tabBar.Name = "tabBar";
            this.tabBar.SelectedIndex = 0;
            this.tabBar.Size = new System.Drawing.Size(805, 384);
            this.tabBar.TabIndex = 15;
            // 
            // tabStock
            // 
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
            this.btnStockGenerateReport.Location = new System.Drawing.Point(14, 197);
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
            this.btnStockMaterials.Location = new System.Drawing.Point(14, 54);
            this.btnStockMaterials.Name = "btnStockMaterials";
            this.btnStockMaterials.Size = new System.Drawing.Size(173, 56);
            this.btnStockMaterials.TabIndex = 5;
            this.btnStockMaterials.Text = "Add Raw Materials";
            this.btnStockMaterials.UseVisualStyleBackColor = true;
            this.btnStockMaterials.Click += new System.EventHandler(this.btnStockMaterials_Click_1);
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.btn_AddProduct);
            this.tabProducts.Controls.Add(this.btnReorderStck);
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
            // btnReorderStck
            // 
            this.btnReorderStck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReorderStck.Location = new System.Drawing.Point(14, 273);
            this.btnReorderStck.Name = "btnReorderStck";
            this.btnReorderStck.Size = new System.Drawing.Size(173, 56);
            this.btnReorderStck.TabIndex = 11;
            this.btnReorderStck.Text = "Reorder Stock";
            this.btnReorderStck.UseVisualStyleBackColor = true;
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
            this.Name = "HomePage";
            this.Text = "OCOTOD | Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet1)).EndInit();
            this.tabBar.ResumeLayout(false);
            this.tabStock.ResumeLayout(false);
            this.tabStock.PerformLayout();
            this.tabProducts.ResumeLayout(false);
            this.tabProducts.PerformLayout();
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
        private System.Windows.Forms.Button btnReorderStck;
        private System.Windows.Forms.Label lblProductHomepg;
        private System.Windows.Forms.Button btnProductUpdateStatus;
        private System.Windows.Forms.Button btnProductQuality;
        private System.Windows.Forms.Button btnProductsView;
        private System.Windows.Forms.Button btn_AddProduct;
    }
}