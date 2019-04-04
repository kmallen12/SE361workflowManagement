namespace WorkFlowManagement
{
    partial class RouteProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteProducts));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRemoveDefects = new System.Windows.Forms.Button();
            this.btnSendToManu = new System.Windows.Forms.Button();
            this.btnAddToDefectsList = new System.Windows.Forms.Button();
            this.lstDefectedProd = new System.Windows.Forms.ListBox();
            this.lblProdIDDefected = new System.Windows.Forms.Label();
            this.cboxProdIDDefects = new System.Windows.Forms.ComboBox();
            this.btnRemoveQualified = new System.Windows.Forms.Button();
            this.btnSendToSales = new System.Windows.Forms.Button();
            this.btnAddToQualifiedList = new System.Windows.Forms.Button();
            this.lstQualifiedProd = new System.Windows.Forms.ListBox();
            this.lblProdIDQualified = new System.Windows.Forms.Label();
            this.cboxProdIDQualified = new System.Windows.Forms.ComboBox();
            this.dataGrid_ViewProducts = new System.Windows.Forms.DataGridView();
            this.pIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.workFlowDatabaseDataSet1 = new Login.WorkFlowDatabaseDataSet1();
            this.productTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workFlowDatabaseDataSetProducts = new Login.WorkFlowDatabaseDataSetProducts();
            this.lblSelectProdForManu = new System.Windows.Forms.Label();
            this.lblSelectProdForSales = new System.Windows.Forms.Label();
            this.productTableTableAdapter = new Login.WorkFlowDatabaseDataSetProductsTableAdapters.ProductTableTableAdapter();
            this.tableAdapterManager = new Login.WorkFlowDatabaseDataSetProductsTableAdapters.TableAdapterManager();
            this.productTableTableAdapter1 = new Login.WorkFlowDatabaseDataSet1TableAdapters.ProductTableTableAdapter();
            this.tableAdapterManager1 = new Login.WorkFlowDatabaseDataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSetProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(645, 410);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRemoveDefects
            // 
            this.btnRemoveDefects.Location = new System.Drawing.Point(60, 392);
            this.btnRemoveDefects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveDefects.Name = "btnRemoveDefects";
            this.btnRemoveDefects.Size = new System.Drawing.Size(68, 41);
            this.btnRemoveDefects.TabIndex = 32;
            this.btnRemoveDefects.Text = "Remove from list";
            this.btnRemoveDefects.UseVisualStyleBackColor = true;
            this.btnRemoveDefects.Click += new System.EventHandler(this.btnRemoveDefects_Click);
            // 
            // btnSendToManu
            // 
            this.btnSendToManu.Location = new System.Drawing.Point(153, 392);
            this.btnSendToManu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSendToManu.Name = "btnSendToManu";
            this.btnSendToManu.Size = new System.Drawing.Size(109, 41);
            this.btnSendToManu.TabIndex = 31;
            this.btnSendToManu.Text = "SEND ALL TO MANUFACTURING";
            this.btnSendToManu.UseVisualStyleBackColor = true;
            this.btnSendToManu.Click += new System.EventHandler(this.btnSendToManu_Click);
            // 
            // btnAddToDefectsList
            // 
            this.btnAddToDefectsList.Location = new System.Drawing.Point(202, 284);
            this.btnAddToDefectsList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddToDefectsList.Name = "btnAddToDefectsList";
            this.btnAddToDefectsList.Size = new System.Drawing.Size(68, 20);
            this.btnAddToDefectsList.TabIndex = 30;
            this.btnAddToDefectsList.Text = "Add to List";
            this.btnAddToDefectsList.UseVisualStyleBackColor = true;
            this.btnAddToDefectsList.Click += new System.EventHandler(this.btnAddToDefectsList_Click);
            // 
            // lstDefectedProd
            // 
            this.lstDefectedProd.FormattingEnabled = true;
            this.lstDefectedProd.Location = new System.Drawing.Point(24, 319);
            this.lstDefectedProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstDefectedProd.Name = "lstDefectedProd";
            this.lstDefectedProd.Size = new System.Drawing.Size(259, 69);
            this.lstDefectedProd.TabIndex = 29;
            // 
            // lblProdIDDefected
            // 
            this.lblProdIDDefected.AutoSize = true;
            this.lblProdIDDefected.Location = new System.Drawing.Point(22, 290);
            this.lblProdIDDefected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdIDDefected.Name = "lblProdIDDefected";
            this.lblProdIDDefected.Size = new System.Drawing.Size(58, 13);
            this.lblProdIDDefected.TabIndex = 28;
            this.lblProdIDDefected.Text = "Product ID";
            // 
            // cboxProdIDDefects
            // 
            this.cboxProdIDDefects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProdIDDefects.FormattingEnabled = true;
            this.cboxProdIDDefects.Location = new System.Drawing.Point(96, 284);
            this.cboxProdIDDefects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxProdIDDefects.Name = "cboxProdIDDefects";
            this.cboxProdIDDefects.Size = new System.Drawing.Size(92, 21);
            this.cboxProdIDDefects.TabIndex = 27;
            // 
            // btnRemoveQualified
            // 
            this.btnRemoveQualified.Location = new System.Drawing.Point(60, 184);
            this.btnRemoveQualified.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveQualified.Name = "btnRemoveQualified";
            this.btnRemoveQualified.Size = new System.Drawing.Size(68, 41);
            this.btnRemoveQualified.TabIndex = 26;
            this.btnRemoveQualified.Text = "Remove from list";
            this.btnRemoveQualified.UseVisualStyleBackColor = true;
            this.btnRemoveQualified.Click += new System.EventHandler(this.btnRemoveQualified_Click);
            // 
            // btnSendToSales
            // 
            this.btnSendToSales.Location = new System.Drawing.Point(173, 184);
            this.btnSendToSales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSendToSales.Name = "btnSendToSales";
            this.btnSendToSales.Size = new System.Drawing.Size(68, 41);
            this.btnSendToSales.TabIndex = 25;
            this.btnSendToSales.Text = "SEND ALL TO SALES";
            this.btnSendToSales.UseVisualStyleBackColor = true;
            this.btnSendToSales.Click += new System.EventHandler(this.btnSendToSales_Click);
            // 
            // btnAddToQualifiedList
            // 
            this.btnAddToQualifiedList.Location = new System.Drawing.Point(202, 76);
            this.btnAddToQualifiedList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddToQualifiedList.Name = "btnAddToQualifiedList";
            this.btnAddToQualifiedList.Size = new System.Drawing.Size(68, 20);
            this.btnAddToQualifiedList.TabIndex = 24;
            this.btnAddToQualifiedList.Text = "Add to List";
            this.btnAddToQualifiedList.UseVisualStyleBackColor = true;
            this.btnAddToQualifiedList.Click += new System.EventHandler(this.btnAddToQualifiedList_Click);
            // 
            // lstQualifiedProd
            // 
            this.lstQualifiedProd.FormattingEnabled = true;
            this.lstQualifiedProd.Location = new System.Drawing.Point(24, 110);
            this.lstQualifiedProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstQualifiedProd.Name = "lstQualifiedProd";
            this.lstQualifiedProd.Size = new System.Drawing.Size(259, 69);
            this.lstQualifiedProd.TabIndex = 23;
            // 
            // lblProdIDQualified
            // 
            this.lblProdIDQualified.AutoSize = true;
            this.lblProdIDQualified.Location = new System.Drawing.Point(22, 81);
            this.lblProdIDQualified.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdIDQualified.Name = "lblProdIDQualified";
            this.lblProdIDQualified.Size = new System.Drawing.Size(58, 13);
            this.lblProdIDQualified.TabIndex = 22;
            this.lblProdIDQualified.Text = "Product ID";
            // 
            // cboxProdIDQualified
            // 
            this.cboxProdIDQualified.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProdIDQualified.FormattingEnabled = true;
            this.cboxProdIDQualified.Location = new System.Drawing.Point(96, 76);
            this.cboxProdIDQualified.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxProdIDQualified.Name = "cboxProdIDQualified";
            this.cboxProdIDQualified.Size = new System.Drawing.Size(92, 21);
            this.cboxProdIDQualified.TabIndex = 21;
            // 
            // dataGrid_ViewProducts
            // 
            this.dataGrid_ViewProducts.AutoGenerateColumns = false;
            this.dataGrid_ViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_ViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.materialsStringDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.productStatusDataGridViewTextBoxColumn});
            this.dataGrid_ViewProducts.DataSource = this.productTableBindingSource1;
            this.dataGrid_ViewProducts.Location = new System.Drawing.Point(404, 24);
            this.dataGrid_ViewProducts.Name = "dataGrid_ViewProducts";
            this.dataGrid_ViewProducts.Size = new System.Drawing.Size(533, 364);
            this.dataGrid_ViewProducts.TabIndex = 20;
            // 
            // pIdDataGridViewTextBoxColumn
            // 
            this.pIdDataGridViewTextBoxColumn.DataPropertyName = "pId";
            this.pIdDataGridViewTextBoxColumn.HeaderText = "pId";
            this.pIdDataGridViewTextBoxColumn.Name = "pIdDataGridViewTextBoxColumn";
            this.pIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "productName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // materialsStringDataGridViewTextBoxColumn
            // 
            this.materialsStringDataGridViewTextBoxColumn.DataPropertyName = "materialsString";
            this.materialsStringDataGridViewTextBoxColumn.HeaderText = "materialsString";
            this.materialsStringDataGridViewTextBoxColumn.Name = "materialsStringDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // productStatusDataGridViewTextBoxColumn
            // 
            this.productStatusDataGridViewTextBoxColumn.DataPropertyName = "productStatus";
            this.productStatusDataGridViewTextBoxColumn.HeaderText = "productStatus";
            this.productStatusDataGridViewTextBoxColumn.Name = "productStatusDataGridViewTextBoxColumn";
            // 
            // productTableBindingSource1
            // 
            this.productTableBindingSource1.DataMember = "ProductTable";
            this.productTableBindingSource1.DataSource = this.workFlowDatabaseDataSet1;
            // 
            // workFlowDatabaseDataSet1
            // 
            this.workFlowDatabaseDataSet1.DataSetName = "WorkFlowDatabaseDataSet1";
            this.workFlowDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // lblSelectProdForManu
            // 
            this.lblSelectProdForManu.AutoSize = true;
            this.lblSelectProdForManu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectProdForManu.Location = new System.Drawing.Point(22, 257);
            this.lblSelectProdForManu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectProdForManu.Name = "lblSelectProdForManu";
            this.lblSelectProdForManu.Size = new System.Drawing.Size(380, 17);
            this.lblSelectProdForManu.TabIndex = 19;
            this.lblSelectProdForManu.Text = "Select Defected Products to Send to Manufacturing";
            // 
            // lblSelectProdForSales
            // 
            this.lblSelectProdForSales.AutoSize = true;
            this.lblSelectProdForSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectProdForSales.Location = new System.Drawing.Point(22, 45);
            this.lblSelectProdForSales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectProdForSales.Name = "lblSelectProdForSales";
            this.lblSelectProdForSales.Size = new System.Drawing.Size(317, 17);
            this.lblSelectProdForSales.TabIndex = 18;
            this.lblSelectProdForSales.Text = "Select Qualified Products to Send to Sales";
            // 
            // productTableTableAdapter
            // 
            this.productTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductTableTableAdapter = this.productTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Login.WorkFlowDatabaseDataSetProductsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productTableTableAdapter1
            // 
            this.productTableTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ProductTableTableAdapter = this.productTableTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Login.WorkFlowDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // RouteProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 465);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRemoveDefects);
            this.Controls.Add(this.btnSendToManu);
            this.Controls.Add(this.btnAddToDefectsList);
            this.Controls.Add(this.lstDefectedProd);
            this.Controls.Add(this.lblProdIDDefected);
            this.Controls.Add(this.cboxProdIDDefects);
            this.Controls.Add(this.btnRemoveQualified);
            this.Controls.Add(this.btnSendToSales);
            this.Controls.Add(this.btnAddToQualifiedList);
            this.Controls.Add(this.lstQualifiedProd);
            this.Controls.Add(this.lblProdIDQualified);
            this.Controls.Add(this.cboxProdIDQualified);
            this.Controls.Add(this.dataGrid_ViewProducts);
            this.Controls.Add(this.lblSelectProdForManu);
            this.Controls.Add(this.lblSelectProdForSales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RouteProducts";
            this.Text = "RouteProducts";
            this.Load += new System.EventHandler(this.RouteProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSetProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRemoveDefects;
        private System.Windows.Forms.Button btnSendToManu;
        private System.Windows.Forms.Button btnAddToDefectsList;
        private System.Windows.Forms.ListBox lstDefectedProd;
        private System.Windows.Forms.Label lblProdIDDefected;
        private System.Windows.Forms.ComboBox cboxProdIDDefects;
        private System.Windows.Forms.Button btnRemoveQualified;
        private System.Windows.Forms.Button btnSendToSales;
        private System.Windows.Forms.Button btnAddToQualifiedList;
        private System.Windows.Forms.ListBox lstQualifiedProd;
        private System.Windows.Forms.Label lblProdIDQualified;
        private System.Windows.Forms.ComboBox cboxProdIDQualified;
        private System.Windows.Forms.DataGridView dataGrid_ViewProducts;
        private System.Windows.Forms.Label lblSelectProdForManu;
        private System.Windows.Forms.Label lblSelectProdForSales;
        private Login.WorkFlowDatabaseDataSetProducts workFlowDatabaseDataSetProducts;
        private System.Windows.Forms.BindingSource productTableBindingSource;
        private Login.WorkFlowDatabaseDataSetProductsTableAdapters.ProductTableTableAdapter productTableTableAdapter;
        private Login.WorkFlowDatabaseDataSetProductsTableAdapters.TableAdapterManager tableAdapterManager;
        private Login.WorkFlowDatabaseDataSet1 workFlowDatabaseDataSet1;
        private System.Windows.Forms.BindingSource productTableBindingSource1;
        private Login.WorkFlowDatabaseDataSet1TableAdapters.ProductTableTableAdapter productTableTableAdapter1;
        private Login.WorkFlowDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialsStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStatusDataGridViewTextBoxColumn;
    }
}