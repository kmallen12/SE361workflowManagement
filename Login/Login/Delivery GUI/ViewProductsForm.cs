using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkFlowManagement
{
    public partial class ViewProductsForm : Form
    {
        Product product;
        
        public ViewProductsForm()
        {
            InitializeComponent();
        }

        private void ViewProductsForm_Load(object sender, EventArgs e)
        {

            dataGrid_ViewProducts.DataSource = product.ProductTable();
        }

        private void ViewProductsForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workFlowDatabaseDataSetProducts.ProductTable' table. You can move, or remove it, as needed.
            this.productTableTableAdapter.Fill(this.workFlowDatabaseDataSetProducts.ProductTable);

        }
    }
}
