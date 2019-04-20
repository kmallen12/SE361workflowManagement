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
            this.btnSaveToDB = new System.Windows.Forms.Button();
            this.lstStocks = new System.Windows.Forms.ListView();
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
            this.lblMaterialType.Location = new System.Drawing.Point(88, 46);
            this.lblMaterialType.Name = "lblMaterialType";
            this.lblMaterialType.Size = new System.Drawing.Size(109, 18);
            this.lblMaterialType.TabIndex = 0;
            this.lblMaterialType.Text = "Material Type";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.Location = new System.Drawing.Point(88, 101);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(70, 18);
            this.lbl_quantity.TabIndex = 1;
            this.lbl_quantity.Text = "Quantity";
            // 
            // lbl_unitCost
            // 
            this.lbl_unitCost.AutoSize = true;
            this.lbl_unitCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unitCost.Location = new System.Drawing.Point(88, 197);
            this.lbl_unitCost.Name = "lbl_unitCost";
            this.lbl_unitCost.Size = new System.Drawing.Size(79, 18);
            this.lbl_unitCost.TabIndex = 2;
            this.lbl_unitCost.Text = "Unit Cost";
            // 
            // lbl_totalCost
            // 
            this.lbl_totalCost.AutoSize = true;
            this.lbl_totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalCost.Location = new System.Drawing.Point(88, 233);
            this.lbl_totalCost.Name = "lbl_totalCost";
            this.lbl_totalCost.Size = new System.Drawing.Size(87, 18);
            this.lbl_totalCost.TabIndex = 3;
            this.lbl_totalCost.Text = "Total Cost";
            // 
            // lbl_dateAcq
            // 
            this.lbl_dateAcq.AutoSize = true;
            this.lbl_dateAcq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateAcq.Location = new System.Drawing.Point(88, 263);
            this.lbl_dateAcq.Name = "lbl_dateAcq";
            this.lbl_dateAcq.Size = new System.Drawing.Size(113, 18);
            this.lbl_dateAcq.TabIndex = 4;
            this.lbl_dateAcq.Text = "Date Acquired";
            // 
            // lbl_dateUsed
            // 
            this.lbl_dateUsed.AutoSize = true;
            this.lbl_dateUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateUsed.Location = new System.Drawing.Point(88, 299);
            this.lbl_dateUsed.Name = "lbl_dateUsed";
            this.lbl_dateUsed.Size = new System.Drawing.Size(87, 18);
            this.lbl_dateUsed.TabIndex = 5;
            this.lbl_dateUsed.Text = "Date Used";
            // 
            // lbl_defected
            // 
            this.lbl_defected.AutoSize = true;
            this.lbl_defected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_defected.Location = new System.Drawing.Point(88, 162);
            this.lbl_defected.Name = "lbl_defected";
            this.lbl_defected.Size = new System.Drawing.Size(183, 18);
            this.lbl_defected.TabIndex = 11;
            this.lbl_defected.Text = "# of Defected Materials";
            // 
            // Another_Material_btn
            // 
            this.Another_Material_btn.Location = new System.Drawing.Point(300, 336);
            this.Another_Material_btn.Name = "Another_Material_btn";
            this.Another_Material_btn.Size = new System.Drawing.Size(115, 23);
            this.Another_Material_btn.TabIndex = 10;
            this.Another_Material_btn.Text = "Add Stock";
            this.Another_Material_btn.UseVisualStyleBackColor = true;
            this.Another_Material_btn.Click += new System.EventHandler(this.Another_Material_btn_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(331, 489);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(136, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txt_materialType
            // 
            this.txt_materialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_materialType.FormattingEnabled = true;
            this.txt_materialType.Location = new System.Drawing.Point(272, 49);
            this.txt_materialType.Margin = new System.Windows.Forms.Padding(2);
            this.txt_materialType.Name = "txt_materialType";
            this.txt_materialType.Size = new System.Drawing.Size(176, 21);
            this.txt_materialType.TabIndex = 1;
            // 
            // btnCustomizeMaterials
            // 
            this.btnCustomizeMaterials.Location = new System.Drawing.Point(472, 48);
            this.btnCustomizeMaterials.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomizeMaterials.Name = "btnCustomizeMaterials";
            this.btnCustomizeMaterials.Size = new System.Drawing.Size(91, 22);
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
            this.btnCalculate.Location = new System.Drawing.Point(472, 228);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(91, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.Location = new System.Drawing.Point(173, 489);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Size = new System.Drawing.Size(136, 23);
            this.btnSaveToDB.TabIndex = 12;
            this.btnSaveToDB.Text = "SAVE TO DATABASE";
            this.btnSaveToDB.UseVisualStyleBackColor = true;
            this.btnSaveToDB.Click += new System.EventHandler(this.btnSaveToDB_Click);
            // 
            // lstStocks
            // 
            this.lstStocks.Location = new System.Drawing.Point(22, 392);
            this.lstStocks.Margin = new System.Windows.Forms.Padding(2);
            this.lstStocks.Name = "lstStocks";
            this.lstStocks.Size = new System.Drawing.Size(541, 80);
            this.lstStocks.TabIndex = 11;
            this.lstStocks.UseCompatibleStateImageBehavior = false;
            this.lstStocks.View = System.Windows.Forms.View.List;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(272, 103);
            this.txt_Quantity.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(176, 20);
            this.txt_Quantity.TabIndex = 3;
            // 
            // txt_Defected
            // 
            this.txt_Defected.Location = new System.Drawing.Point(272, 160);
            this.txt_Defected.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txt_Defected.Name = "txt_Defected";
            this.txt_Defected.Size = new System.Drawing.Size(176, 20);
            this.txt_Defected.TabIndex = 4;
            // 
            // txt_unitCost
            // 
            this.txt_unitCost.Location = new System.Drawing.Point(272, 195);
            this.txt_unitCost.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txt_unitCost.Name = "txt_unitCost";
            this.txt_unitCost.Size = new System.Drawing.Size(176, 20);
            this.txt_unitCost.TabIndex = 5;
            // 
            // txt_TotalCost
            // 
            this.txt_TotalCost.Location = new System.Drawing.Point(272, 228);
            this.txt_TotalCost.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txt_TotalCost.Name = "txt_TotalCost";
            this.txt_TotalCost.Size = new System.Drawing.Size(176, 20);
            this.txt_TotalCost.TabIndex = 6;
            // 
            // txt_DateAcq
            // 
            this.txt_DateAcq.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_DateAcq.Location = new System.Drawing.Point(272, 260);
            this.txt_DateAcq.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txt_DateAcq.Name = "txt_DateAcq";
            this.txt_DateAcq.Size = new System.Drawing.Size(176, 20);
            this.txt_DateAcq.TabIndex = 8;
            this.txt_DateAcq.Value = new System.DateTime(2019, 4, 14, 20, 55, 8, 0);
            // 
            // txt_dateUsed
            // 
            this.txt_dateUsed.CustomFormat = "";
            this.txt_dateUsed.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_dateUsed.Location = new System.Drawing.Point(272, 297);
            this.txt_dateUsed.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txt_dateUsed.Name = "txt_dateUsed";
            this.txt_dateUsed.Size = new System.Drawing.Size(176, 20);
            this.txt_dateUsed.TabIndex = 9;
            this.txt_dateUsed.Value = new System.DateTime(2019, 4, 14, 20, 55, 8, 0);
            this.txt_dateUsed.ValueChanged += new System.EventHandler(this.txt_dateUsed_ValueChanged);
            // 
            // lblAddToList
            // 
            this.lblAddToList.AutoSize = true;
            this.lblAddToList.Location = new System.Drawing.Point(447, 34);
            this.lblAddToList.Name = "lblAddToList";
            this.lblAddToList.Size = new System.Drawing.Size(136, 13);
            this.lblAddToList.TabIndex = 20;
            this.lblAddToList.Text = "Item not in List? Click Here:";
            // 
            // StsAddMaterial
            // 
            this.StsAddMaterial.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.StsAddMaterial.Location = new System.Drawing.Point(0, 534);
            this.StsAddMaterial.Name = "StsAddMaterial";
            this.StsAddMaterial.Size = new System.Drawing.Size(583, 22);
            this.StsAddMaterial.TabIndex = 21;
            this.StsAddMaterial.Text = "Once material added to list, review and add to database";
            this.StsAddMaterial.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.StsAddMaterial_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(227, 17);
            this.toolStripStatusLabel1.Text = "Add material to list, then save to database";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // AddMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 556);
            this.ControlBox = false;
            this.Controls.Add(this.StsAddMaterial);
            this.Controls.Add(this.lblAddToList);
            this.Controls.Add(this.txt_dateUsed);
            this.Controls.Add(this.txt_DateAcq);
            this.Controls.Add(this.txt_TotalCost);
            this.Controls.Add(this.txt_unitCost);
            this.Controls.Add(this.txt_Defected);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.lstStocks);
            this.Controls.Add(this.btnSaveToDB);
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
            this.Name = "AddMaterialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Add Raw Material";
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
        private System.Windows.Forms.Button btnSaveToDB;
        private System.Windows.Forms.ListView lstStocks;
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