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
    public partial class ViewProductInProgress : Form
    {
        Product P;
        private List<Product> products;
        private DatabaseManager objDatabaseManager;

        private void LoadProducts()
        {
            products = objDatabaseManager.LoadInProgressProducts();

            lstProducts.Items.AddRange(products.ToArray());
        }
        public ViewProductInProgress()
        {
            P = new Product();
            InitializeComponent();

            lstProducts.DataSource = P.LoadProductOrders();
        }
        
    }
}
