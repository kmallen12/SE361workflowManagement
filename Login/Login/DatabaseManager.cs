using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowManagement
{
    struct SqlQuery
    {
        string Table;
        string Column;
        string Where;
        string Data;
    }
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
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select " + column + "from " + table + "where " + column + " = @field";
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
        public void UpdateWareHouse(string ID, string max, string low)
        {
            _conn.Open();
            string str = "UPDATE [dbo].[WareHouseTable] SET Max=@Max , Low=@Low WHERE itemID = @itemID";
            using (SqlCommand com = new SqlCommand(str, _conn))
            {
                com.Connection = _conn;
                com.Parameters.Add("@itemID", SqlDbType.Int).Value = int.Parse(ID);

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
        public void InsertStock(string material, string quantity, string unitCost, string totalCost, string dateAcquired, string dateUsed, string amtDefected)
        {
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


        //below is the primary formatting of functions withtin this Database class
        // think of it as an example. if u used it in other classes you'd scall it by: DatabaseManager.insertmaterial()

        // public static void insertmaterial()
        //{
        //    try
        //    {
        //        conn.Open();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    MessageBox.Show("connected to db through database manager");
        //    return;
        //}
    }
}
