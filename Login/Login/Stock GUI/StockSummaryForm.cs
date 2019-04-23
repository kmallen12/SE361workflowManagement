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
    public partial class StockSummaryForm : Form
    {
        private DataTable stocks;
        private DatabaseManager objDatabaseManager;
        HomePage Home;
        public StockSummaryForm(HomePage H)
        {
            InitializeComponent();
            Home = H;
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
            Home.MdiChildren.Last<Form>().Close();

            StockView form = new StockView();
            form.MdiParent = Home;
            form.Show();
        }
    }
}
