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

     
    }
}
