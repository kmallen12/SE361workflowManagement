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
    public partial class UpdateStock : Form
    {
        public UpdateStock()
        {
            InitializeComponent();
        }
        DatabaseManager q = new DatabaseManager();
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

                
                q.InsertStock(materialTypeGrid_box.Text, quantityGrid_box.Text, unitCostGrid_box.Text, totalCostGrid_box.Text, dateAcquiredGrid_box.Text, dateUsedGrid_box.Text, amtDefectedGrid_box.Text);
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

                q.UpdateStock(key ,materialTypeGrid_box.Text, quantityGrid_box.Text, unitCostGrid_box.Text, totalCostGrid_box.Text, dateAcquiredGrid_box.Text, dateUsedGrid_box.Text, amtDefectedGrid_box.Text);

                this.stockTableTableAdapter.Fill(this.workFlowDatabaseDataSet.StockTable);
                this.dataGridView1.Refresh();
                this.dataGridView1.RefreshEdit();
            }
        }

      
    }
}
