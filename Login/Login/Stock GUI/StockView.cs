﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WorkFlowManagement
{
    public partial class StockView : Form
    {
        private DataTable stocks;
        DatabaseManager objDatabaseManager = new DatabaseManager();
        CheckEntry objCheckEntry = new CheckEntry();
        Stock objStock = new Stock();
        private List<RawMaterials> materialList;

        public StockView() => InitializeComponent();

        private void loadStocks()
        {
            //load Stocks Table from database into a list
            stocks = new DataTable();
            stocks = objDatabaseManager.LoadStocks();

            //use stock datatable as datasource for data grid
            DGVStockView.DataSource = stocks;
        }
        private void btnLoadDB_Click(object sender, EventArgs e)
        {
            loadStocks();
        }
    
    }
}
