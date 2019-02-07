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
    public partial class StockReportForm : Form
    {
        public StockReportForm()
        {
            InitializeComponent();
        }

        //all materials on hand - aggregates by material type
        public double totalQuantity()
        {
            return 0;
        }

        //average cost by material type
        public double averageCost()
        {
            return 0;
        }

        //average time to use
        public TimeSpan avgIdleTime()
        {
            return new TimeSpan();
        }

    }
}
