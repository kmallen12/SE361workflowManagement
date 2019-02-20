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
                string materialName = txtRawMaterialName.Text;

                objRawMat = new RawMaterials(materialName);
                rawMaterials.Add(objRawMat);

                MessageBox.Show("Material " + materialName + " was added to the list.");

                lstRawMaterials.Items.Clear();
                lstRawMaterials.Items.AddRange(rawMaterials.ToArray());
            }
            catch (Exception)
            {
                MessageBox.Show("Error adding material to the list.");
                throw;
            }
            

        }

        private void btnCloseRawMaterial_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
