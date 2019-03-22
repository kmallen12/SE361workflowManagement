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
            this.lbl_lowInventory = new System.Windows.Forms.Label();
            this.lbl_maxCapacity = new System.Windows.Forms.Label();
            this.dataGridViewLow = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workFlowDatabaseDataSet1 = new Login.WorkFlowDatabaseDataSet();
            this.dataGridViewMax = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linklblChangeItem = new System.Windows.Forms.LinkLabel();
            this.workFlowDatabaseDataSet = new Login.WorkFlowDatabaseDataSet();
            this.stockTableTableAdapter = new Login.WorkFlowDatabaseDataSetTableAdapters.StockTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_lowInventory
            // 
            this.lbl_lowInventory.AutoSize = true;
            this.lbl_lowInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lowInventory.Location = new System.Drawing.Point(37, 50);
            this.lbl_lowInventory.Name = "lbl_lowInventory";
            this.lbl_lowInventory.Size = new System.Drawing.Size(198, 18);
            this.lbl_lowInventory.TabIndex = 1;
            this.lbl_lowInventory.Text = "Items with Low Inventory:";
            // 
            // lbl_maxCapacity
            // 
            this.lbl_maxCapacity.AutoSize = true;
            this.lbl_maxCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maxCapacity.Location = new System.Drawing.Point(364, 50);
            this.lbl_maxCapacity.Name = "lbl_maxCapacity";
            this.lbl_maxCapacity.Size = new System.Drawing.Size(240, 18);
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
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridViewLow.DataSource = this.stockTableBindingSource;
            this.dataGridViewLow.Location = new System.Drawing.Point(30, 85);
            this.dataGridViewLow.Name = "dataGridViewLow";
            this.dataGridViewLow.ReadOnly = true;
            this.dataGridViewLow.Size = new System.Drawing.Size(264, 216);
            this.dataGridViewLow.TabIndex = 3;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "itemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "itemID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockTableBindingSource
            // 
            this.stockTableBindingSource.DataMember = "StockTable";
            this.stockTableBindingSource.DataSource = this.workFlowDatabaseDataSet1;
            // 
            // workFlowDatabaseDataSet1
            // 
            this.workFlowDatabaseDataSet1.DataSetName = "WorkFlowDatabaseDataSet";
            this.workFlowDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewMax
            // 
            this.dataGridViewMax.AllowUserToAddRows = false;
            this.dataGridViewMax.AllowUserToDeleteRows = false;
            this.dataGridViewMax.AutoGenerateColumns = false;
            this.dataGridViewMax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMax.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn1});
            this.dataGridViewMax.DataSource = this.stockTableBindingSource;
            this.dataGridViewMax.Location = new System.Drawing.Point(364, 85);
            this.dataGridViewMax.Name = "dataGridViewMax";
            this.dataGridViewMax.ReadOnly = true;
            this.dataGridViewMax.Size = new System.Drawing.Size(248, 216);
            this.dataGridViewMax.TabIndex = 4;
            // 
            // itemIDDataGridViewTextBoxColumn1
            // 
            this.itemIDDataGridViewTextBoxColumn1.DataPropertyName = "itemID";
            this.itemIDDataGridViewTextBoxColumn1.HeaderText = "itemID";
            this.itemIDDataGridViewTextBoxColumn1.Name = "itemIDDataGridViewTextBoxColumn1";
            this.itemIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            this.quantityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // linklblChangeItem
            // 
            this.linklblChangeItem.AutoSize = true;
            this.linklblChangeItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblChangeItem.Location = new System.Drawing.Point(200, 9);
            this.linklblChangeItem.Name = "linklblChangeItem";
            this.linklblChangeItem.Size = new System.Drawing.Size(238, 25);
            this.linklblChangeItem.TabIndex = 5;
            this.linklblChangeItem.TabStop = true;
            this.linklblChangeItem.Text = "Change Item Defaults";
            this.linklblChangeItem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblChangeItem_LinkClicked);
            // 
            // workFlowDatabaseDataSet
            // 
            this.workFlowDatabaseDataSet.DataSetName = "WorkFlowDatabaseDataSet";
            this.workFlowDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockTableTableAdapter
            // 
            this.stockTableTableAdapter.ClearBeforeFill = true;
            // 
            // StockReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 354);
            this.Controls.Add(this.linklblChangeItem);
            this.Controls.Add(this.dataGridViewMax);
            this.Controls.Add(this.dataGridViewLow);
            this.Controls.Add(this.lbl_maxCapacity);
            this.Controls.Add(this.lbl_lowInventory);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StockReportForm";
            this.Text = "Stock Report";
            this.Load += new System.EventHandler(this.StockReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_lowInventory;
        private System.Windows.Forms.Label lbl_maxCapacity;
        private Login.WorkFlowDatabaseDataSet workFlowDatabaseDataSet;
        private Login.WorkFlowDatabaseDataSetTableAdapters.StockTableTableAdapter stockTableTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewLow;
        private System.Windows.Forms.DataGridView dataGridViewMax;
        private System.Windows.Forms.LinkLabel linklblChangeItem;
        private Login.WorkFlowDatabaseDataSet workFlowDatabaseDataSet1;
        private System.Windows.Forms.BindingSource stockTableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
    }
}