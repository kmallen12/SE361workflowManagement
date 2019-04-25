using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace WorkFlowManagement
{
    public partial class AddMaterialForm : Form
    {
        private Stock objStock;
        CheckEntry objCheckEntry;
        HomePage home;

        private List<Stock> stocks;
        private DatabaseManager objDatabaseManager = new DatabaseManager();
        //dropdown list property
        private List<RawMaterials> materialList;
        private string material { get; set; }
        public AddMaterialForm(HomePage h)
        {
            home = h;
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

                    objDatabaseManager.InsertToStockTable(stocks);

                    txt_materialType.SelectedIndex = -1;
                    ResetDTP();
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
                this.Hide();
                stocks.Clear();
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
            formMaterial.MdiParent = home;

            formMaterial.FormClosing += (sender2, e2) =>
            {
                txt_materialType.Items.Clear();
                materialList = objDatabaseManager.LoadRawMat();

                foreach (var mat in materialList)
                {
                    txt_materialType.Items.Add(mat.material);
                }
                this.Show();
            };

            formMaterial.Leave += (sender3, args3) =>
            {
                home.MdiChildren.Last<Form>().Close();
            };
            this.Hide();
            formMaterial.Show();
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
            txt_dateUsed.CustomFormat = "MM/dd/yyyy";
        }

        private void AddMaterialForm_Load(object sender, EventArgs e)
        {
            ResetDTP();
        }

        private void ResetDTP()
        {
            txt_DateAcq.Format = DateTimePickerFormat.Custom;
            txt_DateAcq.CustomFormat = " ";

            txt_dateUsed.Format = DateTimePickerFormat.Custom;
            txt_dateUsed.CustomFormat = " ";
        }

        private void txt_DateAcq_ValueChanged(object sender, EventArgs e)
        {
            txt_DateAcq.CustomFormat = "MM/dd/yyyy";
        }
    }
}
