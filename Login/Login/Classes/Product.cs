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
using Newtonsoft.Json;

namespace WorkFlowManagement
{
    public struct MaterialsProduct
    {
        public int ID;
        public int Quantity;
        public string Name;
        public MaterialsProduct(int InitID, int InitQuantity, string InitName)
        {
            ID = InitID;
            Quantity = InitQuantity;
            Name = InitName;
        }
    };
    class Product
    {
        MB M = new MB();
        DatabaseManager objDatabaseManager = new DatabaseManager();
        //Represents the Materials string broken into an array based on ' '.
        string[] materialsDescription;
        string JsonMaterialString;
        
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
            JsonMaterialString = productMaterials;
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
            MaterialsProduct newMaterial = new MaterialsProduct(Int32.Parse(ID), Int32.Parse(Quantity), objDatabaseManager.MaterialName(Int32.Parse(ID)).Trim(' ')); 
            JsonMaterialString = JsonConvert.SerializeObject(newMaterial)+"\n"+JsonMaterialString;
            Console.WriteLine(JsonMaterialString);
            productMaterials = ID + " " + Quantity + " " + productMaterials;
        }
        public string JsonMaterialReturn()
        {
            return JsonMaterialString;
        }
        public string productDiscription()
        {
            return "ID: " + productID + " Name: " + productName + " Materials: " + productMaterials + " Quantity: " + productQuantity;
        }
        public int FinalizeProduct(string name, int quantity)
        {
            
            int tempmat;
            int id;
            decimal amt;
            productMaterials = "";
            //Turn Json format to ID Quantity format seperated by ' ' for easy parsing. 
            ConvertJsonMaterials();
            //Instantiate productName and productQuantity of the new product.
            productName = name;
            productQuantity = quantity;
            //Break up the Materials string into an array so that its easy to parse it. 
            materialsDescription = productMaterials.Split(' ');
            try
            {   //Subtract materials for amount of product. 
                for (int x = 0; x < quantity; x++)
                {
                    //Subtract quantity of material given from material in database. 
                    //Description [0] would be the first ID and [1] is the quantity then increment +2.
                    for (int i = 0; i < materialsDescription.Length - 1; i = i + 2)
                    {
                        id = Int32.Parse(materialsDescription[i]);
                        amt = Decimal.Parse(materialsDescription[i + 1]);
                        //Value for material quantity if we did subtract based on product amount.
                        tempmat = objDatabaseManager.CheckMaterialQuantity(id, (decimal)quantity * amt);
                        if (tempmat < 0)
                        {
                            M.NegativeMaterial(objDatabaseManager.returnMaterialName(id), (int)amt, quantity, tempmat + quantity * (int)amt);
                            return 0;
                        }


                    }
                    //If we don't get negatives in the previous loop we actually subtract materials.
                    for (int i = 0; i < materialsDescription.Length - 1; i = i + 2)
                        objDatabaseManager.SubtractMaterialQuantity(Int32.Parse(materialsDescription[i]), Decimal.Parse(materialsDescription[i + 1]));
                   
                }

            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString());
            }
            //ID is automatically generated when inserted into the table. 
            objDatabaseManager.InsertProduct(productName, JsonMaterialString, productQuantity);
            return 0;
        }
        //This is the conversion from JSon to the ID Quantity format.
        public void ConvertJsonMaterials()
        {
            string ID = "";
            string Quantity = "";
            string both = "";
            for (int i = 0; i < JsonMaterialString.Length; i++)
            {
                
                if (JsonMaterialString[i] == ':' && JsonMaterialString[i - 2] == 'D')
                {
                    i++;
                    //build the ID
                    while (JsonMaterialString[i] != ',')
                    {
                        ID += JsonMaterialString[i];
                        i++;
                    }
                    //Add the ID to both
                    both = ID;
                    ID = "";
                }
                if (JsonMaterialString[i] == ':' && JsonMaterialString[i - 2] == 'y')
                {
                    i++;
                    while (JsonMaterialString[i] != ',')
                    {
                        Quantity = Quantity + JsonMaterialString[i];
                        i++;
                    }
                    //Add the quantity to both
                    both = both +" "+ Quantity;
                    Quantity = "";
                    productMaterials = both + " " + productMaterials;
                    both = "";
                    
                }
                //MessageBox.Show(productMaterials+"ice");
            }
        } 
        public int AdditionalProduct(int key, int quantity)
        {
            //Ensure we have the correct product information.
            SetProduct(key);
            productMaterials = "";
            //Turn Json format to ID Quantity format seperated by ' ' for easy parsing. 
            ConvertJsonMaterials();
            int tempmat;
            int id;
            decimal amt;
            //Break up the Materials string.
            materialsDescription = productMaterials.Split(' ');
            try
            {
                for (int x = 0; x < quantity; x++)
                {
                    //Subtract quantity of material given from material in database. 
                    //Description [0] would be the first ID and [1] is the quantity then increment +2.
                    for (int i = 0; i < materialsDescription.Length - 1; i = i + 2)
                    {
                        id = Int32.Parse(materialsDescription[i]);
                        amt = Decimal.Parse(materialsDescription[i + 1]);
                        //Value for material quantity if we did subtract based on product amount.
                        tempmat = objDatabaseManager.CheckMaterialQuantity(id, (decimal)quantity * amt);
                        if (tempmat < 0)
                        {
                            M.NegativeMaterial(objDatabaseManager.returnMaterialName(id), (int)amt, quantity, tempmat + quantity * (int)amt);
                            return 0;
                        }


                    }
                    //If we don't get negatives in the previous loop we actually subtract materials.
                    for (int i = 0; i < materialsDescription.Length - 1; i = i + 2)
                        objDatabaseManager.SubtractMaterialQuantity(Int32.Parse(materialsDescription[i]), Decimal.Parse(materialsDescription[i + 1]));
                    
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
            return 0;
        }
    }
}
