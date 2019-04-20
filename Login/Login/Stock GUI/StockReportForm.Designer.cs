namespace WorkFlowManagement
{
    partial class StockReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockReportForm));
            this.lbl_lowInventory = new System.Windows.Forms.Label();
            this.lbl_maxCapacity = new System.Windows.Forms.Label();
            this.dataGridViewLow = new System.Windows.Forms.DataGridView();
            this.btnChangeDefaults = new System.Windows.Forms.Button();
            this.dataGridViewMax = new System.Windows.Forms.DataGridView();
            this.workFlowDatabaseDataSet3 = new Login.WorkFlowDatabaseDataSet3();
            this.stockReportLowCapacityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockReportLowCapacityTableAdapter = new Login.WorkFlowDatabaseDataSet3TableAdapters.StockReportLowCapacityTableAdapter();
            this.tableAdapterManager = new Login.WorkFlowDatabaseDataSet3TableAdapters.TableAdapterManager();
            this.stockReportMaxCapacityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockReportMaxCapacityTableAdapter = new Login.WorkFlowDatabaseDataSet3TableAdapters.StockReportMaxCapacityTableAdapter();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockReportLowCapacityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockReportMaxCapacityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_lowInventory
            // 
            this.lbl_lowInventory.AutoSize = true;
            this.lbl_lowInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lowInventory.Location = new System.Drawing.Point(49, 62);
            this.lbl_lowInventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lowInventory.Name = "lbl_lowInventory";
            this.lbl_lowInventory.Size = new System.Drawing.Size(243, 24);
            this.lbl_lowInventory.TabIndex = 1;
            this.lbl_lowInventory.Text = "Items with Low Inventory:";
            // 
            // lbl_maxCapacity
            // 
            this.lbl_maxCapacity.AutoSize = true;
            this.lbl_maxCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maxCapacity.Location = new System.Drawing.Point(556, 62);
            this.lbl_maxCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_maxCapacity.Name = "lbl_maxCapacity";
            this.lbl_maxCapacity.Size = new System.Drawing.Size(296, 24);
            this.lbl_maxCapacity.TabIndex = 2;
            this.lbl_maxCapacity.Text = "Items Reaching Max Capacity: ";
            // 
            // dataGridViewLow
            // 
            this.dataGridViewLow.AllowUserToAddRows = false;
            this.dataGridViewLow.AllowUserToDeleteRows = false;
            this.dataGridViewLow.AutoGenerateColumns = false;
            this.dataGridViewLow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.materialTypeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.lowDataGridViewTextBoxColumn});
            this.dataGridViewLow.DataSource = this.stockReportLowCapacityBindingSource;
            this.dataGridViewLow.Location = new System.Drawing.Point(40, 105);
            this.dataGridViewLow.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewLow.Name = "dataGridViewLow";
            this.dataGridViewLow.ReadOnly = true;
            this.dataGridViewLow.Size = new System.Drawing.Size(458, 426);
            this.dataGridViewLow.TabIndex = 3;
            // 
            // btnChangeDefaults
            // 
            this.btnChangeDefaults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeDefaults.Location = new System.Drawing.Point(349, 12);
            this.btnChangeDefaults.Name = "btnChangeDefaults";
            this.btnChangeDefaults.Size = new System.Drawing.Size(276, 41);
            this.btnChangeDefaults.TabIndex = 6;
            this.btnChangeDefaults.Text = "Change Item Defaults";
            this.btnChangeDefaults.UseVisualStyleBackColor = true;
            this.btnChangeDefaults.Click += new System.EventHandler(this.btnChangeDefaults_Click);
            // 
            // dataGridViewMax
            // 
            this.dataGridViewMax.AllowUserToAddRows = false;
            this.dataGridViewMax.AllowUserToDeleteRows = false;
            this.dataGridViewMax.AutoGenerateColumns = false;
            this.dataGridViewMax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMax.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn1,
            this.materialTypeDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn1,
            this.maxDataGridViewTextBoxColumn});
            this.dataGridViewMax.DataSource = this.stockReportMaxCapacityBindingSource;
            this.dataGridViewMax.Location = new System.Drawing.Point(560, 105);
            this.dataGridViewMax.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMax.Name = "dataGridViewMax";
            this.dataGridViewMax.ReadOnly = true;
            this.dataGridViewMax.Size = new System.Drawing.Size(457, 426);
            this.dataGridViewMax.TabIndex = 4;
            // 
            // workFlowDatabaseDataSet3
            // 
            this.workFlowDatabaseDataSet3.DataSetName = "WorkFlowDatabaseDataSet3";
            this.workFlowDatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockReportLowCapacityBindingSource
            // 
            this.stockReportLowCapacityBindingSource.DataMember = "StockReportLowCapacity";
            this.stockReportLowCapacityBindingSource.DataSource = this.workFlowDatabaseDataSet3;
            // 
            // stockReportLowCapacityTableAdapter
            // 
            this.stockReportLowCapacityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Login.WorkFlowDatabaseDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stockReportMaxCapacityBindingSource
            // 
            this.stockReportMaxCapacityBindingSource.DataMember = "StockReportMaxCapacity";
            this.stockReportMaxCapacityBindingSource.DataSource = this.workFlowDatabaseDataSet3;
            // 
            // stockReportMaxCapacityTableAdapter
            // 
            this.stockReportMaxCapacityTableAdapter.ClearBeforeFill = true;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "itemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "Item ID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // materialTypeDataGridViewTextBoxColumn
            // 
            this.materialTypeDataGridViewTextBoxColumn.DataPropertyName = "materialType";
            this.materialTypeDataGridViewTextBoxColumn.HeaderText = "Material Type";
            this.materialTypeDataGridViewTextBoxColumn.Name = "materialTypeDataGridViewTextBoxColumn";
            this.materialTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialTypeDataGridViewTextBoxColumn.Width = 110;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 75;
            // 
            // lowDataGridViewTextBoxColumn
            // 
            this.lowDataGridViewTextBoxColumn.DataPropertyName = "Low";
            this.lowDataGridViewTextBoxColumn.HeaderText = "Low Inventory Threshold";
            this.lowDataGridViewTextBoxColumn.Name = "lowDataGridViewTextBoxColumn";
            this.lowDataGridViewTextBoxColumn.ReadOnly = true;
            this.lowDataGridViewTextBoxColumn.Width = 75;
            // 
            // itemIDDataGridViewTextBoxColumn1
            // 
            this.itemIDDataGridViewTextBoxColumn1.DataPropertyName = "itemID";
            this.itemIDDataGridViewTextBoxColumn1.HeaderText = "Item ID";
            this.itemIDDataGridViewTextBoxColumn1.Name = "itemIDDataGridViewTextBoxColumn1";
            this.itemIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.itemIDDataGridViewTextBoxColumn1.Width = 50;
            // 
            // materialTypeDataGridViewTextBoxColumn1
            // 
            this.materialTypeDataGridViewTextBoxColumn1.DataPropertyName = "materialType";
            this.materialTypeDataGridViewTextBoxColumn1.HeaderText = "Material Type";
            this.materialTypeDataGridViewTextBoxColumn1.Name = "materialTypeDataGridViewTextBoxColumn1";
            this.materialTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.materialTypeDataGridViewTextBoxColumn1.Width = 110;
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            this.quantityDataGridViewTextBoxColumn1.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn1.Width = 75;
            // 
            // maxDataGridViewTextBoxColumn
            // 
            this.maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn.HeaderText = "Max Capacity";
            this.maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            this.maxDataGridViewTextBoxColumn.ReadOnly = true;
            this.maxDataGridViewTextBoxColumn.Width = 75;
            // 
            // StockReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 568);
            this.ControlBox = false;
            this.Controls.Add(this.btnChangeDefaults);
            this.Controls.Add(this.dataGridViewMax);
            this.Controls.Add(this.dataGridViewLow);
            this.Controls.Add(this.lbl_maxCapacity);
            this.Controls.Add(this.lbl_lowInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(404, 92);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StockReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Stock Warehouse Report";
            this.Load += new System.EventHandler(this.StockReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockReportLowCapacityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockReportMaxCapacityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_lowInventory;
        private System.Windows.Forms.Label lbl_maxCapacity;
        private System.Windows.Forms.DataGridView dataGridViewLow;
        private System.Windows.Forms.Button btnChangeDefaults;
        private System.Windows.Forms.DataGridView dataGridViewMax;
        private Login.WorkFlowDatabaseDataSet3 workFlowDatabaseDataSet3;
        private System.Windows.Forms.BindingSource stockReportLowCapacityBindingSource;
        private Login.WorkFlowDatabaseDataSet3TableAdapters.StockReportLowCapacityTableAdapter stockReportLowCapacityTableAdapter;
        private Login.WorkFlowDatabaseDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource stockReportMaxCapacityBindingSource;
        private Login.WorkFlowDatabaseDataSet3TableAdapters.StockReportMaxCapacityTableAdapter stockReportMaxCapacityTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
    }
}