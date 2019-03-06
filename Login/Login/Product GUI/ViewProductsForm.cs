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
        Product P;
        MB M;
        public ViewProducts()
        {
            InitializeComponent();
            P = new Product();
        }

        private void ViewProducts_Load(object sender, EventArgs e)
        {
           
            dataGrid_ViewProducts.DataSource = P.ProductTable();
        }

        private void btn_UpdateProduct_Click(object sender, EventArgs e)
        {
            //Set the product based on ID
            P.SetProduct(Int32.Parse(txt_ProductID.Text));
            M = new MB();
            if (M.UpdateProduct(P, txt_ProductID.Text, txt_ProductName.Text, txt_ProductMaterials.Text, txt_ProductQuantity.Text) == true)
            {
                P.UpdateProduct(Int32.Parse(txt_ProductID.Text), txt_ProductName.Text, txt_ProductMaterials.Text, Int32.Parse(txt_ProductQuantity.Text));
                ViewProducts_Load(sender, e);
            }
        }

        private void btn_OrderProduct_Click(object sender, EventArgs e)
        {
            //More of an existing product.
            AddProduct addp = new AddProduct();
            addp.SetTXTBoxs(txt_ProductID.Text, txt_ProductQuantity.Text);
            addp.ShowDialog();
        }
    }
}
