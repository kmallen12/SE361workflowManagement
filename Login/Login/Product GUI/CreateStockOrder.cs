using System;
using System.Data;
using System.Windows.Forms;

namespace WorkFlowManagement
{
    public partial class CreateStockOrder : Form
    {
        Stock S;
        DatabaseManager objDatabaseManager;
        DataTable stockTable; 

        public CreateStockOrder()
        {
            InitializeComponent();
            S = new Stock();
            S.newOrders();
            objDatabaseManager = new DatabaseManager();
            stockTable = objDatabaseManager.SumStocks();
        }
        

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            S.InsertStockOrder();
            MessageBox.Show("Order(s) sent to the stock manager.", "Success");
        }

        private void CreateProductOrder_Load_1(object sender, EventArgs e)
        {
            //This line of code loads data into the 'workFlowDatabaseDataSet.StockSummaryView' table.
            this.stockSummaryViewTableAdapter.Fill(this.workFlowDatabaseDataSet.StockSummaryView);

            //load materials from the data table in the Material drop down
            cboxMaterial.Items.Clear();
            for (int i = 0; i < stockTable.Rows.Count; i++)
            {
                cboxMaterial.Items.Add(stockTable.Rows[i]["Material"]);
            }
        }

        private void btn_AddOrderToList_Click(object sender, EventArgs e)
        {
            int result;
            if (Int32.TryParse(Amount_Text.Text, out result))
                S.newOrder(Int32.Parse(Amount_Text.Text), Discription_text.Text,"Pending", cboxMaterial.Text.Trim(' '));
            listBox_StockOrders.Items.Add(S.StockOrder.ToString());
        }
    }
}
