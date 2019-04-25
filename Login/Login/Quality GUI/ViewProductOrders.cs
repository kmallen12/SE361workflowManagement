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
    public partial class ViewProductOrders : Form
    {
        Product P;

        public ViewProductOrders()
        {
            P = new Product();
            InitializeComponent();

            OrderList_listbox.DataSource = P.LoadProductOrders();
        }

    }
}