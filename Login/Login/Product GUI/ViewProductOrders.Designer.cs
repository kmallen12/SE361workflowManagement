namespace WorkFlowManagement
{
    partial class ViewProductOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProductOrders));
            this.OrderList_listbox = new System.Windows.Forms.ListBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderList_listbox
            // 
            this.OrderList_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderList_listbox.FormattingEnabled = true;
            this.OrderList_listbox.ItemHeight = 15;
            this.OrderList_listbox.Location = new System.Drawing.Point(1, 1);
            this.OrderList_listbox.Margin = new System.Windows.Forms.Padding(2);
            this.OrderList_listbox.Name = "OrderList_listbox";
            this.OrderList_listbox.Size = new System.Drawing.Size(939, 319);
            this.OrderList_listbox.TabIndex = 0;
            this.OrderList_listbox.SelectedIndexChanged += new System.EventHandler(this.OrderList_listbox_SelectedIndexChanged);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(674, 325);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(255, 38);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // ViewProductOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 408);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.OrderList_listbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewProductOrders";
            this.Text = "ProductOrders";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox OrderList_listbox;
        private System.Windows.Forms.Button btnExport;
    }
}