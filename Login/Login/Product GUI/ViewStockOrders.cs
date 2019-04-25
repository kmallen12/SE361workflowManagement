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
