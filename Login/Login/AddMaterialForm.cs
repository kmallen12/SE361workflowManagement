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
    public partial class AddMaterialForm : Form
    {
        public AddMaterialForm()
        {
            InitializeComponent();
        }

        private void lbl_unitCost_Click(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
    }
}
