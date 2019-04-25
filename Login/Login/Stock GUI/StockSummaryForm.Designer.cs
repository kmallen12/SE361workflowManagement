namespace WorkFlowManagement
{
    partial class StockSummaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockSummaryForm));
            this.stockTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workFlowDatabaseDataSet = new Login.WorkFlowDatabaseDataSet();
            this.stockTableTableAdapter = new Login.WorkFlowDatabaseDataSetTableAdapters.StockTableTableAdapter();
            this.dataGridViewStockSum = new System.Windows.Forms.DataGridView();
            this.lblSumStocks = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenDetails = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stockTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockSum)).BeginInit();
            this.SuspendLayout();
            // 
            // stockTableBindingSource
            // 
            this.stockTableBindingSource.DataMember = "StockTable";
            this.stockTableBindingSource.DataSource = this.workFlowDatabaseDataSet;
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
            // dataGridViewStockSum
            // 
            this.dataGridViewStockSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStockSum.Location = new System.Drawing.Point(151, 85);
            this.dataGridViewStockSum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewStockSum.Name = "dataGridViewStockSum";
            this.dataGridViewStockSum.RowTemplate.Height = 24;
            this.dataGridViewStockSum.Size = new System.Drawing.Size(306, 384);
            this.dataGridViewStockSum.TabIndex = 0;
            // 
            // lblSumStocks
            // 
            this.lblSumStocks.AutoSize = true;
            this.lblSumStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumStocks.Location = new System.Drawing.Point(62, 25);
            this.lblSumStocks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSumStocks.Name = "lblSumStocks";
            this.lblSumStocks.Size = new System.Drawing.Size(179, 20);
            this.lblSumStocks.TabIndex = 1;
            this.lblSumStocks.Text = "Warehouse Inventory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "The table below shows the total amount of stocks in the warehouse sorted by type." +
    "";
            // 
            // btnOpenDetails
            // 
            this.btnOpenDetails.Location = new System.Drawing.Point(486, 351);
            this.btnOpenDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenDetails.Name = "btnOpenDetails";
            this.btnOpenDetails.Size = new System.Drawing.Size(128, 48);
            this.btnOpenDetails.TabIndex = 3;
            this.btnOpenDetails.Text = "Open Detailed View";
            this.btnOpenDetails.UseVisualStyleBackColor = true;
            this.btnOpenDetails.Click += new System.EventHandler(this.btnOpenDetails_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(486, 422);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 48);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(486, 282);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(128, 47);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.button1_Click);
            // 
            // StockSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.ControlBox = false;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpenDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSumStocks);
            this.Controls.Add(this.dataGridViewStockSum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(404, 92);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StockSummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Stock Summary Form";
            this.Load += new System.EventHandler(this.StockSummaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockSum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Login.WorkFlowDatabaseDataSet workFlowDatabaseDataSet;
        private System.Windows.Forms.BindingSource stockTableBindingSource;
        private Login.WorkFlowDatabaseDataSetTableAdapters.StockTableTableAdapter stockTableTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewStockSum;
        private System.Windows.Forms.Label lblSumStocks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExport;
    }
}