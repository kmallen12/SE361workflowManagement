using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WorkFlowManagement
{
      
    public partial class AddProduct : Form
    {
        Product P;
        //We check to see if text entries are correct.
        CheckEntry CE;
        //Dialogue boxes for confirmation
        MB M;
        public AddProduct()
        {
            InitializeComponent();
            P = new Product();
            CE = new CheckEntry();
            M = new MB();
        }

        private void Product_Load_1(object sender, EventArgs e)
        {
            //use partialstock datatable as datasource for data grid
            PartialStockGrid.DataSource = P.PartialStockTable();
        }

   

        private void btn_AddMaterialtoProduct_Click(object sender, EventArgs e)
        {
            if (CE.isnotNull(txt_MaterialID.Text, "ID") && CE.isnotNull(txt_MaterialQuantity.Text, "Quantity"))
            {
                //Add materials one at a time to materialsProduct in Productclass.
                P.AddMaterialtoProduct(txt_MaterialID.Text, txt_MaterialQuantity.Text);
                //Update the description in the bottom half so the user can see what has been added thus far.
                lbl_Description.Text = P.productMaterials;
            }
        }
        //Sets the GUI form to the version for adding a certain material not creating one. 
        //Functionality is so similar that creating a new form is redundant. 
        public void SetTXTBoxs(string key, string quantity)
        { 
            txt_ProductID.Text = key;
            txt_ProductQuantity.Text = quantity;
            txt_ProductName.Visible=false;
            txt_MaterialQuantity.Visible = false;
            txt_MaterialID.Visible = false;
            lbl_MaterialAmount.Visible = false;
            lbl_MaterialID.Visible = false;
            lbl_CreateANewProduct.Visible = false;
            btn_FinalizeProduct.Visible = false;
            btn_AddMaterialtoProduct.Visible = false;
            lbl_ProductName.Visible = false;
            lbl_OrderMoreProduct.Visible = true;
            lbl_ProductID.Visible = true;
            btn_AdditionalProduct.Visible = true;
            txt_ProductID.Visible = true;
            txt_ProductQuantity.Visible = true;
            //Ensures product has correct attributes based on ID.
            //Only needed so we can correctly set the discription of the materials.
            P.SetProduct(Int32.Parse(txt_ProductID.Text));
            lbl_Description.Text = P.productMaterials;
            
        }
        
        private void btn_FinalizeProduct_Click(object sender, EventArgs e)
        {
            if (CE.isnotNull(txt_ProductName.Text, "ProductName") && CE.isnotNull(txt_ProductQuantity.Text, "ProductQuantity"))
            {
                if (M.CreateProduct(txt_ProductName.Text, P.productMaterials, txt_ProductQuantity.Text))
                {
                    P.FinalizeProduct(txt_ProductName.Text, Int32.Parse(txt_ProductQuantity.Text));
                    Product_Load_1(sender, e);
                }
            }
        }

        private void btn_AdditionalProduct_Click(object sender, EventArgs e)
        {
            //Ensures product has correct attributes based on ID.
            //If the user changes the ID.
            if (CE.isnotNull(txt_ProductID.Text, "ProductID") && CE.isnotNull(txt_ProductQuantity.Text, "ProductQuantity"))
            {
                P.SetProduct(Int32.Parse(txt_ProductID.Text));
                P.AdditionalProduct(Int32.Parse(txt_ProductID.Text), Int32.Parse(txt_ProductQuantity.Text));
            }
        }
    }
}
