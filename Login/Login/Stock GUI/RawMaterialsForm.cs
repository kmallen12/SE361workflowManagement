using System;
using System.Collections.Generic;
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

        private void LoadRawMat()
        {
            rawMaterials = objDatabaseManager.LoadRawMat();

            //refresh list display
            lstRawMaterials.Items.Clear();
            lstRawMaterials.Items.AddRange(rawMaterials.ToArray());
        }

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
            LoadRawMat();
        }

        private void btnAddNewMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                string materialName = txtRawMaterialName.Text.Trim(' ');
                objRawMat = new RawMaterials(materialName);

                if (rawMaterials.Contains(objRawMat))
                {
                    MessageBox.Show(objRawMat.ToString());
                }


                if (!objRawMat.ContainsMaterialName(rawMaterials, objRawMat.material))
                {
                    addedRawMaterials.Add(objRawMat);

                    toolStripStatusLabel1.Text = "The material " + materialName + " was added to the list.";

                    lstRawMaterials.Items.Clear();
                    lstRawMaterials.Items.AddRange(rawMaterials.ToArray());
                    lstRawMaterials.Items.AddRange(addedRawMaterials.ToArray());

                    objDatabaseManager.InsertToRMTable(addedRawMaterials);
                }
                else
                {
                    MessageBox.Show("First input the name of a new material.");
                }

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
            try
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

                //remove from database
                objDatabaseManager.DeleteFromRMTable(deletedRawMaterials);

                //message to user
                toolStripStatusLabel1.Text = "The material " + materialName + " was removed to the list.";
            }
            catch (Exception)
            {
                MessageBox.Show("First select an item to delete.");
            }
            
        }

    }
}
