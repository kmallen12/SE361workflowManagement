using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkflowManagement
{
    public partial class UpdateStock : Form
    {
        public UpdateStock()
        {
            InitializeComponent();
        }

        private void UpdateStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workFlowDatabaseDataSet.StockTable' table. You can move, or remove it, as needed.
            this.stockTableTableAdapter.Fill(this.workFlowDatabaseDataSet.StockTable);

        }
        private void stockdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // THIS IS WHERE WE SHOULD ADD FUNCTIONALITY TO BE ABLE TO EDIT
            // THE ROWS AND TABLES OF THE DATABASE ROWS THAT ARE DISPLAYED
            // https://stackoverflow.com/questions/14065443/updating-database-using-datagridview


        }
    }
}
