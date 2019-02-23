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
        private Stock objStock;
        private List<Stock> stocks;

        DatabaseManager objDatabaseManager;

        //dropdown list property
        private List<RawMaterials> materialList;
        private RawMaterials objWood;  //DELETE THIS ONCE CONNECTED TO DATABASE

        public AddMaterialForm()
        {
            InitializeComponent();

            stocks = new List<Stock>();

            materialList = new List<RawMaterials>();

            //DELETE THESE TWO LINES ONCE CONNECTED TO DATABASE
            objWood = new RawMaterials("wood");
            materialList.Add(objWood);

            //materialList = objDatabaseManager.LoadRawMat();
            foreach(RawMaterials mat in materialList)
            {
                txt_materialType.Items.Add(mat.material);
            }
        }

        private void lbl_unitCost_Click(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Cowen - I commented these lines out so the Homepage doesn't get closed when the form is closed.
            //base.OnFormClosing(e);    
            //Application.Exit();
        }

        private void Another_Material_btn_Click(object sender, EventArgs e)
        {
            try
            {
                CheckEntry objCheckQuantity = new CheckEntry(txt_Quantity.Text, lbl_quantity.Text);
                if(!objCheckQuantity.isValidNumber())
                {
                    txt_Quantity.Clear();
                }

                CheckEntry objCheckUnitCost = new CheckEntry(txt_unitCost.Text, lbl_unitCost.Text);
                if (!objCheckUnitCost.isNull())
                {
                    if (!objCheckUnitCost.isValidNumber())
                    {
                        txt_unitCost.Clear(); 
                    }
                }

                CheckEntry objCheckDefects = new CheckEntry(txt_Defected.Text, lbl_defected.Text);
                if (!objCheckDefects.isNull())
                {
                    if (!objCheckDefects.isValidNumber())
                    {
                        txt_Defected.Clear();
                    }
                }

                CheckEntry objCheckTotalCost = new CheckEntry(txt_TotalCost.Text, lbl_totalCost.Text);
                if (!objCheckTotalCost.isNull())
                {
                    if (!objCheckTotalCost.isValidNumber())
                    {
                        txt_TotalCost.Clear();
                    }
                }

                string materialType = txt_materialType.Text;
                double quantity = double.Parse(txt_Quantity.Text);
                double unitCost = double.Parse(txt_unitCost.Text);
                double defects = double.Parse(txt_Defected.Text);
                double totalCost = double.Parse(txt_TotalCost.Text);
                DateTime dateAquired = DateTime.Parse(txt_DateAcq.Text);
                DateTime dateUsed = DateTime.Parse(txt_dateUsed.Text);

                objStock = new Stock(materialType, quantity, unitCost, defects, dateAquired, dateUsed);

                stocks.Add(objStock);

                
                
                //CODE BELOW NEEDS TO BE REPLACED WITH DB HANDLER CODE
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "tcp:workflowdatabase.database.windows.net,1433";
                builder.DataSource = "OCOTOD";
                builder.Password = "FairBanks152";
                builder.InitialCatalog = "WorkFlowDatabase";
                SqlConnection con = new SqlConnection(builder.ConnectionString);

                string str;
                str = "INSERT INTO [dbo].[StockTable] (  [materialType], [quantity], [unitCost], [totalCost], [dateAcquired], [dateUsed], [amtDefected]) VALUES (@materialType, @quantity, @unitCost, @totalCost, @dateAcquired, @dateUsed, @amtDefected)";
                con.Open();

                using (SqlCommand com = new SqlCommand(str, con))
                {
                    com.Connection = con;
                    com.Parameters.Add("@materialType", SqlDbType.VarChar).Value = materialType;
                    com.Parameters.Add("@quantity", SqlDbType.Decimal).Value = quantity;

                    // If the unit cost text box is not empty, add the unit cost in decimal format to the database.
                    // Otherwise, add a null value.
                    if (!objCheckUnitCost.isNull())
                    {
                        com.Parameters.Add("@unitCost", SqlDbType.Decimal).Value = unitCost;
                    }
                    else
                    {
                        com.Parameters.Add("@unitCost", SqlDbType.Decimal).Value = DBNull.Value;
                    }

                    // If the total cost text box is not empty, add the total cost in decimal format to the database.
                    // Otherwise, add a null value.
                    if (!objCheckTotalCost.isNull())
                    {
                        com.Parameters.Add("@totalCost", SqlDbType.Decimal).Value = totalCost;
                    }
                    else
                    {
                        com.Parameters.Add("@totalCost", SqlDbType.Decimal).Value = DBNull.Value;
                    }

                    // If the defects text box is not empty, add the defects in decimal format to the database.
                    // Otherwise, add a null value.
                    if (!objCheckDefects.isNull())
                    {
                        com.Parameters.Add("@amtDefected", SqlDbType.Decimal).Value = defects;
                    }
                    else
                    {
                        com.Parameters.Add("@amtDefected", SqlDbType.Decimal).Value = DBNull.Value;
                    }

                    // If the date acquired text box is not empty, add the date acquired in varchar format to the database.
                    // Otherwise, add a null value.
                    if (!string.IsNullOrEmpty(txt_DateAcq.Text))
                    {
                        com.Parameters.Add("@dateAcquired", SqlDbType.VarChar).Value = dateAquired;
                    }
                    else
                    {
                        com.Parameters.Add("@dateAcquired", SqlDbType.VarChar).Value = DBNull.Value;
                    }

                    // If the date used text box is not empty, add the date used in varchar format to the database.
                    // Otherwise, add a null value.
                    if (!string.IsNullOrEmpty(txt_dateUsed.Text))
                    {
                        com.Parameters.Add("@dateUsed", SqlDbType.VarChar).Value = dateUsed;
                    }
                    else
                    {
                        com.Parameters.Add("@dateUsed", SqlDbType.VarChar).Value = DBNull.Value;
                    }

                    com.ExecuteNonQuery();
                }

                StockForm formStock = new StockForm();

                txt_materialType.SelectedIndex = -1;
                txt_DateAcq.Clear();
                txt_dateUsed.Clear();
                txt_Defected.Clear();
                txt_Quantity.Clear();
                txt_TotalCost.Clear();
                txt_unitCost.Clear();
            }
            catch
            {

            }
        }

        private void Confirm_Material_btn_Click(object sender, EventArgs e)
        {
            try
            {
                CheckEntry objCheckEntryQuantity = new CheckEntry(txt_Quantity.Text, lbl_quantity.Text);
                if (!objCheckEntryQuantity.isValidNumber())
                {
                    txt_Quantity.Clear();
                }

                CheckEntry objCheckUnitCost = new CheckEntry(txt_unitCost.Text, lbl_unitCost.Text);
                if (!objCheckUnitCost.isNull())
                {
                    if (!objCheckUnitCost.isValidNumber())
                    {
                        txt_unitCost.Clear();
                    }
                }

                CheckEntry objCheckDefects = new CheckEntry(txt_Defected.Text, lbl_defected.Text);
                if (!objCheckDefects.isNull())
                {
                    if (!objCheckDefects.isValidNumber())
                    {
                        txt_Defected.Clear();
                    }
                }

                CheckEntry objCheckTotalCost = new CheckEntry(txt_TotalCost.Text, lbl_totalCost.Text);
                if (!objCheckTotalCost.isNull())
                {
                    if (!objCheckTotalCost.isValidNumber())
                    {
                        txt_TotalCost.Clear();
                    }
                }

                string materialType = txt_materialType.Text;
                double quantity = double.Parse(txt_Quantity.Text);
                double unitCost = double.Parse(txt_unitCost.Text);
                double defects = double.Parse(txt_Defected.Text);
                double totalCost = double.Parse(txt_TotalCost.Text);
                DateTime dateAquired = DateTime.Parse(txt_DateAcq.Text);
                DateTime dateUsed = DateTime.Parse(txt_dateUsed.Text);

                objStock = new Stock(materialType, quantity, unitCost, defects, dateAquired, dateUsed);

                stocks.Add(objStock);

            



            //CODE BELOW NEEDS TO BE REPLACED WITH DB HANDLER CODE
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
                    com.Parameters.Add("@materialType", SqlDbType.VarChar).Value = materialType;
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
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCustomizeMaterials_Click(object sender, EventArgs e)
        {
            RawMaterialsForm formMaterial = new RawMaterialsForm();
            formMaterial.ShowDialog();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CheckEntry objCheckQuantity = new CheckEntry(txt_Quantity.Text, lbl_quantity.Text);
            CheckEntry objCheckUCost = new CheckEntry(txt_unitCost.Text, lbl_unitCost.Text);

            if (!objCheckQuantity.isNull() && !objCheckUCost.isNull())
            {
                double uCost = double.Parse(txt_unitCost.Text);
                double quan = double.Parse(txt_Quantity.Text);
                double tCost = uCost * quan;

                txt_TotalCost.Text = tCost.ToString();
            }
            else
            {
                MessageBox.Show("Enter a value in the Quantity and Unit Cost fields.");
            }
        }
    }
}
