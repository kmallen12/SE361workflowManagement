namespace WorkFlowManagement
{
    partial class AddProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.PartialStockGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceStock = new System.Windows.Forms.BindingSource(this.components);
            this.workFlowDatabaseDataStock = new Login.WorkFlowDatabaseDataSet();
            this.stockTableTableAdapterPartial = new Login.WorkFlowDatabaseDataSetTableAdapters.StockTableTableAdapter();
            this.lbl_CreateANewProduct = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.txt_ProductQuantity = new System.Windows.Forms.TextBox();
            this.txt_MaterialID = new System.Windows.Forms.TextBox();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_MaterialID = new System.Windows.Forms.Label();
            this.btn_AddMaterialtoProduct = new System.Windows.Forms.Button();
            this.btn_FinalizeProduct = new System.Windows.Forms.Button();
            this.lbl_MaterialAmount = new System.Windows.Forms.Label();
            this.txt_MaterialQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.lbl_ProductID = new System.Windows.Forms.Label();
            this.lbl_OrderMoreProduct = new System.Windows.Forms.Label();
            this.btn_AdditionalProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PartialStockGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // PartialStockGrid
            // 
            this.PartialStockGrid.AutoGenerateColumns = false;
            this.PartialStockGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartialStockGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.PartialStockGrid.DataSource = this.bindingSourceStock;
            this.PartialStockGrid.Location = new System.Drawing.Point(451, 0);
            this.PartialStockGrid.Name = "PartialStockGrid";
            this.PartialStockGrid.Size = new System.Drawing.Size(345, 526);
            this.PartialStockGrid.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "itemID";
            this.dataGridViewTextBoxColumn1.HeaderText = "itemID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "materialType";
            this.dataGridViewTextBoxColumn2.HeaderText = "materialType";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // bindingSourceStock
            // 
            this.bindingSourceStock.DataMember = "StockTable";
            this.bindingSourceStock.DataSource = this.workFlowDatabaseDataStock;
            // 
            // workFlowDatabaseDataStock
            // 
            this.workFlowDatabaseDataStock.DataSetName = "WorkFlowDatabaseDataSet";
            this.workFlowDatabaseDataStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockTableTableAdapterPartial
            // 
            this.stockTableTableAdapterPartial.ClearBeforeFill = true;
            // 
            // lbl_CreateANewProduct
            // 
            this.lbl_CreateANewProduct.AutoSize = true;
            this.lbl_CreateANewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreateANewProduct.Location = new System.Drawing.Point(106, 9);
            this.lbl_CreateANewProduct.Name = "lbl_CreateANewProduct";
            this.lbl_CreateANewProduct.Size = new System.Drawing.Size(217, 24);
            this.lbl_CreateANewProduct.TabIndex = 1;
            this.lbl_CreateANewProduct.Text = "Create A New Product\r\n";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Location = new System.Drawing.Point(250, 78);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(100, 20);
            this.txt_ProductName.TabIndex = 2;
            // 
            // txt_ProductQuantity
            // 
            this.txt_ProductQuantity.Location = new System.Drawing.Point(250, 144);
            this.txt_ProductQuantity.Name = "txt_ProductQuantity";
            this.txt_ProductQuantity.Size = new System.Drawing.Size(100, 20);
            this.txt_ProductQuantity.TabIndex = 3;
            // 
            // txt_MaterialID
            // 
            this.txt_MaterialID.Location = new System.Drawing.Point(250, 206);
            this.txt_MaterialID.Name = "txt_MaterialID";
            this.txt_MaterialID.Size = new System.Drawing.Size(100, 20);
            this.txt_MaterialID.TabIndex = 4;
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductName.Location = new System.Drawing.Point(59, 76);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(117, 20);
            this.lbl_ProductName.TabIndex = 6;
            this.lbl_ProductName.Text = "ProductName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "ProductQuantity";
            // 
            // lbl_MaterialID
            // 
            this.lbl_MaterialID.AutoSize = true;
            this.lbl_MaterialID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaterialID.Location = new System.Drawing.Point(59, 204);
            this.lbl_MaterialID.Name = "lbl_MaterialID";
            this.lbl_MaterialID.Size = new System.Drawing.Size(92, 20);
            this.lbl_MaterialID.TabIndex = 8;
            this.lbl_MaterialID.Text = "MaterialID";
            // 
            // btn_AddMaterialtoProduct
            // 
            this.btn_AddMaterialtoProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddMaterialtoProduct.Location = new System.Drawing.Point(63, 308);
            this.btn_AddMaterialtoProduct.Name = "btn_AddMaterialtoProduct";
            this.btn_AddMaterialtoProduct.Size = new System.Drawing.Size(150, 50);
            this.btn_AddMaterialtoProduct.TabIndex = 9;
            this.btn_AddMaterialtoProduct.Text = "Add Material to Current Product";
            this.btn_AddMaterialtoProduct.UseVisualStyleBackColor = true;
            this.btn_AddMaterialtoProduct.Click += new System.EventHandler(this.btn_AddMaterialtoProduct_Click);
            // 
            // btn_FinalizeProduct
            // 
            this.btn_FinalizeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FinalizeProduct.Location = new System.Drawing.Point(250, 308);
            this.btn_FinalizeProduct.Name = "btn_FinalizeProduct";
            this.btn_FinalizeProduct.Size = new System.Drawing.Size(150, 50);
            this.btn_FinalizeProduct.TabIndex = 10;
            this.btn_FinalizeProduct.Text = "Finalize Product";
            this.btn_FinalizeProduct.UseVisualStyleBackColor = true;
            this.btn_FinalizeProduct.Click += new System.EventHandler(this.btn_FinalizeProduct_Click);
            // 
            // lbl_MaterialAmount
            // 
            this.lbl_MaterialAmount.AutoSize = true;
            this.lbl_MaterialAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaterialAmount.Location = new System.Drawing.Point(59, 267);
            this.lbl_MaterialAmount.Name = "lbl_MaterialAmount";
            this.lbl_MaterialAmount.Size = new System.Drawing.Size(135, 20);
            this.lbl_MaterialAmount.TabIndex = 11;
            this.lbl_MaterialAmount.Text = "MaterialAmount";
            // 
            // txt_MaterialQuantity
            // 
            this.txt_MaterialQuantity.Location = new System.Drawing.Point(250, 269);
            this.txt_MaterialQuantity.Name = "txt_MaterialQuantity";
            this.txt_MaterialQuantity.Size = new System.Drawing.Size(100, 20);
            this.txt_MaterialQuantity.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(316, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Product Description(ID, Amount):";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(106, 423);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(10, 24);
            this.lbl_Description.TabIndex = 14;
            this.lbl_Description.Text = "\r\n";
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.Location = new System.Drawing.Point(250, 104);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(100, 20);
            this.txt_ProductID.TabIndex = 15;
            this.txt_ProductID.Visible = false;
            this.txt_ProductID.WordWrap = false;
            // 
            // lbl_ProductID
            // 
            this.lbl_ProductID.AutoSize = true;
            this.lbl_ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductID.Location = new System.Drawing.Point(59, 104);
            this.lbl_ProductID.Name = "lbl_ProductID";
            this.lbl_ProductID.Size = new System.Drawing.Size(90, 20);
            this.lbl_ProductID.TabIndex = 16;
            this.lbl_ProductID.Text = "ProductID";
            this.lbl_ProductID.Visible = false;
            // 
            // lbl_OrderMoreProduct
            // 
            this.lbl_OrderMoreProduct.AutoSize = true;
            this.lbl_OrderMoreProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderMoreProduct.Location = new System.Drawing.Point(106, 33);
            this.lbl_OrderMoreProduct.Name = "lbl_OrderMoreProduct";
            this.lbl_OrderMoreProduct.Size = new System.Drawing.Size(196, 24);
            this.lbl_OrderMoreProduct.TabIndex = 17;
            this.lbl_OrderMoreProduct.Text = "Order More Product";
            this.lbl_OrderMoreProduct.Visible = false;
            // 
            // btn_AdditionalProduct
            // 
            this.btn_AdditionalProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdditionalProduct.Location = new System.Drawing.Point(141, 308);
            this.btn_AdditionalProduct.Name = "btn_AdditionalProduct";
            this.btn_AdditionalProduct.Size = new System.Drawing.Size(150, 50);
            this.btn_AdditionalProduct.TabIndex = 18;
            this.btn_AdditionalProduct.Text = "Order Additional Product";
            this.btn_AdditionalProduct.UseVisualStyleBackColor = true;
            this.btn_AdditionalProduct.Visible = false;
            this.btn_AdditionalProduct.Click += new System.EventHandler(this.btn_AdditionalProduct_Click);
            // 
            // AddProduct
            // 
            this.ClientSize = new System.Drawing.Size(797, 526);
            this.Controls.Add(this.btn_AdditionalProduct);
            this.Controls.Add(this.lbl_OrderMoreProduct);
            this.Controls.Add(this.lbl_ProductID);
            this.Controls.Add(this.txt_ProductID);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_MaterialQuantity);
            this.Controls.Add(this.lbl_MaterialAmount);
            this.Controls.Add(this.btn_FinalizeProduct);
            this.Controls.Add(this.btn_AddMaterialtoProduct);
            this.Controls.Add(this.lbl_MaterialID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.txt_MaterialID);
            this.Controls.Add(this.txt_ProductQuantity);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.lbl_CreateANewProduct);
            this.Controls.Add(this.PartialStockGrid);
            this.Name = "AddProduct";
            this.Load += new System.EventHandler(this.Product_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.PartialStockGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Prod_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridPartialStock;
        private System.Windows.Forms.BindingSource workFlowDatabaseDataSetBindingSource;

        private System.Windows.Forms.BindingSource stockTableBindingSource;

        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;

        private System.Windows.Forms.DataGridView PartialStockGrid;
        private Login.WorkFlowDatabaseDataSet workFlowDatabaseDataStock;
        private System.Windows.Forms.BindingSource bindingSourceStock;
        private Login.WorkFlowDatabaseDataSetTableAdapters.StockTableTableAdapter stockTableTableAdapterPartial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lbl_CreateANewProduct;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.TextBox txt_ProductQuantity;
        private System.Windows.Forms.TextBox txt_MaterialID;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_MaterialID;
        private System.Windows.Forms.Button btn_AddMaterialtoProduct;
        private System.Windows.Forms.Button btn_FinalizeProduct;
        private System.Windows.Forms.Label lbl_MaterialAmount;
        private System.Windows.Forms.TextBox txt_MaterialQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TextBox txt_ProductID;
        private System.Windows.Forms.Label lbl_ProductID;
        private System.Windows.Forms.Label lbl_OrderMoreProduct;
        private System.Windows.Forms.Button btn_AdditionalProduct;
    }
}