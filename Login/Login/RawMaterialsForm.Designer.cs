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
            this.button1 = new System.Windows.Forms.Button();
            this.btnSaveRMtoDB = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstRawMaterials
            // 
            this.lstRawMaterials.FormattingEnabled = true;
            this.lstRawMaterials.Location = new System.Drawing.Point(85, 101);
            this.lstRawMaterials.Margin = new System.Windows.Forms.Padding(2);
            this.lstRawMaterials.Name = "lstRawMaterials";
            this.lstRawMaterials.Size = new System.Drawing.Size(422, 134);
            this.lstRawMaterials.TabIndex = 0;
            this.lstRawMaterials.SelectedIndexChanged += new System.EventHandler(this.lstRawMaterials_SelectedIndexChanged);
            // 
            // btnCloseRawMaterial
            // 
            this.btnCloseRawMaterial.Location = new System.Drawing.Point(325, 309);
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
            this.btnAddNewMaterial.Location = new System.Drawing.Point(340, 249);
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
            this.lblAddRawMaterial.Location = new System.Drawing.Point(82, 9);
            this.lblAddRawMaterial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddRawMaterial.Name = "lblAddRawMaterial";
            this.lblAddRawMaterial.Size = new System.Drawing.Size(391, 17);
            this.lblAddRawMaterial.TabIndex = 4;
            this.lblAddRawMaterial.Text = "Click \"Add New\" to add a new raw material to the list.";
            // 
            // txtRawMaterialName
            // 
            this.txtRawMaterialName.Location = new System.Drawing.Point(164, 249);
            this.txtRawMaterialName.Margin = new System.Windows.Forms.Padding(2);
            this.txtRawMaterialName.Name = "txtRawMaterialName";
            this.txtRawMaterialName.Size = new System.Drawing.Size(146, 20);
            this.txtRawMaterialName.TabIndex = 6;
            // 
            // lblRawMaterialName
            // 
            this.lblRawMaterialName.AutoSize = true;
            this.lblRawMaterialName.Location = new System.Drawing.Point(82, 249);
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
            this.lblRawMaterialsList.Location = new System.Drawing.Point(81, 82);
            this.lblRawMaterialsList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRawMaterialsList.Name = "lblRawMaterialsList";
            this.lblRawMaterialsList.Size = new System.Drawing.Size(145, 17);
            this.lblRawMaterialsList.TabIndex = 9;
            this.lblRawMaterialsList.Text = "Raw Materials List:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 249);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSaveRMtoDB
            // 
            this.btnSaveRMtoDB.Location = new System.Drawing.Point(164, 309);
            this.btnSaveRMtoDB.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveRMtoDB.Name = "btnSaveRMtoDB";
            this.btnSaveRMtoDB.Size = new System.Drawing.Size(127, 28);
            this.btnSaveRMtoDB.TabIndex = 11;
            this.btnSaveRMtoDB.Text = "Save List to Database";
            this.btnSaveRMtoDB.UseVisualStyleBackColor = true;
            this.btnSaveRMtoDB.Click += new System.EventHandler(this.btnSaveRMtoDB_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 41);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 26);
            this.button2.TabIndex = 12;
            this.button2.Text = "Load List from Database";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RawMaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSaveRMtoDB);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSaveRMtoDB;
        private System.Windows.Forms.Button button2;
    }
}