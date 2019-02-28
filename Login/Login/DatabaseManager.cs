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

        //update max/min information for the warehouse
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
            _conn.Close();
            _conn.Open();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = _conn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT ST.itemID , ST.quantity FROM StockTable AS ST, WareHouseTable AS WHT WHERE ST.itemID = WHT.itemID AND ST.quantity >= WHT.Max";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);

            _conn.Close();

            return dtRecord;
        }

        public DataTable StockReportLow()
        {
            _conn.Close();
            _conn.Open();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = _conn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT ST.itemID , ST.quantity FROM StockTable AS ST, WareHouseTable AS WHT WHERE ST.itemID = WHT.itemID AND ST.quantity <= WHT.Low";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            _conn.Close();

            return dtRecord;
        }

    }
}
