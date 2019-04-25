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
    public partial class InProgressProducts : Form
    {
        private DatabaseManager objDatabaseManager;
        public InProgressProducts()
        {
            InitializeComponent();
            objDatabaseManager = new DatabaseManager();

            
            dataGridProductStatus.DataSource = objDatabaseManager.LoadDataInProgressProducts();
        }

        private void InProgressProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workFlowDatabaseDataSet.ProductTable' table. You can move, or remove it, as needed.
            this.productTableTableAdapter1.Fill(this.workFlowDatabaseDataSet.ProductTable);

        }
    }
}
