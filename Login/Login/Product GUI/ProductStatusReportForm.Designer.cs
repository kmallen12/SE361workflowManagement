namespace WorkFlowManagement
{
    partial class ProductStatusReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductStatusReportForm));
            this.qualifiedProducts = new Login.QualifiedProducts();
            this.qualifiedProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workFlowDatabaseDataSet2 = new Login.WorkFlowDatabaseDataSet2();
            this.productTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableTableAdapter = new Login.WorkFlowDatabaseDataSet2TableAdapters.ProductTableTableAdapter();
            this.lblDefectiveProducts = new System.Windows.Forms.Label();
            this.dataGridProductStatus = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.qualifiedProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualifiedProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // qualifiedProducts
            // 
            this.qualifiedProducts.DataSetName = "QualifiedProducts";
            this.qualifiedProducts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qualifiedProductsBindingSource
            // 
            this.qualifiedProductsBindingSource.DataSource = this.qualifiedProducts;
            this.qualifiedProductsBindingSource.Position = 0;
            // 
            // workFlowDatabaseDataSet2
            // 
            this.workFlowDatabaseDataSet2.DataSetName = "WorkFlowDatabaseDataSet2";
            this.workFlowDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableBindingSource
            // 
            this.productTableBindingSource.DataMember = "ProductTable";
            this.productTableBindingSource.DataSource = this.workFlowDatabaseDataSet2;
            // 
            // productTableTableAdapter
            // 
            this.productTableTableAdapter.ClearBeforeFill = true;
            // 
            // lblDefectiveProducts
            // 
            this.lblDefectiveProducts.AutoSize = true;
            this.lblDefectiveProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefectiveProducts.Location = new System.Drawing.Point(20, 20);
            this.lblDefectiveProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDefectiveProducts.Name = "lblDefectiveProducts";
            this.lblDefectiveProducts.Size = new System.Drawing.Size(129, 20);
            this.lblDefectiveProducts.TabIndex = 4;
            this.lblDefectiveProducts.Text = "Product Status";
            // 
            // dataGridProductStatus
            // 
            this.dataGridProductStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductStatus.Location = new System.Drawing.Point(80, 57);
            this.dataGridProductStatus.Name = "dataGridProductStatus";
            this.dataGridProductStatus.Size = new System.Drawing.Size(275, 363);
            this.dataGridProductStatus.TabIndex = 7;
            // 
            // ProductStatusReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 432);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridProductStatus);
            this.Controls.Add(this.lblDefectiveProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(404, 92);
            this.Name = "ProductStatusReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Product Status Report Form";
            ((System.ComponentModel.ISupportInitialize)(this.qualifiedProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualifiedProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Login.QualifiedProducts qualifiedProducts;
        private System.Windows.Forms.BindingSource qualifiedProductsBindingSource;
        private Login.WorkFlowDatabaseDataSet2 workFlowDatabaseDataSet2;
        private System.Windows.Forms.BindingSource productTableBindingSource;
        private Login.WorkFlowDatabaseDataSet2TableAdapters.ProductTableTableAdapter productTableTableAdapter;
        private System.Windows.Forms.Label lblDefectiveProducts;
        private System.Windows.Forms.DataGridView dataGridProductStatus;
    }
}