using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkFlowManagement
{
    public partial class RouteProducts : Form
    {
        private List<ProductStruct> qualifiedProducts;
        private List<ProductStruct> defectiveProducts;
        private List<ProductStruct> toSalesProducts;
        private List<ProductStruct> toManufacturingProducts;
        private DatabaseManager objDatabaseManager;

        private void LoadQualifiedProducts()
        {
            qualifiedProducts = objDatabaseManager.LoadQualifiedProducts();

            foreach (var prod in qualifiedProducts)
            {
                cboxProdIDQualified.Items.Add(prod.ProductID);
            }
        }

        private void LoadDefectiveProducts()
        {
            defectiveProducts = objDatabaseManager.LoadDefectiveProducts();

            foreach (var prod in defectiveProducts)
            {
                cboxProdIDDefects.Items.Add(prod.ProductID);
            }
        }

        public RouteProducts()
        {
            InitializeComponent();

            qualifiedProducts = new List<ProductStruct>();
            defectiveProducts = new List<ProductStruct>();
            toSalesProducts = new List<ProductStruct>();
            toManufacturingProducts = new List<ProductStruct>();
            objDatabaseManager = new DatabaseManager();
        }

        private void RouteProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workFlowDatabaseDataSet1.ProductTable' table. You can move, or remove it, as needed.
            this.productTableTableAdapter1.Fill(this.workFlowDatabaseDataSet1.ProductTable);

            LoadQualifiedProducts();

            LoadDefectiveProducts();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddToQualifiedList_Click(object sender, EventArgs e)
        {
            if (!lstQualifiedProd.Items.Contains(cboxProdIDQualified.Text))
            {
                lstQualifiedProd.Items.Add(cboxProdIDQualified.Text);

                foreach (var prod in qualifiedProducts)
                {
                    if(prod.ProductID == int.Parse(cboxProdIDQualified.Text))
                    {
                        toSalesProducts.Add(prod);
                    }
                }
            }
            else
            {
                MessageBox.Show("This product is already in the list.");
            }
        }

        private void btnAddToDefectsList_Click(object sender, EventArgs e)
        {
            if (!lstDefectedProd.Items.Contains(cboxProdIDDefects.Text))
            {
                lstDefectedProd.Items.Add(cboxProdIDDefects.Text);

                foreach (var prod in defectiveProducts)
                {
                    if (prod.ProductID == int.Parse(cboxProdIDDefects.Text))
                    {
                        toManufacturingProducts.Add(prod);
                    }
                }
            }
            else
            {
                MessageBox.Show("This product is already in the list.");
            }
        }

        private void btnRemoveQualified_Click(object sender, EventArgs e)
        {
            lstQualifiedProd.Items.Remove(lstQualifiedProd.SelectedItem);
        }

        private void btnRemoveDefects_Click(object sender, EventArgs e)
        {
            lstDefectedProd.Items.Remove(lstDefectedProd.SelectedItem);
        }

        private void btnSendToSales_Click(object sender, EventArgs e)
        {
            foreach (var prod in toSalesProducts)
            {
                
                objDatabaseManager.UpdateProductStatus(prod.ProductID, "Sent to Sales");
                
            }

            lstQualifiedProd.Items.Clear();
            cboxProdIDDefects.Items.Clear();
            LoadQualifiedProducts();
            toSalesProducts.Clear();

            this.productTableTableAdapter1.Fill(this.workFlowDatabaseDataSet1.ProductTable);
        }

        private void btnSendToManu_Click(object sender, EventArgs e)
        {
            foreach (var prod in toManufacturingProducts)
            {
               
                objDatabaseManager.UpdateProductStatus(prod.ProductID, "Returned to Manufacturing");
            }

            lstDefectedProd.Items.Clear();
            cboxProdIDDefects.Items.Clear();
            LoadDefectiveProducts();
            toManufacturingProducts.Clear();

            this.productTableTableAdapter1.Fill(this.workFlowDatabaseDataSet1.ProductTable);
        }
    }
}
