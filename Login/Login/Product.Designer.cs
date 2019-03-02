namespace WorkFlowManagement
{
    partial class Product
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.txt_ProductQuantity = new System.Windows.Forms.TextBox();
            this.txt_MaterialID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_AddMaterialtoProduct = new System.Windows.Forms.Button();
            this.btn_FinalizeProduct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_MaterialQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Description_lbl = new System.Windows.Forms.Label();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create A New Product\r\n";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "ProductName";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "MaterialID";
            // 
            // txt_AddMaterialtoProduct
            // 
            this.txt_AddMaterialtoProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AddMaterialtoProduct.Location = new System.Drawing.Point(63, 308);
            this.txt_AddMaterialtoProduct.Name = "txt_AddMaterialtoProduct";
            this.txt_AddMaterialtoProduct.Size = new System.Drawing.Size(150, 50);
            this.txt_AddMaterialtoProduct.TabIndex = 9;
            this.txt_AddMaterialtoProduct.Text = "Add Material to Current Product";
            this.txt_AddMaterialtoProduct.UseVisualStyleBackColor = true;
            this.txt_AddMaterialtoProduct.Click += new System.EventHandler(this.txt_AddMaterialtoProduct_Click);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "MaterialAmount";
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
            // Description_lbl
            // 
            this.Description_lbl.AutoSize = true;
            this.Description_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_lbl.Location = new System.Drawing.Point(106, 423);
            this.Description_lbl.Name = "Description_lbl";
            this.Description_lbl.Size = new System.Drawing.Size(10, 24);
            this.Description_lbl.TabIndex = 14;
            this.Description_lbl.Text = "\r\n";
            // 
            // Product
            // 
            this.ClientSize = new System.Drawing.Size(797, 526);
            this.Controls.Add(this.Description_lbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_MaterialQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_FinalizeProduct);
            this.Controls.Add(this.txt_AddMaterialtoProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_MaterialID);
            this.Controls.Add(this.txt_ProductQuantity);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PartialStockGrid);
            this.Name = "Product";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.TextBox txt_ProductQuantity;
        private System.Windows.Forms.TextBox txt_MaterialID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button txt_AddMaterialtoProduct;
        private System.Windows.Forms.Button btn_FinalizeProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_MaterialQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Description_lbl;
    }
}