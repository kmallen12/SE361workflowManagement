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
        
        private List<Stock> stocks;

        
        Stock S;
        //dropdown list property
        private List<RawMaterials> materialList;

        public AddMaterialForm()
        {
            InitializeComponent();
            S = new Stock();
            stocks = new List<Stock>();

            materialList = new List<RawMaterials>();

            materialList = S.LoadRawMat();
            //materialList = objDatabaseManager.LoadRawMat();

            foreach(var mat in materialList)
            {
                
                txt_materialType.Items.Add(mat.material);
            }
        }

        private void lbl_unitCost_Click(object sender, EventArgs e)
        {

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

                S.InsertStock(txt_materialType.Text, txt_Quantity.Text, txt_unitCost.Text, txt_TotalCost.Text, txt_DateAcq.Text, txt_dateUsed.Text, txt_Defected.Text);
                //StockForm formStock = new StockForm();

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
                MessageBox.Show("Error: "+ err);
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

                S.InsertStock(txt_materialType.Text, txt_Quantity.Text, txt_unitCost.Text, txt_TotalCost.Text, txt_DateAcq.Text, txt_dateUsed.Text, txt_Defected.Text);

                Hide();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err);
            }
        }

        private void btnCustomizeMaterials_Click(object sender, EventArgs e)
        {
            RawMaterialsForm formMaterial = new RawMaterialsForm();
            formMaterial.FormClosing += (sender2, e2) =>
            {
                txt_materialType.Items.Clear();
                materialList = S.LoadRawMat();
                //materialList = objDatabaseManager.LoadRawMat();
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
    }
}
