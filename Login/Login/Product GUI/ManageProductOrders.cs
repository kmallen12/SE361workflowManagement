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
    public partial class ManageProductOrders : Form
    {
        Product P;
        ProductOrderRequest Order;
        AddProduct addProduct;
        Form Home;
        public ManageProductOrders(Form H)
        {
            P = new Product();
            InitializeComponent();
            Home = H;
            OrderList_listbox.DataSource = P.LoadProductOrders();
        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            Home.MdiChildren.Last<Form>().Close();
            
            addProduct = new AddProduct(this);
            addProduct.MdiParent = Home;
            addProduct.SetTXTBoxs(Order.ProductID.ToString(), Order.Quantity.ToString());
            addProduct.Show();
            
        }

        private void OrderList_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (OrderList_listbox.SelectedIndex>=0)
                {
                    Order = (ProductOrderRequest)OrderList_listbox.SelectedItem;
                }
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }

        
        public void ConfirmFilled()
        {
            P.UpdateProductOrderStatus(Order.OrderID);
            OrderList_listbox.DataSource = P.LoadProductOrders();
        }
    }
}
