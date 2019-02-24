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

namespace WorkFlowManagement
{
    public partial class ItemCapacityForm : Form
    {
        public ItemCapacityForm()
        {
            InitializeComponent();
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

      
    

    private void btnUpdateWarningValues_Click(object sender, EventArgs e)
        {
            if (isValidQuantity(txtItemID.Text))
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "tcp:workflowdatabase.database.windows.net,1433";
                builder.UserID = "OCOTOD";
                builder.Password = "FairBanks152";
                builder.InitialCatalog = "WorkFlowDatabase";
                SqlConnection con = new SqlConnection(builder.ConnectionString);

                string str;
                str = "UPDATE [dbo].[WareHouseTable] SET Max=@Max , Low=@Low WHERE itemID = @itemID";
                con.Open();

                using(SqlCommand com = new SqlCommand(str, con))
                {
                    com.Parameters.Add("@itemID", SqlDbType.Int).Value = int.Parse(txtItemID.Text);

                    if (!string.IsNullOrEmpty(txtMax.Text) && isValidQuantity(txtMax.Text))
                    {
                        com.Parameters.Add("@Max", SqlDbType.Int).Value = int.Parse(txtMax.Text);
                    } else com.Parameters.Add("@Max", SqlDbType.Int).Value = 100;

                    if (!string.IsNullOrEmpty(txtLow.Text) && isValidQuantity(txtLow.Text))
                    {
                        com.Parameters.Add("@Low", SqlDbType.Int).Value = int.Parse(txtLow.Text);
                    }
                    else com.Parameters.Add("@Low", SqlDbType.Int).Value = 10;

                    com.ExecuteNonQuery();
                }
            }
        }
    }
}
