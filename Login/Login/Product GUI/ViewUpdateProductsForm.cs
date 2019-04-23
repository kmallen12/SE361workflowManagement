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
        DataTable productTable;
        //Dialogue boxes for confirmation
        WorkFlowMessage M;
        //We check to see if text entries are correct.
        CheckEntry CE;

        public ViewProducts()
        {
            InitializeComponent();
            P = new Product();
            CE = new CheckEntry();
            productTable = P.ProductTable();
        }

        private void ViewProducts_Load(object sender, EventArgs e)
        {
           
            dataGrid_ViewProducts.DataSource = P.ProductTable();

            txt_ProductID.Items.Clear();
            for (int i = 0; i < productTable.Rows.Count; i++)
            {
                txt_ProductID.Items.Add(productTable.Rows[i]["pId"]);
            }
        }

        private void btn_UpdateProduct_Click(object sender, EventArgs e)
        {
            M = new WorkFlowMessage();
            
            //Set the product based on ID


            if (CE.isValidInt(txt_ProductID.Text, "ID") && CE.isnotNull(txt_ProductID.Text, "ID") && CE.isnotNull(txt_ProductName.Text, "Name")&& CE.isnotNull(txt_ProductMaterials.Text, "Materials") && CE.isnotNull(txt_ProductQuantity.Text, "Quantity"))
            {
                P.SetProduct(Int32.Parse(txt_ProductID.Text));
                if (M.UpdateProduct(P, txt_ProductID.Text, txt_ProductName.Text, txt_ProductMaterials.Text, txt_ProductQuantity.Text))
                {
                    P.UpdateProduct(Int32.Parse(txt_ProductID.Text), txt_ProductName.Text, txt_ProductMaterials.Text, Int32.Parse(txt_ProductQuantity.Text), "In Progress");
                    ViewProducts_Load(sender, e);
                }
            }
            else
                M.IncorrectEntry();
        }

        private void btn_OrderProduct_Click(object sender, EventArgs e)
        {
            try
            {
                //More of an existing product.
                AddProduct addp = new AddProduct();
                addp.SetTXTBoxs(txt_ProductID.Text, txt_ProductQuantity.Text);
                addp.ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show("Select a product using the Product ID dropdown before trying to order more.");
            }
            
        }

        private void txt_ProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataRow[] selectedRow;

                selectedRow = productTable.Select("pId = " + txt_ProductID.Text);

                if (selectedRow.Length > 0)
                {
                    txt_ProductName.Text = selectedRow[0]["productName"].ToString();
                    txt_ProductMaterials.Text = selectedRow[0]["materialsString"].ToString();
                    txt_ProductQuantity.Text = selectedRow[0]["quantity"].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error selecting data from data table.");
            }
        }
    }
}
