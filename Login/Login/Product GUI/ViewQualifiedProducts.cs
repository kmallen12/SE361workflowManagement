﻿using System;
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
    public partial class ViewQualifiedProducts : Form
    {
        private List<Product> qualProducts;
        private DatabaseManager objDatabaseManager;
        public ViewQualifiedProducts()
        {
            InitializeComponent();
            qualProducts = new List<Product>();
            objDatabaseManager = new DatabaseManager();

            qualProducts = objDatabaseManager.LoadQualifiedProducts();

            foreach (var prod in qualProducts)
            {
                lstQualProd.Items.Add(prod.ToString());
            }
        }

        private void btnRepRemanufacture_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selected Item has been sent to Delivery Manager");
        }
    }
}
