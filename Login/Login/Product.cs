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
  
    public partial class Product : Form
    {
        DatabaseManager objDatabaseManager;
        DatabaseManager q = new DatabaseManager();
        private DataTable Partialstocks;
        public Product()
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
            Partialstocks = q.LoadPartialStocks();

            //use stock datatable as datasource for data grid
            PartialStockGrid.DataSource = Partialstocks;

        }

   

        private void txt_AddMaterialtoProduct_Click(object sender, EventArgs e)
        {
            Materials = txt_MaterialID.Text + " " + txt_MaterialQuantity.Text + " " + Materials;
            q.SubtractMaterial(Int32.Parse(txt_MaterialID.Text), Decimal.Parse(txt_MaterialQuantity.Text));
           
            Partialstocks = new DataTable();
            Partialstocks = q.LoadPartialStocks();

            //use stock datatable as datasource for data grid
            PartialStockGrid.DataSource = Partialstocks;
            Description_lbl.Text = Materials;
        }

        private void btn_FinalizeProduct_Click(object sender, EventArgs e)
        {
            string[] list = Materials.Split(' ');
            try
            {
                ProductQuantity = int.Parse(txt_ProductQuantity.Text);
                ProductName = txt_ProductQuantity.Text;
                int test1;
                decimal test2;
               // MessageBox.Show(Int32.Parse(list[0]) + " " + Decimal.Parse(list[1]) + " " + Int32.Parse(list[2]) + " " + Decimal.Parse(list[3]));
                if (ProductQuantity > 1)
                {
                    for (int x = 1; x < ProductQuantity; x++)
                    {
                        for (int i = 0; i < list.Length-1; i++)
                        {
                            if (i % 2 == 0)
                            {
                              //  MessageBox.Show(list.Length.ToString());
                                test1 = Int32.Parse(list[i]);
                                test2 = Decimal.Parse(list[i + 1]);
                               // MessageBox.Show(test1.ToString());
                                q.SubtractMaterial(test1, test2);
                            }
                        }
                    }
                }
            }
            catch (Exception p)
            {
               // MessageBox.Show("TEST" + Int32.Parse(list[0]) + " " + Decimal.Parse(list[1]) + "TEST");
                MessageBox.Show(p.ToString());
            }
            q.InsertProduct(txt_ProductName.Text, Materials, Int32.Parse(txt_ProductQuantity.Text));

        }
    }
}
