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
            if (!isValidQuantity(txt_Quantity.Text))
            {
                System.Windows.Forms.MessageBox.Show("Quantity must be an integer (e.g. 30, 1000, etc.)");
                txt_Quantity.Clear();
                return false;
            }

            return true;
        }

        private void Confirm_Material_btn_Click(object sender, EventArgs e)
        {
            if (CheckValidStock())
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "tcp:workflowdatabase.database.windows.net,1433";
                builder.UserID = "OCOTOD";
                builder.Password = "FairBanks152";
                builder.InitialCatalog = "WorkFlowDatabase";
                SqlConnection con = new SqlConnection(builder.ConnectionString);

                string str;
                str = "INSERT INTO [dbo].[StockTable] (  [materialType], [quantity], [unitCost], [totalCost], [dateAcquired], [dateUsed], [amtDefected]) VALUES ('" + txt_materialType.Text + "','" + txt_Quantity.Text + "','" + txt_unitCost.Text + "','" + txt_TotalCost.Text + "','" + txt_DateAcq.Text + "','" + txt_dateUsed.Text + "','" + 0 + "')";
                con.Open();

                SqlCommand com = new SqlCommand(str, con);
                com.ExecuteNonQuery();


                StockForm formStock = new StockForm();

                Hide();
                formStock.ShowDialog();
            }
        }

        private void Another_Material_btn_Click(object sender, EventArgs e)
        {
            if(CheckValidStock())
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "tcp:workflowdatabase.database.windows.net,1433";
                builder.UserID = "OCOTOD";
                builder.Password = "FairBanks152";
                builder.InitialCatalog = "WorkFlowDatabase";
                SqlConnection con = new SqlConnection(builder.ConnectionString);

                string str;
                str = "INSERT INTO [dbo].[StockTable] (  [materialType], [quantity], [unitCost], [totalCost], [dateAcquired], [dateUsed], [amtDefected]) VALUES ('" + txt_materialType.Text + "','" + txt_Quantity.Text + "','" + txt_unitCost.Text + "','" + txt_TotalCost.Text + "','" + txt_DateAcq.Text + "','" + txt_dateUsed.Text + "','" + 0 + "')";
                con.Open();

                SqlCommand com = new SqlCommand(str, con);
                com.ExecuteNonQuery();


                StockForm formStock = new StockForm();

                txt_materialType.Clear();
                txt_Quantity.Clear();
                txt_Defected.Clear();
                txt_unitCost.Clear();
                txt_TotalCost.Clear();
                txt_DateAcq.Clear();
                txt_dateUsed.Clear();
            }
            
            

        }
    }
}
