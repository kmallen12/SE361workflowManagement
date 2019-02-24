namespace WorkFlowManagement
{
    partial class StockForm
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
            this.btn_AddMaterial = new System.Windows.Forms.Button();
            this.btn_UpdateStock = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_AddMaterial
            // 
            this.btn_AddMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddMaterial.Location = new System.Drawing.Point(224, 95);
            this.btn_AddMaterial.Name = "btn_AddMaterial";
            this.btn_AddMaterial.Size = new System.Drawing.Size(194, 42);
            this.btn_AddMaterial.TabIndex = 0;
            this.btn_AddMaterial.Text = "Add Raw Materials";
            this.btn_AddMaterial.UseVisualStyleBackColor = true;
            this.btn_AddMaterial.Click += new System.EventHandler(this.btn_AddMaterial_Click);
            // 
            // btn_UpdateStock
            // 
            this.btn_UpdateStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateStock.Location = new System.Drawing.Point(224, 168);
            this.btn_UpdateStock.Name = "btn_UpdateStock";
            this.btn_UpdateStock.Size = new System.Drawing.Size(194, 41);
            this.btn_UpdateStock.TabIndex = 1;
            this.btn_UpdateStock.Text = "View/Update Stock";
            this.btn_UpdateStock.UseVisualStyleBackColor = true;
            this.btn_UpdateStock.Click += new System.EventHandler(this.btn_UpdateStock_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report.Location = new System.Drawing.Point(224, 240);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(194, 42);
            this.btn_Report.TabIndex = 3;
            this.btn_Report.Text = "Generate Report";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stock Management Homepage";
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 392);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.btn_UpdateStock);
            this.Controls.Add(this.btn_AddMaterial);
            this.Name = "StockForm";
            this.Text = "Stock Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddMaterial;
        private System.Windows.Forms.Button btn_UpdateStock;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Label label1;
    }
}