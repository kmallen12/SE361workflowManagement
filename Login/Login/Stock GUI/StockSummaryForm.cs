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
    public partial class StockSummaryForm : Form
    {
        DataTable stocks;
        DatabaseManager objDatabaseManager;

        public StockSummaryForm()
        {
            InitializeComponent();

            stocks = new DataTable();
            objDatabaseManager = new DatabaseManager();
        }

        private void StockSummaryForm_Load(object sender, EventArgs e)
        {
            stocks = objDatabaseManager.SumStocks();

            dataGridViewStockSum.DataSource = stocks;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnOpenDetails_Click(object sender, EventArgs e)
        {
            StockView form = new StockView();
            form.ShowDialog();
        }
    }
}