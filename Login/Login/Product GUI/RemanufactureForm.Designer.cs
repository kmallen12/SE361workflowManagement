﻿namespace WorkFlowManagement
{
    partial class RemanufactureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemanufactureForm));
            this.lblDefectiveProducts = new System.Windows.Forms.Label();
            this.lstDefProd = new System.Windows.Forms.ListBox();
            this.btnRepRemanufacture = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDefectiveProducts
            // 
            this.lblDefectiveProducts.AutoSize = true;
            this.lblDefectiveProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefectiveProducts.Location = new System.Drawing.Point(20, 20);
            this.lblDefectiveProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDefectiveProducts.Name = "lblDefectiveProducts";
            this.lblDefectiveProducts.Size = new System.Drawing.Size(161, 20);
            this.lblDefectiveProducts.TabIndex = 0;
            this.lblDefectiveProducts.Text = "Defective Products";
            // 
            // lstDefProd
            // 
            this.lstDefProd.FormattingEnabled = true;
            this.lstDefProd.Location = new System.Drawing.Point(23, 57);
            this.lstDefProd.Margin = new System.Windows.Forms.Padding(2);
            this.lstDefProd.Name = "lstDefProd";
            this.lstDefProd.Size = new System.Drawing.Size(528, 134);
            this.lstDefProd.TabIndex = 1;
            this.lstDefProd.SelectedIndexChanged += new System.EventHandler(this.lstDefProd_SelectedIndexChanged);
            // 
            // btnRepRemanufacture
            // 
            this.btnRepRemanufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepRemanufacture.Location = new System.Drawing.Point(412, 213);
            this.btnRepRemanufacture.Margin = new System.Windows.Forms.Padding(2);
            this.btnRepRemanufacture.Name = "btnRepRemanufacture";
            this.btnRepRemanufacture.Size = new System.Drawing.Size(139, 46);
            this.btnRepRemanufacture.TabIndex = 3;
            this.btnRepRemanufacture.Text = "Remanufacture Selected Item";
            this.btnRepRemanufacture.UseVisualStyleBackColor = true;
            this.btnRepRemanufacture.Click += new System.EventHandler(this.btnRepRemanufacture_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(268, 213);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(139, 46);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // RemanufactureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 309);
            this.ControlBox = false;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnRepRemanufacture);
            this.Controls.Add(this.lstDefProd);
            this.Controls.Add(this.lblDefectiveProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(404, 92);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RemanufactureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Remanufacture Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDefectiveProducts;
        private System.Windows.Forms.ListBox lstDefProd;
        private System.Windows.Forms.Button btnRepRemanufacture;
        private System.Windows.Forms.Button btnExport;
    }
}