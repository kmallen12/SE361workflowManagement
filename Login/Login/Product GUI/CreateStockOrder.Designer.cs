namespace WorkFlowManagement
{
    partial class CreateStockOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateStockOrder));
            this.ProductOrderInfo_lbl = new System.Windows.Forms.Label();
            this.Confirm_btn = new System.Windows.Forms.Button();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Discription_text = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockSummaryViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workFlowDatabaseDataSet = new Login.WorkFlowDatabaseDataSet();
            this.stockTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workFlowDatabaseDataSetProducts = new Login.WorkFlowDatabaseDataSetProducts();
            this.productTableTableAdapter = new Login.WorkFlowDatabaseDataSetProductsTableAdapters.ProductTableTableAdapter();
            this.listBox_StockOrders = new System.Windows.Forms.ListBox();
            this.btn_AddOrderToList = new System.Windows.Forms.Button();
            this.stockTableTableAdapter = new Login.WorkFlowDatabaseDataSetTableAdapters.StockTableTableAdapter();
            this.stockTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.stockSummaryViewTableAdapter = new Login.WorkFlowDatabaseDataSetTableAdapters.StockSummaryViewTableAdapter();
            this.tableAdapterManager = new Login.WorkFlowDatabaseDataSetTableAdapters.TableAdapterManager();
            this.cboxMaterial = new System.Windows.Forms.ComboBox();
            this.Amount_Text = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockSummaryViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSetProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amount_Text)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductOrderInfo_lbl
            // 
            this.ProductOrderInfo_lbl.AutoSize = true;
            this.ProductOrderInfo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductOrderInfo_lbl.Location = new System.Drawing.Point(7, 45);
            this.ProductOrderInfo_lbl.MaximumSize = new System.Drawing.Size(320, 120);
            this.ProductOrderInfo_lbl.Name = "ProductOrderInfo_lbl";
            this.ProductOrderInfo_lbl.Size = new System.Drawing.Size(301, 100);
            this.ProductOrderInfo_lbl.TabIndex = 1;
            this.ProductOrderInfo_lbl.Text = "Send a request to the Stock Manager for more materials. Indicate the material typ" +
    "e and quantity below.";
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_btn.Location = new System.Drawing.Point(7, 538);
            this.Confirm_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(300, 71);
            this.Confirm_btn.TabIndex = 3;
            this.Confirm_btn.Text = "Send List To Stock Manager";
            this.Confirm_btn.UseVisualStyleBackColor = true;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.Location = new System.Drawing.Point(7, 176);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(96, 25);
            this.lblMaterial.TabIndex = 4;
            this.lblMaterial.Text = "Material:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Request Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity:";
            // 
            // Discription_text
            // 
            this.Discription_text.Location = new System.Drawing.Point(7, 312);
            this.Discription_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Discription_text.Multiline = true;
            this.Discription_text.Name = "Discription_text";
            this.Discription_text.Size = new System.Drawing.Size(300, 120);
            this.Discription_text.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialTypeDataGridViewTextBoxColumn,
            this.sumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stockSummaryViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1005, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(580, 587);
            this.dataGridView1.TabIndex = 9;
            // 
            // materialTypeDataGridViewTextBoxColumn
            // 
            this.materialTypeDataGridViewTextBoxColumn.DataPropertyName = "materialType";
            this.materialTypeDataGridViewTextBoxColumn.HeaderText = "Material";
            this.materialTypeDataGridViewTextBoxColumn.Name = "materialTypeDataGridViewTextBoxColumn";
            this.materialTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "Sum";
            this.sumDataGridViewTextBoxColumn.HeaderText = "Total in Stock";
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
            // stockTableBindingSource
            // 
            this.stockTableBindingSource.DataMember = "StockTable";
            this.stockTableBindingSource.DataSource = this.workFlowDatabaseDataSet;
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
            // listBox_StockOrders
            // 
            this.listBox_StockOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_StockOrders.FormattingEnabled = true;
            this.listBox_StockOrders.ItemHeight = 20;
            this.listBox_StockOrders.Location = new System.Drawing.Point(317, 45);
            this.listBox_StockOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_StockOrders.MaximumSize = new System.Drawing.Size(672, 575);
            this.listBox_StockOrders.Name = "listBox_StockOrders";
            this.listBox_StockOrders.Size = new System.Drawing.Size(672, 564);
            this.listBox_StockOrders.TabIndex = 10;
            // 
            // btn_AddOrderToList
            // 
            this.btn_AddOrderToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddOrderToList.Location = new System.Drawing.Point(7, 447);
            this.btn_AddOrderToList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddOrderToList.Name = "btn_AddOrderToList";
            this.btn_AddOrderToList.Size = new System.Drawing.Size(300, 71);
            this.btn_AddOrderToList.TabIndex = 11;
            this.btn_AddOrderToList.Text = "Add Order To List";
            this.btn_AddOrderToList.UseVisualStyleBackColor = true;
            this.btn_AddOrderToList.Click += new System.EventHandler(this.btn_AddOrderToList_Click);
            // 
            // stockTableTableAdapter
            // 
            this.stockTableTableAdapter.ClearBeforeFill = true;
            // 
            // stockTableBindingSource1
            // 
            this.stockTableBindingSource1.DataMember = "StockTable";
            this.stockTableBindingSource1.DataSource = this.workFlowDatabaseDataSet;
            // 
            // stockTableBindingSource2
            // 
            this.stockTableBindingSource2.DataMember = "StockTable";
            this.stockTableBindingSource2.DataSource = this.workFlowDatabaseDataSet;
            // 
            // stockSummaryViewTableAdapter
            // 
            this.stockSummaryViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductOrderRequestTableAdapter = null;
            this.tableAdapterManager.ProductStatusTableTableAdapter = null;
            this.tableAdapterManager.ProductTableTableAdapter = null;
            this.tableAdapterManager.RawMaterialsTableTableAdapter = null;
            this.tableAdapterManager.StockOrderRequestTableAdapter = null;
            this.tableAdapterManager.StockTableTableAdapter = this.stockTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Login.WorkFlowDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableTableAdapter = null;
            this.tableAdapterManager.UserTypeTableTableAdapter = null;
            this.tableAdapterManager.WareHouseTableTableAdapter = null;
            // 
            // cboxMaterial
            // 
            this.cboxMaterial.BackColor = System.Drawing.SystemColors.Menu;
            this.cboxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMaterial.FormattingEnabled = true;
            this.cboxMaterial.Location = new System.Drawing.Point(164, 176);
            this.cboxMaterial.Name = "cboxMaterial";
            this.cboxMaterial.Size = new System.Drawing.Size(143, 24);
            this.cboxMaterial.TabIndex = 12;
            // 
            // Amount_Text
            // 
            this.Amount_Text.Location = new System.Drawing.Point(164, 227);
            this.Amount_Text.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.Amount_Text.Name = "Amount_Text";
            this.Amount_Text.Size = new System.Drawing.Size(143, 22);
            this.Amount_Text.TabIndex = 13;
            // 
            // CreateStockOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 675);
            this.ControlBox = false;
            this.Controls.Add(this.Amount_Text);
            this.Controls.Add(this.cboxMaterial);
            this.Controls.Add(this.btn_AddOrderToList);
            this.Controls.Add(this.listBox_StockOrders);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Discription_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.Confirm_btn);
            this.Controls.Add(this.ProductOrderInfo_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(404, 92);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateStockOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CreateStockOrder";
            this.Load += new System.EventHandler(this.CreateProductOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockSummaryViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSetProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amount_Text)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label ProductOrderInfo_lbl;
        private System.Windows.Forms.Button Confirm_btn;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Discription_text;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Login.WorkFlowDatabaseDataSetProducts workFlowDatabaseDataSetProducts;
        private System.Windows.Forms.BindingSource productTableBindingSource;
        private Login.WorkFlowDatabaseDataSetProductsTableAdapters.ProductTableTableAdapter productTableTableAdapter;
        private System.Windows.Forms.ListBox listBox_StockOrders;
        private System.Windows.Forms.Button btn_AddOrderToList;
        private Login.WorkFlowDatabaseDataSet workFlowDatabaseDataSet;
        private System.Windows.Forms.BindingSource stockTableBindingSource;
        private Login.WorkFlowDatabaseDataSetTableAdapters.StockTableTableAdapter stockTableTableAdapter;
        private System.Windows.Forms.BindingSource stockTableBindingSource2;
        private System.Windows.Forms.BindingSource stockTableBindingSource1;
        private System.Windows.Forms.BindingSource stockSummaryViewBindingSource;
        private Login.WorkFlowDatabaseDataSetTableAdapters.StockSummaryViewTableAdapter stockSummaryViewTableAdapter;
        private Login.WorkFlowDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cboxMaterial;
        private System.Windows.Forms.NumericUpDown Amount_Text;
    }
}