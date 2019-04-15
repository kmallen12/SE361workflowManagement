namespace WorkFlowManagement
{
    partial class ManageProductOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProductOrders));
            this.OrderList_listbox = new System.Windows.Forms.ListBox();
            this.Confirm_btn = new System.Windows.Forms.Button();
            this.AcceptorDeny_lbl = new System.Windows.Forms.Label();
            this.btn_ConfirmFilled = new System.Windows.Forms.Button();
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
            // Confirm_btn
            // 
            this.Confirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_btn.Location = new System.Drawing.Point(15, 396);
            this.Confirm_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(208, 46);
            this.Confirm_btn.TabIndex = 2;
            this.Confirm_btn.Text = "Fill";
            this.Confirm_btn.UseVisualStyleBackColor = true;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // AcceptorDeny_lbl
            // 
            this.AcceptorDeny_lbl.AutoSize = true;
            this.AcceptorDeny_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptorDeny_lbl.Location = new System.Drawing.Point(11, 341);
            this.AcceptorDeny_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AcceptorDeny_lbl.Name = "AcceptorDeny_lbl";
            this.AcceptorDeny_lbl.Size = new System.Drawing.Size(242, 20);
            this.AcceptorDeny_lbl.TabIndex = 4;
            this.AcceptorDeny_lbl.Text = "Select a product order to fill. ";
            // 
            // btn_ConfirmFilled
            // 
            this.btn_ConfirmFilled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmFilled.Location = new System.Drawing.Point(621, 396);
            this.btn_ConfirmFilled.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ConfirmFilled.Name = "btn_ConfirmFilled";
            this.btn_ConfirmFilled.Size = new System.Drawing.Size(208, 46);
            this.btn_ConfirmFilled.TabIndex = 5;
            this.btn_ConfirmFilled.Text = "Confirm Filled";
            this.btn_ConfirmFilled.UseVisualStyleBackColor = true;
            this.btn_ConfirmFilled.Click += new System.EventHandler(this.btn_ConfirmFilled_Click);
            // 
            // ManageProductOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 489);
            this.Controls.Add(this.btn_ConfirmFilled);
            this.Controls.Add(this.AcceptorDeny_lbl);
            this.Controls.Add(this.Confirm_btn);
            this.Controls.Add(this.OrderList_listbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageProductOrders";
            this.Text = "ProductOrders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OrderList_listbox;
        private System.Windows.Forms.Button Confirm_btn;
        private System.Windows.Forms.Label AcceptorDeny_lbl;
        private System.Windows.Forms.Button btn_ConfirmFilled;
    }
}