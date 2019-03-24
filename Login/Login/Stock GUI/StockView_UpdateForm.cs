﻿using System;
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
            //load Stocks Table from database into a list
            stocks = new DataTable();
            stocks = objDatabaseManager.LoadStocks();

            //use stock datatable as datasource for data grid
            dataGridView1.DataSource = stocks;
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
    }
}
