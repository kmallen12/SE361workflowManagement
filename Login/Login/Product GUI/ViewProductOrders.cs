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
    public partial class ViewProductOrders : Form
    {
        Product P;
        ProductOrderRequest Order;
       
        public ViewProductOrders()
        {
            P = new Product();
            InitializeComponent();

            OrderList_listbox.DataSource = P.LoadProductOrders();
        }

       

        private void Confirm_btn_Click(object sender, EventArgs e)
        {

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
    }
}
