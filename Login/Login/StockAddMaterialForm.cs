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
    public partial class AddMaterialForm : Form
    {
        public AddMaterialForm()
        {
            InitializeComponent();
        }

        private void lbl_unitCost_Click(object sender, EventArgs e)
        {

        }
   

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private Boolean isValidNumber(string number)
        {
            try
            {
                double num = double.Parse(number);
                return true;
            }
            catch
            {
                return false;
            }
        }


        private Boolean CheckValidStock()
        {
            if (!isValidNumber(txt_Quantity.Text))
            {
                System.Windows.Forms.MessageBox.Show("Quantity must be numerical (e.g. 30, 1000, etc.)");
                txt_Quantity.Clear();
                return false;
            }

            /*
            if (!isValidNumber(txt_Defected.Text))
            {
                System.Windows.Forms.MessageBox.Show("Number of defected items must be numerical (e.g. 30, 1000, etc.)");
                txt_Defected.Clear();
                return false;
            }

            if (!isValidNumber(txt_unitCost.Text))
            {
                System.Windows.Forms.MessageBox.Show("Unit cost must be numerical and can contain two decimal places (e.g. 30, 1.45, etc.)");
                txt_Defected.Clear();
                return false;
            }

            if (!isValidNumber(txt_TotalCost.Text))
            {
                System.Windows.Forms.MessageBox.Show("Total cost must be numerical and can contain two decimal places (e.g. 30, 1.45, etc.)");
                txt_Defected.Clear();
                return false;
            }*/

            return true;
        }

        

        private void Another_Material_btn_Click(object sender, EventArgs e)
        {
            if (CheckValidStock())
            {
                string material = txt_materialType.Text;

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
                    com.Parameters.Add("@quantity", SqlDbType.Decimal).Value = double.Parse(txt_Quantity.Text);

                    if (!string.IsNullOrEmpty(txt_unitCost.Text))
                    {
                        com.Parameters.Add("@unitCost", SqlDbType.Decimal).Value = double.Parse(txt_unitCost.Text);
                    }
                    else
                    {
                        com.Parameters.Add("@unitCost", SqlDbType.Decimal).Value = DBNull.Value;
                    }

                    if (!string.IsNullOrEmpty(txt_TotalCost.Text))
                    {
                        com.Parameters.Add("@totalCost", SqlDbType.Decimal).Value = double.Parse(txt_TotalCost.Text);
                    }
                    else
                    {
                        com.Parameters.Add("@totalCost", SqlDbType.Decimal).Value = DBNull.Value;
                    }

                    if (!string.IsNullOrEmpty(txt_DateAcq.Text))
                    {
                        com.Parameters.Add("@dateAcquired", SqlDbType.VarChar).Value = txt_DateAcq.Text;
                    }
                    else
                    {
                        com.Parameters.Add("@dateAcquired", SqlDbType.VarChar).Value = DBNull.Value;
                    }

                    if (!string.IsNullOrEmpty(txt_dateUsed.Text))
                    {
                        com.Parameters.Add("@dateUsed", SqlDbType.VarChar).Value = txt_dateUsed.Text;
                    }
                    else
                    {
                        com.Parameters.Add("@dateUsed", SqlDbType.VarChar).Value = DBNull.Value;
                    }

                    if (!string.IsNullOrEmpty(txt_Defected.Text))
                    {
                        com.Parameters.Add("@amtDefected", SqlDbType.Decimal).Value = double.Parse(txt_Defected.Text);
                    }
                    else
                    {
                        com.Parameters.Add("@amtDefected", SqlDbType.Decimal).Value = DBNull.Value;

                    }

                    com.ExecuteNonQuery();
                }

                StockForm formStock = new StockForm();

                txt_materialType.Clear();
                txt_DateAcq.Clear();
                txt_dateUsed.Clear();
                txt_Defected.Clear();
                txt_Quantity.Clear();
                txt_TotalCost.Clear();
                txt_unitCost.Clear();
            }

        }

        private void Confirm_Material_btn_Click(object sender, EventArgs e)
        {
            if (CheckValidStock())
            {
                string material = txt_materialType.Text;

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
                    com.Parameters.Add("@quantity", SqlDbType.Decimal).Value = double.Parse(txt_Quantity.Text);

                    if (!string.IsNullOrEmpty(txt_unitCost.Text))
                    {
                        com.Parameters.Add("@unitCost", SqlDbType.Decimal).Value = double.Parse(txt_unitCost.Text);
                    }
                    else
                    {
                        com.Parameters.Add("@unitCost", SqlDbType.Decimal).Value = DBNull.Value;
                    }

                    if (!string.IsNullOrEmpty(txt_TotalCost.Text))
                    {
                        com.Parameters.Add("@totalCost", SqlDbType.Decimal).Value = double.Parse(txt_TotalCost.Text);
                    }
                    else
                    {
                        com.Parameters.Add("@totalCost", SqlDbType.Decimal).Value = DBNull.Value;
                    }

                    if (!string.IsNullOrEmpty(txt_DateAcq.Text))
                    {
                        com.Parameters.Add("@dateAcquired", SqlDbType.VarChar).Value = txt_DateAcq.Text;
                    }
                    else
                    {
                        com.Parameters.Add("@dateAcquired", SqlDbType.VarChar).Value = DBNull.Value;
                    }

                    if (!string.IsNullOrEmpty(txt_dateUsed.Text))
                    {
                        com.Parameters.Add("@dateUsed", SqlDbType.VarChar).Value = txt_dateUsed.Text;
                    }
                    else
                    {
                        com.Parameters.Add("@dateUsed", SqlDbType.VarChar).Value = DBNull.Value;
                    }

                    if (!string.IsNullOrEmpty(txt_Defected.Text))
                    {
                        com.Parameters.Add("@amtDefected", SqlDbType.Decimal).Value = double.Parse(txt_Defected.Text);
                    }
                    else
                    {
                        com.Parameters.Add("@amtDefected", SqlDbType.Decimal).Value = DBNull.Value;

                    }

                    com.ExecuteNonQuery();
                }

                StockForm formStock = new StockForm();

                Hide();
                formStock.ShowDialog();
            }
        }

        private void btnCalcTotalCost_Click(object sender, EventArgs e)
        {
            double quan = double.Parse(txt_Quantity.Text);
            double uCost = double.Parse(txt_unitCost.Text);
            double tCost = Math.Round(quan * uCost, 2);
            txt_TotalCost.Text = tCost.ToString();
        }
    }
}
