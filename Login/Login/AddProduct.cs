using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WorkFlowManagement
{
  
    public partial class AddProduct : Form
    {
        DatabaseManager objDatabaseManager = new DatabaseManager();
        string[] Description;
        private DataTable Partialstocks;
        public AddProduct()
        {
            InitializeComponent();
            
        }
        string Materials;
        int ProductQuantity;
        string ProductName;

       

        private void Product_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workFlowDatabaseDataSet1.StockTable' table. You can move, or remove it, as needed.
          
            Partialstocks = new DataTable();
            Partialstocks = objDatabaseManager.LoadPartialStocks();

            //use stock datatable as datasource for data grid
            PartialStockGrid.DataSource = Partialstocks;

        }

   

        private void btn_AddMaterialtoProduct_Click(object sender, EventArgs e)
        {
            Materials = txt_MaterialID.Text + " " + txt_MaterialQuantity.Text + " " + Materials;
            
           
            Partialstocks = new DataTable();
            Partialstocks = objDatabaseManager.LoadPartialStocks();

            //use Product datatable as datasource for data grid
            PartialStockGrid.DataSource = Partialstocks;
            lbl_Description.Text = Materials;
        }
        public void SetTXTBoxs(string key, string quantity)
        {
            txt_ProductID.Text = key;
            txt_ProductQuantity.Text = quantity;
            txt_ProductName.Visible=false;
            txt_MaterialQuantity.Visible = false;
            txt_MaterialID.Visible = false;
            lbl_MaterialAmount.Visible = false;
            lbl_MaterialID.Visible = false;
            lbl_CreateANewProduct.Visible = false;
            btn_FinalizeProduct.Visible = false;
            btn_AddMaterialtoProduct.Visible = false;
            lbl_ProductName.Visible = false;
            lbl_OrderMoreProduct.Visible = true;
            lbl_ProductID.Visible = true;
            btn_AdditionalProduct.Visible = true;
            txt_ProductID.Visible = true;
            txt_ProductQuantity.Visible = true;
            lbl_Description.Text = objDatabaseManager.ProductMaterials(Int32.Parse(txt_ProductID.Text));
            Description = lbl_Description.Text.Split(' ');
            
        }
        private void btn_FinalizeProduct_Click(object sender, EventArgs e)
        {
            Description = Materials.Split(' ');
            try
            {
                ProductQuantity = int.Parse(txt_ProductQuantity.Text);
                
                int test1;
                decimal test2;
                // MessageBox.Show(Int32.Parse(list[0]) + " " + Decimal.Parse(list[1]) + " " + Int32.Parse(list[2]) + " " + Decimal.Parse(list[3]));
                for (int x = 0; x < ProductQuantity; x++)
                {
                    for (int i = 0; i < Description.Length-1; i++)
                    {
                        if (i % 2 == 0)
                        {
                        //  MessageBox.Show(list.Length.ToString());
                        test1 = Int32.Parse(Description[i]);
                        test2 = Decimal.Parse(Description[i + 1]);
                        // MessageBox.Show(test1.ToString());
                        objDatabaseManager.SubtractMaterial(test1, test2);
                        }
                    }
                }
                
            }
            catch (Exception p)
            {
               // MessageBox.Show("TEST" + Int32.Parse(list[0]) + " " + Decimal.Parse(list[1]) + "TEST");
                MessageBox.Show(p.ToString());
            }
            objDatabaseManager.InsertProduct(txt_ProductName.Text, Materials, Int32.Parse(txt_ProductQuantity.Text));

        }

        private void btn_AdditionalProduct_Click(object sender, EventArgs e)
        {
            
            try
            {
                ProductQuantity = int.Parse(txt_ProductQuantity.Text);
                
                int test1;
                decimal test2;
                // MessageBox.Show(Int32.Parse(list[0]) + " " + Decimal.Parse(list[1]) + " " + Int32.Parse(list[2]) + " " + Decimal.Parse(list[3]));
                
                
                for (int x = 0; x < ProductQuantity; x++)
                {
                    for (int i = 0; i < Description.Length - 1; i++)
                    {
                        if (i % 2 == 0)
                        {
                            //  MessageBox.Show(list.Length.ToString());
                            test1 = Int32.Parse(Description[i]);
                            test2 = Decimal.Parse(Description[i + 1]);
                            // MessageBox.Show(test1.ToString());
                            objDatabaseManager.SubtractMaterial(test1, test2);
                        }
                    }
                }
                
            }
            catch (Exception p)
            {
                // MessageBox.Show("TEST" + Int32.Parse(list[0]) + " " + Decimal.Parse(list[1]) + "TEST");
                MessageBox.Show(p.ToString());
            }
            objDatabaseManager.IncreaseProduct(Int32.Parse(txt_ProductID.Text), ProductQuantity);
        }
    }
}
