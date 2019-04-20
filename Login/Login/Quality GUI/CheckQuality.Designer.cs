namespace WorkFlowManagement
{
    partial class CheckQuality
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckQuality));
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblUpdateStatus = new System.Windows.Forms.Label();
            this.workFlowDatabaseDataSet1 = new Login.WorkFlowDatabaseDataSet1();
            this.productTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableTableAdapter = new Login.WorkFlowDatabaseDataSet1TableAdapters.ProductTableTableAdapter();
            this.tableAdapterManager = new Login.WorkFlowDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.lblInstrux = new System.Windows.Forms.Label();
            this.lblProdID = new System.Windows.Forms.Label();
            this.lblProdName = new System.Windows.Forms.Label();
            this.cboxStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(75, 23);
            this.lblProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(80, 20);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "Products";
            // 
            // lblUpdateStatus
            // 
            this.lblUpdateStatus.AutoSize = true;
            this.lblUpdateStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateStatus.Location = new System.Drawing.Point(75, 214);
            this.lblUpdateStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateStatus.Name = "lblUpdateStatus";
            this.lblUpdateStatus.Size = new System.Drawing.Size(193, 20);
            this.lblUpdateStatus.TabIndex = 2;
            this.lblUpdateStatus.Text = "Update Product Status";
            // 
            // workFlowDatabaseDataSet1
            // 
            this.workFlowDatabaseDataSet1.DataSetName = "WorkFlowDatabaseDataSet1";
            this.workFlowDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableBindingSource
            // 
            this.productTableBindingSource.DataMember = "ProductTable";
            this.productTableBindingSource.DataSource = this.workFlowDatabaseDataSet1;
            // 
            // productTableTableAdapter
            // 
            this.productTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductTableTableAdapter = this.productTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Login.WorkFlowDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(79, 62);
            this.lstProducts.Margin = new System.Windows.Forms.Padding(2);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(458, 134);
            this.lstProducts.TabIndex = 3;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.lstProducts_SelectedIndexChanged);
            // 
            // lblInstrux
            // 
            this.lblInstrux.AutoSize = true;
            this.lblInstrux.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrux.Location = new System.Drawing.Point(75, 242);
            this.lblInstrux.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInstrux.Name = "lblInstrux";
            this.lblInstrux.Size = new System.Drawing.Size(402, 13);
            this.lblInstrux.TabIndex = 4;
            this.lblInstrux.Text = "Select a product from the list above. Then select a product status and click Upda" +
    "te.";
            // 
            // lblProdID
            // 
            this.lblProdID.AutoSize = true;
            this.lblProdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdID.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblProdID.Location = new System.Drawing.Point(76, 280);
            this.lblProdID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdID.Name = "lblProdID";
            this.lblProdID.Size = new System.Drawing.Size(20, 13);
            this.lblProdID.TabIndex = 5;
            this.lblProdID.Text = "ID";
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblProdName.Location = new System.Drawing.Point(132, 280);
            this.lblProdName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(87, 13);
            this.lblProdName.TabIndex = 6;
            this.lblProdName.Text = "Product Name";
            // 
            // cboxStatus
            // 
            this.cboxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxStatus.FormattingEnabled = true;
            this.cboxStatus.Location = new System.Drawing.Point(256, 280);
            this.cboxStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cboxStatus.Name = "cboxStatus";
            this.cboxStatus.Size = new System.Drawing.Size(152, 21);
            this.cboxStatus.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(467, 274);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(69, 25);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(364, 329);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 40);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "SAVE TO DATABASE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(182, 329);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 40);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CheckQuality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 395);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cboxStatus);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.lblProdID);
            this.Controls.Add(this.lblInstrux);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.lblUpdateStatus);
            this.Controls.Add(this.lblProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(404, 92);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CheckQuality";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Check Product Quality";
            this.Load += new System.EventHandler(this.CheckQuality_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblUpdateStatus;
        private Login.WorkFlowDatabaseDataSet1 workFlowDatabaseDataSet1;
        private System.Windows.Forms.BindingSource productTableBindingSource;
        private Login.WorkFlowDatabaseDataSet1TableAdapters.ProductTableTableAdapter productTableTableAdapter;
        private Login.WorkFlowDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Label lblInstrux;
        private System.Windows.Forms.Label lblProdID;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.ComboBox cboxStatus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}