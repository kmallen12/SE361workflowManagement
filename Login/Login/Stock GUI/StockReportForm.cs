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
        HomePage home;
        DatabaseManager objDatabaseManager = new DatabaseManager();
        public StockReportForm(HomePage h)
        {
            home = h;
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
            //home.MdiChildren.Last<Form>().Close();

            ItemCapacityForm ICF = new ItemCapacityForm();
            ICF.MdiParent=home;

            ICF.FormClosing += (sender2, args2) =>
            {
               // home.MdiChildren.Last<Form>().Close();
                updateMaxLowDataViewer();
                this.Show();
            };

            ICF.Leave += (sender3, args3) =>
            {
                home.MdiChildren.Last<Form>().Close();
                //updateMaxLowDataViewer();
               //this.Show();
            };

            this.Hide();
            ICF.Show();
        }
    }
}