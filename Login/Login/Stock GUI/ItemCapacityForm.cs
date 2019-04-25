using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WorkFlowManagement
{
    public partial class ItemCapacityForm : Form
    {
        DatabaseManager objDatabaseManager = new DatabaseManager();
        CheckEntry objCheckEntry;
        private List<RawMaterials> materialList;


        public ItemCapacityForm()
        {
            InitializeComponent();
            materialList = objDatabaseManager.LoadRawMat();

            foreach (var mat in materialList)
            {
                cbox_Materials.Items.Add(mat.material);
            }

            objCheckEntry = new CheckEntry();
        }


        private void btnUpdateWarningValues_Click(object sender, EventArgs e)
        {
                objDatabaseManager.UpdateWareHouse(cbox_Materials.SelectedItem.ToString(), txtMax.Text, txtLow.Text);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbox_Materials_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] numberswecareabout;
            numberswecareabout = objDatabaseManager.WareHouseStats(cbox_Materials.SelectedItem.ToString());
            txtQty.Text = numberswecareabout[0].ToString();
            txtLow.Text = numberswecareabout[1].ToString();
            txtMax.Text = numberswecareabout[2].ToString();

        }
    }
}
