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
        //Dialogue boxes for confirmation
        MB M;
        //We check to see if text entries are correct.
        CheckEntry CE;
        public ViewProducts()
        {
            InitializeComponent();
            P = new Product();
            CE = new CheckEntry();
        }

        private void ViewProducts_Load(object sender, EventArgs e)
        {
           
            dataGrid_ViewProducts.DataSource = P.ProductTable();
        }

        private void btn_UpdateProduct_Click(object sender, EventArgs e)
        {
            M = new MB();
            
            //Set the product based on ID


            if (CE.isValidInt(txt_ProductID.Text, "ID") && CE.isnotNull(txt_ProductID.Text, "ID") && CE.isnotNull(txt_ProductName.Text, "Name")&& CE.isnotNull(txt_ProductMaterials.Text, "Materials") && CE.isnotNull(txt_ProductQuantity.Text, "Quantity"))
            {
                P.SetProduct(Int32.Parse(txt_ProductID.Text));
                if (M.UpdateProduct(P, txt_ProductID.Text, txt_ProductName.Text, txt_ProductMaterials.Text, txt_ProductQuantity.Text))
                {
                    P.UpdateProduct(Int32.Parse(txt_ProductID.Text), txt_ProductName.Text, txt_ProductMaterials.Text, Int32.Parse(txt_ProductQuantity.Text));
                    ViewProducts_Load(sender, e);
                }
            }
            else
                M.IncorrectEntry();
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
