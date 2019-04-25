using System;
using System.Data;
using System.Windows.Forms;

namespace WorkFlowManagement
{
    public partial class AddProduct : Form
    {
        Product product;
        DataTable stockTable;
        DatabaseManager objDatabaseManager;
        //We check to see if text entries are correct.
        CheckEntry CE;
        //Dialogue boxes for confirmation
        WorkFlowMessage M;
        
        ManageProductOrders Orders;
        public AddProduct(ManageProductOrders O)
        {
            InitializeComponent();
            product = new Product();
            product.newProduct();
            CE = new CheckEntry();
            M = new WorkFlowMessage();
            Orders = O;       
        }
        public AddProduct()
        {
            InitializeComponent();
            product = new Product();
            product.newProduct();
            CE = new CheckEntry();
            M = new WorkFlowMessage();
            objDatabaseManager = new DatabaseManager();
            stockTable = objDatabaseManager.SumStocks();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workFlowDatabaseDataSet.StockSummaryView' table. You can move, or remove it, as needed.
            this.stockSummaryViewTableAdapter.Fill(this.workFlowDatabaseDataSet.StockSummaryView);

            lbl_Title.Text = "Create a New Product";

            for(int i=0; i<stockTable.Rows.Count; i++)
            {
                txt_Material.Items.Add(stockTable.Rows[i]["Material"].ToString().Trim(' '));
            }

        }


        private void btn_AddMaterialtoProduct_Click(object sender, EventArgs e)
        {
            if (CE.isnotNull(txt_Material.Text, "ID") && CE.isnotNull(txt_MaterialQuantity.Text, "Quantity"))
            {
                //Add materials one at a time to materialsProduct in Productclass.
                product.AddMaterialtoProduct(txt_Material.Text, txt_MaterialQuantity.Text);
                //Update the description in the bottom half so the user can see what has been added thus far.
                
                lbl_Description.Text = string.Empty;
                foreach (var v in product.productMaterials)
                    lbl_Description.Text = lbl_Description.Text +v.Name + ", " + v.Quantity + "\n";


            }
        }
        //Sets the GUI form to the version for adding a certain product not creating one. 
        //Functionality is so similar that creating a new form is redundant. 
        public void SetTXTBoxs(string key, string quantity)
        { 
            txt_ProductID.Text = key;
            txt_ProductQuantity.Text = quantity;
            txt_ProductName.Visible=false;
            txt_MaterialQuantity.Visible = false;
            txt_Material.Visible = false;
            lbl_MaterialAmount.Visible = false;
            lbl_MaterialID.Visible = false;
            lbl_Title.Visible = false;
            btn_FinalizeProduct.Visible = false;
            btn_AddMaterialtoProduct.Visible = false;
            lbl_ProductName.Visible = false;
            lbl_OrderMoreProduct.Visible = true;
            lbl_ProductID.Visible = true;
            btn_AdditionalProduct.Visible = true;
            txt_ProductID.Visible = true;
            txt_ProductQuantity.Visible = true;
            btnCancel.Visible = true;
            //Ensures product has correct attributes based on ID.
            //Only needed so we can correctly set the discription of the materials.
            product.SetProduct(Int32.Parse(txt_ProductID.Text));
            
            lbl_Description.Text = string.Empty;
            foreach (var v in product.productMaterials)
                lbl_Description.Text = lbl_Description.Text + v.Name + ", " + v.Quantity + "\n";

        }
        
        private void btn_FinalizeProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (CE.isnotNull(txt_ProductName.Text, "ProductName") && CE.isnotNull(txt_ProductQuantity.Text, "ProductQuantity"))
                {
                    if (M.CreateProduct(txt_ProductName.Text, lbl_Description.Text, txt_ProductQuantity.Text))
                    {
                        product.FinalizeProduct(txt_ProductName.Text, Int32.Parse(txt_ProductQuantity.Text));
                        Product_Load(sender, e);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            
        }

        private void btn_AdditionalProduct_Click(object sender, EventArgs e)
        {
            //Ensures product has correct attributes based on ID.
            //If the user changes the ID.
            if (CE.isnotNull(txt_ProductID.Text, "ProductID") && CE.isnotNull(txt_ProductQuantity.Text, "ProductQuantity"))
            {
                product.SetProduct(Int32.Parse(txt_ProductID.Text));
                product.FinalizeProduct(product.productName, Int32.Parse(txt_ProductQuantity.Text));
                Product_Load(sender, e);
                
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
