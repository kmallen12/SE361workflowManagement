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
    public partial class ManageStockOrders : Form
    {
        Stock S;
        StockOrderRequest Order;
        AddMaterialForm AddMaterial;
        public ManageStockOrders()
        {
            S = new Stock();
            InitializeComponent();

            OrderList_listbox.DataSource = S.LoadStockOrders();
        }

       

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            AddMaterial = new AddMaterialForm();

            AddMaterial.SETFORM(Order.StockID,Order.Quantity);
            AddMaterial.ShowDialog();
        }

        private void OrderList_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (OrderList_listbox.SelectedIndex>=0)
                {
                    Order = (StockOrderRequest)OrderList_listbox.SelectedItem;
                }
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }
    }
}
