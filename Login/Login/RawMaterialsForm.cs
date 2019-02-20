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

        DatabaseManager objDatabaseManager;

        //declare connection string to Azure database
        const string connectionString = @"Data Source=workflowdatabase.database.windows.net;Initial Catalog=WorkFlowDatabase;User ID=OCOTOD;Password=********;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public RawMaterialsForm()
        {
            InitializeComponent();

            rawMaterials = new List<RawMaterials>();

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

        private void lstRawMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get the reference to the material from listbox and cast it to RawMaterial object
            objRawMat = (RawMaterials)lstRawMaterials.SelectedItem;

            //update the text box wit the RawMaterial value
            txtRawMaterialName.Text = objRawMat.material;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //remove item
            string materialName = objRawMat.material;
            rawMaterials.Remove(objRawMat);

            //message to user
            MessageBox.Show("Material " + materialName + " was removed from the list.");

            //refresh list display
            lstRawMaterials.Items.Clear();
            lstRawMaterials.Items.AddRange(rawMaterials.ToArray());
        }

        private void btnSaveRMtoDB_Click(object sender, EventArgs e)
        {
            objDatabaseManager.InsertToRMTable(rawMaterials);

            MessageBox.Show("List saved to the database.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rawMaterials = objDatabaseManager.LoadRawMat();

            MessageBox.Show("List loaded from the database.");
        }
    }
}
