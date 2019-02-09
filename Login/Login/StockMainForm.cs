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
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
        }

        string str;
        private void btn_AddMaterial_Click(object sender, EventArgs e)
        {
            AddMaterialForm formMaterial = new AddMaterialForm();
            
            Hide();
            formMaterial.ShowDialog();
        }

        private void btn_UpdateStock_Click(object sender, EventArgs e)
        {
            UpdateStock formStock = new UpdateStock();

            Hide();
            formStock.ShowDialog();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            StockReportForm formReport = new StockReportForm();

            Hide();
            formReport.ShowDialog();
        }
    }
}
