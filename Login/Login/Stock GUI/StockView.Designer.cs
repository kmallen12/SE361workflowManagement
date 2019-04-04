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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockView));
            this.btnLoadDB = new System.Windows.Forms.Button();
            this.DGVStockView = new System.Windows.Forms.DataGridView();
            this.lbl_warehouseSummary = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStockView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadDB
            // 
            this.btnLoadDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadDB.Location = new System.Drawing.Point(274, 19);
            this.btnLoadDB.Name = "btnLoadDB";
            this.btnLoadDB.Size = new System.Drawing.Size(213, 52);
            this.btnLoadDB.TabIndex = 16;
            this.btnLoadDB.Text = "Load from Database";
            this.btnLoadDB.UseVisualStyleBackColor = true;
            this.btnLoadDB.Click += new System.EventHandler(this.btnLoadDB_Click);
            // 
            // DGVStockView
            // 
            this.DGVStockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStockView.Location = new System.Drawing.Point(-4, 83);
            this.DGVStockView.Name = "DGVStockView";
            this.DGVStockView.RowHeadersWidth = 5;
            this.DGVStockView.Size = new System.Drawing.Size(808, 348);
            this.DGVStockView.TabIndex = 15;
            // 
            // lbl_warehouseSummary
            // 
            this.lbl_warehouseSummary.AutoSize = true;
            this.lbl_warehouseSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warehouseSummary.Location = new System.Drawing.Point(30, 32);
            this.lbl_warehouseSummary.Name = "lbl_warehouseSummary";
            this.lbl_warehouseSummary.Size = new System.Drawing.Size(216, 24);
            this.lbl_warehouseSummary.TabIndex = 14;
            this.lbl_warehouseSummary.Text = "Warehouse Summary:";
            // 
            // StockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadDB);
            this.Controls.Add(this.DGVStockView);
            this.Controls.Add(this.lbl_warehouseSummary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockView";
            this.Text = "StockView";
            ((System.ComponentModel.ISupportInitialize)(this.DGVStockView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadDB;
        private System.Windows.Forms.DataGridView DGVStockView;
        private System.Windows.Forms.Label lbl_warehouseSummary;
    }
}