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
            // TODO: This line of code loads data into the 'workFlowDatabaseDataSet.StockTable' table. You can move, or remove it, as needed.
            this.stockTableTableAdapter.Fill(this.workFlowDatabaseDataSet.StockTable);
            loadStocks();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
