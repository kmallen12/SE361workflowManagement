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
    class Product
    {
        DatabaseManager objDatabaseManager = new DatabaseManager();
        //Represents the Materials string broken into an array based on ' '.
        string[] Description;
        
        public int productID { get; set; }
        public string productName { get; set; }
        public string productMaterials { get; set; }
        public int productQuantity { get; set; }
        //We set attributes after class initialization(in some cases) so I changed it from Product() to SetProduct()
        
        public void SetProduct(int key)
        {
            //Querries the database for each attributes based on the key. 
            productID = key;
            productName = objDatabaseManager.ProductName(key);
            productMaterials = objDatabaseManager.ProductMaterials(key);
            productQuantity = objDatabaseManager.ProductQuantity(key);
        }
        public void UpdateProduct(int id, string name, string materials, int quantity)
        {
            objDatabaseManager.UpdateProduct(id, name, materials, quantity);
        }
        //Grabs the ID, name, and quantity of a material for a datagrid.
        public DataTable PartialStockTable()
        {
           return objDatabaseManager.LoadPartialStocks();
        }
        public DataTable ProductTable()
        {
            return objDatabaseManager.LoadProducts();
        }
        //build the productMaterial string. 
        public void AddMaterialtoProduct(string ID, string Quantity)
        {
            productMaterials = ID + " " + Quantity + " " + productMaterials;
        }
        public void FinalizeProduct(string name, int quantity)
        {
            //Instantiate productName and productQuantity of the new product.
            productName = name;
            productQuantity = quantity;
            //Break up the Materials string into an array so that its easy to parse it. 
            Description = productMaterials.Split(' ');
            try
            {   //Subtract materials for amount of product. 
                for (int x = 0; x < quantity; x++)
                {
                    //Subtract quantity of material given from material in database. 
                    //Description [0] would be the first ID and [1] is the quantity then increment +2.
                    for (int i = 0; i < Description.Length - 1; i = i + 2)
                        objDatabaseManager.SubtractMaterialQuantity(Int32.Parse(Description[i]), Decimal.Parse(Description[i + 1]));
                }
            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
            //ID is automatically generated when inserted into the table. 
            objDatabaseManager.InsertProduct(productName, productMaterials, productQuantity);
            
        }
        public void AdditionalProduct(int key, int quantity)
        {
            //Ensure we have the correct product information.
            SetProduct(key);
            
            //Break up the Materials string.
            Description = productMaterials.Split(' ');
            try
            {
               
                // MessageBox.Show(Int32.Parse(list[0]) + " " + Decimal.Parse(list[1]) + " " + Int32.Parse(list[2]) + " " + Decimal.Parse(list[3]));

                for (int x = 0; x < quantity; x++)
                {
                    //Subtract quantity of material given from material in database. 
                    //Description [0] would be the first ID and [1] is the quantity then increment +2.
                    for (int i = 0; i < Description.Length - 1; i = i + 2)
                         objDatabaseManager.SubtractMaterialQuantity(Int32.Parse(Description[i]), Decimal.Parse(Description[i + 1])); 
         
                }

            }
            catch (Exception p)
            {
                // MessageBox.Show("TEST" + Int32.Parse(list[0]) + " " + Decimal.Parse(list[1]) + "TEST");
                MessageBox.Show(p.ToString());
            }
            objDatabaseManager.IncreaseProductQuantity(productID,quantity);
            //Update product info after increase.
            SetProduct(key);
        }
    }
}
