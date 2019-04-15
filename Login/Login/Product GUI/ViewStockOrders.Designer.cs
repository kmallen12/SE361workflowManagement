namespace WorkFlowManagement
{
    partial class ViewStockOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStockOrders));
            this.OrderList_listbox = new System.Windows.Forms.ListBox();
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
            this.OrderList_listbox.Size = new System.Drawing.Size(939, 484);
            this.OrderList_listbox.TabIndex = 0;
            // 
            // ViewStockOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 489);
            this.Controls.Add(this.OrderList_listbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewStockOrders";
            this.Text = "StockOrders";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox OrderList_listbox;
    }
}