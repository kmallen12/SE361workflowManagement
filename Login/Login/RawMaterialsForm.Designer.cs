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
            this.txtRawMaterialName = new System.Windows.Forms.TextBox();
            this.lblRawMaterialName = new System.Windows.Forms.Label();
            this.lblRawMaterialsList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstRawMaterials
            // 
            this.lstRawMaterials.FormattingEnabled = true;
            this.lstRawMaterials.Location = new System.Drawing.Point(86, 155);
            this.lstRawMaterials.Margin = new System.Windows.Forms.Padding(2);
            this.lstRawMaterials.Name = "lstRawMaterials";
            this.lstRawMaterials.Size = new System.Drawing.Size(422, 134);
            this.lstRawMaterials.TabIndex = 0;
            // 
            // btnCloseRawMaterial
            // 
            this.btnCloseRawMaterial.Location = new System.Drawing.Point(254, 309);
            this.btnCloseRawMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseRawMaterial.Name = "btnCloseRawMaterial";
            this.btnCloseRawMaterial.Size = new System.Drawing.Size(80, 28);
            this.btnCloseRawMaterial.TabIndex = 1;
            this.btnCloseRawMaterial.Text = "Close";
            this.btnCloseRawMaterial.UseVisualStyleBackColor = true;
            this.btnCloseRawMaterial.Click += new System.EventHandler(this.btnCloseRawMaterial_Click);
            // 
            // btnAddNewMaterial
            // 
            this.btnAddNewMaterial.Location = new System.Drawing.Point(380, 63);
            this.btnAddNewMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewMaterial.Name = "btnAddNewMaterial";
            this.btnAddNewMaterial.Size = new System.Drawing.Size(93, 27);
            this.btnAddNewMaterial.TabIndex = 2;
            this.btnAddNewMaterial.Text = "Add/Update";
            this.btnAddNewMaterial.UseVisualStyleBackColor = true;
            this.btnAddNewMaterial.Click += new System.EventHandler(this.btnAddNewMaterial_Click);
            // 
            // lblAddRawMaterial
            // 
            this.lblAddRawMaterial.AutoSize = true;
            this.lblAddRawMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRawMaterial.Location = new System.Drawing.Point(82, 24);
            this.lblAddRawMaterial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddRawMaterial.Name = "lblAddRawMaterial";
            this.lblAddRawMaterial.Size = new System.Drawing.Size(391, 17);
            this.lblAddRawMaterial.TabIndex = 4;
            this.lblAddRawMaterial.Text = "Click \"Add New\" to add a new raw material to the list.";
            // 
            // txtRawMaterialName
            // 
            this.txtRawMaterialName.Location = new System.Drawing.Point(203, 67);
            this.txtRawMaterialName.Margin = new System.Windows.Forms.Padding(2);
            this.txtRawMaterialName.Name = "txtRawMaterialName";
            this.txtRawMaterialName.Size = new System.Drawing.Size(146, 20);
            this.txtRawMaterialName.TabIndex = 6;
            // 
            // lblRawMaterialName
            // 
            this.lblRawMaterialName.AutoSize = true;
            this.lblRawMaterialName.Location = new System.Drawing.Point(121, 67);
            this.lblRawMaterialName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRawMaterialName.Name = "lblRawMaterialName";
            this.lblRawMaterialName.Size = new System.Drawing.Size(78, 13);
            this.lblRawMaterialName.TabIndex = 8;
            this.lblRawMaterialName.Text = "Material Name:";
            // 
            // lblRawMaterialsList
            // 
            this.lblRawMaterialsList.AutoSize = true;
            this.lblRawMaterialsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRawMaterialsList.Location = new System.Drawing.Point(82, 136);
            this.lblRawMaterialsList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRawMaterialsList.Name = "lblRawMaterialsList";
            this.lblRawMaterialsList.Size = new System.Drawing.Size(145, 17);
            this.lblRawMaterialsList.TabIndex = 9;
            this.lblRawMaterialsList.Text = "Raw Materials List:";
            // 
            // RawMaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblRawMaterialsList);
            this.Controls.Add(this.lblRawMaterialName);
            this.Controls.Add(this.txtRawMaterialName);
            this.Controls.Add(this.lblAddRawMaterial);
            this.Controls.Add(this.btnAddNewMaterial);
            this.Controls.Add(this.btnCloseRawMaterial);
            this.Controls.Add(this.lstRawMaterials);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox txtRawMaterialName;
        private System.Windows.Forms.Label lblRawMaterialName;
        private System.Windows.Forms.Label lblRawMaterialsList;
    }
}