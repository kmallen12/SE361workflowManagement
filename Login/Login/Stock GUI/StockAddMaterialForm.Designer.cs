namespace WorkFlowManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMaterialForm));
            this.lblMaterialType = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_unitCost = new System.Windows.Forms.Label();
            this.lbl_totalCost = new System.Windows.Forms.Label();
            this.lbl_dateAcq = new System.Windows.Forms.Label();
            this.lbl_dateUsed = new System.Windows.Forms.Label();
            this.lbl_defected = new System.Windows.Forms.Label();
            this.Another_Material_btn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txt_materialType = new System.Windows.Forms.ComboBox();
            this.btnCustomizeMaterials = new System.Windows.Forms.Button();
            this.lblRequiredMaterial = new System.Windows.Forms.Label();
            this.lblRequiredQuantity = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txt_Quantity = new System.Windows.Forms.NumericUpDown();
            this.txt_Defected = new System.Windows.Forms.NumericUpDown();
            this.txt_unitCost = new System.Windows.Forms.NumericUpDown();
            this.txt_TotalCost = new System.Windows.Forms.NumericUpDown();
            this.txt_DateAcq = new System.Windows.Forms.DateTimePicker();
            this.txt_dateUsed = new System.Windows.Forms.DateTimePicker();
            this.lblAddToList = new System.Windows.Forms.Label();
            this.StsAddMaterial = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Defected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_unitCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TotalCost)).BeginInit();
            this.StsAddMaterial.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaterialType
            // 
            this.lblMaterialType.AutoSize = true;
            this.lblMaterialType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialType.Location = new System.Drawing.Point(117, 57);
            this.lblMaterialType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaterialType.Name = "lblMaterialType";
            this.lblMaterialType.Size = new System.Drawing.Size(136, 24);
            this.lblMaterialType.TabIndex = 0;
            this.lblMaterialType.Text = "Material Type";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.Location = new System.Drawing.Point(117, 124);
            this.lbl_quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(86, 24);
            this.lbl_quantity.TabIndex = 1;
            this.lbl_quantity.Text = "Quantity";
            // 
            // lbl_unitCost
            // 
            this.lbl_unitCost.AutoSize = true;
            this.lbl_unitCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unitCost.Location = new System.Drawing.Point(117, 199);
            this.lbl_unitCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_unitCost.Name = "lbl_unitCost";
            this.lbl_unitCost.Size = new System.Drawing.Size(93, 24);
            this.lbl_unitCost.TabIndex = 2;
            this.lbl_unitCost.Text = "Unit Cost";
            // 
            // lbl_totalCost
            // 
            this.lbl_totalCost.AutoSize = true;
            this.lbl_totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalCost.Location = new System.Drawing.Point(117, 244);
            this.lbl_totalCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_totalCost.Name = "lbl_totalCost";
            this.lbl_totalCost.Size = new System.Drawing.Size(103, 24);
            this.lbl_totalCost.TabIndex = 3;
            this.lbl_totalCost.Text = "Total Cost";
            // 
            // lbl_dateAcq
            // 
            this.lbl_dateAcq.AutoSize = true;
            this.lbl_dateAcq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateAcq.Location = new System.Drawing.Point(117, 281);
            this.lbl_dateAcq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dateAcq.Name = "lbl_dateAcq";
            this.lbl_dateAcq.Size = new System.Drawing.Size(143, 24);
            this.lbl_dateAcq.TabIndex = 4;
            this.lbl_dateAcq.Text = "Date Acquired";
            // 
            // lbl_dateUsed
            // 
            this.lbl_dateUsed.AutoSize = true;
            this.lbl_dateUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateUsed.Location = new System.Drawing.Point(117, 325);
            this.lbl_dateUsed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dateUsed.Name = "lbl_dateUsed";
            this.lbl_dateUsed.Size = new System.Drawing.Size(106, 24);
            this.lbl_dateUsed.TabIndex = 5;
            this.lbl_dateUsed.Text = "Date Used";
            // 
            // lbl_defected
            // 
            this.lbl_defected.AutoSize = true;
            this.lbl_defected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_defected.Location = new System.Drawing.Point(117, 369);
            this.lbl_defected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_defected.Name = "lbl_defected";
            this.lbl_defected.Size = new System.Drawing.Size(222, 24);
            this.lbl_defected.TabIndex = 11;
            this.lbl_defected.Text = "# of Defected Materials";
            // 
            // Another_Material_btn
            // 
            this.Another_Material_btn.Location = new System.Drawing.Point(363, 414);
            this.Another_Material_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Another_Material_btn.Name = "Another_Material_btn";
            this.Another_Material_btn.Size = new System.Drawing.Size(153, 28);
            this.Another_Material_btn.TabIndex = 10;
            this.Another_Material_btn.Text = "Add Stock";
            this.Another_Material_btn.UseVisualStyleBackColor = true;
            this.Another_Material_btn.Click += new System.EventHandler(this.Another_Material_btn_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(524, 414);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 28);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txt_materialType
            // 
            this.txt_materialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_materialType.FormattingEnabled = true;
            this.txt_materialType.Location = new System.Drawing.Point(363, 60);
            this.txt_materialType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_materialType.Name = "txt_materialType";
            this.txt_materialType.Size = new System.Drawing.Size(233, 24);
            this.txt_materialType.TabIndex = 1;
            // 
            // btnCustomizeMaterials
            // 
            this.btnCustomizeMaterials.Location = new System.Drawing.Point(629, 59);
            this.btnCustomizeMaterials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomizeMaterials.Name = "btnCustomizeMaterials";
            this.btnCustomizeMaterials.Size = new System.Drawing.Size(121, 27);
            this.btnCustomizeMaterials.TabIndex = 2;
            this.btnCustomizeMaterials.Text = "Customize List";
            this.btnCustomizeMaterials.UseVisualStyleBackColor = true;
            this.btnCustomizeMaterials.Click += new System.EventHandler(this.btnCustomizeMaterials_Click);
            // 
            // lblRequiredMaterial
            // 
            this.lblRequiredMaterial.AutoSize = true;
            this.lblRequiredMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredMaterial.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredMaterial.Location = new System.Drawing.Point(143, 79);
            this.lblRequiredMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequiredMaterial.Name = "lblRequiredMaterial";
            this.lblRequiredMaterial.Size = new System.Drawing.Size(77, 18);
            this.lblRequiredMaterial.TabIndex = 18;
            this.lblRequiredMaterial.Text = "(Required)";
            // 
            // lblRequiredQuantity
            // 
            this.lblRequiredQuantity.AutoSize = true;
            this.lblRequiredQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredQuantity.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredQuantity.Location = new System.Drawing.Point(143, 146);
            this.lblRequiredQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequiredQuantity.Name = "lblRequiredQuantity";
            this.lblRequiredQuantity.Size = new System.Drawing.Size(77, 18);
            this.lblRequiredQuantity.TabIndex = 19;
            this.lblRequiredQuantity.Text = "(Required)";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(629, 238);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(121, 28);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(363, 127);
            this.txt_Quantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Quantity.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(235, 22);
            this.txt_Quantity.TabIndex = 3;
            // 
            // txt_Defected
            // 
            this.txt_Defected.Location = new System.Drawing.Point(363, 367);
            this.txt_Defected.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Defected.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txt_Defected.Name = "txt_Defected";
            this.txt_Defected.Size = new System.Drawing.Size(235, 22);
            this.txt_Defected.TabIndex = 9;
            // 
            // txt_unitCost
            // 
            this.txt_unitCost.Location = new System.Drawing.Point(363, 197);
            this.txt_unitCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_unitCost.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txt_unitCost.Name = "txt_unitCost";
            this.txt_unitCost.Size = new System.Drawing.Size(235, 22);
            this.txt_unitCost.TabIndex = 4;
            // 
            // txt_TotalCost
            // 
            this.txt_TotalCost.Location = new System.Drawing.Point(363, 238);
            this.txt_TotalCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TotalCost.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txt_TotalCost.Name = "txt_TotalCost";
            this.txt_TotalCost.Size = new System.Drawing.Size(235, 22);
            this.txt_TotalCost.TabIndex = 5;
            // 
            // txt_DateAcq
            // 
            this.txt_DateAcq.CustomFormat = " ";
            this.txt_DateAcq.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_DateAcq.Location = new System.Drawing.Point(363, 277);
            this.txt_DateAcq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_DateAcq.Name = "txt_DateAcq";
            this.txt_DateAcq.Size = new System.Drawing.Size(233, 22);
            this.txt_DateAcq.TabIndex = 7;
            this.txt_DateAcq.Value = new System.DateTime(2019, 4, 14, 20, 55, 8, 0);
            this.txt_DateAcq.ValueChanged += new System.EventHandler(this.txt_DateAcq_ValueChanged);
            // 
            // txt_dateUsed
            // 
            this.txt_dateUsed.CustomFormat = " ";
            this.txt_dateUsed.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_dateUsed.Location = new System.Drawing.Point(363, 322);
            this.txt_dateUsed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_dateUsed.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txt_dateUsed.Name = "txt_dateUsed";
            this.txt_dateUsed.Size = new System.Drawing.Size(233, 22);
            this.txt_dateUsed.TabIndex = 8;
            this.txt_dateUsed.Value = new System.DateTime(2019, 4, 14, 20, 55, 8, 0);
            this.txt_dateUsed.ValueChanged += new System.EventHandler(this.txt_dateUsed_ValueChanged);
            // 
            // lblAddToList
            // 
            this.lblAddToList.AutoSize = true;
            this.lblAddToList.Location = new System.Drawing.Point(596, 42);
            this.lblAddToList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddToList.Name = "lblAddToList";
            this.lblAddToList.Size = new System.Drawing.Size(179, 17);
            this.lblAddToList.TabIndex = 20;
            this.lblAddToList.Text = "Item not in List? Click Here:";
            // 
            // StsAddMaterial
            // 
            this.StsAddMaterial.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StsAddMaterial.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.StsAddMaterial.Location = new System.Drawing.Point(0, 471);
            this.StsAddMaterial.Name = "StsAddMaterial";
            this.StsAddMaterial.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StsAddMaterial.Size = new System.Drawing.Size(777, 25);
            this.StsAddMaterial.TabIndex = 21;
            this.StsAddMaterial.Text = "Once material added to list, review and add to database";
            this.StsAddMaterial.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.StsAddMaterial_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(289, 20);
            this.toolStripStatusLabel1.Text = "Add material to list, then save to database";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 20);
            // 
            // AddMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 496);
            this.ControlBox = false;
            this.Controls.Add(this.StsAddMaterial);
            this.Controls.Add(this.lblAddToList);
            this.Controls.Add(this.txt_dateUsed);
            this.Controls.Add(this.txt_DateAcq);
            this.Controls.Add(this.txt_TotalCost);
            this.Controls.Add(this.txt_unitCost);
            this.Controls.Add(this.txt_Defected);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblRequiredQuantity);
            this.Controls.Add(this.lblRequiredMaterial);
            this.Controls.Add(this.btnCustomizeMaterials);
            this.Controls.Add(this.txt_materialType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Another_Material_btn);
            this.Controls.Add(this.lbl_defected);
            this.Controls.Add(this.lbl_dateUsed);
            this.Controls.Add(this.lbl_dateAcq);
            this.Controls.Add(this.lbl_totalCost);
            this.Controls.Add(this.lbl_unitCost);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lblMaterialType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(404, 92);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddMaterialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Add Raw Material";
            this.Load += new System.EventHandler(this.AddMaterialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Defected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_unitCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TotalCost)).EndInit();
            this.StsAddMaterial.ResumeLayout(false);
            this.StsAddMaterial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaterialType;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_unitCost;
        private System.Windows.Forms.Label lbl_totalCost;
        private System.Windows.Forms.Label lbl_dateAcq;
        private System.Windows.Forms.Label lbl_dateUsed;
        private System.Windows.Forms.Label lbl_defected;
        private System.Windows.Forms.Button Another_Material_btn;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox txt_materialType;
        private System.Windows.Forms.Button btnCustomizeMaterials;
        private System.Windows.Forms.Label lblRequiredMaterial;
        private System.Windows.Forms.Label lblRequiredQuantity;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown txt_Quantity;
        private System.Windows.Forms.NumericUpDown txt_Defected;
        private System.Windows.Forms.NumericUpDown txt_unitCost;
        private System.Windows.Forms.NumericUpDown txt_TotalCost;
        private System.Windows.Forms.DateTimePicker txt_DateAcq;
        private System.Windows.Forms.DateTimePicker txt_dateUsed;
        private System.Windows.Forms.Label lblAddToList;
        private System.Windows.Forms.StatusStrip StsAddMaterial;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}