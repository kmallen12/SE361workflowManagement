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
        private Product objProduct;
        private List<Product> qualifiedProducts;
        private List<Product> defectiveProducts;
        private List<Product> toSalesProducts;
        private List<Product> toManufacturingProducts;
        private DatabaseManager objDatabaseManager;

        private void LoadQualifiedProducts()
        {
            qualifiedProducts = objDatabaseManager.LoadQualifiedProducts();

            foreach (var prod in qualifiedProducts)
            {
                cboxProdIDQualified.Items.Add(prod.productID);
            }
        }

        private void LoadDefectiveProducts()
        {
            defectiveProducts = objDatabaseManager.LoadDefectiveProducts();

            foreach (var prod in defectiveProducts)
            {
                cboxProdIDDefects.Items.Add(prod.productID);
            }
        }

        public RouteProducts()
        {
            InitializeComponent();

            qualifiedProducts = new List<Product>();
            defectiveProducts = new List<Product>();
            toSalesProducts = new List<Product>();
            toManufacturingProducts = new List<Product>();
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
                    if(prod.productID == int.Parse(cboxProdIDQualified.Text))
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
                    if (prod.productID == int.Parse(cboxProdIDDefects.Text))
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
                prod.productStatus = "Sent to Sales";
                objDatabaseManager.UpdateProduct(prod.productID, prod.productName, prod.productMaterials, prod.productQuantity, prod.productStatus);
                MessageBox.Show(prod.ToString());
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
                prod.productStatus = "Returned to Manufacturing";
                objDatabaseManager.UpdateProduct(prod.productID, prod.productName, prod.productMaterials, prod.productQuantity, prod.productStatus);
                MessageBox.Show(prod.ToString());
            }

            lstDefectedProd.Items.Clear();
            cboxProdIDDefects.Items.Clear();
            LoadDefectiveProducts();
            toManufacturingProducts.Clear();

            this.productTableTableAdapter1.Fill(this.workFlowDatabaseDataSet1.ProductTable);
        }
    }
}
