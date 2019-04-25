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
            this.stockReportLowCapacityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workFlowDatabaseDataSet3 = new Login.WorkFlowDatabaseDataSet3();
            this.btnChangeDefaults = new System.Windows.Forms.Button();
            this.dataGridViewMax = new System.Windows.Forms.DataGridView();
            this.stockReportMaxCapacityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockReportLowCapacityTableAdapter = new Login.WorkFlowDatabaseDataSet3TableAdapters.StockReportLowCapacityTableAdapter();
            this.tableAdapterManager = new Login.WorkFlowDatabaseDataSet3TableAdapters.TableAdapterManager();
            this.stockReportMaxCapacityTableAdapter = new Login.WorkFlowDatabaseDataSet3TableAdapters.StockReportMaxCapacityTableAdapter();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockReportLowCapacityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockReportMaxCapacityBindingSource)).BeginInit();
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
            this.lbl_maxCapacity.Location = new System.Drawing.Point(417, 50);
            this.lbl_maxCapacity.Name = "lbl_maxCapacity";
            this.lbl_maxCapacity.Size = new System.Drawing.Size(240, 18);
            this.lbl_maxCapacity.TabIndex = 2;
            this.lbl_maxCapacity.Text = "Items Reaching Max Capacity: ";
            // 
            // dataGridViewLow
            // 
            this.dataGridViewLow.AllowUserToAddRows = false;
            this.dataGridViewLow.AllowUserToDeleteRows = false;
            this.dataGridViewLow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLow.Location = new System.Drawing.Point(30, 85);
            this.dataGridViewLow.Name = "dataGridViewLow";
            this.dataGridViewLow.ReadOnly = true;
            this.dataGridViewLow.Size = new System.Drawing.Size(344, 346);
            this.dataGridViewLow.TabIndex = 3;
            // 
            // stockReportLowCapacityBindingSource
            // 
            this.stockReportLowCapacityBindingSource.DataMember = "StockReportLowCapacity";
            this.stockReportLowCapacityBindingSource.DataSource = this.workFlowDatabaseDataSet3;
            // 
            // workFlowDatabaseDataSet3
            // 
            this.workFlowDatabaseDataSet3.DataSetName = "WorkFlowDatabaseDataSet3";
            this.workFlowDatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnChangeDefaults
            // 
            this.btnChangeDefaults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeDefaults.Location = new System.Drawing.Point(262, 10);
            this.btnChangeDefaults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangeDefaults.Name = "btnChangeDefaults";
            this.btnChangeDefaults.Size = new System.Drawing.Size(207, 33);
            this.btnChangeDefaults.TabIndex = 6;
            this.btnChangeDefaults.Text = "Change Item Defaults";
            this.btnChangeDefaults.UseVisualStyleBackColor = true;
            this.btnChangeDefaults.Click += new System.EventHandler(this.btnChangeDefaults_Click);
            // 
            // dataGridViewMax
            // 
            this.dataGridViewMax.AllowUserToAddRows = false;
            this.dataGridViewMax.AllowUserToDeleteRows = false;
            this.dataGridViewMax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMax.Location = new System.Drawing.Point(420, 85);
            this.dataGridViewMax.Name = "dataGridViewMax";
            this.dataGridViewMax.ReadOnly = true;
            this.dataGridViewMax.Size = new System.Drawing.Size(343, 346);
            this.dataGridViewMax.TabIndex = 4;
            // 
            // stockReportMaxCapacityBindingSource
            // 
            this.stockReportMaxCapacityBindingSource.DataMember = "StockReportMaxCapacity";
            this.stockReportMaxCapacityBindingSource.DataSource = this.workFlowDatabaseDataSet3;
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
            // stockReportMaxCapacityTableAdapter
            // 
            this.stockReportMaxCapacityTableAdapter.ClearBeforeFill = true;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(686, 10);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(87, 33);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // StockReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 462);
            this.ControlBox = false;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnChangeDefaults);
            this.Controls.Add(this.dataGridViewMax);
            this.Controls.Add(this.dataGridViewLow);
            this.Controls.Add(this.lbl_maxCapacity);
            this.Controls.Add(this.lbl_lowInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(404, 92);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StockReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Stock Warehouse Report";
            this.Load += new System.EventHandler(this.StockReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockReportLowCapacityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMax)).EndInit();
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
        private System.Windows.Forms.Button btnExport;
    }
}