using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowManagement
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



        

        //Insert data into the Raw Materials table in the database
        public void InsertToRMTable(List<RawMaterials> rawMaterials)
        {
            try
            {
                conn.Open();

                //SQL Command to insert data to the Raw Materials Table
                SqlCommand cmd = new SqlCommand("INSERT INTO RawMaterials (rawMaterials)" + "VALUES (@rMaterial)");
                cmd.Connection = conn;

                //feed Raw Materials list to the sqlCommand
                foreach (var rawMat in rawMaterials)
                {
                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("rMaterial", rawMat.material);

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error adding raw materials to the database.");
            }
            finally
            {
                conn.Close();
            }
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM RawMaterials", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string rawMatName = (string)reader["matName"];
                    tempRawMat = new RawMaterials(rawMatName);
                    rawMaterials.Add(tempRawMat);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error reading data in from the database.");
            }
            finally
            {
                conn.Close();
            }

            return rawMaterials;
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
