﻿namespace WorkFlowManagement
{
    partial class ManageStockOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStockOrders));
            this.OrderList_listbox = new System.Windows.Forms.ListBox();
            this.Confirm_btn = new System.Windows.Forms.Button();
            this.AcceptorDeny_lbl = new System.Windows.Forms.Label();
            this.btn_Filled = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderList_listbox
            // 
            this.OrderList_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderList_listbox.FormattingEnabled = true;
            this.OrderList_listbox.ItemHeight = 15;
            this.OrderList_listbox.Location = new System.Drawing.Point(15, 11);
            this.OrderList_listbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrderList_listbox.Name = "OrderList_listbox";
            this.OrderList_listbox.Size = new System.Drawing.Size(692, 304);
            this.OrderList_listbox.TabIndex = 0;
            this.OrderList_listbox.SelectedIndexChanged += new System.EventHandler(this.OrderList_listbox_SelectedIndexChanged);
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_btn.Location = new System.Drawing.Point(15, 379);
            this.Confirm_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(208, 46);
            this.Confirm_btn.TabIndex = 2;
            this.Confirm_btn.Text = "Fill Order";
            this.Confirm_btn.UseVisualStyleBackColor = true;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // AcceptorDeny_lbl
            // 
            this.AcceptorDeny_lbl.AutoSize = true;
            this.AcceptorDeny_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptorDeny_lbl.Location = new System.Drawing.Point(11, 335);
            this.AcceptorDeny_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AcceptorDeny_lbl.Name = "AcceptorDeny_lbl";
            this.AcceptorDeny_lbl.Size = new System.Drawing.Size(224, 20);
            this.AcceptorDeny_lbl.TabIndex = 4;
            this.AcceptorDeny_lbl.Text = "Select a stock order to fill. ";
            // 
            // btn_Filled
            // 
            this.btn_Filled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Filled.Location = new System.Drawing.Point(499, 379);
            this.btn_Filled.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Filled.Name = "btn_Filled";
            this.btn_Filled.Size = new System.Drawing.Size(208, 46);
            this.btn_Filled.TabIndex = 5;
            this.btn_Filled.Text = "Confirm Order Filled";
            this.btn_Filled.UseVisualStyleBackColor = true;
            this.btn_Filled.Click += new System.EventHandler(this.btn_Filled_Click);
            // 
            // ManageStockOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 461);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Filled);
            this.Controls.Add(this.AcceptorDeny_lbl);
            this.Controls.Add(this.Confirm_btn);
            this.Controls.Add(this.OrderList_listbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(404, 92);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageStockOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "StockOrders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OrderList_listbox;
        private System.Windows.Forms.Button Confirm_btn;
        private System.Windows.Forms.Label AcceptorDeny_lbl;
        private System.Windows.Forms.Button btn_Filled;
    }
}