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
        DatabaseManager q = new DatabaseManager();
        //dropdown list property
        private List<RawMaterials> materialList;
        private RawMaterials objWood;  //DELETE THIS ONCE CONNECTED TO DATABASE

        public AddMaterialForm()
        {
            InitializeComponent();

            stocks = new List<Stock>();

            materialList = new List<RawMaterials>();

            //DELETE THESE TWO LINES ONCE CONNECTED TO DATABASE
            
           
            materialList = q.LoadRawMat();
            //materialList = objDatabaseManager.LoadRawMat();
            foreach(var mat in materialList)
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
                q.InsertStock(txt_materialType.Text, txt_Quantity.Text, txt_unitCost.Text, txt_TotalCost.Text, txt_DateAcq.Text, txt_dateUsed.Text, txt_Defected.Text);
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

                q.InsertStock(txt_materialType.Text, txt_Quantity.Text, txt_unitCost.Text, txt_TotalCost.Text, txt_DateAcq.Text, txt_dateUsed.Text, txt_Defected.Text);



                //CODE BELOW NEEDS TO BE REPLACED WITH DB HANDLER CODE

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
