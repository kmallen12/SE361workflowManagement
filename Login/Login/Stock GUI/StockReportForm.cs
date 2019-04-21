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
            ICF.StartPosition = FormStartPosition.Manual;

            ICF.Left = this.Left+1;
            ICF.Top = this.Top+25;

            ICF.FormClosing += (sender2, args2) =>
            {
                updateMaxLowDataViewer();
                this.Show();
            };

            this.Hide();
            ICF.Show();
        }
    }
}