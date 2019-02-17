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
    public partial class RawMaterialsForm : Form
    {
        private RawMaterials objRawMat;
        private List<RawMaterials> rawMaterials;

        public RawMaterialsForm()
        {
            InitializeComponent();

            rawMaterials = new List<RawMaterials>();
        }

        private void RawMaterialsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNewMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                CheckEntry objCheckRMUnitCost = new CheckEntry(txtRawMaterialUnitCost.Text, lblRawMaterialUnitCost.Text);
                if (!objCheckRMUnitCost.isNull())
                {
                    if (!objCheckRMUnitCost.isValidNumber())
                    {
                        txtRawMaterialUnitCost.Clear();
                    }
                }

                string materialName = txtRawMaterialName.Text;
                double? unitCost = double.Parse(txtRawMaterialUnitCost.Text);

                objRawMat = new RawMaterials(materialName, unitCost);
                rawMaterials.Add(objRawMat);

                MessageBox.Show("Material " + materialName + ", " + unitCost + " added to the list.");

                lstRawMaterials.Items.Clear();
                lstRawMaterials.Items.AddRange(rawMaterials.ToArray());
            }
            catch (Exception)
            {

                throw;
            }
            

        }
    }
}
