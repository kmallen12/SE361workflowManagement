namespace WorkFlowManagement
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblUserType = new System.Windows.Forms.Label();
            this.workFlowDatabaseDataSet1 = new Login.WorkFlowDatabaseDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.BackColor = System.Drawing.Color.White;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(594, 36);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUsername.Size = new System.Drawing.Size(200, 13);
            this.lblUsername.TabIndex = 13;
            this.lblUsername.Text = "User";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogOut.Location = new System.Drawing.Point(719, 10);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblUserType
            // 
            this.lblUserType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserType.BackColor = System.Drawing.Color.Transparent;
            this.lblUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.ForeColor = System.Drawing.Color.White;
            this.lblUserType.Location = new System.Drawing.Point(594, 49);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserType.Size = new System.Drawing.Size(200, 13);
            this.lblUserType.TabIndex = 14;
            this.lblUserType.Text = "UserType";
            this.lblUserType.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblUserType.Click += new System.EventHandler(this.lblUserType_Click);
            // 
            // workFlowDatabaseDataSet1
            // 
            this.workFlowDatabaseDataSet1.DataSetName = "WorkFlowDatabaseDataSet";
            this.workFlowDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.OCOTODWorkflow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.Text = "OCOTOD | Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.workFlowDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblUserType;
        private Login.WorkFlowDatabaseDataSet workFlowDatabaseDataSet1;
    }
}