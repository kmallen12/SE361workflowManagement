namespace WorkFlowManagement
{
    partial class CreateStockOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateStockOrder));
            this.ProductOrderInfo_lbl = new System.Windows.Forms.Label();
            this.ID_Text = new System.Windows.Forms.TextBox();
            this.Confirm_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Discription_text = new System.Windows.Forms.TextBox();
            this.Amount_Text = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stockTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workFlowDatabaseDataSet = new Login.WorkFlowDatabaseDataSet();
            this.productTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workFlowDatabaseDataSetProducts = new Login.WorkFlowDatabaseDataSetProducts();
            this.productTableTableAdapter = new Login.WorkFlowDatabaseDataSetProductsTableAdapters.ProductTableTableAdapter();
            this.listBox_StockOrders = new System.Windows.Forms.ListBox();
            this.btn_AddOrderToList = new System.Windows.Forms.Button();
            this.stockTableTableAdapter = new Login.WorkFlowDatabaseDataSetTableAdapters.StockTableTableAdapter();
            this.stockTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSetProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTableBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductOrderInfo_lbl
            // 
            this.ProductOrderInfo_lbl.AutoSize = true;
            this.ProductOrderInfo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductOrderInfo_lbl.Location = new System.Drawing.Point(5, 6);
            this.ProductOrderInfo_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductOrderInfo_lbl.MaximumSize = new System.Drawing.Size(253, 65);
            this.ProductOrderInfo_lbl.Name = "ProductOrderInfo_lbl";
            this.ProductOrderInfo_lbl.Size = new System.Drawing.Size(204, 40);
            this.ProductOrderInfo_lbl.TabIndex = 1;
            this.ProductOrderInfo_lbl.Text = "Enter information about defective product.";
            // 
            // ID_Text
            // 
            this.ID_Text.Location = new System.Drawing.Point(161, 69);
            this.ID_Text.Margin = new System.Windows.Forms.Padding(2);
            this.ID_Text.Name = "ID_Text";
            this.ID_Text.Size = new System.Drawing.Size(73, 20);
            this.ID_Text.TabIndex = 2;
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_btn.Location = new System.Drawing.Point(8, 400);
            this.Confirm_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(225, 58);
            this.Confirm_btn.TabIndex = 3;
            this.Confirm_btn.Text = "Send List To Product Manager";
            this.Confirm_btn.UseVisualStyleBackColor = true;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stock ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Request Discription:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stock Amount:";
            // 
            // Discription_text
            // 
            this.Discription_text.Location = new System.Drawing.Point(8, 197);
            this.Discription_text.Margin = new System.Windows.Forms.Padding(2);
            this.Discription_text.Multiline = true;
            this.Discription_text.Name = "Discription_text";
            this.Discription_text.Size = new System.Drawing.Size(226, 98);
            this.Discription_text.TabIndex = 7;
            // 
            // Amount_Text
            // 
            this.Amount_Text.Location = new System.Drawing.Point(161, 142);
            this.Amount_Text.Margin = new System.Windows.Forms.Padding(2);
            this.Amount_Text.Name = "Amount_Text";
            this.Amount_Text.Size = new System.Drawing.Size(73, 20);
            this.Amount_Text.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(755, -1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(648, 477);
            this.dataGridView1.TabIndex = 9;
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
            // productTableBindingSource
            // 
            this.productTableBindingSource.DataMember = "ProductTable";
            this.productTableBindingSource.DataSource = this.workFlowDatabaseDataSetProducts;
            // 
            // workFlowDatabaseDataSetProducts
            // 
            this.workFlowDatabaseDataSetProducts.DataSetName = "WorkFlowDatabaseDataSetProducts";
            this.workFlowDatabaseDataSetProducts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableTableAdapter
            // 
            this.productTableTableAdapter.ClearBeforeFill = true;
            // 
            // listBox_StockOrders
            // 
            this.listBox_StockOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_StockOrders.FormattingEnabled = true;
            this.listBox_StockOrders.ItemHeight = 16;
            this.listBox_StockOrders.Location = new System.Drawing.Point(247, 2);
            this.listBox_StockOrders.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_StockOrders.MaximumSize = new System.Drawing.Size(505, 475);
            this.listBox_StockOrders.Name = "listBox_StockOrders";
            this.listBox_StockOrders.Size = new System.Drawing.Size(505, 468);
            this.listBox_StockOrders.TabIndex = 10;
            // 
            // btn_AddOrderToList
            // 
            this.btn_AddOrderToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddOrderToList.Location = new System.Drawing.Point(8, 320);
            this.btn_AddOrderToList.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddOrderToList.Name = "btn_AddOrderToList";
            this.btn_AddOrderToList.Size = new System.Drawing.Size(225, 58);
            this.btn_AddOrderToList.TabIndex = 11;
            this.btn_AddOrderToList.Text = "Add Order To List";
            this.btn_AddOrderToList.UseVisualStyleBackColor = true;
            this.btn_AddOrderToList.Click += new System.EventHandler(this.btn_AddOrderToList_Click);
            // 
            // stockTableTableAdapter
            // 
            this.stockTableTableAdapter.ClearBeforeFill = true;
            // 
            // stockTableBindingSource1
            // 
            this.stockTableBindingSource1.DataMember = "StockTable";
            this.stockTableBindingSource1.DataSource = this.workFlowDatabaseDataSet;
            // 
            // stockTableBindingSource2
            // 
            this.stockTableBindingSource2.DataMember = "StockTable";
            this.stockTableBindingSource2.DataSource = this.workFlowDatabaseDataSet;
            // 
            // CreateStockOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 475);
            this.Controls.Add(this.btn_AddOrderToList);
            this.Controls.Add(this.listBox_StockOrders);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Amount_Text);
            this.Controls.Add(this.Discription_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Confirm_btn);
            this.Controls.Add(this.ID_Text);
            this.Controls.Add(this.ProductOrderInfo_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateStockOrder";
            this.Text = "CreateProductOrder";
            this.Load += new System.EventHandler(this.CreateProductOrder_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSetProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTableBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label ProductOrderInfo_lbl;
        private System.Windows.Forms.TextBox ID_Text;
        private System.Windows.Forms.Button Confirm_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Discription_text;
        private System.Windows.Forms.TextBox Amount_Text;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Login.WorkFlowDatabaseDataSetProducts workFlowDatabaseDataSetProducts;
        private System.Windows.Forms.BindingSource productTableBindingSource;
        private Login.WorkFlowDatabaseDataSetProductsTableAdapters.ProductTableTableAdapter productTableTableAdapter;
        private System.Windows.Forms.ListBox listBox_StockOrders;
        private System.Windows.Forms.Button btn_AddOrderToList;
        private Login.WorkFlowDatabaseDataSet workFlowDatabaseDataSet;
        private System.Windows.Forms.BindingSource stockTableBindingSource;
        private Login.WorkFlowDatabaseDataSetTableAdapters.StockTableTableAdapter stockTableTableAdapter;
        private System.Windows.Forms.BindingSource stockTableBindingSource2;
        private System.Windows.Forms.BindingSource stockTableBindingSource1;
    }
}