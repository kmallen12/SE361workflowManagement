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

namespace WorkflowManagement
{
    public partial class ItemCapacityForm : Form
    {
        DatabaseManager q = new DatabaseManager();
        public ItemCapacityForm()
        {
            InitializeComponent();
        }

        private Boolean isValidQuantity(string quantity)
        {
            try
            {
                int quan = int.Parse(quantity);
                return true;
            }
            catch
            {
                return false;
            }
        }




        private void btnUpdateWarningValues_Click(object sender, EventArgs e)
        {
            if (isValidQuantity(txtItemID.Text))
            {
                q.UpdateWareHouse(txtItemID.Text, txtMax.Text, txtLow.Text);
            }
        }
    }
}
