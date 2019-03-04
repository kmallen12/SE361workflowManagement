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
    public partial class ViewProducts : Form
    {
        DatabaseManager objDatabaseManager = new DatabaseManager();
        private DataTable Products;
        public ViewProducts()
        {
            InitializeComponent();
        }

        private void ViewProducts_Load(object sender, EventArgs e)
        {
            Products = new DataTable();
            Products = objDatabaseManager.LoadProducts();
            dataGrid_ViewProducts.DataSource = Products;
        }

        private void btn_UpdateProduct_Click(object sender, EventArgs e)
        {
            objDatabaseManager.UpdateProduct(Int32.Parse(txt_ProductID.Text), txt_ProductName.Text, txt_ProductMaterials.Text, Int32.Parse(txt_ProductQuantity.Text));
        }

        private void btn_OrderProduct_Click(object sender, EventArgs e)
        {
            AddProduct p = new AddProduct();
            p.SetTXTBoxs(txt_ProductID.Text, txt_ProductQuantity.Text);
            p.ShowDialog();
        }
    }
}
