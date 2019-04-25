namespace WorkFlowManagement
{
    partial class RawMaterialsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RawMaterialsForm));
            this.lstRawMaterials = new System.Windows.Forms.ListBox();
            this.btnCloseRawMaterial = new System.Windows.Forms.Button();
            this.btnAddNewMaterial = new System.Windows.Forms.Button();
            this.lblAddRawMaterial = new System.Windows.Forms.Label();
            this.txtRawMaterialName = new System.Windows.Forms.TextBox();
            this.lblRawMaterialName = new System.Windows.Forms.Label();
            this.lblRawMaterialsList = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.StsRawMaterial = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StsRawMaterial.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstRawMaterials
            // 
            this.lstRawMaterials.FormattingEnabled = true;
            this.lstRawMaterials.ItemHeight = 16;
            this.lstRawMaterials.Location = new System.Drawing.Point(113, 124);
            this.lstRawMaterials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstRawMaterials.Name = "lstRawMaterials";
            this.lstRawMaterials.Size = new System.Drawing.Size(561, 164);
            this.lstRawMaterials.TabIndex = 0;
            this.lstRawMaterials.SelectedIndexChanged += new System.EventHandler(this.lstRawMaterials_SelectedIndexChanged);
            // 
            // btnCloseRawMaterial
            // 
            this.btnCloseRawMaterial.Location = new System.Drawing.Point(349, 364);
            this.btnCloseRawMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseRawMaterial.Name = "btnCloseRawMaterial";
            this.btnCloseRawMaterial.Size = new System.Drawing.Size(107, 34);
            this.btnCloseRawMaterial.TabIndex = 1;
            this.btnCloseRawMaterial.Text = "Close";
            this.btnCloseRawMaterial.UseVisualStyleBackColor = true;
            this.btnCloseRawMaterial.Click += new System.EventHandler(this.btnCloseRawMaterial_Click);
            // 
            // btnAddNewMaterial
            // 
            this.btnAddNewMaterial.Location = new System.Drawing.Point(453, 306);
            this.btnAddNewMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNewMaterial.Name = "btnAddNewMaterial";
            this.btnAddNewMaterial.Size = new System.Drawing.Size(124, 33);
            this.btnAddNewMaterial.TabIndex = 2;
            this.btnAddNewMaterial.Text = "Add/Update";
            this.btnAddNewMaterial.UseVisualStyleBackColor = true;
            this.btnAddNewMaterial.Click += new System.EventHandler(this.btnAddNewMaterial_Click);
            // 
            // lblAddRawMaterial
            // 
            this.lblAddRawMaterial.AutoSize = true;
            this.lblAddRawMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRawMaterial.Location = new System.Drawing.Point(107, 48);
            this.lblAddRawMaterial.Name = "lblAddRawMaterial";
            this.lblAddRawMaterial.Size = new System.Drawing.Size(372, 25);
            this.lblAddRawMaterial.TabIndex = 4;
            this.lblAddRawMaterial.Text = "Add, Update, or Delete Raw Materials";
            // 
            // txtRawMaterialName
            // 
            this.txtRawMaterialName.Location = new System.Drawing.Point(219, 306);
            this.txtRawMaterialName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRawMaterialName.Name = "txtRawMaterialName";
            this.txtRawMaterialName.Size = new System.Drawing.Size(193, 22);
            this.txtRawMaterialName.TabIndex = 6;
            // 
            // lblRawMaterialName
            // 
            this.lblRawMaterialName.AutoSize = true;
            this.lblRawMaterialName.Location = new System.Drawing.Point(109, 306);
            this.lblRawMaterialName.Name = "lblRawMaterialName";
            this.lblRawMaterialName.Size = new System.Drawing.Size(103, 17);
            this.lblRawMaterialName.TabIndex = 8;
            this.lblRawMaterialName.Text = "Material Name:";
            // 
            // lblRawMaterialsList
            // 
            this.lblRawMaterialsList.AutoSize = true;
            this.lblRawMaterialsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRawMaterialsList.Location = new System.Drawing.Point(108, 101);
            this.lblRawMaterialsList.Name = "lblRawMaterialsList";
            this.lblRawMaterialsList.Size = new System.Drawing.Size(173, 20);
            this.lblRawMaterialsList.TabIndex = 9;
            this.lblRawMaterialsList.Text = "Raw Materials List:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(583, 306);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 33);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // StsRawMaterial
            // 
            this.StsRawMaterial.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StsRawMaterial.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.StsRawMaterial.Location = new System.Drawing.Point(0, 425);
            this.StsRawMaterial.Name = "StsRawMaterial";
            this.StsRawMaterial.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StsRawMaterial.Size = new System.Drawing.Size(800, 25);
            this.StsRawMaterial.TabIndex = 22;
            this.StsRawMaterial.Text = "...";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(399, 20);
            this.toolStripStatusLabel1.Text = "Clicking \"Add/Update\" saves your material to the database";
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
            // RawMaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.StsRawMaterial);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblRawMaterialsList);
            this.Controls.Add(this.lblRawMaterialName);
            this.Controls.Add(this.txtRawMaterialName);
            this.Controls.Add(this.lblAddRawMaterial);
            this.Controls.Add(this.btnAddNewMaterial);
            this.Controls.Add(this.btnCloseRawMaterial);
            this.Controls.Add(this.lstRawMaterials);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(404, 92);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RawMaterialsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RawMaterialsForm";
            this.Load += new System.EventHandler(this.RawMaterialsForm_Load);
            this.StsRawMaterial.ResumeLayout(false);
            this.StsRawMaterial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRawMaterials;
        private System.Windows.Forms.Button btnCloseRawMaterial;
        private System.Windows.Forms.Button btnAddNewMaterial;
        private System.Windows.Forms.Label lblAddRawMaterial;
        private System.Windows.Forms.TextBox txtRawMaterialName;
        private System.Windows.Forms.Label lblRawMaterialName;
        private System.Windows.Forms.Label lblRawMaterialsList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.StatusStrip StsRawMaterial;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}