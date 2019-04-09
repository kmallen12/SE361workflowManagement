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
    public partial class AddMaterialForm : Form
    {
        private Stock objStock;
        CheckEntry objCheckEntry;

        private List<Stock> stocks;
        private DatabaseManager objDatabaseManager = new DatabaseManager();
        //dropdown list property
        private List<RawMaterials> materialList;

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
        }

        public void SETFORM(int stockID, int Quantity)
        {
            txt_Quantity.Text = Quantity.ToString();
            txt_materialType.FindStringExact(objDatabaseManager.StockName(stockID).Trim(' '));

            txt_materialType.SelectedIndex = txt_materialType.FindStringExact(objDatabaseManager.StockName(stockID).Trim(' '));
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
                    txt_DateAcq.Clear();
                    txt_dateUsed.Clear();
                    txt_Defected.Clear();
                    txt_Quantity.Clear();
                    txt_TotalCost.Clear();
                    txt_unitCost.Clear();
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

            stocks.Clear();
            lstStocks.Clear();
        }

        private void txt_materialType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
