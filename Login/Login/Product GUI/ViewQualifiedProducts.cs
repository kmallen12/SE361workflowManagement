using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WorkFlowManagement
{
    public partial class ViewQualifiedProducts : Form
    {
        private List<ProductStruct> qualProducts;
        private DatabaseManager objDatabaseManager;
        private ToolTip ttExport = new ToolTip();
        public ViewQualifiedProducts()
        {
            InitializeComponent();
            qualProducts = new List<ProductStruct>();
            objDatabaseManager = new DatabaseManager();

            qualProducts = objDatabaseManager.LoadQualifiedProducts();

            foreach (var prod in qualProducts)
            {
                lstQualProd.Items.Add(prod.ToString());
            }

            ttExport.SetToolTip(btnExport, "Export as pdfs coming soon  :D");
        }

        private void btnRepRemanufacture_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selected Item has been sent to Delivery Manager");
        }
    }
}
