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
    public partial class CreateStockOrder : Form
    {

        Stock S;
        DatabaseManager objDatabaseManager;
        public CreateStockOrder()
        {
            InitializeComponent();
            S = new Stock();
            S.newOrders();
            objDatabaseManager = new DatabaseManager();
        }

        

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            S.InsertStockOrder();
        }

        private void CreateProductOrder_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workFlowDatabaseDataSet.StockTable' table. You can move, or remove it, as needed.
            DataTable dataProductStatus = objDatabaseManager.StockOrderTable();
            dataGridView1.DataSource = dataProductStatus;

        }

        private void btn_AddOrderToList_Click(object sender, EventArgs e)
        {
            int result;
            if (Int32.TryParse(Amount_Text.Text, out result) && Int32.TryParse(ID_Text.Text, out result))
                S.newOrder(Int32.Parse(Amount_Text.Text), Discription_text.Text, Int32.Parse(ID_Text.Text));
            listBox_StockOrders.Items.Add(S.StockOrder.returnOrders());
        }
    }
}
