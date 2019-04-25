using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WorkFlowManagement
{
    public partial class UpdateStockForm : Form
    {
        private DataTable stocks;
        DatabaseManager objDatabaseManager = new DatabaseManager();
        CheckEntry objCheckEntry = new CheckEntry();
        Stock objStock = new Stock();
        private List<RawMaterials> materialList;

        public UpdateStockForm() => InitializeComponent();

        private void loadStocks()
        {
            ItemIDGrid_box.Items.Clear();

            //load Stocks Table from database into a list
            stocks = new DataTable();
            stocks = objDatabaseManager.LoadStocks();

            //use stock datatable as datasource for data grid
            dataGridView1.DataSource = stocks;

            for(int i=0; i<stocks.Rows.Count; i++)
            {
                ItemIDGrid_box.Items.Add(stocks.Rows[i]["itemID"]);
            }
        }

        private void UpdateStockForm_Load(object sender, EventArgs e)
        {
            loadStocks();

            materialList = new List<RawMaterials>();

            materialList = objDatabaseManager.LoadRawMat();

            foreach (var mat in materialList)
            {
                txtMaterialType.Items.Add(mat.material);
            }
            ResetDTP();

        }

        private void btnLoadStockFromDB_Click(object sender, EventArgs e)
        {
            loadStocks();
        }

        private void ConfirmGrid_btn_Click(object sender, EventArgs e)
        {
            //Add a new stock if the Item ID is empty
            if (string.IsNullOrEmpty(ItemIDGrid_box.Text.ToString()))
            {
                try
                {
                    objCheckEntry.checkValidStockEntry(txtMaterialType.Text, lblMaterialType.Text, quantityGrid_box.Text, lblQuantity.Text, unitCostGrid_box.Text, lblUnitCost.Text,
                        totalCostGrid_box.Text, lblTotalCost.Text, amtDefectedGrid_box.Text, lblDefects.Text, dateAcquiredGrid_box.Text, lblDateAcq.Text, dateUsedGrid_box.Text,
                        lblDateUsed.Text, objStock);

                    objDatabaseManager.InsertStock(txtMaterialType.Text, quantityGrid_box.Text, unitCostGrid_box.Text, totalCostGrid_box.Text, dateAcquiredGrid_box.Text, dateUsedGrid_box.Text, amtDefectedGrid_box.Text);

                    loadStocks();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error adding stock to Stock table.");
                }
            }

            //Update existing stock based on the ID entered in the Item ID field
            if (!string.IsNullOrEmpty(ItemIDGrid_box.Text.ToString()))
            {
                try
                {
                    objCheckEntry.checkValidStockEntry(txtMaterialType.Text, lblMaterialType.Text, quantityGrid_box.Text, lblQuantity.Text, unitCostGrid_box.Text, lblUnitCost.Text,
                        totalCostGrid_box.Text, lblTotalCost.Text, amtDefectedGrid_box.Text, lblDefects.Text, dateAcquiredGrid_box.Text, lblDateAcq.Text, dateUsedGrid_box.Text,
                        lblDateUsed.Text, objStock);

                    int key = Int32.Parse(ItemIDGrid_box.Text);

                    objDatabaseManager.UpdateStock(key, txtMaterialType.Text, quantityGrid_box.Text, unitCostGrid_box.Text, totalCostGrid_box.Text, dateAcquiredGrid_box.Text, dateUsedGrid_box.Text, amtDefectedGrid_box.Text);
                    MessageBox.Show("Item number " + ItemIDGrid_box.Text + " (" + txtMaterialType.Text + ") was updated in the database.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error updating stock in the Stock database table.");
                }

                loadStocks();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void ResetDTP()
        {
            dateAcquiredGrid_box.Format = DateTimePickerFormat.Custom;
            dateAcquiredGrid_box.CustomFormat = " ";

            dateUsedGrid_box.Format = DateTimePickerFormat.Custom;
            dateUsedGrid_box.CustomFormat = " ";
        }



        private void ItemIDGrid_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataRow[] selectedRow;

                selectedRow = stocks.Select("itemID = " + ItemIDGrid_box.Text);

                if (selectedRow.Length > 0)
                {
                    if (DateTime.Parse(selectedRow[0]["dateAcquired"].ToString()) != DateTime.MinValue){
                        dateAcquiredGrid_box.CustomFormat = "MM/dd/yyyy";
                        dateAcquiredGrid_box.Text = selectedRow[0]["dateAcquired"].ToString();
                    }
                    else
                    {
                        dateAcquiredGrid_box.CustomFormat = " ";
                    }

                    if (DateTime.Parse(selectedRow[0]["dateUsed"].ToString()) != DateTime.MinValue)
                    {
                        dateUsedGrid_box.CustomFormat = "MM/dd/yyyy";
                        dateUsedGrid_box.Text = selectedRow[0]["dateUsed"].ToString();
                    }
                    else
                    {
                        dateUsedGrid_box.CustomFormat = " ";
                    }

                    txtMaterialType.Text = selectedRow[0]["materialType"].ToString();
                    quantityGrid_box.Text = selectedRow[0]["quantity"].ToString();
                    unitCostGrid_box.Text = selectedRow[0]["unitCost"].ToString();
                    totalCostGrid_box.Text = selectedRow[0]["totalCost"].ToString();
                    amtDefectedGrid_box.Text = selectedRow[0]["amtDefected"].ToString();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error selecting data from data table.");
            }
        }

        private void dateUsedGrid_box_ValueChanged(object sender, EventArgs e)
        {
            dateUsedGrid_box.CustomFormat = "MM/dd/yyyy";
        }

        private void dateAcquiredGrid_box_ValueChanged(object sender, EventArgs e)
        {
            dateAcquiredGrid_box.CustomFormat = "MM/dd/yyyy";

        }
    }
}
