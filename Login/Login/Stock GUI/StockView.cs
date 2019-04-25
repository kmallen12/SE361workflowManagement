using System;
using System.Data;
using System.Windows.Forms;


namespace WorkFlowManagement
{
    public partial class StockView : Form
    {
        private DataTable stocks;
        private DatabaseManager objDatabaseManager = new DatabaseManager();

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

        private void StockView_Load(object sender, EventArgs e)
        {
            loadStocks();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
