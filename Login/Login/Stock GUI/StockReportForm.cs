using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WorkFlowManagement
{
    public partial class StockReportForm : Form
    {
        DatabaseManager objDatabaseManager = new DatabaseManager();
        public StockReportForm()
        {
            InitializeComponent();
        }

        private void StockReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workFlowDatabaseDataSet3.StockReportMaxCapacity' table. You can move, or remove it, as needed.
            this.stockReportMaxCapacityTableAdapter.Fill(this.workFlowDatabaseDataSet3.StockReportMaxCapacity);
            // TODO: This line of code loads data into the 'workFlowDatabaseDataSet3.StockReportLowCapacity' table. You can move, or remove it, as needed.
            this.stockReportLowCapacityTableAdapter.Fill(this.workFlowDatabaseDataSet3.StockReportLowCapacity);
            // TODO: This line of code loads data into the 'workFlowDatabaseDataSet3.StockReportLowCapacity' table. You can move, or remove it, as needed.
            this.stockReportLowCapacityTableAdapter.Fill(this.workFlowDatabaseDataSet3.StockReportLowCapacity);
            updateMaxLowDataViewer();
        }

        private void updateMaxLowDataViewer()
        {
            DataTable dataMax = objDatabaseManager.StockReportMax();
            dataGridViewMax.DataSource = dataMax;

            DataTable dataLow = objDatabaseManager.StockReportLow();
            dataGridViewLow.DataSource = dataLow;
        }

        private void btnChangeDefaults_Click(object sender, EventArgs e)
        {
            ItemCapacityForm ICF = new ItemCapacityForm();


            ICF.FormClosing += (sender2, args2) =>
            {
                updateMaxLowDataViewer();
            };


            ICF.Show();
        }
    }
}