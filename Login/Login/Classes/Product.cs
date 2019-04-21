using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WorkFlowManagement
{
    public struct MaterialsProduct
    {
        public string Name;
        public int Quantity;

        public MaterialsProduct(string InitName, int InitQuantity)
        {
            Name = InitName;
            Quantity = InitQuantity;
        }

    };
    public struct ProductOrderRequest
    {
        public int OrderID;
        public int Quantity;
        public string Description;
        public int ProductID;
        public string OrderStatus;
        public ProductOrderRequest(int initID, int initQuantity, string initDescription, string initOrderStatus, int initProductID)
        {
            OrderID = initID;
            Quantity = initQuantity;
            Description = initDescription;
            ProductID = initProductID;
            OrderStatus = initOrderStatus;
        }
        public override string ToString()
        {
            return string.Format("ProductID: {0}, DefectiveQuantity: {1}, Description: {2}, Status: {3}", ProductID, Quantity, Description, OrderStatus);
        }
        public string returnOrders()
        {
            return string.Format("ProductID: {0}, DefectiveQuantity: {1}", ProductID, Quantity);
        }
    }
    public struct ProductStruct
    {
        public int ProductID;
        public string ProductName;
        public int ProductQuantity;
        public string ProductStatus;
        public ProductStruct(int initProductID, int initProductQuantity, string initProductName, string initProductStatus)
        {
            ProductID = initProductID;
            ProductQuantity = initProductQuantity;
            ProductName = initProductName;
            ProductStatus = initProductStatus;
        }
        public override string ToString()
        {
            return string.Format("ProductID: {0}, ProductName: {1}, ProductQuantity: {2}, ProductStatus: {3}", ProductID, ProductName, ProductQuantity, ProductStatus);
        }
    }

    public class Product
    {
        WorkFlowMessage M = new WorkFlowMessage();
        DatabaseManager objDatabaseManager = new DatabaseManager();
        //Represents the Materials string broken into an array based on ' '.
        string[] materialsDescription;
        public string JsonMaterialString;

        public List<ProductOrderRequest> ProductOrderRequests;

        public ProductOrderRequest ProductOrder;
        public int productID { get; set; }
        public string productName { get; set; }
        //public string productMaterials { get; set; }
        public List<MaterialsProduct> productMaterials;
        public int productQuantity { get; set; }
        private List<int> IDs;
        private int materialamt;
        public string productStatus { get; set; }

        public void newProduct()
        {
            productMaterials = new List<MaterialsProduct>();
            materialamt = 0;
        }
        public List<ProductOrderRequest> LoadProductOrders()
        {
            ProductOrderRequests = objDatabaseManager.LoadProductOrders();
            return ProductOrderRequests;
        }
        public void UpdateProductOrderStatus(int ID)
        {
            objDatabaseManager.UpdateProductOrderStatus(ID);
        }
        public void newOrders()
        {
            ProductOrderRequests = new List<ProductOrderRequest>();
        }
        public void newOrder(int initQuantity, string initDiscription, string initOrderStatus, int initID)
        {
            ProductOrder = new ProductOrderRequest(0, initQuantity, initDiscription, initOrderStatus, initID);
            ProductOrderRequests.Add(ProductOrder);
        }
        public List<ProductStruct> LoadDefectives()
        {
            return objDatabaseManager.LoadDefectiveProducts();
        }
        public void InsertProductOrder()
        {
            objDatabaseManager.InsertProductOrders(ProductOrderRequests);
        }
        public void SetProduct(int key)
        {
            //Querries the database for each attribute based on the key. 
            productID = key;
            productName = objDatabaseManager.ProductName(key);
            JsonMaterialString = objDatabaseManager.ProductMaterials(key);
            
            ConvertJsonMaterials();
            
            materialamt = productMaterials.Count;
            productQuantity = objDatabaseManager.ProductQuantity(key);
            productStatus = objDatabaseManager.ProductStatus(key);
        }
        public void UpdateProduct(int id, string name, string materials, int quantity, string status)
        {
            objDatabaseManager.UpdateProduct(id, name, materials, quantity, status);
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
        public void AddMaterialtoProduct(string Material, string Quantity)
        {
            MaterialsProduct newMaterial = new MaterialsProduct(Material, Int32.Parse(Quantity));
            
            materialamt++;
            productMaterials.Add(newMaterial);
            JsonMaterialString = JsonConvert.SerializeObject(productMaterials);
            
        }
        
        public string productDescription()
        {
            return "ID: " + productID + " Name: " + productName + " Materials: " + productMaterials + " Quantity: " + productQuantity;
        }
        public int FinalizeProduct(string name, int quantity)
        {
            
            int tempmat;
            string stockMaterial;
            string stockAmount;
            materialsDescription = new string[2*materialamt];
            //Turn Json format to ID Quantity format seperated by ' ' for easy parsing. 
            ConvertJsonMaterials();
            //Instantiate productName and productQuantity of the new product.
            productName = name;
            productQuantity = quantity;
            //Build the materials string into an array so that its easy to parse it. 
            for (int i = 0; i < materialamt; i++)
            {
                materialsDescription[2*i] = productMaterials[i].Name;
                materialsDescription[2*i + 1] = productMaterials[i].Quantity.ToString();
                
            }
            try
            {   //Subtract materials for amount of product. 
                for (int x = 0; x < quantity; x++)
                {
                    //Subtract quantity of material given from material in database. 
                    //Description [0] would be the first ID and [1] is the quantity then increment +2.
                    for (int i = 0; i < materialsDescription.Length; i=i+2)
                    {
                        stockMaterial = materialsDescription[i];
                        stockAmount = materialsDescription[i + 1];
                        //Value for material quantity if we did subtract based on product amount.
                        tempmat = objDatabaseManager.CheckMaterialQuantity(stockMaterial, stockAmount);
                        if (tempmat < 0)
                        {
                            MessageBox.Show("Not enough stock to create this product.");
                            //M.NegativeMaterial(objDatabaseManager.returnMaterialName(id), (int)amt, quantity, tempmat + quantity * (int)amt);
                            return 0;
                        }

                    }
                    //If we don't get negatives in the previous loop we actually subtract materials.
                    for (int i = 0; i < materialsDescription.Length - 1; i = i + 2)
                        objDatabaseManager.SubtractMaterialQuantity(materialsDescription[i], materialsDescription[i + 1]);
                   
                }

            }
            catch (Exception p)
            {
                MessageBox.Show(p.ToString(),"Warning");
            }
            //ID is automatically generated when inserted into the table. 
            objDatabaseManager.InsertProduct(productName, JsonMaterialString, productQuantity, "In Progress");
            return 0;
        }

        //This is the conversion from JSon to the ID Quantity format.
        public void ConvertJsonMaterials()
        {
            productMaterials = JsonConvert.DeserializeObject<List<MaterialsProduct>>(JsonMaterialString);
        } 
        public int AdditionalProduct(string name, int quantity)
        {
            FinalizeProduct(name, quantity);

            return 0;

            ////Ensure we have the correct product information.
            
            //materialsDescription = new int[2 * materialamt];
            
            //int tempmat;
            //int id;
            //decimal amt;
            ////Build the materialstring
            //for (int i = 0; i < materialamt; i++)
            //{
            //    materialsDescription[2 * i] = productMaterials[i].ID;
            //    materialsDescription[2 * i + 1] = productMaterials[i].Quantity;
            //}
            
            //try
            //{
            //    for (int x = 0; x < quantity; x++)
            //    {
            //        //Subtract quantity of material given from material in database. 
            //        //Description [0] would be the first ID and [1] is the quantity then increment +2.
            //        for (int i = 0; i < materialsDescription.Length; i = i + 2)
            //        {
            //            id = materialsDescription[i];
            //            amt = materialsDescription[i + 1];
            //            //Value for material quantity if we did subtract based on product amount.
            //            tempmat = objDatabaseManager.CheckMaterialQuantity(id, (decimal)quantity * amt);
            //            if (tempmat < 0)
            //            {
            //                M.NegativeMaterial(objDatabaseManager.returnMaterialName(id), (int)amt, quantity, tempmat + quantity * (int)amt);
            //                return 0;
            //            }


            //        }
            //        //If we don't get negatives in the previous loop we actually subtract materials.
            //        for (int i = 0; i < materialsDescription.Length - 1; i = i + 2)
            //            objDatabaseManager.SubtractMaterialQuantity(materialsDescription[i], materialsDescription[i + 1]);

            //    }

            //}
            //catch (Exception p)
            //{
            //    // MessageBox.Show("TEST" + Int32.Parse(list[0]) + " " + Decimal.Parse(list[1]) + "TEST");
            //    MessageBox.Show(p.ToString());
            //}
            //objDatabaseManager.IncreaseProductQuantity(productID,quantity);
            ////Update product info after increase.
            //SetProduct(key);
            //return 0;
        }

        public override string ToString()
        {
            return string.Format("ID: {0}, Product: {1}, Quantity: {2}, Status: {3}",
                productID, productName, productQuantity, productStatus);

        }

    }
}
