using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WorkflowManagement
{
    public partial class UpdateStock : Form
    {
        public UpdateStock()
        {
            InitializeComponent();
        }

        private void UpdateStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workFlowDatabaseDataSet.StockTable' table. You can move, or remove it, as needed.
            this.stockTableTableAdapter.Fill(this.workFlowDatabaseDataSet.StockTable);

        }
    

     

       
        private Boolean isValidQuantity(string quantity)
        {
            try
            {
                double quan = double.Parse(quantity);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private Boolean CheckValidStock()
        {
            if (!isValidQuantity(quantityGrid_box.Text))
            {
                System.Windows.Forms.MessageBox.Show("Quantity must be an integer (e.g. 30, 1000, etc.)");
                quantityGrid_box.Clear();
                return false;
            }

            return true;
        }
        private void ConfirmGrid_btn_Click(object sender, EventArgs e)
        {
            if (CheckValidStock()&&string.IsNullOrEmpty(ItemIDGrid_box.Text.ToString()))
            {
                string material = materialTypeGrid_box.Text;
                double unitCost;

                if (string.IsNullOrEmpty(unitCostGrid_box.Text))
                {
                    unitCost = 0;
                }
                else
                {
                    unitCost = double.Parse(unitCostGrid_box.Text);
                }

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "tcp:workflowdatabase.database.windows.net,1433";
                builder.UserID = "OCOTOD";
                builder.Password = "FairBanks152";
                builder.InitialCatalog = "WorkFlowDatabase";
                SqlConnection con = new SqlConnection(builder.ConnectionString);

                string str;
                str = "INSERT INTO [dbo].[StockTable] (  [materialType], [quantity], [unitCost], [totalCost], [dateAcquired], [dateUsed], [amtDefected]) VALUES (@materialType, @quantity, @unitCost, @totalCost, @dateAcquired, @dateUsed, @amtDefected)";
                con.Open();

                using (SqlCommand com = new SqlCommand(str, con))
                {
                    com.Connection = con;
                    com.Parameters.Add("@materialType", SqlDbType.VarChar).Value = material;
                    com.Parameters.Add("@quantity", SqlDbType.Decimal).Value = double.Parse(quantityGrid_box.Text);

                    if (!string.IsNullOrEmpty(unitCostGrid_box.Text))
                    {
                        com.Parameters.Add("@unitCost", SqlDbType.Decimal).Value = unitCost;
                    }
                    else
                    {
                        com.Parameters.Add("@unitCost", SqlDbType.Decimal).Value = DBNull.Value;
                    }

                    if (!string.IsNullOrEmpty(totalCostGrid_box.Text))
                    {
                        com.Parameters.Add("@totalCost", SqlDbType.Decimal).Value = double.Parse(totalCostGrid_box.Text);
                    }
                    else
                    {
                        com.Parameters.Add("@totalCost", SqlDbType.Decimal).Value = DBNull.Value;
                    }

                    if (!string.IsNullOrEmpty(dateAcquiredGrid_box.Text))
                    {
                        com.Parameters.Add("@dateAcquired", SqlDbType.VarChar).Value =dateAcquiredGrid_box.Text;
                    }
                    else
                    {
                        com.Parameters.Add("@dateAcquired", SqlDbType.VarChar).Value = DBNull.Value;
                    }

                    if (!string.IsNullOrEmpty(dateUsedGrid_box.Text))
                    {
                        com.Parameters.Add("@dateUsed", SqlDbType.VarChar).Value = dateUsedGrid_box.Text;
                    }
                    else
                    {
                        com.Parameters.Add("@dateUsed", SqlDbType.VarChar).Value = DBNull.Value;
                    }

                    if (!string.IsNullOrEmpty(amtDefectedGrid_box.Text))
                    {
                        com.Parameters.Add("@amtDefected", SqlDbType.Decimal).Value = double.Parse(amtDefectedGrid_box.Text);
                    }
                    else
                    {
                        com.Parameters.Add("@amtDefected", SqlDbType.Decimal).Value = DBNull.Value;

                    }

                    com.ExecuteNonQuery();
                }
                this.stockTableTableAdapter.Fill(this.workFlowDatabaseDataSet.StockTable);
                this.dataGridView1.Refresh();
                this.dataGridView1.RefreshEdit();

            }
            else if (CheckValidStock()&&!string.IsNullOrEmpty(ItemIDGrid_box.Text.ToString()))
            {
              
                string material = materialTypeGrid_box.Text;
                double unitCost;
                int key = Int32.Parse(ItemIDGrid_box.Text);
                if (string.IsNullOrEmpty(unitCostGrid_box.Text))
                {
                    unitCost = 0;
                }
                else
                {
                    unitCost = double.Parse(unitCostGrid_box.Text);
                }

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "tcp:workflowdatabase.database.windows.net,1433";
                builder.UserID = "OCOTOD";
                builder.Password = "FairBanks152";
                builder.InitialCatalog = "WorkFlowDatabase";
                SqlConnection con = new SqlConnection(builder.ConnectionString);
                
                string str;
                str = "UPDATE [dbo].[StockTable] SET materialType=@materialType, quantity=@quantity, unitCost=@unitCost, totalCost=@totalCost, dateAcquired=@dateAcquired, dateUsed=@dateUsed, amtDefected=@amtDefected WHERE itemID=@itemID";
                con.Open();

                using (SqlCommand com = new SqlCommand(str, con))
                {
                    
                    com.Connection = con;
                    com.Parameters.Add("@itemID",SqlDbType.Int).Value= ItemIDGrid_box.Text;
                    com.Parameters.Add("@materialType", SqlDbType.VarChar).Value = material;
                    com.Parameters.Add("@quantity", SqlDbType.Decimal).Value = double.Parse(quantityGrid_box.Text);

                    if (!string.IsNullOrEmpty(unitCostGrid_box.Text))
                    {
                        com.Parameters.Add("@unitCost", SqlDbType.Decimal).Value = unitCost;
                    }
                    else
                    {
                        com.Parameters.Add("@unitCost", SqlDbType.Decimal).Value = DBNull.Value;
                    }

                    if (!string.IsNullOrEmpty(totalCostGrid_box.Text))
                    {
                        com.Parameters.Add("@totalCost", SqlDbType.Decimal).Value = double.Parse(totalCostGrid_box.Text);
                    }
                    else
                    {
                        com.Parameters.Add("@totalCost", SqlDbType.Decimal).Value = DBNull.Value;
                    }

                    if (!string.IsNullOrEmpty(dateAcquiredGrid_box.Text))
                    {
                        com.Parameters.Add("@dateAcquired", SqlDbType.VarChar).Value = dateAcquiredGrid_box.Text;
                    }
                    else
                    {
                        com.Parameters.Add("@dateAcquired", SqlDbType.VarChar).Value = DBNull.Value;
                    }

                    if (!string.IsNullOrEmpty(dateUsedGrid_box.Text))
                    {
                        com.Parameters.Add("@dateUsed", SqlDbType.VarChar).Value = dateUsedGrid_box.Text;
                    }
                    else
                    {
                        com.Parameters.Add("@dateUsed", SqlDbType.VarChar).Value = DBNull.Value;
                    }

                    if (!string.IsNullOrEmpty(amtDefectedGrid_box.Text))
                    {
                        com.Parameters.Add("@amtDefected", SqlDbType.Decimal).Value = double.Parse(amtDefectedGrid_box.Text);
                    }
                    else
                    {
                        com.Parameters.Add("@amtDefected", SqlDbType.Decimal).Value = DBNull.Value;

                    }

                    com.ExecuteNonQuery();
                }
                this.stockTableTableAdapter.Fill(this.workFlowDatabaseDataSet.StockTable);
                this.dataGridView1.Refresh();
                this.dataGridView1.RefreshEdit();
            }
        }

      
    }
}
