﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowManagement
{

   public class DatabaseManager
    {
        private static SqlConnection _conn = new SqlConnection(
            @"Server=tcp:workflowdatabase.database.windows.net,1433;
              Initial Catalog=WorkFlowDatabase;
              User ID=OCOTOD;
              Password=FairBanks152;
              Encrypt=true;"
        );

        public static SqlConnection conn
        {
            get { return _conn;} private set {conn = value;}
        }

        private static bool CheckField(string table, string column, string data)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conn,
                CommandText = "select " + column + "from " + table + "where " + column + " = @field"
            };
            cmd.Parameters.AddWithValue("@field", data);
            try
            {
                conn.Open();
                if (data.Equals((string)cmd.ExecuteScalar()))
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        private Boolean isValidQuantity(string quantity)
        {
            try
            {
                int quan = int.Parse(quantity);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string returnMaterialName(int key)
        {
            try
            {
                _conn.Open();

                //SQL Command to grab quantity based on materialID
                SqlCommand cmd = new SqlCommand("SELECT materialType FROM StockTable WHERE itemID=" + key, _conn);
                SqlDataReader reader2 = cmd.ExecuteReader();
                reader2.Read();
                return reader2.GetString(0);

            }
            catch (Exception q)
            {
                MessageBox.Show(q.ToString());
            }
            finally
            {
                _conn.Close();
            }
            _conn.Close();
            return "";
        }
        //returns the amount of material if we tried to subtract that much material.
        public int CheckMaterialQuantity(string StockMaterial, string StockAmount)
        {
            try
            {
                decimal quantity;

                _conn.Open();

                //SQL Command to grab quantity based on materialID
                SqlCommand cmd = new SqlCommand("SELECT SUM(quantity) as Sum FROM StockTable WHERE materialType = @material", _conn);

                cmd.Parameters.AddWithValue("@material", StockMaterial);


                SqlDataReader reader2 = cmd.ExecuteReader();
                reader2.Read();
                decimal sum = (decimal)reader2["Sum"];

                reader2.Close();

                quantity = decimal.Parse(StockAmount);
                sum -= quantity;
                _conn.Close();                
                return (int)sum;
            }
            catch (Exception q)
            {
                MessageBox.Show(q.ToString());
            }
            finally
            {
                _conn.Close();
            }
            _conn.Close();
            return 0;
        }
        //actually subtracts the material
        public void SubtractMaterialQuantity(string StockMaterial, string StockAmount)
        {
            

            try
            {
                decimal total = decimal.Parse(StockAmount);

                _conn.Open();

                //SQL Command to grab quantity based on materialID
                SqlCommand cmd = new SqlCommand("SELECT itemID, quantity FROM StockTable WHERE materialType = @material", _conn);

                cmd.Parameters.AddWithValue("@material", StockMaterial);

                SqlDataReader reader2 = cmd.ExecuteReader();
                List<Stock> Stocks = new List<Stock>();
                Stock S;
                while (reader2.Read())
                {
                    S = new Stock();

                    S.quantity= (decimal)reader2["quantity"];
                    S.id = (int)reader2["itemID"];
                    Stocks.Add(S);
                }
                reader2.Close();
                foreach (Stock So in Stocks)  {
                    if (total < So.quantity)
                    {
                        _conn.Close();
                        _conn.Open();
                        So.quantity -= total;


                        //Update row to new total 
                        string str = "UPDATE [dbo].[StockTable] SET quantity=@quantity WHERE itemID=@itemID";
                        using (SqlCommand con = new SqlCommand(str, _conn))
                        {
                            con.Parameters.Add("@itemID", SqlDbType.Int).Value = So.id;
                            con.Parameters.Add("@quantity", SqlDbType.Decimal).Value = So.quantity;
                            con.ExecuteNonQuery();
                        }
                        return;
                    }
                    else
                    {
                        _conn.Close();
                        _conn.Open();

                        //Update row to new total 
                        string str = "UPDATE [dbo].[StockTable] SET  quantity=@quantity WHERE itemID=@itemID";
                        using (SqlCommand co = new SqlCommand(str, _conn))
                        {
                            co.Parameters.Add("@itemID", SqlDbType.Int).Value = So.id;
                            co.Parameters.Add("@quantity", SqlDbType.Decimal).Value = 0;
                            co.ExecuteNonQuery();
                        }

                    }

                    
                    
                }
            }
            catch (Exception q)
            {
                MessageBox.Show(q.ToString());
            }
            finally
            {
                _conn.Close();
            }
            _conn.Close();
        }
        //Insert data into the Raw Materials table in the database
        public void InsertToRMTable(List<RawMaterials> rawMaterials)
        {
            try
            {
                _conn.Open();

                //SQL Command to insert data to the Raw Materials Table
                string str = "INSERT INTO [dbo].[RawMaterialsTable] ([rawMaterial]) Values (@rMaterial)";

                //feed Raw Materials list to the sqlCommand
                foreach (var rawMat in rawMaterials)
                {
                    SqlCommand com = new SqlCommand(str, _conn);
                    com.Connection = _conn;
                    com.Parameters.Add("@rMaterial", SqlDbType.VarChar).Value = rawMat.material;
         
                    com.ExecuteNonQuery();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error adding raw materials to the database.");
            }
            finally
            {
                _conn.Close();
            }
            _conn.Close();
        }

        //Delete data from the Raw Materials table in the database
        public void DeleteFromRMTable(List<RawMaterials> rawMaterials)
        {
            try
            {
                _conn.Open();

                //SQL Command to delete data from the Raw Materials Table
                string str = "DELETE FROM [dbo].[RawMaterialsTable] WHERE ([rawMaterial]) = (@rMaterial)";

                //feed Raw Materials list to the sqlCommand
                foreach (var rawMat in rawMaterials)
                {
                    SqlCommand com = new SqlCommand(str, _conn);
                    com.Connection = _conn;
                    com.Parameters.Add("@rMaterial", SqlDbType.VarChar).Value = rawMat.material;

                    com.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error deleting raw materials from the database.");
            }
            finally
            {
                _conn.Close();
            }
            _conn.Close();
        }

        //load data from the Raw Materials Table into a list
        public List<RawMaterials> LoadRawMat()
        {
            List<RawMaterials> rawMaterials = new List<RawMaterials>();

            try
            {
                RawMaterials tempRawMat;

                //open a db connection
                conn.Open();

                //create SQL Command to pull data from Raw Materials table
                SqlCommand cmd = new SqlCommand("SELECT * FROM RawMaterialsTable", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string rawMatName = (string)reader["rawMaterial"];
                    tempRawMat = new RawMaterials(rawMatName);
                    rawMaterials.Add(tempRawMat);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error reading data in from the database.");
            }
            finally
            {
                conn.Close();
            }

            return rawMaterials;
        }

        //load data from the Raw Materials Table into a list
        public List<string> LoadProductStatus()
        {
            List<string> status = new List<string>();

            try
            {
                string tempStatus;

                //open a db connection
                conn.Open();

                //create SQL Command to pull data from Raw Materials table
                SqlCommand cmd = new SqlCommand("SELECT * FROM ProductStatusTable", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string prodStatus = (string)reader["statusText"];
                    tempStatus = prodStatus;
                    status.Add(tempStatus);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error reading data in from the database.");
            }
            finally
            {
                conn.Close();
            }

            return status;
        }

        //load IDs of qualified products from the Products Table into a list
        public List<ProductStruct> LoadQualifiedProducts()
        {
            string acceptable = "Acceptable";
            string medium = "Medium";
            string high = "High";
            List<ProductStruct> qualifiedProds = new List<ProductStruct>();

            try
            {
                ProductStruct tempProd;

                //open a db connection
                conn.Open();

                //create SQL Command to pull data from Product table
                SqlCommand cmd = new SqlCommand("SELECT * FROM ProductTable WHERE productStatus = @status1 OR productStatus = @status2 OR productStatus = @status3", conn);

                cmd.Parameters.AddWithValue("@status1", acceptable);
                cmd.Parameters.AddWithValue("@status2", medium);
                cmd.Parameters.AddWithValue("@status3", high);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tempProd = new ProductStruct((int)reader["pID"], (int)reader["quantity"], (string)reader["ProductName"], (string)reader["productStatus"]);
                    ;
                    qualifiedProds.Add(tempProd);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error loading qualified products from the database.");
            }
            finally
            {
                conn.Close();
            }

            return qualifiedProds;
        }

        //load IDs of defective products from the Products Table into a list
        public List<ProductStruct> LoadDefectiveProducts()
        {
            string poor = "Poor";
            string veryPoor = "Very Poor";

            List<ProductStruct> defectiveProds = new List<ProductStruct>();

            try
            {
                ProductStruct tempProd;

                //open a db connection
                conn.Open();

                //create SQL Command to pull data from Raw Materials table
                SqlCommand cmd = new SqlCommand("SELECT * FROM ProductTable WHERE productStatus = @status1 OR productStatus = @status2", conn);

                cmd.Parameters.AddWithValue("@status1", poor);
                cmd.Parameters.AddWithValue("@status2", veryPoor);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tempProd = new ProductStruct((int)reader["pID"], (int)reader["quantity"], (string)reader["ProductName"], (string)reader["productStatus"]);

                   
                    defectiveProds.Add(tempProd);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error loading qualified products from the database.");
            }
            finally
            {
                conn.Close();
            }

            return defectiveProds;
        }



        public int[] WareHouseStats(string mat)
        {

            int[] numbers = new int[3];

            try
            {
                conn.Close();

                //open a db connection
                conn.Open();

                //create SQL Command to pull data from Raw Materials table
                SqlCommand cmd = new SqlCommand(@"SELECT ST.materialType, ST.Sum, WHT.Max, WHT.Low FROM 
                                      (SELECT materialType, SUM(quantity) as Sum
                                       FROM StockTable GROUP BY materialType) AS ST,
                                     WarehouseCapTable AS WHT
                                      WHERE ST.materialType = @material AND ST.materialType = WHT.Material; ", conn);


                cmd.Parameters.AddWithValue("@material", mat);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    numbers[0] = (int)((Decimal)reader["Sum"]);

                    numbers[1] = (int)(reader["Low"]);
                    numbers[2] = (int)(reader["Max"]);
                 

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error getting material information from the database.");
            }
            finally
            {
                conn.Close();
            }

            return numbers;
        }
        public List<Product> LoadInProgressProducts()
        {
            string status = "In Progress";
            List<Product> products = new List<Product>();

            try
            {
                Product tempProd;

                //open a db connection
                conn.Open();

                //create SQL Command to pull data from Raw Materials table
                SqlCommand cmd = new SqlCommand("SELECT * FROM ProductTable WHERE productStatus = @status", conn);

                cmd.Parameters.AddWithValue("@status", status);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tempProd = new Product();
                    tempProd.productID = (int)reader["pID"];
                    tempProd.productName = (string)reader["ProductName"];
                    tempProd.JsonMaterialString = (string)reader["materialsString"];
                    tempProd.productQuantity = (int)reader["quantity"];
                    tempProd.productStatus = (string)reader["productStatus"];
                    products.Add(tempProd);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error loading qualified products from the database.");
            }
            finally
            {
                conn.Close();
            }

            return products;
        }
        //load IDs of defective products from the Products Table into a list
        public DataTable LoadDataInProgressProducts()
        {
            string status = "In Progress";

            DataTable dtRecord = new DataTable();
            try
            {
               

                //open a db connection
                conn.Open();

                //create SQL Command to pull data from Raw Materials table
                SqlCommand cmd = new SqlCommand("SELECT * FROM ProductTable WHERE productStatus = @status", conn);

                cmd.Parameters.AddWithValue("@status", status);

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(cmd);

                
                sqlDataAdap.Fill(dtRecord);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error loading qualified products from the database.");
            }
            finally
            {
                conn.Close();
            }

            return dtRecord;
        }

        //update max/min information for the warehouse
        public void UpdateWareHouse(string ID, string max, string low)
        {
            _conn.Open();
            string str = "UPDATE [dbo].[WarehouseCapTable] SET Max=@Max, Low=@Low WHERE Material = @itemID";
            using (SqlCommand com = new SqlCommand(str, _conn))
            {
                com.Connection = _conn;
                com.Parameters.Add("@itemID", SqlDbType.VarChar).Value =ID;

                if (!string.IsNullOrEmpty(max) && isValidQuantity(max))
                {
                    com.Parameters.Add("@Max", SqlDbType.Int).Value = int.Parse(max);
                }
                else com.Parameters.Add("@Max", SqlDbType.Int).Value = 100;

                if (!string.IsNullOrEmpty(low) && isValidQuantity(low))
                {
                    com.Parameters.Add("@Low", SqlDbType.Int).Value = int.Parse(low);
                }
                else com.Parameters.Add("@Low", SqlDbType.Int).Value = 10;

                com.ExecuteNonQuery();
            }
            _conn.Close();
        }
        //Insert a new product into the productTable.
        public void InsertProduct(string productName, string materialsString, int quantity, string status)
        {
            
            _conn.Close();
            _conn.Open();
            string str = "INSERT INTO [dbo].[ProductTable] (  [productName], [materialsString], [quantity], [productStatus]) VALUES (@productName, @materialsString, @quantity, @status)";
            for (int i = 0; i < quantity; i++)
            {
                using (SqlCommand com = new SqlCommand(str, _conn))
                {
                    com.Connection = _conn;
                    com.Parameters.Add("@productName", SqlDbType.VarChar).Value = productName;
                    com.Parameters.Add("@quantity", SqlDbType.Int).Value = 1;
                    com.Parameters.Add("@materialsString", SqlDbType.VarChar).Value = materialsString;
                    com.Parameters.Add("@status", SqlDbType.VarChar).Value = status;


                    com.ExecuteNonQuery();
                }
            }
            _conn.Close();
        }
            
        public void InsertStockOrders(List<StockOrderRequest> Orders)
        {

            foreach (StockOrderRequest order in Orders)
            {
                _conn.Close();
                _conn.Open();

                string str = "INSERT INTO [dbo].[StockOrderRequest] (  [Amount], [OrderDescription], [OrderStatus], [MaterialType]) VALUES (@Amount, @OrderDescription, @Status, @MaterialType)";
                using (SqlCommand com = new SqlCommand(str, _conn))
                {
                    com.Connection = _conn;
                    com.Parameters.Add("@Amount", SqlDbType.Int).Value = order.Quantity;
                    com.Parameters.Add("@OrderDescription", SqlDbType.NVarChar).Value = order.Description;
                    com.Parameters.Add("@Status", SqlDbType.NVarChar).Value = order.Status;
                    com.Parameters.Add("@MaterialType", SqlDbType.NVarChar).Value = order.MaterialType;

                    com.ExecuteNonQuery();
                }
                _conn.Close();
            }

        }
        public List<StockOrderRequest> LoadStockOrders()
        {
            List<StockOrderRequest> orders = new List<StockOrderRequest>();

            try
            {
                StockOrderRequest order;

                //open a db connection
                _conn.Open();

                //create SQL Command to pull data from Repair table
                SqlCommand cmd = new SqlCommand("SELECT OrderID, Amount, OrderDescription, OrderStatus, MaterialType FROM [dbo].[StockOrderRequest]", _conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int ID = (int)reader["OrderID"];
                    int Quantity = (int)reader["Amount"];
                    string Discription = (string)reader["OrderDescription"];
                    string Status = (string)reader["OrderStatus"];
                    string MaterialType = (string)reader["MaterialType"];

                    order = new StockOrderRequest(ID, Quantity, Discription, Status, MaterialType);
                    orders.Add(order);
                }
                _conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error reading data in from the database.");
            }

            _conn.Close();
            return orders;
        }
        public void InsertProductOrders(List<ProductOrderRequest> Orders)
        {
           
            List<int> IDs = new List<int>();
            foreach (ProductOrderRequest order in Orders)
            {
                _conn.Close();
                _conn.Open();
                
                string str = "INSERT INTO [dbo].[ProductOrderRequest] (  [Amount], [OrderDiscription], [OrderStatus], [pId]) VALUES (@Amount, @OrderDiscription, 'Pending', @ProductID)";
                using (SqlCommand com = new SqlCommand(str, _conn))
                {
                    com.Connection = _conn;
                    com.Parameters.Add("@Amount", SqlDbType.Int).Value = order.Quantity;
                    com.Parameters.Add("@OrderDiscription", SqlDbType.NVarChar).Value = order.Description;
                    com.Parameters.Add("@ProductID", SqlDbType.Int).Value = order.ProductID;



                    com.ExecuteNonQuery();
                }
                _conn.Close();
            }
           
        }
        //return the list of productorders for the product manager
        public List<ProductOrderRequest> LoadProductOrders()
        {
            List<ProductOrderRequest> orders  = new List<ProductOrderRequest>();

            try
            {
                ProductOrderRequest order;

                //open a db connection
                _conn.Open();

                //create SQL Command to pull data from Repair table
                SqlCommand cmd = new SqlCommand("SELECT OrderID, Amount, OrderDiscription, OrderStatus, pId FROM [dbo].[ProductOrderRequest]", _conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int ID = (int)reader["OrderID"];
                    int Quantity = (int)reader["Amount"];
                    string Discription = (string)reader["OrderDiscription"];
                    string Status = (string)reader["OrderStatus"];
                    int ProductID = (int)reader["pId"];

                    order = new ProductOrderRequest(ID, Quantity,Discription, Status,ProductID);
                    orders.Add(order);
                }
                _conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error reading data in from the database.");
            }

            _conn.Close();
            return orders;
        }
        //insert new stock into the Stock Table
        public void InsertStock(string material, string quantity, string unitCost, string totalCost, string dateAcquired, string dateUsed, string amtDefected)
        {
            _conn.Close();
            _conn.Open();
            string str = "INSERT INTO [dbo].[StockTable] (  [materialType], [quantity], [unitCost], [totalCost], [dateAcquired], [dateUsed], [amtDefected]) VALUES (@materialType, @quantity, @unitCost, @totalCost, @dateAcquired, @dateUsed, @amtDefected)";
            using (SqlCommand com = new SqlCommand(str, _conn))
            {
                com.Connection = _conn;
                com.Parameters.Add("@materialType", SqlDbType.VarChar).Value = material;
                com.Parameters.Add("@quantity", SqlDbType.Decimal).Value = double.Parse(quantity);

                if (!string.IsNullOrEmpty(unitCost))
                {
                    com.Parameters.Add("@unitCost", SqlDbType.Decimal).Value = unitCost;
                }
                else
                {
                    com.Parameters.Add("@unitCost", SqlDbType.Decimal).Value = DBNull.Value;
                }

                if (!string.IsNullOrEmpty(totalCost))
                {
                    com.Parameters.Add("@totalCost", SqlDbType.Decimal).Value = double.Parse(totalCost);
                }
                else
                {
                    com.Parameters.Add("@totalCost", SqlDbType.Decimal).Value = DBNull.Value;
                }

                if (!string.IsNullOrEmpty(dateAcquired))
                {
                    com.Parameters.Add("@dateAcquired", SqlDbType.VarChar).Value = dateAcquired;
                }
                else
                {
                    com.Parameters.Add("@dateAcquired", SqlDbType.VarChar).Value = DBNull.Value;
                }

                if (!string.IsNullOrEmpty(dateUsed))
                {
                    com.Parameters.Add("@dateUsed", SqlDbType.VarChar).Value = dateUsed;
                }
                else
                {
                    com.Parameters.Add("@dateUsed", SqlDbType.VarChar).Value = DBNull.Value;
                }

                if (!string.IsNullOrEmpty(amtDefected))
                {
                    com.Parameters.Add("@amtDefected", SqlDbType.Decimal).Value = double.Parse(amtDefected);
                }
                else
                {
                    com.Parameters.Add("@amtDefected", SqlDbType.Decimal).Value = DBNull.Value;

                }

                com.ExecuteNonQuery();
            }
            _conn.Close();
        }

        public void InsertToStockTable(List<Stock> stocks)
        {
            try
            {
                _conn.Open();

                //SQL Command to insert data to the Raw Materials Table
                string str = "INSERT INTO [dbo].[StockTable] ([materialType], [quantity], [unitCost], [totalCost], [dateAcquired], [dateUsed], [amtDefected]) " +
                    "Values (@material, @quan, @uCost, @tCost, @dateAcq, @dateUsed, @defects)";

                //feed Raw Materials list to the sqlCommand
                foreach (var stock in stocks)
                {
                    SqlCommand com = new SqlCommand(str, _conn);
                    com.Connection = _conn;
                    com.Parameters.Add("@material", SqlDbType.VarChar).Value = stock.materialType;
                    com.Parameters.Add("@quan", SqlDbType.Decimal).Value = stock.quantity;

                    if(stock.unitCost != 0)
                    {
                        com.Parameters.Add("@uCost", SqlDbType.Decimal).Value = stock.unitCost;
                    }
                    else
                    {
                        com.Parameters.Add("@uCost", SqlDbType.Decimal).Value = DBNull.Value;
                    }

                    if (stock.totalCost() != 0)
                    {
                        com.Parameters.Add("@tCost", SqlDbType.Decimal).Value = stock.totalCost();
                    }
                    else
                    {
                        com.Parameters.Add("@tCost", SqlDbType.Decimal).Value = DBNull.Value;
                    }

                    if (stock.dateAcquired != DateTime.MinValue)
                    {
                        com.Parameters.Add("@dateAcq", SqlDbType.Date).Value = stock.dateAcquired;
                    }
                    else
                    {
                        com.Parameters.Add("@dateAcq", SqlDbType.Date).Value = DBNull.Value;
                    }

                    if (stock.dateUsed != DateTime.MinValue)
                    {
                        com.Parameters.Add("@dateUsed", SqlDbType.VarChar).Value = stock.dateUsed;
                    }
                    else
                    {
                        com.Parameters.Add("@dateUsed", SqlDbType.VarChar).Value = DBNull.Value;
                    }

                    if (stock.defects != 0)
                    {
                        com.Parameters.Add("@defects", SqlDbType.Decimal).Value = stock.defects;
                    }
                    else
                    {
                        com.Parameters.Add("@defects", SqlDbType.Decimal).Value = DBNull.Value;
                    }

                    com.ExecuteNonQuery();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Error adding stocks to the database.");
            }
            finally
            {
                _conn.Close();
            }
            _conn.Close();
        }

        //load data from the Stocks Table into a list
        public DataTable LoadStocks()
        {
            DataTable stockTable = new DataTable();
            stockTable.Columns.Add("itemID", typeof(int));
            stockTable.Columns.Add("materialType", typeof(string));
            stockTable.Columns.Add("quantity", typeof(double));
            stockTable.Columns.Add("unitCost", typeof(double));
            stockTable.Columns.Add("totalCost", typeof(double));
            stockTable.Columns.Add("dateAcquired", typeof(DateTime));
            stockTable.Columns.Add("dateUsed", typeof(DateTime));
            stockTable.Columns.Add("amtDefected", typeof(double));

            try
            {
                //open a db connection
                conn.Open();

                //create SQL Command to pull data from Raw Materials table
                SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[StockTable]", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["itemID"];
                    string matName = (string)reader["materialType"];
                    decimal quan = (decimal)reader["quantity"];
                    double quantity = (double) quan;

                    double unitCost, amtDefected, totalCost;
                    DateTime dateAcq, dateUsed;

                    //handle null unit cost values in database
                    if (!reader.IsDBNull(3))
                    {
                        decimal uCost = (decimal)reader["unitCost"];
                        unitCost = (double)uCost;
                        totalCost = unitCost * quantity;
                    }
                    else
                    {
                        unitCost = 0;
                        totalCost = 0;
                    }

                    //handle null defects in database
                    if (!reader.IsDBNull(7))
                    {
                        decimal defects = (decimal)reader["amtDefected"];
                        amtDefected = (double)defects;
                    }
                    else
                    {
                        amtDefected = 0;
                    }

                    //handle null date acquired in database
                    if (!reader.IsDBNull(5))
                    {
                        dateAcq = (DateTime)reader["dateAcquired"];
                    }
                    else
                    {
                        dateAcq = DateTime.MinValue;
                    }

                    //handle null date used in database
                    if (!reader.IsDBNull(6))
                    {
                        dateUsed = (DateTime)reader["dateUsed"];
                    }
                    else
                    {
                        dateUsed = DateTime.MinValue;
                    }

                    stockTable.Rows.Add(id, matName, quantity, unitCost, totalCost, dateAcq, dateUsed, amtDefected);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error loading stocks from the database.");
            }
            finally
            {
                conn.Close();
            }

            return stockTable;
        }
        

        public DataTable LoadProducts()
        {
            DataTable ProductTable = new DataTable();
            ProductTable.Columns.Add("pId", typeof(int));
            ProductTable.Columns.Add("ProductName", typeof(string));
            ProductTable.Columns.Add("materialsString", typeof(string));
            ProductTable.Columns.Add("quantity", typeof(int));
            ProductTable.Columns.Add("productStatus", typeof(string));
            try
            {
                //open a db connection
                conn.Open();

                //SQL Command to pull data from Product table
                SqlCommand cmd = new SqlCommand("SELECT pId, ProductName, materialsString, quantity, productStatus FROM [dbo].[ProductTable]", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int pId = (int)reader["pId"];
                    string ProductName = (string)reader["ProductName"];
                    string materialsString = (string)reader["materialsString"];
                    int quantity = (int)reader["quantity"];
                    string status = (string)reader["productStatus"];



                    //handle null unit cost values in database


                    //handle null defects in database


                    ProductTable.Rows.Add(pId, ProductName, materialsString, quantity, status);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error loading stocks from the database.");
            }
            finally
            {
                conn.Close();
            }

            return ProductTable;
        }
        public string ProductMaterials(int key)
        {
            string materials="";
            try
            {
                //open a db connection
                conn.Open();

                //SQL Command to pull productMaterials from productTable.
                SqlCommand cmd = new SqlCommand("SELECT  materialsString FROM [dbo].[ProductTable] WHERE pId="+key, conn);

                materials=Convert.ToString(cmd.ExecuteScalar()); 



            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error loading stocks from the database.");
            }
            finally
            {
                conn.Close();
            }

            return materials;
        }
        public int ProductQuantity(int key)
        {
            int quantity = 0;
            try
            {
                //open a db connection
                conn.Open();

                //SQL Command to pull productQuantity from productTable.
                SqlCommand cmd = new SqlCommand("SELECT  quantity FROM [dbo].[ProductTable] WHERE pId=" + key, conn);

                quantity = (int)cmd.ExecuteScalar();



            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error loading stocks from the database.");
            }
            finally
            {
                conn.Close();
            }

            return quantity;
        }
        public string ProductName(int key)
        {
            string name = "";
            try
            {
                //open a db connection
                conn.Open();

                //SQL Command to pull productName from productTable.
                SqlCommand cmd = new SqlCommand("SELECT  productName FROM [dbo].[ProductTable] WHERE pId=" + key, conn);

                name = Convert.ToString(cmd.ExecuteScalar());


            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error loading stocks from the database.");
            }
            finally
            {
                conn.Close();
            }

            return name;
        }
        
        public string ProductStatus(int key)
        {
            string status = "";
            try
            {
                //open a db connection
                conn.Open();

                //SQL Command to pull productStatus from productTable.
                SqlCommand cmd = new SqlCommand("SELECT  productStatus FROM [dbo].[ProductTable] WHERE pId=" + key, conn);

                status = Convert.ToString(cmd.ExecuteScalar());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error loading product status from the database.");
            }
            finally
            {
                conn.Close();
            }

            return status;
        }
        
        //Updates Product based on key(ID).
        public void UpdateProduct(int key, string ProductName ,string materialsString, int quantity, string productStatus)
        {
            _conn.Open();
            string str = "UPDATE [dbo].[ProductTable] SET ProductName=@ProductName, materialsString=@materialsString, quantity=@quantity, productStatus=@productStatus WHERE pId=@pId";
            using (SqlCommand com = new SqlCommand(str, _conn))
            {
                com.Connection = _conn;
                com.Parameters.Add("@pId", SqlDbType.Int).Value = key;
                com.Parameters.Add("@ProductName", SqlDbType.VarChar).Value = ProductName;
                com.Parameters.Add("@materialsString", SqlDbType.VarChar).Value = materialsString;
                com.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;
                com.Parameters.Add("@productStatus", SqlDbType.VarChar).Value = productStatus;

                com.ExecuteNonQuery();
            }
            _conn.Close();
        }
        public void UpdateProductStatus(int key, string productStatus)
        {
            _conn.Open();
            string str = "UPDATE [dbo].[ProductTable] SET  productStatus=@productStatus WHERE pId=@pId";
            using (SqlCommand com = new SqlCommand(str, _conn))
            {
                com.Connection = _conn;
                com.Parameters.Add("@pId", SqlDbType.Int).Value = key;
              
                com.Parameters.Add("@productStatus", SqlDbType.VarChar).Value = productStatus;

                com.ExecuteNonQuery();
            }
            _conn.Close();
        }

        public void UpdateStockOrderStatus(int key)
        {
            _conn.Open();
            string str = "UPDATE [dbo].[StockOrderRequest] SET OrderStatus='Order Filled' WHERE OrderID="+key;

            using (SqlCommand com = new SqlCommand(str, _conn))
            {
                com.Connection = _conn;
                             
                com.ExecuteNonQuery();
            }
            _conn.Close();
        }
        public void UpdateProductOrderStatus(int key)
        {
            _conn.Open();
            string str = "UPDATE [dbo].[ProductOrderRequest] SET OrderStatus='Order Filled' WHERE OrderID=" + key;

            using (SqlCommand com = new SqlCommand(str, _conn))
            {
                com.Connection = _conn;




                com.ExecuteNonQuery();
            }
            _conn.Close();
        }
       
        //update stock in the Stock Table
        public void UpdateStock(int key, string material, string quantity, string unitCost, string totalCost, string dateAcquired, string dateUsed, string amtDefected)
        {
            _conn.Open();
            string str = "UPDATE [dbo].[StockTable] SET materialType=@materialType, quantity=@quantity, unitCost=@unitCost, totalCost=@totalCost, dateAcquired=@dateAcquired, dateUsed=@dateUsed, amtDefected=@amtDefected WHERE itemID=@itemID";
            using (SqlCommand com = new SqlCommand(str, _conn))
            {
                com.Connection = _conn;
                com.Parameters.Add("@itemID", SqlDbType.Int).Value = key;
                com.Parameters.Add("@materialType", SqlDbType.VarChar).Value = material;
                com.Parameters.Add("@quantity", SqlDbType.Decimal).Value = double.Parse(quantity);

                if (!string.IsNullOrEmpty(unitCost))
                {
                    com.Parameters.Add("@unitCost", SqlDbType.Decimal).Value = unitCost;
                }
                else
                {
                    com.Parameters.Add("@unitCost", SqlDbType.Decimal).Value = DBNull.Value;
                }

                if (!string.IsNullOrEmpty(totalCost))
                {
                    com.Parameters.Add("@totalCost", SqlDbType.Decimal).Value = double.Parse(totalCost);
                }
                else
                {
                    com.Parameters.Add("@totalCost", SqlDbType.Decimal).Value = DBNull.Value;
                }

                if (!string.IsNullOrEmpty(dateAcquired))
                {
                    com.Parameters.Add("@dateAcquired", SqlDbType.VarChar).Value = dateAcquired;
                }
                else
                {
                    com.Parameters.Add("@dateAcquired", SqlDbType.VarChar).Value = DBNull.Value;
                }

                if (!string.IsNullOrEmpty(dateUsed))
                {
                    com.Parameters.Add("@dateUsed", SqlDbType.VarChar).Value = dateUsed;
                }
                else
                {
                    com.Parameters.Add("@dateUsed", SqlDbType.VarChar).Value = DBNull.Value;
                }

                if (!string.IsNullOrEmpty(amtDefected))
                {
                    com.Parameters.Add("@amtDefected", SqlDbType.Decimal).Value = double.Parse(amtDefected);
                }
                else
                {
                    com.Parameters.Add("@amtDefected", SqlDbType.Decimal).Value = DBNull.Value;

                }

                com.ExecuteNonQuery();
                
            }
            _conn.Close();
        }

        //insert new user into the Users Table
        public void InsertUser(string FirstName, string LastName, string UserType, string Email, string UserName, string Password)
        {
            _conn.Close();
            _conn.Open();
            string str = "INSERT INTO [dbo].[UsersTable] ( [FirstName], [LastName], [UserType], [Email], [UserName], [Password]) VALUES (  @FirstName  , @LastName,@UserType,@Email,@UserName,@Password)";

            using (SqlCommand com = new SqlCommand(str, _conn))
            {
                com.Connection = _conn;

                if (!string.IsNullOrEmpty(FirstName))
                {
                    com.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FirstName;
                }
                else
                {
                    com.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = DBNull.Value;
                }

                if (!string.IsNullOrEmpty(LastName))
                {
                    com.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastName;
                }
                else
                {
                    com.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = DBNull.Value;
                }

                if (!string.IsNullOrEmpty(UserType))
                {
                    com.Parameters.Add("@UserType", SqlDbType.NVarChar).Value = UserType;
                }
                else
                {
                    com.Parameters.Add("@UserType", SqlDbType.NVarChar).Value = DBNull.Value;
                }

                if (!string.IsNullOrEmpty(Email))
                {
                    com.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email;
                }
                else
                {
                    com.Parameters.Add("@Email", SqlDbType.NVarChar).Value = DBNull.Value;
                }

                if (!string.IsNullOrEmpty(UserName))
                {
                    com.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = UserName;
                }
                else
                {
                    com.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = DBNull.Value;
                }

                if (!string.IsNullOrEmpty(Password))
                {
                    com.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Password;
                }
                else
                {
                    com.Parameters.Add("@Password", SqlDbType.NVarChar).Value = DBNull.Value;

                }

                com.ExecuteNonQuery();

            }
            _conn.Close();

        }

        public int GetUserTypeID(string UserType)
        {
            int ID=-1;
            try
            {

                _conn.Close();
                _conn.Open();

                string str = "SELECT UserTypeID " + "FROM  [dbo].[UserTypeTable]" +
                           "WHERE userTypeText = @UserType";

                using (SqlCommand com = new SqlCommand(str, _conn))
                {
                    com.Connection = _conn;


                    if (!string.IsNullOrEmpty(UserType))
                    {
                        com.Parameters.Add("@UserType", SqlDbType.NVarChar).Value = UserType;
                    }
                    else
                    {
                        com.Parameters.Add("@UserType", SqlDbType.NVarChar).Value = DBNull.Value;

                    }

                    SqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {


                        if (UserType != null )
                            ID = (int) (reader[0]);

                    }
                    reader.Close();
                }
                _conn.Close();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                ID = -1;
            }


            return ID;

        }

        public string LoginFromDb(string UserName, string enteredPassword)
        {
            string UserType = null;
            try
            {
                UserType = String.Empty;

                _conn.Close();
                _conn.Open();

                string str = "SELECT UserType,Password " + "FROM  [dbo].[UsersTable]" +
                           "WHERE UserName = @Username";

                using (SqlCommand com = new SqlCommand(str, _conn))
                {
                    com.Connection = _conn;


                    if (!string.IsNullOrEmpty(UserName))
                    {
                        com.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = UserName;
                    }
                    else
                    {
                        com.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = DBNull.Value;

                    }

                    SqlDataReader reader = com.ExecuteReader();

                    while (reader.Read())
                    {

                        string dbPassword = reader[1]?.ToString();
                        Password objPassword = new Password();

                        if (UserType != null && objPassword.verifyPasswordMatch(dbPassword, enteredPassword))
                            UserType = reader[0]?.ToString();

                    }
                    reader.Close();
                }
                _conn.Close();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                UserType = null;
            }


            return UserType;
        }

        public DataTable StockReportMax()
        {
            DataTable dtRecord = new DataTable();

            try
            {
                _conn.Close();
                _conn.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = _conn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = @"SELECT ST.materialType, ST.Sum, WHT.Max FROM 
                                      (SELECT materialType, SUM(quantity) as Sum 
                                       FROM StockTable GROUP BY materialType) AS ST,
                                     WarehouseCapTable AS WHT
                                      WHERE ST.materialType = WHT.Material AND ST.Sum >= WHT.Max; ";
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                sqlDataAdap.Fill(dtRecord);

                _conn.Close();

                
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading stock max capacity from database.");
            }

            return dtRecord;

        }

        public DataTable StockReportLow()
        {
            DataTable dtRecord = new DataTable();

            try
            {
                _conn.Close();
                _conn.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = _conn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = @"SELECT ST.materialType, ST.Sum, WHT.Low FROM 
                                      (SELECT materialType, SUM(quantity) as Sum 
                                       FROM StockTable GROUP BY materialType) AS ST,
                                     WarehouseCapTable AS WHT
                                      WHERE ST.materialType = WHT.Material AND ST.Sum <= WHT.Low; ";
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                sqlDataAdap.Fill(dtRecord);
                _conn.Close();

                
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading stock low capacity from database.");
            }

            return dtRecord;

        }

        //load data from the User Type Table into a list
        public List<string> LoadUserTypes()
        {
            List<string> users = new List<string>();

            try
            {
                string tempUsers;

                //open a db connection
                conn.Open();

                //create SQL Command to pull data from Raw Materials table
                SqlCommand cmd = new SqlCommand("SELECT * FROM UserTypeTable", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string type = (string)reader["userTypeText"];
                    tempUsers = type;
                    users.Add(tempUsers);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error reading data in from the User Type database table.");
            }
            finally
            {
                conn.Close();
            }

            return users;
        }

        public DataTable SumStocks()
        {
            DataTable stockTable = new DataTable();
            stockTable.Columns.Add("Material", typeof(string));
            stockTable.Columns.Add("Inventory Level", typeof(double));
            
            try
            {
                //open a db connection
                conn.Open();

                //create SQL Command to pull data from Raw Materials table
                SqlCommand cmd = new SqlCommand("SELECT materialType, SUM(quantity) as Sum FROM StockTable GROUP BY materialType", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string matName = (string)reader["materialType"];
                    decimal sum = (decimal)reader["Sum"];
                    double sumStocks = (double)sum;

                    stockTable.Rows.Add(matName, sumStocks);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error loading stock summary from the database.");
            }
            finally
            {
                conn.Close();
            }

            return stockTable;
        }

        public DataTable ProductStatusTable()
        {
            _conn.Close();
            _conn.Open();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = _conn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT PT.productName , PT.productStatus FROM ProductTable AS PT ORDER BY PT.productStatus";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);

            _conn.Close();

            return dtRecord;
        }

    }
}
