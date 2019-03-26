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
    public partial class ReportStock : Form
    {
        public ReportStock()
        {
            InitializeComponent();

            ToolTip toolTip1 = new ToolTip();
            //ttExport1.SetToolTip(btnExport, "Export the report you generated.");
            toolTip1.SetToolTip(btnExport, "Export the report you generated.");
        }

        private void ReportStock_Load(object sender, EventArgs e)
        {
           // TODO: This line of code loads data into the 'workFlowDatabaseDataSet.StockTable' table. You can move, or remove it, as needed.
           this.stockTableTableAdapter.Fill(this.workFlowDatabaseDataSet.StockTable);

        }
    }
}
