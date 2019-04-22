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
    public partial class RemanufactureForm : Form
    {
        
        
        private DatabaseManager objDatabaseManager;
        private ToolTip ttExport = new ToolTip();
        Product P;
        HomePage Home;
        ProductStruct PS;
        public RemanufactureForm(HomePage H)
        {
            InitializeComponent();
            
            P = new Product();
            objDatabaseManager = new DatabaseManager();
            Home = H;
            

            lstDefProd.DataSource = P.LoadDefectives();

            ttExport.SetToolTip(btnExport, "Export as pdfs coming soon  :D");
        }

        //add selected item to Remanufacture list
        private void btnRepRemanufacture_Click(object sender, EventArgs e)
        {
            Home.MdiChildren.Last<Form>().Close();
            AddProduct newProduct = new AddProduct();
            newProduct.MdiParent = Home;
            newProduct.SetTXTBoxs(PS.ProductID.ToString(), 1.ToString());
            newProduct.Show();
            
            
        }

        private void lstDefProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstDefProd.SelectedIndex >= 0)
                {
                    PS = (ProductStruct)lstDefProd.SelectedItem;                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }
    }
}
