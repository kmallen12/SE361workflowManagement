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
