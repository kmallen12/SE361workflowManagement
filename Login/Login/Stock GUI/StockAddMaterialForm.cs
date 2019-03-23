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
        private string material;
        private double quantity;
        private double unitCost;
        private double defects;
        private double totalCost;
        private DateTime dateAcq;
        private DateTime dateUsed;
        string warningNull = "";
        string warningNumberFormat = "";
        string warningDateFormat = "";

        private List<Stock> stocks;
        private DatabaseManager objDatabaseManager = new DatabaseManager();
        //dropdown list property
        private List<RawMaterials> materialList;

        public AddMaterialForm()
        {
            InitializeComponent();

            stocks = new List<Stock>();

            materialList = new List<RawMaterials>();            
           
            materialList = objDatabaseManager.LoadRawMat();

            foreach(var mat in materialList)
            {
                txt_materialType.Items.Add(mat.material);
            }
        }

        private Boolean checkValidStockEntry()
        {
            bool validStock = true;

            CheckEntry objCheckEntry = new CheckEntry();

            //Check to see if material is null. If null, prompt user to enter a value.
            //Else add text input to material variable.
            if(objCheckEntry.isNull(txt_materialType.Text, lblMaterialType.Text))
            {
                warningNull += "\n" + lblMaterialType.Text;
                validStock = false;
            }
            else
            {
                material = txt_materialType.Text;
            }

            //Check to see if quantity is null. If null, prompt user to enter a value.
            //Else add text input to quantity variable.
            if (objCheckEntry.isNull(txt_Quantity.Text, lbl_quantity.Text))
            {
                warningNull += "\n" + lbl_quantity.Text;
                validStock = false;
            }
            else if(!objCheckEntry.isValidNumber(txt_Quantity.Text, lbl_quantity.Text))
            {
                warningNumberFormat += "\n" + lbl_quantity.Text;
                txt_Quantity.Clear();
                validStock = false;
            }
            else
            {
                quantity = double.Parse(txt_Quantity.Text);
            }

            //If unit cost contains a value that is not formatted correctly, prompt user to enter a different value.
            //Else add text input to unit cost variable.
            if (!objCheckEntry.isNull(txt_unitCost.Text, lbl_unitCost.Text) 
                && !objCheckEntry.isValidNumber(txt_unitCost.Text, lbl_unitCost.Text))
            {
                warningNumberFormat += "\n" + lbl_unitCost.Text;
                txt_unitCost.Clear();
                validStock = false;
            }
            else if(!objCheckEntry.isNull(txt_unitCost.Text, lbl_unitCost.Text))
            {
                unitCost = double.Parse(txt_unitCost.Text);
            }

            //If defects contains a value that is not formatted correctly, prompt user to enter a different value.
            //Else add text input to defects variable.
            if (!objCheckEntry.isNull(txt_Defected.Text, lbl_defected.Text)
                && !objCheckEntry.isValidNumber(txt_Defected.Text, lbl_defected.Text))
            {
                warningNumberFormat += "\n" + lbl_defected.Text;
                txt_Defected.Clear();
                validStock = false;
            }
            else if (!objCheckEntry.isNull(txt_Defected.Text, lbl_defected.Text))
            {
                defects = double.Parse(txt_Defected.Text);
            }

            //If total cost contains a value that is not formatted correctly, prompt user to enter a different value.
            //Else add text input to total cost variable.
            if (!objCheckEntry.isNull(txt_TotalCost.Text, lbl_totalCost.Text)
                && !objCheckEntry.isValidNumber(txt_TotalCost.Text, lbl_totalCost.Text))
            {
                warningNumberFormat += "\n" + lbl_totalCost.Text;
                txt_TotalCost.Clear();
                validStock = false;
            }
            else if (!objCheckEntry.isNull(txt_TotalCost.Text, lbl_totalCost.Text))
            {
                totalCost = double.Parse(txt_TotalCost.Text);
            }

            //If date acquired contains a value that is not formatted correctly, prompt user to enter a different value.
            //Else add text input to dateAcq variable.
            //If no date is entered, set dateAcq to MinValue
            if (!objCheckEntry.isNull(txt_DateAcq.Text, lbl_dateAcq.Text))
            {
                if (!objCheckEntry.isValidDate(txt_DateAcq.Text))
                {
                    warningDateFormat += "\n" + lbl_dateAcq.Text;
                    txt_DateAcq.Clear();
                    validStock = false;
                }
                else
                {
                    dateAcq = DateTime.Parse(txt_DateAcq.Text);
                }
            }
            else
            {
                dateAcq = DateTime.MinValue;
            }

            //If date acquired contains a value that is not formatted correctly, prompt user to enter a different value.
            //Else add text input to dateAcq variable.
            //If no date is entered, set dateAcq to MinValue
            if (!objCheckEntry.isNull(txt_dateUsed.Text, lbl_dateUsed.Text))
            {
                if (!objCheckEntry.isValidDate(txt_dateUsed.Text))
                {
                    warningDateFormat += "\n" + lbl_dateUsed.Text;
                    txt_DateAcq.Clear();
                    validStock = false;
                }
                else
                {
                    dateUsed = DateTime.Parse(txt_dateUsed.Text);
                }
            }
            else
            {
                dateUsed = DateTime.MinValue;
            }


            //Give feedback to user
            if (warningNull != "")
            {
                if(warningNumberFormat != "" && warningDateFormat != "")
                {
                    MessageBox.Show("Add a value for: " + warningNull + "\n \nEnter an integer value in: " + warningNumberFormat
                        + "\n \nEnter a valid date in: " + warningDateFormat);
                }
                else if (warningNumberFormat != "" && warningDateFormat == "")
                {
                    MessageBox.Show("Add a value for: " + warningNull + "\n \nEnter an integer value in: " + warningNumberFormat);
                }
                else if (warningNumberFormat == "" && warningDateFormat != "")
                {
                    MessageBox.Show("Add a value for: " + warningNull + "\n \nEnter a valid date in: " + warningDateFormat);
                }
                else
                {
                    MessageBox.Show("Add a value for: " + warningNull);
                }
            }
            else if (warningNumberFormat != "")
            {
                if(warningDateFormat == "")
                {
                    MessageBox.Show("Enter an integer value in: " + warningNumberFormat);
                }
                else
                {
                    MessageBox.Show("Enter an integer value in: " + warningNumberFormat + "\n \nEnter a valid date in: " + warningDateFormat);
                }
            }
            else if (warningDateFormat != "")
            {
                MessageBox.Show("Enter a valid date in: " + warningDateFormat);
            }

            warningNull = "";
            warningNumberFormat = "";
            warningDateFormat = "";

            return validStock;
        }
        private void Another_Material_btn_Click(object sender, EventArgs e)
        {
            if (checkValidStockEntry())
            {
                try
                {
                    objStock = new Stock(material, quantity, unitCost, defects, dateAcq, dateUsed);
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
    }
}
