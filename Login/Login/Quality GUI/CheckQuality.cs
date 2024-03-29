﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WorkFlowManagement
{
    public partial class CheckQuality : Form
    {
        private List<Product> products;
        private List<Product> updatedProducts;
        private List<string> statusList;
        private DatabaseManager objDatabaseManager;
        private Product objProduct;

        private void LoadProducts()
        {
            products = objDatabaseManager.LoadInProgressProducts();

            lstProducts.Items.AddRange(products.ToArray());
        }

        public CheckQuality()
        {
            InitializeComponent();

            products = new List<Product>();
            updatedProducts = new List<Product>();
            statusList = new List<string>();
            objDatabaseManager = new DatabaseManager();
            objProduct = new Product();

            statusList = objDatabaseManager.LoadProductStatus();

            foreach (var status in statusList)
            {
                cboxStatus.Items.Add(status);
            }

            LoadProducts();
        }

        private void CheckQuality_Load(object sender, EventArgs e)
        {

        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            objProduct = (Product)lstProducts.SelectedItem;

            lblProdID.Text = objProduct.productID.ToString();
            lblProdName.Text = objProduct.productName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (var prod in updatedProducts)
            {
                objDatabaseManager.UpdateProduct(prod.productID, prod.productName, prod.JsonMaterialString, prod.productQuantity, prod.productStatus);
            }

            lstProducts.Items.Clear();
            LoadProducts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            objProduct.productStatus = cboxStatus.Text;

            objDatabaseManager.UpdateProduct(objProduct.productID, objProduct.productName, objProduct.JsonMaterialString, objProduct.productQuantity, objProduct.productStatus);

            lstProducts.Items.Clear();

            LoadProducts();
        }
    }
}
