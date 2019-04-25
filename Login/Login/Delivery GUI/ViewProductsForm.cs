using System;
using System.Windows.Forms;

namespace WorkFlowManagement
{
    public partial class ViewProductsForm : Form
    {
        Product product;
        
        public ViewProductsForm()
        {
            InitializeComponent();
            product = new Product();
            dataGrid_ViewProducts.DataSource = product.ProductTable();
        }

        private void ViewProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workFlowDatabaseDataSetProducts.ProductTable' table. You can move, or remove it, as needed.
            this.productTableTableAdapter.Fill(this.workFlowDatabaseDataSetProducts.ProductTable);
        }
    }
}
