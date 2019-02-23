namespace WorkflowManagement
{
    partial class AddMaterialForm
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
            this.materialType = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_unitCost = new System.Windows.Forms.Label();
            this.lbl_totalCost = new System.Windows.Forms.Label();
            this.lbl_dateAcq = new System.Windows.Forms.Label();
            this.lbl_dateUsed = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_unitCost = new System.Windows.Forms.TextBox();
            this.txt_DateAcq = new System.Windows.Forms.TextBox();
            this.txt_dateUsed = new System.Windows.Forms.TextBox();
            this.txt_Defected = new System.Windows.Forms.TextBox();
            this.lbl_defected = new System.Windows.Forms.Label();
            this.txt_TotalCost = new System.Windows.Forms.TextBox();
            this.Another_Material_btn = new System.Windows.Forms.Button();
            this.Confirm_Material_btn = new System.Windows.Forms.Button();
            this.txt_materialType = new System.Windows.Forms.ComboBox();
            this.btnCustomizeMaterials = new System.Windows.Forms.Button();
            this.lblRequiredMaterial = new System.Windows.Forms.Label();
            this.lblRequiredQuantity = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // materialType
            // 
            this.materialType.AutoSize = true;
            this.materialType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialType.Location = new System.Drawing.Point(88, 46);
            this.materialType.Name = "materialType";
            this.materialType.Size = new System.Drawing.Size(114, 18);
            this.materialType.TabIndex = 0;
            this.materialType.Text = "Material Type:";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.Location = new System.Drawing.Point(88, 101);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(75, 18);
            this.lbl_quantity.TabIndex = 1;
            this.lbl_quantity.Text = "Quantity:";
            // 
            // lbl_unitCost
            // 
            this.lbl_unitCost.AutoSize = true;
            this.lbl_unitCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unitCost.Location = new System.Drawing.Point(88, 212);
            this.lbl_unitCost.Name = "lbl_unitCost";
            this.lbl_unitCost.Size = new System.Drawing.Size(89, 18);
            this.lbl_unitCost.TabIndex = 2;
            this.lbl_unitCost.Text = "Unit Cost: ";
            this.lbl_unitCost.Click += new System.EventHandler(this.lbl_unitCost_Click);
            // 
            // lbl_totalCost
            // 
            this.lbl_totalCost.AutoSize = true;
            this.lbl_totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalCost.Location = new System.Drawing.Point(88, 268);
            this.lbl_totalCost.Name = "lbl_totalCost";
            this.lbl_totalCost.Size = new System.Drawing.Size(97, 18);
            this.lbl_totalCost.TabIndex = 3;
            this.lbl_totalCost.Text = "Total Cost: ";
            // 
            // lbl_dateAcq
            // 
            this.lbl_dateAcq.AutoSize = true;
            this.lbl_dateAcq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateAcq.Location = new System.Drawing.Point(88, 325);
            this.lbl_dateAcq.Name = "lbl_dateAcq";
            this.lbl_dateAcq.Size = new System.Drawing.Size(118, 18);
            this.lbl_dateAcq.TabIndex = 4;
            this.lbl_dateAcq.Text = "Date Acquired:";
            // 
            // lbl_dateUsed
            // 
            this.lbl_dateUsed.AutoSize = true;
            this.lbl_dateUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateUsed.Location = new System.Drawing.Point(88, 382);
            this.lbl_dateUsed.Name = "lbl_dateUsed";
            this.lbl_dateUsed.Size = new System.Drawing.Size(97, 18);
            this.lbl_dateUsed.TabIndex = 5;
            this.lbl_dateUsed.Text = "Date Used: ";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(272, 101);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(176, 20);
            this.txt_Quantity.TabIndex = 7;
            // 
            // txt_unitCost
            // 
            this.txt_unitCost.Location = new System.Drawing.Point(272, 212);
            this.txt_unitCost.Name = "txt_unitCost";
            this.txt_unitCost.Size = new System.Drawing.Size(176, 20);
            this.txt_unitCost.TabIndex = 9;
            // 
            // txt_DateAcq
            // 
            this.txt_DateAcq.Location = new System.Drawing.Point(272, 326);
            this.txt_DateAcq.Name = "txt_DateAcq";
            this.txt_DateAcq.Size = new System.Drawing.Size(176, 20);
            this.txt_DateAcq.TabIndex = 11;
            // 
            // txt_dateUsed
            // 
            this.txt_dateUsed.Location = new System.Drawing.Point(272, 380);
            this.txt_dateUsed.Name = "txt_dateUsed";
            this.txt_dateUsed.Size = new System.Drawing.Size(176, 20);
            this.txt_dateUsed.TabIndex = 12;
            // 
            // txt_Defected
            // 
            this.txt_Defected.Location = new System.Drawing.Point(272, 150);
            this.txt_Defected.Name = "txt_Defected";
            this.txt_Defected.Size = new System.Drawing.Size(176, 20);
            this.txt_Defected.TabIndex = 8;
            // 
            // lbl_defected
            // 
            this.lbl_defected.AutoSize = true;
            this.lbl_defected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_defected.Location = new System.Drawing.Point(88, 150);
            this.lbl_defected.Name = "lbl_defected";
            this.lbl_defected.Size = new System.Drawing.Size(188, 18);
            this.lbl_defected.TabIndex = 11;
            this.lbl_defected.Text = "# of Defected Materials:";
            // 
            // txt_TotalCost
            // 
            this.txt_TotalCost.Location = new System.Drawing.Point(272, 266);
            this.txt_TotalCost.Name = "txt_TotalCost";
            this.txt_TotalCost.Size = new System.Drawing.Size(176, 20);
            this.txt_TotalCost.TabIndex = 10;
            // 
            // Another_Material_btn
            // 
            this.Another_Material_btn.Location = new System.Drawing.Point(136, 415);
            this.Another_Material_btn.Name = "Another_Material_btn";
            this.Another_Material_btn.Size = new System.Drawing.Size(176, 23);
            this.Another_Material_btn.TabIndex = 14;
            this.Another_Material_btn.Text = "Add Another Material";
            this.Another_Material_btn.UseVisualStyleBackColor = true;
            this.Another_Material_btn.Click += new System.EventHandler(this.Another_Material_btn_Click);
            // 
            // Confirm_Material_btn
            // 
            this.Confirm_Material_btn.Location = new System.Drawing.Point(375, 415);
            this.Confirm_Material_btn.Name = "Confirm_Material_btn";
            this.Confirm_Material_btn.Size = new System.Drawing.Size(176, 23);
            this.Confirm_Material_btn.TabIndex = 15;
            this.Confirm_Material_btn.Text = "Confirm Material And Exit";
            this.Confirm_Material_btn.UseVisualStyleBackColor = true;
            this.Confirm_Material_btn.Click += new System.EventHandler(this.Confirm_Material_btn_Click);
            // 
            // txt_materialType
            // 
            this.txt_materialType.FormattingEnabled = true;
            this.txt_materialType.Location = new System.Drawing.Point(272, 49);
            this.txt_materialType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_materialType.Name = "txt_materialType";
            this.txt_materialType.Size = new System.Drawing.Size(176, 21);
            this.txt_materialType.TabIndex = 16;
            // 
            // btnCustomizeMaterials
            // 
            this.btnCustomizeMaterials.Location = new System.Drawing.Point(472, 48);
            this.btnCustomizeMaterials.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCustomizeMaterials.Name = "btnCustomizeMaterials";
            this.btnCustomizeMaterials.Size = new System.Drawing.Size(91, 22);
            this.btnCustomizeMaterials.TabIndex = 17;
            this.btnCustomizeMaterials.Text = "Customize List";
            this.btnCustomizeMaterials.UseVisualStyleBackColor = true;
            this.btnCustomizeMaterials.Click += new System.EventHandler(this.btnCustomizeMaterials_Click);
            // 
            // lblRequiredMaterial
            // 
            this.lblRequiredMaterial.AutoSize = true;
            this.lblRequiredMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredMaterial.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredMaterial.Location = new System.Drawing.Point(107, 64);
            this.lblRequiredMaterial.Name = "lblRequiredMaterial";
            this.lblRequiredMaterial.Size = new System.Drawing.Size(66, 15);
            this.lblRequiredMaterial.TabIndex = 18;
            this.lblRequiredMaterial.Text = "(Required)";
            // 
            // lblRequiredQuantity
            // 
            this.lblRequiredQuantity.AutoSize = true;
            this.lblRequiredQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredQuantity.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredQuantity.Location = new System.Drawing.Point(107, 119);
            this.lblRequiredQuantity.Name = "lblRequiredQuantity";
            this.lblRequiredQuantity.Size = new System.Drawing.Size(66, 15);
            this.lblRequiredQuantity.TabIndex = 19;
            this.lblRequiredQuantity.Text = "(Required)";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(472, 263);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(91, 23);
            this.btnCalculate.TabIndex = 20;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // AddMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblRequiredQuantity);
            this.Controls.Add(this.lblRequiredMaterial);
            this.Controls.Add(this.btnCustomizeMaterials);
            this.Controls.Add(this.txt_materialType);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.txt_Defected);
            this.Controls.Add(this.txt_unitCost);
            this.Controls.Add(this.txt_TotalCost);
            this.Controls.Add(this.txt_DateAcq);
            this.Controls.Add(this.txt_dateUsed);
            this.Controls.Add(this.Confirm_Material_btn);
            this.Controls.Add(this.Another_Material_btn);
            this.Controls.Add(this.lbl_defected);
            this.Controls.Add(this.lbl_dateUsed);
            this.Controls.Add(this.lbl_dateAcq);
            this.Controls.Add(this.lbl_totalCost);
            this.Controls.Add(this.lbl_unitCost);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.materialType);
            this.Name = "AddMaterialForm";
            this.Text = "Add Raw Material";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label materialType;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_unitCost;
        private System.Windows.Forms.Label lbl_totalCost;
        private System.Windows.Forms.Label lbl_dateAcq;
        private System.Windows.Forms.Label lbl_dateUsed;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.TextBox txt_unitCost;
        private System.Windows.Forms.TextBox txt_DateAcq;
        private System.Windows.Forms.TextBox txt_dateUsed;
        private System.Windows.Forms.TextBox txt_Defected;
        private System.Windows.Forms.Label lbl_defected;
        private System.Windows.Forms.TextBox txt_TotalCost;
        private System.Windows.Forms.Button Another_Material_btn;
        private System.Windows.Forms.Button Confirm_Material_btn;
        private System.Windows.Forms.ComboBox txt_materialType;
        private System.Windows.Forms.Button btnCustomizeMaterials;
        private System.Windows.Forms.Label lblRequiredMaterial;
        private System.Windows.Forms.Label lblRequiredQuantity;
        private System.Windows.Forms.Button btnCalculate;
    }
}