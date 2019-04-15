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
    public partial class ViewStockOrders : Form
    {
        Stock S;
        public ViewStockOrders()
        {
            S = new Stock();
            InitializeComponent();

            OrderList_listbox.DataSource = S.LoadStockOrders();
        }
    }
}
