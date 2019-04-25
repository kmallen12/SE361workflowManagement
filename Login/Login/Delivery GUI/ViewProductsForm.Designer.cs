namespace WorkFlowManagement
{
    partial class ViewProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProductsForm));
            this.lblProductDetails = new System.Windows.Forms.Label();
            this.workFlowDatabaseDataSet1 = new Login.WorkFlowDatabaseDataSet();
            this.workFlowDatabaseDataSet2 = new Login.WorkFlowDatabaseDataSet();
            this.dataGrid_ViewProducts = new System.Windows.Forms.DataGridView();
            this.productTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workFlowDatabaseDataSetProducts = new Login.WorkFlowDatabaseDataSetProducts();
            this.productTableTableAdapter = new Login.WorkFlowDatabaseDataSetProductsTableAdapters.ProductTableTableAdapter();
            this.tableAdapterManager = new Login.WorkFlowDatabaseDataSetProductsTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSetProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductDetails
            // 
            this.lblProductDetails.AutoSize = true;
            this.lblProductDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDetails.Location = new System.Drawing.Point(24, 20);
            this.lblProductDetails.Name = "lblProductDetails";
            this.lblProductDetails.Size = new System.Drawing.Size(150, 24);
            this.lblProductDetails.TabIndex = 2;
            this.lblProductDetails.Text = "Product Details";
            // 
            // workFlowDatabaseDataSet1
            // 
            this.workFlowDatabaseDataSet1.DataSetName = "WorkFlowDatabaseDataSet";
            this.workFlowDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workFlowDatabaseDataSet2
            // 
            this.workFlowDatabaseDataSet2.DataSetName = "WorkFlowDatabaseDataSet";
            this.workFlowDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGrid_ViewProducts
            // 
            this.dataGrid_ViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_ViewProducts.Location = new System.Drawing.Point(78, 65);
            this.dataGrid_ViewProducts.Name = "dataGrid_ViewProducts";
            this.dataGrid_ViewProducts.Size = new System.Drawing.Size(553, 347);
            this.dataGrid_ViewProducts.TabIndex = 3;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductTableTableAdapter = this.productTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Login.WorkFlowDatabaseDataSetProductsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ViewProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 461);
            this.ControlBox = false;
            this.Controls.Add(this.dataGrid_ViewProducts);
            this.Controls.Add(this.lblProductDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(404, 92);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ViewProductsForm";
            this.Load += new System.EventHandler(this.ViewProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSetProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProductDetails;
        private Login.WorkFlowDatabaseDataSet workFlowDatabaseDataSet1;
        private Login.WorkFlowDatabaseDataSet workFlowDatabaseDataSet2;
        private System.Windows.Forms.DataGridView dataGrid_ViewProducts;
        private Login.WorkFlowDatabaseDataSetProducts workFlowDatabaseDataSetProducts;
        private System.Windows.Forms.BindingSource productTableBindingSource;
        private Login.WorkFlowDatabaseDataSetProductsTableAdapters.ProductTableTableAdapter productTableTableAdapter;
        private Login.WorkFlowDatabaseDataSetProductsTableAdapters.TableAdapterManager tableAdapterManager;
    }
}