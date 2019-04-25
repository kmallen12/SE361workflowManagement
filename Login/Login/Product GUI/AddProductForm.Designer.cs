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
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockSummaryViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workFlowDatabaseDataSet = new Login.WorkFlowDatabaseDataSet();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.txt_ProductQuantity = new System.Windows.Forms.TextBox();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_MaterialID = new System.Windows.Forms.Label();
            this.btn_AddMaterialtoProduct = new System.Windows.Forms.Button();
            this.btn_FinalizeProduct = new System.Windows.Forms.Button();
            this.lbl_MaterialAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.lbl_ProductID = new System.Windows.Forms.Label();
            this.lbl_OrderMoreProduct = new System.Windows.Forms.Label();
            this.btn_AdditionalProduct = new System.Windows.Forms.Button();
            this.txt_MaterialQuantity = new System.Windows.Forms.NumericUpDown();
            this.txt_Material = new System.Windows.Forms.ComboBox();
            this.stockSummaryViewTableAdapter = new Login.WorkFlowDatabaseDataSetTableAdapters.StockSummaryViewTableAdapter();
            this.tableAdapterManager = new Login.WorkFlowDatabaseDataSetTableAdapters.TableAdapterManager();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PartialStockGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockSummaryViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaterialQuantity)).BeginInit();
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
            this.sumDataGridViewTextBoxColumn});
            this.PartialStockGrid.DataSource = this.stockSummaryViewBindingSource;
            this.PartialStockGrid.Location = new System.Drawing.Point(761, 94);
            this.PartialStockGrid.Margin = new System.Windows.Forms.Padding(4);
            this.PartialStockGrid.Name = "PartialStockGrid";
            this.PartialStockGrid.Size = new System.Drawing.Size(460, 700);
            this.PartialStockGrid.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "materialType";
            this.dataGridViewTextBoxColumn1.HeaderText = "Material";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "Sum";
            this.sumDataGridViewTextBoxColumn.HeaderText = "Total Quantity";
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            // 
            // stockSummaryViewBindingSource
            // 
            this.stockSummaryViewBindingSource.DataMember = "StockSummaryView";
            this.stockSummaryViewBindingSource.DataSource = this.workFlowDatabaseDataSet;
            // 
            // workFlowDatabaseDataSet
            // 
            this.workFlowDatabaseDataSet.DataSetName = "WorkFlowDatabaseDataSet";
            this.workFlowDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(141, 11);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(271, 29);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Create A New Product\r\n";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Location = new System.Drawing.Point(333, 96);
            this.txt_ProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(132, 22);
            this.txt_ProductName.TabIndex = 2;
            // 
            // txt_ProductQuantity
            // 
            this.txt_ProductQuantity.Location = new System.Drawing.Point(333, 177);
            this.txt_ProductQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ProductQuantity.Name = "txt_ProductQuantity";
            this.txt_ProductQuantity.Size = new System.Drawing.Size(132, 22);
            this.txt_ProductQuantity.TabIndex = 3;
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductName.Location = new System.Drawing.Point(79, 94);
            this.lbl_ProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(148, 25);
            this.lbl_ProductName.TabIndex = 6;
            this.lbl_ProductName.Text = "Product Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Product Quantity";
            // 
            // lbl_MaterialID
            // 
            this.lbl_MaterialID.AutoSize = true;
            this.lbl_MaterialID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaterialID.Location = new System.Drawing.Point(79, 251);
            this.lbl_MaterialID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaterialID.Name = "lbl_MaterialID";
            this.lbl_MaterialID.Size = new System.Drawing.Size(89, 25);
            this.lbl_MaterialID.TabIndex = 8;
            this.lbl_MaterialID.Text = "Material";
            // 
            // btn_AddMaterialtoProduct
            // 
            this.btn_AddMaterialtoProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddMaterialtoProduct.Location = new System.Drawing.Point(84, 379);
            this.btn_AddMaterialtoProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddMaterialtoProduct.Name = "btn_AddMaterialtoProduct";
            this.btn_AddMaterialtoProduct.Size = new System.Drawing.Size(200, 62);
            this.btn_AddMaterialtoProduct.TabIndex = 9;
            this.btn_AddMaterialtoProduct.Text = "Add Material to Current Product";
            this.btn_AddMaterialtoProduct.UseVisualStyleBackColor = true;
            this.btn_AddMaterialtoProduct.Click += new System.EventHandler(this.btn_AddMaterialtoProduct_Click);
            // 
            // btn_FinalizeProduct
            // 
            this.btn_FinalizeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FinalizeProduct.Location = new System.Drawing.Point(333, 379);
            this.btn_FinalizeProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btn_FinalizeProduct.Name = "btn_FinalizeProduct";
            this.btn_FinalizeProduct.Size = new System.Drawing.Size(200, 62);
            this.btn_FinalizeProduct.TabIndex = 10;
            this.btn_FinalizeProduct.Text = "Finalize Product";
            this.btn_FinalizeProduct.UseVisualStyleBackColor = true;
            this.btn_FinalizeProduct.Click += new System.EventHandler(this.btn_FinalizeProduct_Click);
            // 
            // lbl_MaterialAmount
            // 
            this.lbl_MaterialAmount.AutoSize = true;
            this.lbl_MaterialAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaterialAmount.Location = new System.Drawing.Point(79, 329);
            this.lbl_MaterialAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaterialAmount.Name = "lbl_MaterialAmount";
            this.lbl_MaterialAmount.Size = new System.Drawing.Size(169, 25);
            this.lbl_MaterialAmount.TabIndex = 11;
            this.lbl_MaterialAmount.Text = "Material Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 460);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(320, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Materials (Type, Quantity):";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(79, 501);
            this.lbl_Description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(13, 29);
            this.lbl_Description.TabIndex = 14;
            this.lbl_Description.Text = "\r\n";
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.Location = new System.Drawing.Point(333, 128);
            this.txt_ProductID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(132, 22);
            this.txt_ProductID.TabIndex = 15;
            this.txt_ProductID.Visible = false;
            this.txt_ProductID.WordWrap = false;
            // 
            // lbl_ProductID
            // 
            this.lbl_ProductID.AutoSize = true;
            this.lbl_ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductID.Location = new System.Drawing.Point(79, 128);
            this.lbl_ProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ProductID.Name = "lbl_ProductID";
            this.lbl_ProductID.Size = new System.Drawing.Size(113, 25);
            this.lbl_ProductID.TabIndex = 16;
            this.lbl_ProductID.Text = "Product ID";
            this.lbl_ProductID.Visible = false;
            // 
            // lbl_OrderMoreProduct
            // 
            this.lbl_OrderMoreProduct.AutoSize = true;
            this.lbl_OrderMoreProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderMoreProduct.Location = new System.Drawing.Point(141, 41);
            this.lbl_OrderMoreProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OrderMoreProduct.Name = "lbl_OrderMoreProduct";
            this.lbl_OrderMoreProduct.Size = new System.Drawing.Size(245, 29);
            this.lbl_OrderMoreProduct.TabIndex = 17;
            this.lbl_OrderMoreProduct.Text = "Order More Product";
            this.lbl_OrderMoreProduct.Visible = false;
            // 
            // btn_AdditionalProduct
            // 
            this.btn_AdditionalProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdditionalProduct.Location = new System.Drawing.Point(188, 379);
            this.btn_AdditionalProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AdditionalProduct.Name = "btn_AdditionalProduct";
            this.btn_AdditionalProduct.Size = new System.Drawing.Size(200, 62);
            this.btn_AdditionalProduct.TabIndex = 18;
            this.btn_AdditionalProduct.Text = "Order Additional Product";
            this.btn_AdditionalProduct.UseVisualStyleBackColor = true;
            this.btn_AdditionalProduct.Visible = false;
            this.btn_AdditionalProduct.Click += new System.EventHandler(this.btn_AdditionalProduct_Click);
            // 
            // txt_MaterialQuantity
            // 
            this.txt_MaterialQuantity.Location = new System.Drawing.Point(333, 329);
            this.txt_MaterialQuantity.Name = "txt_MaterialQuantity";
            this.txt_MaterialQuantity.Size = new System.Drawing.Size(132, 22);
            this.txt_MaterialQuantity.TabIndex = 19;
            // 
            // txt_Material
            // 
            this.txt_Material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_Material.FormattingEnabled = true;
            this.txt_Material.Location = new System.Drawing.Point(333, 251);
            this.txt_Material.Name = "txt_Material";
            this.txt_Material.Size = new System.Drawing.Size(132, 24);
            this.txt_Material.TabIndex = 20;
            // 
            // stockSummaryViewTableAdapter
            // 
            this.stockSummaryViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ProductOrderRequestTableAdapter = null;
            this.tableAdapterManager.ProductStatusTableTableAdapter = null;
            this.tableAdapterManager.ProductTableTableAdapter = null;
            this.tableAdapterManager.RawMaterialsTableTableAdapter = null;
            this.tableAdapterManager.StockOrderRequestTableAdapter = null;
            this.tableAdapterManager.StockTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Login.WorkFlowDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableTableAdapter = null;
            this.tableAdapterManager.UserTypeTableTableAdapter = null;
            this.tableAdapterManager.WareHouseTableTableAdapter = null;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(188, 718);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 62);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1220, 793);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txt_Material);
            this.Controls.Add(this.txt_MaterialQuantity);
            this.Controls.Add(this.btn_AdditionalProduct);
            this.Controls.Add(this.lbl_OrderMoreProduct);
            this.Controls.Add(this.lbl_ProductID);
            this.Controls.Add(this.txt_ProductID);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_MaterialAmount);
            this.Controls.Add(this.btn_FinalizeProduct);
            this.Controls.Add(this.btn_AddMaterialtoProduct);
            this.Controls.Add(this.lbl_MaterialID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.txt_ProductQuantity);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.PartialStockGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(404, 92);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PartialStockGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockSummaryViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaterialQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DataGridView PartialStockGrid;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.TextBox txt_ProductQuantity;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_MaterialID;
        private System.Windows.Forms.Button btn_AddMaterialtoProduct;
        private System.Windows.Forms.Button btn_FinalizeProduct;
        private System.Windows.Forms.Label lbl_MaterialAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ProductID;
        private System.Windows.Forms.Label lbl_ProductID;
        private System.Windows.Forms.Label lbl_OrderMoreProduct;
        private System.Windows.Forms.Button btn_AdditionalProduct;
        public System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.NumericUpDown txt_MaterialQuantity;
        private System.Windows.Forms.ComboBox txt_Material;
        private Login.WorkFlowDatabaseDataSet workFlowDatabaseDataSet;
        private System.Windows.Forms.BindingSource stockSummaryViewBindingSource;
        private Login.WorkFlowDatabaseDataSetTableAdapters.StockSummaryViewTableAdapter stockSummaryViewTableAdapter;
        private Login.WorkFlowDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCancel;
    }
}