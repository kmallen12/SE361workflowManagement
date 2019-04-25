namespace WorkFlowManagement
{
    partial class StockView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockView));
            this.btnLoadDB = new System.Windows.Forms.Button();
            this.DGVStockView = new System.Windows.Forms.DataGridView();
            this.lbl_warehouseSummary = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.workFlowDatabaseDataSet = new Login.WorkFlowDatabaseDataSet();
            this.stockTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableTableAdapter = new Login.WorkFlowDatabaseDataSetTableAdapters.StockTableTableAdapter();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAcquiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateUsedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amtDefectedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStockView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadDB
            // 
            this.btnLoadDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadDB.Location = new System.Drawing.Point(365, 23);
            this.btnLoadDB.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadDB.Name = "btnLoadDB";
            this.btnLoadDB.Size = new System.Drawing.Size(210, 64);
            this.btnLoadDB.TabIndex = 16;
            this.btnLoadDB.Text = "Refresh Table";
            this.btnLoadDB.UseVisualStyleBackColor = true;
            this.btnLoadDB.Click += new System.EventHandler(this.btnLoadDB_Click);
            // 
            // DGVStockView
            // 
            this.DGVStockView.AutoGenerateColumns = false;
            this.DGVStockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStockView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.materialTypeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitCostDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.dateAcquiredDataGridViewTextBoxColumn,
            this.dateUsedDataGridViewTextBoxColumn,
            this.amtDefectedDataGridViewTextBoxColumn});
            this.DGVStockView.DataSource = this.stockTableBindingSource;
            this.DGVStockView.Location = new System.Drawing.Point(-5, 102);
            this.DGVStockView.Margin = new System.Windows.Forms.Padding(4);
            this.DGVStockView.Name = "DGVStockView";
            this.DGVStockView.RowHeadersWidth = 5;
            this.DGVStockView.Size = new System.Drawing.Size(1077, 428);
            this.DGVStockView.TabIndex = 15;
            // 
            // lbl_warehouseSummary
            // 
            this.lbl_warehouseSummary.AutoSize = true;
            this.lbl_warehouseSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warehouseSummary.Location = new System.Drawing.Point(40, 39);
            this.lbl_warehouseSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_warehouseSummary.Name = "lbl_warehouseSummary";
            this.lbl_warehouseSummary.Size = new System.Drawing.Size(267, 29);
            this.lbl_warehouseSummary.TabIndex = 14;
            this.lbl_warehouseSummary.Text = "Warehouse Summary:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(608, 23);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(165, 64);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // stockTableTableAdapter
            // 
            this.stockTableTableAdapter.ClearBeforeFill = true;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "itemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "Item ID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialTypeDataGridViewTextBoxColumn
            // 
            this.materialTypeDataGridViewTextBoxColumn.DataPropertyName = "materialType";
            this.materialTypeDataGridViewTextBoxColumn.HeaderText = "Material Type";
            this.materialTypeDataGridViewTextBoxColumn.Name = "materialTypeDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // unitCostDataGridViewTextBoxColumn
            // 
            this.unitCostDataGridViewTextBoxColumn.DataPropertyName = "unitCost";
            this.unitCostDataGridViewTextBoxColumn.HeaderText = "Unit Cost";
            this.unitCostDataGridViewTextBoxColumn.Name = "unitCostDataGridViewTextBoxColumn";
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "totalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "Total Cost";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            // 
            // dateAcquiredDataGridViewTextBoxColumn
            // 
            this.dateAcquiredDataGridViewTextBoxColumn.DataPropertyName = "dateAcquired";
            this.dateAcquiredDataGridViewTextBoxColumn.HeaderText = "Date Acquired";
            this.dateAcquiredDataGridViewTextBoxColumn.Name = "dateAcquiredDataGridViewTextBoxColumn";
            // 
            // dateUsedDataGridViewTextBoxColumn
            // 
            this.dateUsedDataGridViewTextBoxColumn.DataPropertyName = "dateUsed";
            this.dateUsedDataGridViewTextBoxColumn.HeaderText = "Date Used";
            this.dateUsedDataGridViewTextBoxColumn.Name = "dateUsedDataGridViewTextBoxColumn";
            // 
            // amtDefectedDataGridViewTextBoxColumn
            // 
            this.amtDefectedDataGridViewTextBoxColumn.DataPropertyName = "amtDefected";
            this.amtDefectedDataGridViewTextBoxColumn.HeaderText = "Amount Defected";
            this.amtDefectedDataGridViewTextBoxColumn.Name = "amtDefectedDataGridViewTextBoxColumn";
            // 
            // StockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLoadDB);
            this.Controls.Add(this.DGVStockView);
            this.Controls.Add(this.lbl_warehouseSummary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(404, 92);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StockView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "StockView";
            this.Load += new System.EventHandler(this.StockView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVStockView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadDB;
        private System.Windows.Forms.DataGridView DGVStockView;
        private System.Windows.Forms.Label lbl_warehouseSummary;
        private System.Windows.Forms.Button btnClose;
        private Login.WorkFlowDatabaseDataSet workFlowDatabaseDataSet;
        private System.Windows.Forms.BindingSource stockTableBindingSource;
        private Login.WorkFlowDatabaseDataSetTableAdapters.StockTableTableAdapter stockTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAcquiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateUsedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amtDefectedDataGridViewTextBoxColumn;
    }
}