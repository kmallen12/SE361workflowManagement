﻿namespace WorkFlowManagement
{
    partial class UpdateStockForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStockForm));
            this.lbl_warehouseSummary = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAcquiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateUsedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amtDefectedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workFlowDatabaseDataSet = new Login.WorkFlowDatabaseDataSet();
            this.stockTableTableAdapter = new Login.WorkFlowDatabaseDataSetTableAdapters.StockTableTableAdapter();
            this.Enter_ID_lbl = new System.Windows.Forms.Label();
            this.ConfirmGrid_btn = new System.Windows.Forms.Button();
            this.btnLoadStockFromDB = new System.Windows.Forms.Button();
            this.lblItemID = new System.Windows.Forms.Label();
            this.lblMaterialType = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblUnitCost = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblDateAcq = new System.Windows.Forms.Label();
            this.lblDateUsed = new System.Windows.Forms.Label();
            this.lblDefects = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtMaterialType = new System.Windows.Forms.ComboBox();
            this.ItemIDGrid_box = new System.Windows.Forms.ComboBox();
            this.quantityGrid_box = new System.Windows.Forms.NumericUpDown();
            this.unitCostGrid_box = new System.Windows.Forms.NumericUpDown();
            this.totalCostGrid_box = new System.Windows.Forms.NumericUpDown();
            this.amtDefectedGrid_box = new System.Windows.Forms.NumericUpDown();
            this.dateAcquiredGrid_box = new System.Windows.Forms.DateTimePicker();
            this.dateUsedGrid_box = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityGrid_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitCostGrid_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalCostGrid_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amtDefectedGrid_box)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_warehouseSummary
            // 
            this.lbl_warehouseSummary.AutoSize = true;
            this.lbl_warehouseSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warehouseSummary.Location = new System.Drawing.Point(46, 39);
            this.lbl_warehouseSummary.Name = "lbl_warehouseSummary";
            this.lbl_warehouseSummary.Size = new System.Drawing.Size(216, 24);
            this.lbl_warehouseSummary.TabIndex = 0;
            this.lbl_warehouseSummary.Text = "Warehouse Summary:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.materialTypeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitCostDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.dateAcquiredDataGridViewTextBoxColumn,
            this.dateUsedDataGridViewTextBoxColumn,
            this.amtDefectedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stockTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 5;
            this.dataGridView1.Size = new System.Drawing.Size(808, 323);
            this.dataGridView1.TabIndex = 1;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "itemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "Item ID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialTypeDataGridViewTextBoxColumn
            // 
            this.materialTypeDataGridViewTextBoxColumn.DataPropertyName = "materialType";
            this.materialTypeDataGridViewTextBoxColumn.HeaderText = "Material Type";
            this.materialTypeDataGridViewTextBoxColumn.Name = "materialTypeDataGridViewTextBoxColumn";
            this.materialTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // unitCostDataGridViewTextBoxColumn
            // 
            this.unitCostDataGridViewTextBoxColumn.DataPropertyName = "unitCost";
            this.unitCostDataGridViewTextBoxColumn.HeaderText = "Unit Cost";
            this.unitCostDataGridViewTextBoxColumn.Name = "unitCostDataGridViewTextBoxColumn";
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "totalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "Total Cost";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            // 
            // dateAcquiredDataGridViewTextBoxColumn
            // 
            this.dateAcquiredDataGridViewTextBoxColumn.DataPropertyName = "dateAcquired";
            this.dateAcquiredDataGridViewTextBoxColumn.HeaderText = "Date Acquired";
            this.dateAcquiredDataGridViewTextBoxColumn.Name = "dateAcquiredDataGridViewTextBoxColumn";
            // 
            // dateUsedDataGridViewTextBoxColumn
            // 
            this.dateUsedDataGridViewTextBoxColumn.DataPropertyName = "dateUsed";
            this.dateUsedDataGridViewTextBoxColumn.HeaderText = "Date Used";
            this.dateUsedDataGridViewTextBoxColumn.Name = "dateUsedDataGridViewTextBoxColumn";
            // 
            // amtDefectedDataGridViewTextBoxColumn
            // 
            this.amtDefectedDataGridViewTextBoxColumn.DataPropertyName = "amtDefected";
            this.amtDefectedDataGridViewTextBoxColumn.HeaderText = "Amout Defected";
            this.amtDefectedDataGridViewTextBoxColumn.Name = "amtDefectedDataGridViewTextBoxColumn";
            // 
            // stockTableBindingSource
            // 
            this.stockTableBindingSource.DataMember = "StockTable";
            this.stockTableBindingSource.DataSource = this.workFlowDatabaseDataSet;
            // 
            // workFlowDatabaseDataSet
            // 
            this.workFlowDatabaseDataSet.DataSetName = "WorkFlowDatabaseDataSet";
            this.workFlowDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockTableTableAdapter
            // 
            this.stockTableTableAdapter.ClearBeforeFill = true;
            // 
            // Enter_ID_lbl
            // 
            this.Enter_ID_lbl.AutoSize = true;
            this.Enter_ID_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_ID_lbl.Location = new System.Drawing.Point(15, 448);
            this.Enter_ID_lbl.Name = "Enter_ID_lbl";
            this.Enter_ID_lbl.Size = new System.Drawing.Size(398, 18);
            this.Enter_ID_lbl.TabIndex = 10;
            this.Enter_ID_lbl.Text = "To Add New: Omit Item ID and complete other fields";
            // 
            // ConfirmGrid_btn
            // 
            this.ConfirmGrid_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmGrid_btn.Location = new System.Drawing.Point(614, 527);
            this.ConfirmGrid_btn.Name = "ConfirmGrid_btn";
            this.ConfirmGrid_btn.Size = new System.Drawing.Size(94, 32);
            this.ConfirmGrid_btn.TabIndex = 11;
            this.ConfirmGrid_btn.Text = "Save";
            this.ConfirmGrid_btn.UseVisualStyleBackColor = true;
            this.ConfirmGrid_btn.Click += new System.EventHandler(this.ConfirmGrid_btn_Click);
            // 
            // btnLoadStockFromDB
            // 
            this.btnLoadStockFromDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadStockFromDB.Location = new System.Drawing.Point(290, 26);
            this.btnLoadStockFromDB.Name = "btnLoadStockFromDB";
            this.btnLoadStockFromDB.Size = new System.Drawing.Size(154, 52);
            this.btnLoadStockFromDB.TabIndex = 13;
            this.btnLoadStockFromDB.Text = "Refresh Table";
            this.btnLoadStockFromDB.UseVisualStyleBackColor = true;
            this.btnLoadStockFromDB.Click += new System.EventHandler(this.btnLoadStockFromDB_Click);
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemID.Location = new System.Drawing.Point(16, 473);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(46, 15);
            this.lblItemID.TabIndex = 14;
            this.lblItemID.Text = "Item ID";
            // 
            // lblMaterialType
            // 
            this.lblMaterialType.AutoSize = true;
            this.lblMaterialType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialType.Location = new System.Drawing.Point(116, 473);
            this.lblMaterialType.Name = "lblMaterialType";
            this.lblMaterialType.Size = new System.Drawing.Size(81, 15);
            this.lblMaterialType.TabIndex = 15;
            this.lblMaterialType.Text = "Material Type";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(218, 473);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(51, 15);
            this.lblQuantity.TabIndex = 16;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblUnitCost
            // 
            this.lblUnitCost.AutoSize = true;
            this.lblUnitCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitCost.Location = new System.Drawing.Point(318, 473);
            this.lblUnitCost.Name = "lblUnitCost";
            this.lblUnitCost.Size = new System.Drawing.Size(56, 15);
            this.lblUnitCost.TabIndex = 17;
            this.lblUnitCost.Text = "Unit Cost";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(418, 473);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(61, 15);
            this.lblTotalCost.TabIndex = 18;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // lblDateAcq
            // 
            this.lblDateAcq.AutoSize = true;
            this.lblDateAcq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAcq.Location = new System.Drawing.Point(520, 473);
            this.lblDateAcq.Name = "lblDateAcq";
            this.lblDateAcq.Size = new System.Drawing.Size(84, 15);
            this.lblDateAcq.TabIndex = 19;
            this.lblDateAcq.Text = "Date Acquired";
            // 
            // lblDateUsed
            // 
            this.lblDateUsed.AutoSize = true;
            this.lblDateUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateUsed.Location = new System.Drawing.Point(621, 473);
            this.lblDateUsed.Name = "lblDateUsed";
            this.lblDateUsed.Size = new System.Drawing.Size(65, 15);
            this.lblDateUsed.TabIndex = 20;
            this.lblDateUsed.Text = "Date Used";
            // 
            // lblDefects
            // 
            this.lblDefects.AutoSize = true;
            this.lblDefects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefects.Location = new System.Drawing.Point(722, 473);
            this.lblDefects.Name = "lblDefects";
            this.lblDefects.Size = new System.Drawing.Size(48, 15);
            this.lblDefects.TabIndex = 21;
            this.lblDefects.Text = "Defects";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(736, 527);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 32);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtMaterialType
            // 
            this.txtMaterialType.FormattingEnabled = true;
            this.txtMaterialType.Location = new System.Drawing.Point(117, 491);
            this.txtMaterialType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaterialType.Name = "txtMaterialType";
            this.txtMaterialType.Size = new System.Drawing.Size(95, 21);
            this.txtMaterialType.TabIndex = 23;
            // 
            // ItemIDGrid_box
            // 
            this.ItemIDGrid_box.FormattingEnabled = true;
            this.ItemIDGrid_box.Location = new System.Drawing.Point(18, 491);
            this.ItemIDGrid_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ItemIDGrid_box.Name = "ItemIDGrid_box";
            this.ItemIDGrid_box.Size = new System.Drawing.Size(95, 21);
            this.ItemIDGrid_box.TabIndex = 24;
            this.ItemIDGrid_box.SelectedIndexChanged += new System.EventHandler(this.ItemIDGrid_box_SelectedIndexChanged);
            // 
            // quantityGrid_box
            // 
            this.quantityGrid_box.Location = new System.Drawing.Point(218, 492);
            this.quantityGrid_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quantityGrid_box.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.quantityGrid_box.Name = "quantityGrid_box";
            this.quantityGrid_box.Size = new System.Drawing.Size(94, 20);
            this.quantityGrid_box.TabIndex = 25;
            // 
            // unitCostGrid_box
            // 
            this.unitCostGrid_box.DecimalPlaces = 2;
            this.unitCostGrid_box.Location = new System.Drawing.Point(320, 492);
            this.unitCostGrid_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unitCostGrid_box.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.unitCostGrid_box.Name = "unitCostGrid_box";
            this.unitCostGrid_box.Size = new System.Drawing.Size(94, 20);
            this.unitCostGrid_box.TabIndex = 26;
            // 
            // totalCostGrid_box
            // 
            this.totalCostGrid_box.DecimalPlaces = 2;
            this.totalCostGrid_box.Location = new System.Drawing.Point(420, 492);
            this.totalCostGrid_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.totalCostGrid_box.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.totalCostGrid_box.Name = "totalCostGrid_box";
            this.totalCostGrid_box.Size = new System.Drawing.Size(94, 20);
            this.totalCostGrid_box.TabIndex = 27;
            // 
            // amtDefectedGrid_box
            // 
            this.amtDefectedGrid_box.Location = new System.Drawing.Point(724, 492);
            this.amtDefectedGrid_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.amtDefectedGrid_box.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.amtDefectedGrid_box.Name = "amtDefectedGrid_box";
            this.amtDefectedGrid_box.Size = new System.Drawing.Size(94, 20);
            this.amtDefectedGrid_box.TabIndex = 28;
            // 
            // dateAcquiredGrid_box
            // 
            this.dateAcquiredGrid_box.CustomFormat = " ";
            this.dateAcquiredGrid_box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAcquiredGrid_box.Location = new System.Drawing.Point(521, 492);
            this.dateAcquiredGrid_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateAcquiredGrid_box.Name = "dateAcquiredGrid_box";
            this.dateAcquiredGrid_box.Size = new System.Drawing.Size(95, 20);
            this.dateAcquiredGrid_box.TabIndex = 29;
            this.dateAcquiredGrid_box.ValueChanged += new System.EventHandler(this.dateAcquiredGrid_box_ValueChanged);
            // 
            // dateUsedGrid_box
            // 
            this.dateUsedGrid_box.CustomFormat = " ";
            this.dateUsedGrid_box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateUsedGrid_box.Location = new System.Drawing.Point(623, 492);
            this.dateUsedGrid_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateUsedGrid_box.Name = "dateUsedGrid_box";
            this.dateUsedGrid_box.Size = new System.Drawing.Size(95, 20);
            this.dateUsedGrid_box.TabIndex = 30;
            this.dateUsedGrid_box.ValueChanged += new System.EventHandler(this.dateUsedGrid_box_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "To Update: Select Item ID and update the fields below";
            // 
            // UpdateStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 572);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateUsedGrid_box);
            this.Controls.Add(this.dateAcquiredGrid_box);
            this.Controls.Add(this.amtDefectedGrid_box);
            this.Controls.Add(this.totalCostGrid_box);
            this.Controls.Add(this.unitCostGrid_box);
            this.Controls.Add(this.quantityGrid_box);
            this.Controls.Add(this.ItemIDGrid_box);
            this.Controls.Add(this.txtMaterialType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDefects);
            this.Controls.Add(this.lblDateUsed);
            this.Controls.Add(this.lblDateAcq);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblUnitCost);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblMaterialType);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.btnLoadStockFromDB);
            this.Controls.Add(this.ConfirmGrid_btn);
            this.Controls.Add(this.Enter_ID_lbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_warehouseSummary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(404, 92);
            this.Name = "UpdateStockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "View and Update Stock Form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UpdateStockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityGrid_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitCostGrid_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalCostGrid_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amtDefectedGrid_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_warehouseSummary;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Login.WorkFlowDatabaseDataSet workFlowDatabaseDataSet;
        private System.Windows.Forms.BindingSource stockTableBindingSource;
        private Login.WorkFlowDatabaseDataSetTableAdapters.StockTableTableAdapter stockTableTableAdapter;
        private System.Windows.Forms.Label Enter_ID_lbl;
        private System.Windows.Forms.Button ConfirmGrid_btn;
        private System.Windows.Forms.Button btnLoadStockFromDB;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Label lblMaterialType;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblUnitCost;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblDateAcq;
        private System.Windows.Forms.Label lblDateUsed;
        private System.Windows.Forms.Label lblDefects;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox txtMaterialType;
        private System.Windows.Forms.ComboBox ItemIDGrid_box;
        private System.Windows.Forms.NumericUpDown quantityGrid_box;
        private System.Windows.Forms.NumericUpDown unitCostGrid_box;
        private System.Windows.Forms.NumericUpDown totalCostGrid_box;
        private System.Windows.Forms.NumericUpDown amtDefectedGrid_box;
        private System.Windows.Forms.DateTimePicker dateAcquiredGrid_box;
        private System.Windows.Forms.DateTimePicker dateUsedGrid_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAcquiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateUsedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amtDefectedDataGridViewTextBoxColumn;
    }
}