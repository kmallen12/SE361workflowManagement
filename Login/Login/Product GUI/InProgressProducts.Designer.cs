﻿namespace WorkFlowManagement
{
    partial class InProgressProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InProgressProducts));
            this.qualifiedProducts = new Login.QualifiedProducts();
            this.qualifiedProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workFlowDatabaseDataSet2 = new Login.WorkFlowDatabaseDataSet2();
            this.productTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableTableAdapter = new Login.WorkFlowDatabaseDataSet2TableAdapters.ProductTableTableAdapter();
            this.lblDefectiveProducts = new System.Windows.Forms.Label();
            this.dataGridProductStatus = new System.Windows.Forms.DataGridView();
            this.workFlowDatabaseDataSet = new Login.WorkFlowDatabaseDataSet();
            this.productTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productTableTableAdapter1 = new Login.WorkFlowDatabaseDataSetTableAdapters.ProductTableTableAdapter();
            this.pIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.qualifiedProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualifiedProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource1)).BeginInit();
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
            this.lblDefectiveProducts.Location = new System.Drawing.Point(27, 25);
            this.lblDefectiveProducts.Name = "lblDefectiveProducts";
            this.lblDefectiveProducts.Size = new System.Drawing.Size(213, 25);
            this.lblDefectiveProducts.TabIndex = 4;
            this.lblDefectiveProducts.Text = "In Progress Products";
            // 
            // dataGridProductStatus
            // 
            this.dataGridProductStatus.AutoGenerateColumns = false;
            this.dataGridProductStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.materialsStringDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.productStatusDataGridViewTextBoxColumn});
            this.dataGridProductStatus.DataSource = this.productTableBindingSource1;
            this.dataGridProductStatus.Location = new System.Drawing.Point(98, 70);
            this.dataGridProductStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridProductStatus.Name = "dataGridProductStatus";
            this.dataGridProductStatus.Size = new System.Drawing.Size(879, 546);
            this.dataGridProductStatus.TabIndex = 7;
            // 
            // workFlowDatabaseDataSet
            // 
            this.workFlowDatabaseDataSet.DataSetName = "WorkFlowDatabaseDataSet";
            this.workFlowDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableBindingSource1
            // 
            this.productTableBindingSource1.DataMember = "ProductTable";
            this.productTableBindingSource1.DataSource = this.workFlowDatabaseDataSet;
            // 
            // productTableTableAdapter1
            // 
            this.productTableTableAdapter1.ClearBeforeFill = true;
            // 
            // pIdDataGridViewTextBoxColumn
            // 
            this.pIdDataGridViewTextBoxColumn.DataPropertyName = "pId";
            this.pIdDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.pIdDataGridViewTextBoxColumn.Name = "pIdDataGridViewTextBoxColumn";
            this.pIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.pIdDataGridViewTextBoxColumn.Width = 60;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // materialsStringDataGridViewTextBoxColumn
            // 
            this.materialsStringDataGridViewTextBoxColumn.DataPropertyName = "materialsString";
            this.materialsStringDataGridViewTextBoxColumn.HeaderText = "Materials in Product";
            this.materialsStringDataGridViewTextBoxColumn.Name = "materialsStringDataGridViewTextBoxColumn";
            this.materialsStringDataGridViewTextBoxColumn.Width = 275;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 60;
            // 
            // productStatusDataGridViewTextBoxColumn
            // 
            this.productStatusDataGridViewTextBoxColumn.DataPropertyName = "productStatus";
            this.productStatusDataGridViewTextBoxColumn.HeaderText = "Product Status";
            this.productStatusDataGridViewTextBoxColumn.Name = "productStatusDataGridViewTextBoxColumn";
            this.productStatusDataGridViewTextBoxColumn.Width = 75;
            // 
            // InProgressProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 667);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridProductStatus);
            this.Controls.Add(this.lblDefectiveProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(404, 92);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InProgressProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Product Status Report Form";
            this.Load += new System.EventHandler(this.InProgressProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qualifiedProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualifiedProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource1)).EndInit();
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
        private Login.WorkFlowDatabaseDataSet workFlowDatabaseDataSet;
        private System.Windows.Forms.BindingSource productTableBindingSource1;
        private Login.WorkFlowDatabaseDataSetTableAdapters.ProductTableTableAdapter productTableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialsStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStatusDataGridViewTextBoxColumn;
    }
}