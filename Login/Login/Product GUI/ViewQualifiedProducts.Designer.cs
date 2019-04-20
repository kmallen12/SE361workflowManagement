namespace WorkFlowManagement
{
    partial class ViewQualifiedProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewQualifiedProducts));
            this.qualifiedProducts = new Login.QualifiedProducts();
            this.qualifiedProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workFlowDatabaseDataSet2 = new Login.WorkFlowDatabaseDataSet2();
            this.productTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableTableAdapter = new Login.WorkFlowDatabaseDataSet2TableAdapters.ProductTableTableAdapter();
            this.lstQualProd = new System.Windows.Forms.ListBox();
            this.lblDefectiveProducts = new System.Windows.Forms.Label();
            this.btnRepRemanufacture = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qualifiedProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualifiedProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).BeginInit();
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
            // lstQualProd
            // 
            this.lstQualProd.FormattingEnabled = true;
            this.lstQualProd.Location = new System.Drawing.Point(23, 57);
            this.lstQualProd.Margin = new System.Windows.Forms.Padding(2);
            this.lstQualProd.Name = "lstQualProd";
            this.lstQualProd.Size = new System.Drawing.Size(528, 134);
            this.lstQualProd.TabIndex = 5;
            // 
            // lblDefectiveProducts
            // 
            this.lblDefectiveProducts.AutoSize = true;
            this.lblDefectiveProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefectiveProducts.Location = new System.Drawing.Point(20, 20);
            this.lblDefectiveProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDefectiveProducts.Name = "lblDefectiveProducts";
            this.lblDefectiveProducts.Size = new System.Drawing.Size(156, 20);
            this.lblDefectiveProducts.TabIndex = 4;
            this.lblDefectiveProducts.Text = "Qualified Products";
            // 
            // btnRepRemanufacture
            // 
            this.btnRepRemanufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepRemanufacture.Location = new System.Drawing.Point(412, 213);
            this.btnRepRemanufacture.Margin = new System.Windows.Forms.Padding(2);
            this.btnRepRemanufacture.Name = "btnRepRemanufacture";
            this.btnRepRemanufacture.Size = new System.Drawing.Size(139, 46);
            this.btnRepRemanufacture.TabIndex = 6;
            this.btnRepRemanufacture.Text = "Ship Selected Item";
            this.btnRepRemanufacture.UseVisualStyleBackColor = true;
            this.btnRepRemanufacture.Click += new System.EventHandler(this.btnRepRemanufacture_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(268, 213);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(139, 46);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // ViewQualifiedProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 309);
            this.ControlBox = false;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnRepRemanufacture);
            this.Controls.Add(this.lstQualProd);
            this.Controls.Add(this.lblDefectiveProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(404, 92);
            this.Name = "ViewQualifiedProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ViewQualifiedProducts";
            ((System.ComponentModel.ISupportInitialize)(this.qualifiedProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualifiedProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Login.QualifiedProducts qualifiedProducts;
        private System.Windows.Forms.BindingSource qualifiedProductsBindingSource;
        private Login.WorkFlowDatabaseDataSet2 workFlowDatabaseDataSet2;
        private System.Windows.Forms.BindingSource productTableBindingSource;
        private Login.WorkFlowDatabaseDataSet2TableAdapters.ProductTableTableAdapter productTableTableAdapter;
        private System.Windows.Forms.ListBox lstQualProd;
        private System.Windows.Forms.Label lblDefectiveProducts;
        private System.Windows.Forms.Button btnRepRemanufacture;
        private System.Windows.Forms.Button btnExport;
    }
}