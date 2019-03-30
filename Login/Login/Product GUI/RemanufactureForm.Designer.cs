namespace WorkFlowManagement
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
            this.lblDefectiveProducts = new System.Windows.Forms.Label();
            this.lstDefProd = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDefectiveProducts
            // 
            this.lblDefectiveProducts.AutoSize = true;
            this.lblDefectiveProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefectiveProducts.Location = new System.Drawing.Point(34, 30);
            this.lblDefectiveProducts.Name = "lblDefectiveProducts";
            this.lblDefectiveProducts.Size = new System.Drawing.Size(193, 25);
            this.lblDefectiveProducts.TabIndex = 0;
            this.lblDefectiveProducts.Text = "Defective Products";
            // 
            // lstDefProd
            // 
            this.lstDefProd.FormattingEnabled = true;
            this.lstDefProd.ItemHeight = 16;
            this.lstDefProd.Location = new System.Drawing.Point(39, 75);
            this.lstDefProd.Name = "lstDefProd";
            this.lstDefProd.Size = new System.Drawing.Size(702, 116);
            this.lstDefProd.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Check stock levels";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 56);
            this.button2.TabIndex = 3;
            this.button2.Text = "Remanufacture";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RemanufactureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstDefProd);
            this.Controls.Add(this.lblDefectiveProducts);
            this.Name = "RemanufactureForm";
            this.Text = "RemanufactureForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDefectiveProducts;
        private System.Windows.Forms.ListBox lstDefProd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}