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
    public partial class CreateProductOrder : Form
    {
        
        Product P;
        public CreateProductOrder()
        {
            InitializeComponent();
            P = new Product();
            P.newOrders();
        }

        private void CreateProductOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workFlowDatabaseDataSetProducts.ProductTable' table. You can move, or remove it, as needed.
            this.productTableTableAdapter.Fill(this.workFlowDatabaseDataSetProducts.ProductTable);

        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            P.InsertProductOrder();
        }

        private void CreateProductOrder_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workFlowDatabaseDataSetProducts.ProductTable' table. You can move, or remove it, as needed.
            this.productTableTableAdapter.Fill(this.workFlowDatabaseDataSetProducts.ProductTable);

        }

        private void btn_AddOrderToList_Click(object sender, EventArgs e)
        {
            int result;
            if (Int32.TryParse(Amount_Text.Text, out result) && Int32.TryParse(ID_Text.Text, out result))
                P.newOrder(Int32.Parse(Amount_Text.Text), Discription_text.Text, Int32.Parse(ID_Text.Text));
            listBox_ProductOrders.Items.Add(P.ProductOrder.returnOrders());
        }
    }
}
