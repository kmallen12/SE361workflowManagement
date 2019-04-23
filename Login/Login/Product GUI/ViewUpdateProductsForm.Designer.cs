namespace WorkFlowManagement
{
    partial class ViewProducts
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProducts));
            this.dataGrid_ViewProducts = new System.Windows.Forms.DataGridView();
            this.productTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workFlowDatabaseDataSetProducts = new Login.WorkFlowDatabaseDataSetProducts();
            this.productTableTableAdapter = new Login.WorkFlowDatabaseDataSetProductsTableAdapters.ProductTableTableAdapter();
            this.lbl_ViewProducts = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.txt_ProductQuantity = new System.Windows.Forms.TextBox();
            this.lbl_ProductID = new System.Windows.Forms.Label();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.lbl_ProductMaterials = new System.Windows.Forms.Label();
            this.lbl_ProductQuantity = new System.Windows.Forms.Label();
            this.btn_UpdateProduct = new System.Windows.Forms.Button();
            this.btn_OrderProduct = new System.Windows.Forms.Button();
            this.lbl_ProductInfo = new System.Windows.Forms.Label();
            this.txt_ProductID = new System.Windows.Forms.ComboBox();
            this.txt_ProductMaterials = new System.Windows.Forms.RichTextBox();
            this.pIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSetProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_ViewProducts
            // 
            this.dataGrid_ViewProducts.AutoGenerateColumns = false;
            this.dataGrid_ViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_ViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.materialsStringDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGrid_ViewProducts.DataSource = this.productTableBindingSource;
            this.dataGrid_ViewProducts.Location = new System.Drawing.Point(457, 15);
            this.dataGrid_ViewProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGrid_ViewProducts.Name = "dataGrid_ViewProducts";
            this.dataGrid_ViewProducts.Size = new System.Drawing.Size(593, 524);
            this.dataGrid_ViewProducts.TabIndex = 0;
            // 
            // productTableBindingSource
            // 
            this.productTableBindingSource.DataMember = "ProductTable";
            this.productTableBindingSource.DataSource = this.workFlowDatabaseDataSetProducts;
            // 
            // workFlowDatabaseDataSetProducts
            // 
            this.workFlowDatabaseDataSetProducts.DataSetName = "WorkFlowDatabaseDataSetProducts";
            this.workFlowDatabaseDataSetProducts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableTableAdapter
            // 
            this.productTableTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_ViewProducts
            // 
            this.lbl_ViewProducts.AutoSize = true;
            this.lbl_ViewProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ViewProducts.Location = new System.Drawing.Point(75, 27);
            this.lbl_ViewProducts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ViewProducts.Name = "lbl_ViewProducts";
            this.lbl_ViewProducts.Size = new System.Drawing.Size(282, 29);
            this.lbl_ViewProducts.TabIndex = 1;
            this.lbl_ViewProducts.Text = "Update Product Details";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Location = new System.Drawing.Point(240, 186);
            this.txt_ProductName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(181, 22);
            this.txt_ProductName.TabIndex = 3;
            // 
            // txt_ProductQuantity
            // 
            this.txt_ProductQuantity.Location = new System.Drawing.Point(240, 395);
            this.txt_ProductQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ProductQuantity.Name = "txt_ProductQuantity";
            this.txt_ProductQuantity.Size = new System.Drawing.Size(181, 22);
            this.txt_ProductQuantity.TabIndex = 5;
            // 
            // lbl_ProductID
            // 
            this.lbl_ProductID.AutoSize = true;
            this.lbl_ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductID.Location = new System.Drawing.Point(17, 128);
            this.lbl_ProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ProductID.Name = "lbl_ProductID";
            this.lbl_ProductID.Size = new System.Drawing.Size(105, 20);
            this.lbl_ProductID.TabIndex = 6;
            this.lbl_ProductID.Text = "Product ID:";
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductName.Location = new System.Drawing.Point(17, 186);
            this.lbl_ProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(134, 20);
            this.lbl_ProductName.TabIndex = 7;
            this.lbl_ProductName.Text = "Product Name:";
            // 
            // lbl_ProductMaterials
            // 
            this.lbl_ProductMaterials.AutoSize = true;
            this.lbl_ProductMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductMaterials.Location = new System.Drawing.Point(17, 244);
            this.lbl_ProductMaterials.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ProductMaterials.Name = "lbl_ProductMaterials";
            this.lbl_ProductMaterials.Size = new System.Drawing.Size(164, 20);
            this.lbl_ProductMaterials.TabIndex = 8;
            this.lbl_ProductMaterials.Text = "Product Materials:";
            // 
            // lbl_ProductQuantity
            // 
            this.lbl_ProductQuantity.AutoSize = true;
            this.lbl_ProductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductQuantity.Location = new System.Drawing.Point(17, 400);
            this.lbl_ProductQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ProductQuantity.Name = "lbl_ProductQuantity";
            this.lbl_ProductQuantity.Size = new System.Drawing.Size(156, 20);
            this.lbl_ProductQuantity.TabIndex = 9;
            this.lbl_ProductQuantity.Text = "Product Quantity:";
            // 
            // btn_UpdateProduct
            // 
            this.btn_UpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateProduct.Location = new System.Drawing.Point(20, 473);
            this.btn_UpdateProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_UpdateProduct.Name = "btn_UpdateProduct";
            this.btn_UpdateProduct.Size = new System.Drawing.Size(209, 52);
            this.btn_UpdateProduct.TabIndex = 10;
            this.btn_UpdateProduct.Text = "Update Product";
            this.btn_UpdateProduct.UseVisualStyleBackColor = true;
            this.btn_UpdateProduct.Click += new System.EventHandler(this.btn_UpdateProduct_Click);
            // 
            // btn_OrderProduct
            // 
            this.btn_OrderProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OrderProduct.Location = new System.Drawing.Point(240, 473);
            this.btn_OrderProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_OrderProduct.Name = "btn_OrderProduct";
            this.btn_OrderProduct.Size = new System.Drawing.Size(209, 52);
            this.btn_OrderProduct.TabIndex = 11;
            this.btn_OrderProduct.Text = "Order Product";
            this.btn_OrderProduct.UseVisualStyleBackColor = true;
            this.btn_OrderProduct.Click += new System.EventHandler(this.btn_OrderProduct_Click);
            // 
            // lbl_ProductInfo
            // 
            this.lbl_ProductInfo.AutoSize = true;
            this.lbl_ProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductInfo.Location = new System.Drawing.Point(16, 68);
            this.lbl_ProductInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ProductInfo.Name = "lbl_ProductInfo";
            this.lbl_ProductInfo.Size = new System.Drawing.Size(378, 36);
            this.lbl_ProductInfo.TabIndex = 12;
            this.lbl_ProductInfo.Text = "Enter ID and Quantity to order more of a product.\r\nEnter all fields to Update a p" +
    "roduct.";
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.FormattingEnabled = true;
            this.txt_ProductID.Location = new System.Drawing.Point(240, 124);
            this.txt_ProductID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(181, 24);
            this.txt_ProductID.TabIndex = 13;
            this.txt_ProductID.SelectedIndexChanged += new System.EventHandler(this.txt_ProductID_SelectedIndexChanged);
            // 
            // txt_ProductMaterials
            // 
            this.txt_ProductMaterials.Location = new System.Drawing.Point(53, 268);
            this.txt_ProductMaterials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ProductMaterials.Name = "txt_ProductMaterials";
            this.txt_ProductMaterials.ReadOnly = true;
            this.txt_ProductMaterials.Size = new System.Drawing.Size(367, 101);
            this.txt_ProductMaterials.TabIndex = 14;
            this.txt_ProductMaterials.Text = "";
            // 
            // pIdDataGridViewTextBoxColumn
            // 
            this.pIdDataGridViewTextBoxColumn.DataPropertyName = "pId";
            this.pIdDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.pIdDataGridViewTextBoxColumn.Name = "pIdDataGridViewTextBoxColumn";
            this.pIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.pIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // materialsStringDataGridViewTextBoxColumn
            // 
            this.materialsStringDataGridViewTextBoxColumn.DataPropertyName = "materialsString";
            this.materialsStringDataGridViewTextBoxColumn.HeaderText = "Materials in Product";
            this.materialsStringDataGridViewTextBoxColumn.Name = "materialsStringDataGridViewTextBoxColumn";
            this.materialsStringDataGridViewTextBoxColumn.Width = 200;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 50;
            // 
            // ViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.txt_ProductMaterials);
            this.Controls.Add(this.txt_ProductID);
            this.Controls.Add(this.lbl_ProductInfo);
            this.Controls.Add(this.btn_OrderProduct);
            this.Controls.Add(this.btn_UpdateProduct);
            this.Controls.Add(this.lbl_ProductQuantity);
            this.Controls.Add(this.lbl_ProductMaterials);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.lbl_ProductID);
            this.Controls.Add(this.txt_ProductQuantity);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.lbl_ViewProducts);
            this.Controls.Add(this.dataGrid_ViewProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(404, 92);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "View & Update Products";
            this.Load += new System.EventHandler(this.ViewProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSetProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_ViewProducts;
        private Login.WorkFlowDatabaseDataSetProducts workFlowDatabaseDataSetProducts;
        private System.Windows.Forms.BindingSource productTableBindingSource;
        private Login.WorkFlowDatabaseDataSetProductsTableAdapters.ProductTableTableAdapter productTableTableAdapter;
        private System.Windows.Forms.Label lbl_ViewProducts;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.TextBox txt_ProductQuantity;
        private System.Windows.Forms.Label lbl_ProductID;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_ProductMaterials;
        private System.Windows.Forms.Label lbl_ProductQuantity;
        private System.Windows.Forms.Button btn_UpdateProduct;
        private System.Windows.Forms.Button btn_OrderProduct;
        private System.Windows.Forms.Label lbl_ProductInfo;
        private System.Windows.Forms.ComboBox txt_ProductID;
        private System.Windows.Forms.RichTextBox txt_ProductMaterials;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialsStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}