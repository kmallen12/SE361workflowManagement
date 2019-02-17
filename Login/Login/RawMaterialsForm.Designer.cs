namespace WorkflowManagement
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
            this.lstRawMaterials = new System.Windows.Forms.ListBox();
            this.btnCloseRawMaterial = new System.Windows.Forms.Button();
            this.btnAddNewMaterial = new System.Windows.Forms.Button();
            this.lblAddRawMaterial = new System.Windows.Forms.Label();
            this.txtRawMaterialUnitCost = new System.Windows.Forms.TextBox();
            this.txtRawMaterialName = new System.Windows.Forms.TextBox();
            this.lblRawMaterialUnitCost = new System.Windows.Forms.Label();
            this.lblRawMaterialName = new System.Windows.Forms.Label();
            this.lblRawMaterialsList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstRawMaterials
            // 
            this.lstRawMaterials.FormattingEnabled = true;
            this.lstRawMaterials.ItemHeight = 16;
            this.lstRawMaterials.Location = new System.Drawing.Point(114, 191);
            this.lstRawMaterials.Name = "lstRawMaterials";
            this.lstRawMaterials.Size = new System.Drawing.Size(561, 164);
            this.lstRawMaterials.TabIndex = 0;
            // 
            // btnCloseRawMaterial
            // 
            this.btnCloseRawMaterial.Location = new System.Drawing.Point(340, 379);
            this.btnCloseRawMaterial.Name = "btnCloseRawMaterial";
            this.btnCloseRawMaterial.Size = new System.Drawing.Size(107, 35);
            this.btnCloseRawMaterial.TabIndex = 1;
            this.btnCloseRawMaterial.Text = "Close";
            this.btnCloseRawMaterial.UseVisualStyleBackColor = true;
            // 
            // btnAddNewMaterial
            // 
            this.btnAddNewMaterial.Location = new System.Drawing.Point(506, 78);
            this.btnAddNewMaterial.Name = "btnAddNewMaterial";
            this.btnAddNewMaterial.Size = new System.Drawing.Size(93, 42);
            this.btnAddNewMaterial.TabIndex = 2;
            this.btnAddNewMaterial.Text = "Add New";
            this.btnAddNewMaterial.UseVisualStyleBackColor = true;
            this.btnAddNewMaterial.Click += new System.EventHandler(this.btnAddNewMaterial_Click);
            // 
            // lblAddRawMaterial
            // 
            this.lblAddRawMaterial.AutoSize = true;
            this.lblAddRawMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRawMaterial.Location = new System.Drawing.Point(110, 30);
            this.lblAddRawMaterial.Name = "lblAddRawMaterial";
            this.lblAddRawMaterial.Size = new System.Drawing.Size(459, 20);
            this.lblAddRawMaterial.TabIndex = 4;
            this.lblAddRawMaterial.Text = "Click \"Add New\" to add a new raw material to the list.";
            // 
            // txtRawMaterialUnitCost
            // 
            this.txtRawMaterialUnitCost.Location = new System.Drawing.Point(266, 109);
            this.txtRawMaterialUnitCost.Name = "txtRawMaterialUnitCost";
            this.txtRawMaterialUnitCost.Size = new System.Drawing.Size(194, 22);
            this.txtRawMaterialUnitCost.TabIndex = 5;
            // 
            // txtRawMaterialName
            // 
            this.txtRawMaterialName.Location = new System.Drawing.Point(266, 73);
            this.txtRawMaterialName.Name = "txtRawMaterialName";
            this.txtRawMaterialName.Size = new System.Drawing.Size(194, 22);
            this.txtRawMaterialName.TabIndex = 6;
            // 
            // lblRawMaterialUnitCost
            // 
            this.lblRawMaterialUnitCost.AutoSize = true;
            this.lblRawMaterialUnitCost.Location = new System.Drawing.Point(191, 109);
            this.lblRawMaterialUnitCost.Name = "lblRawMaterialUnitCost";
            this.lblRawMaterialUnitCost.Size = new System.Drawing.Size(69, 17);
            this.lblRawMaterialUnitCost.TabIndex = 7;
            this.lblRawMaterialUnitCost.Text = "Unit Cost:";
            // 
            // lblRawMaterialName
            // 
            this.lblRawMaterialName.AutoSize = true;
            this.lblRawMaterialName.Location = new System.Drawing.Point(157, 73);
            this.lblRawMaterialName.Name = "lblRawMaterialName";
            this.lblRawMaterialName.Size = new System.Drawing.Size(103, 17);
            this.lblRawMaterialName.TabIndex = 8;
            this.lblRawMaterialName.Text = "Material Name:";
            // 
            // lblRawMaterialsList
            // 
            this.lblRawMaterialsList.AutoSize = true;
            this.lblRawMaterialsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRawMaterialsList.Location = new System.Drawing.Point(110, 168);
            this.lblRawMaterialsList.Name = "lblRawMaterialsList";
            this.lblRawMaterialsList.Size = new System.Drawing.Size(173, 20);
            this.lblRawMaterialsList.TabIndex = 9;
            this.lblRawMaterialsList.Text = "Raw Materials List:";
            // 
            // RawMaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRawMaterialsList);
            this.Controls.Add(this.lblRawMaterialName);
            this.Controls.Add(this.lblRawMaterialUnitCost);
            this.Controls.Add(this.txtRawMaterialName);
            this.Controls.Add(this.txtRawMaterialUnitCost);
            this.Controls.Add(this.lblAddRawMaterial);
            this.Controls.Add(this.btnAddNewMaterial);
            this.Controls.Add(this.btnCloseRawMaterial);
            this.Controls.Add(this.lstRawMaterials);
            this.Name = "RawMaterialsForm";
            this.Text = "RawMaterialsForm";
            this.Load += new System.EventHandler(this.RawMaterialsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRawMaterials;
        private System.Windows.Forms.Button btnCloseRawMaterial;
        private System.Windows.Forms.Button btnAddNewMaterial;
        private System.Windows.Forms.Label lblAddRawMaterial;
        private System.Windows.Forms.TextBox txtRawMaterialUnitCost;
        private System.Windows.Forms.TextBox txtRawMaterialName;
        private System.Windows.Forms.Label lblRawMaterialUnitCost;
        private System.Windows.Forms.Label lblRawMaterialName;
        private System.Windows.Forms.Label lblRawMaterialsList;
    }
}