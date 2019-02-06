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

     
        private void btn_AddMaterial_Click(object sender, EventArgs e)
        {
            AddMaterialForm formMaterial = new AddMaterialForm();
            Hide();
            formMaterial.ShowDialog();
        }

        private void btn_UpdateStock_Click(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StockForm_Load(object sender, EventArgs e)
        {

        }
    }
}
