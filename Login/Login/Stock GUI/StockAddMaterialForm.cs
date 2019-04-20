﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WorkFlowManagement
{
    public partial class AddMaterialForm : Form
    {
        private Stock objStock;
        CheckEntry objCheckEntry;

        private List<Stock> stocks;
        private DatabaseManager objDatabaseManager = new DatabaseManager();
        //dropdown list property
        private List<RawMaterials> materialList;
        private string material { get; set; }
        public AddMaterialForm()
        {
            InitializeComponent();

            objStock = new Stock();
            stocks = new List<Stock>();
            materialList = new List<RawMaterials>();
            objCheckEntry = new CheckEntry();
           
            materialList = objDatabaseManager.LoadRawMat();

            foreach(var mat in materialList)
            {
                txt_materialType.Items.Add(mat.material);
            }

            txt_unitCost.DecimalPlaces = 2;
            txt_TotalCost.DecimalPlaces = 2;
            txt_dateUsed.CustomFormat = " ";
        }

        public void SETFORM(string Material, int Quantity)
        {
            txt_Quantity.Text = Quantity.ToString();
            txt_materialType.Text = Material.ToString();
        }

        private void Another_Material_btn_Click(object sender, EventArgs e)
        {
            if(objCheckEntry.checkValidStockEntry(txt_materialType.Text, lblMaterialType.Text, txt_Quantity.Text, lbl_quantity.Text, txt_unitCost.Text, lbl_unitCost.Text, 
                txt_TotalCost.Text, lbl_totalCost.Text, txt_Defected.Text, lbl_defected.Text, txt_DateAcq.Text, lbl_dateAcq.Text, txt_dateUsed.Text, lbl_dateUsed.Text, objStock))
            {
                try
                {
                    stocks.Add(objStock);

                    lstStocks.Items.Add(objStock.ToString());

                    txt_materialType.SelectedIndex = -1;
                    txt_DateAcq.Value= DateTime.Now;
                    txt_dateUsed.CustomFormat = "";
                    txt_Defected.Value = 0;
                    txt_Quantity.Value = 0;
                    txt_TotalCost.Value = 0;
                    txt_unitCost.Value = 0;
                    objStock = new Stock();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(stocks.Count > 0)
            {
                MessageBox.Show("Save list of Stocks to database before closing.");
            }
            else
            {
                this.Hide();
            }
        }

        private void btnCustomizeMaterials_Click(object sender, EventArgs e)
        {
            RawMaterialsForm formMaterial = new RawMaterialsForm();
            formMaterial.FormClosing += (sender2, e2) =>
            {
                txt_materialType.Items.Clear();
                materialList = objDatabaseManager.LoadRawMat();

                foreach (var mat in materialList)
                {
                    txt_materialType.Items.Add(mat.material);
                }
            };
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

        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            try
            {
                objDatabaseManager.InsertToStockTable(stocks);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err);
            }
            toolStripStatusLabel1.Text = "List of Materials Added to Database";
            stocks.Clear();
            lstStocks.Clear();
        }

        

        private void btn_IncreaseQuantity_Click(object sender, EventArgs e)
        {
            try
            {
                //objDatabaseManager.IncreaseStockQuantity(ID, Int32.Parse(txt_Quantity.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show(txt_materialType.SelectedItem.ToString() + " has had it's quantity increased by " + txt_Quantity.Text+".", "Success!");
        }

        private void txt_dateUsed_ValueChanged(object sender, EventArgs e)
        {
            txt_dateUsed.CustomFormat = "dd/mm/yyyy";
        }

        private void StsAddMaterial_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            toolStripStatusLabel1.Text = "Review items in the list then save to database";
        }
    }
}
