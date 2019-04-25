using System.Data;
using System.Windows.Forms;

namespace WorkFlowManagement
{
    public partial class ProductStatusReportForm : Form
    {
        private DatabaseManager objDatabaseManager;
        public ProductStatusReportForm()
        {
            InitializeComponent();
            objDatabaseManager = new DatabaseManager();

            DataTable dataProductStatus = objDatabaseManager.ProductStatusTable();
            dataGridProductStatus.DataSource = dataProductStatus;
        }

     
    }
}
