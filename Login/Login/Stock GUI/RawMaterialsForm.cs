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
    public partial class RawMaterialsForm : Form
    {
        private RawMaterials objRawMat;
        private List<RawMaterials> rawMaterials;
        private List<RawMaterials> addedRawMaterials;
        private List<RawMaterials> deletedRawMaterials;

        DatabaseManager objDatabaseManager;

        public RawMaterialsForm()
        {
            InitializeComponent();

            rawMaterials = new List<RawMaterials>();
            addedRawMaterials = new List<RawMaterials>();
            deletedRawMaterials = new List<RawMaterials>();

            //create an instance of DatabaseManager
            objDatabaseManager = new DatabaseManager();
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
                addedRawMaterials.Add(objRawMat);

                MessageBox.Show("Material " + materialName + " was added to the list.");

                lstRawMaterials.Items.Clear();
                lstRawMaterials.Items.AddRange(rawMaterials.ToArray());
                lstRawMaterials.Items.AddRange(addedRawMaterials.ToArray());
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "Error adding material to the list.");
                throw;
            }
        }

        private void btnCloseRawMaterial_Click(object sender, EventArgs e)
        {
            Hide();

        }

        private void lstRawMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get the reference to the material from listbox and cast it to RawMaterial object
            objRawMat = (RawMaterials)lstRawMaterials.SelectedItem;

            //update the text box wit the RawMaterial value
            txtRawMaterialName.Text = objRawMat.material;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //save material name to a string to use in the message to user
            string materialName = objRawMat.material;
            
            //remove item from local list
            rawMaterials.Remove(objRawMat);
            addedRawMaterials.Remove(objRawMat);

            //add deleted object to the deleted list - this will later be used to remove these from the database
            deletedRawMaterials.Add(objRawMat);

            //refresh list display
            lstRawMaterials.Items.Clear();
            lstRawMaterials.Items.AddRange(rawMaterials.ToArray());
            lstRawMaterials.Items.AddRange(addedRawMaterials.ToArray());

            //message to user
            MessageBox.Show("Material " + materialName + " was removed from the list.");
        }

        private void btnSaveRMtoDB_Click(object sender, EventArgs e)
        {
            objDatabaseManager.InsertToRMTable(addedRawMaterials);
            objDatabaseManager.DeleteFromRMTable(deletedRawMaterials);

            MessageBox.Show("List saved to the database.");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            rawMaterials = objDatabaseManager.LoadRawMat();

            MessageBox.Show("List loaded from the database.");

            //refresh list display
            lstRawMaterials.Items.Clear();
            lstRawMaterials.Items.AddRange(rawMaterials.ToArray());
        }
    }
}
