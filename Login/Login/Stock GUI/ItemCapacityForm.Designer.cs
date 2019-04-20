namespace WorkFlowManagement
{
    partial class ItemCapacityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemCapacityForm));
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateWarningValues = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(63, 107);
            this.txtItemID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(132, 22);
            this.txtItemID.TabIndex = 0;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(252, 106);
            this.txtMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(132, 22);
            this.txtMax.TabIndex = 1;
            // 
            // txtLow
            // 
            this.txtLow.Location = new System.Drawing.Point(431, 107);
            this.txtLow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLow.Name = "txtLow";
            this.txtLow.Size = new System.Drawing.Size(132, 22);
            this.txtLow.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "itemID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Max Capacity Warning";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Low Inventory Warning";
            // 
            // btnUpdateWarningValues
            // 
            this.btnUpdateWarningValues.Location = new System.Drawing.Point(573, 152);
            this.btnUpdateWarningValues.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateWarningValues.Name = "btnUpdateWarningValues";
            this.btnUpdateWarningValues.Size = new System.Drawing.Size(201, 33);
            this.btnUpdateWarningValues.TabIndex = 6;
            this.btnUpdateWarningValues.Text = "Change Warning Values";
            this.btnUpdateWarningValues.UseVisualStyleBackColor = true;
            this.btnUpdateWarningValues.Click += new System.EventHandler(this.btnUpdateWarningValues_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(690, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter a stock item ID. Then indicate how much warehouse space is allocated to thi" +
    "s item (Max Capacity) and ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(370, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "what level of inventory triggers a warning (Low Inventory).";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(447, 152);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 33);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ItemCapacityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 219);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUpdateWarningValues);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtItemID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(404, 92);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ItemCapacityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Item Capacity Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateWarningValues;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
    }
}