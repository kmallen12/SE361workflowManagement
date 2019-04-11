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
        private List<Product> defProducts;
        
        private DatabaseManager objDatabaseManager;

        public RemanufactureForm()
        {
            InitializeComponent();
            defProducts = new List<Product>();
            
            objDatabaseManager = new DatabaseManager();

            defProducts = objDatabaseManager.LoadDefectiveProducts();
            
            foreach (var prod in defProducts)
            {
                lstDefProd.Items.Add(prod.ToString());
            }
        }

        //add selected item to Remanufacture list
        private void btnRepRemanufacture_Click(object sender, EventArgs e)
        {
            //This line of code is what needs to happen but you can't cast the selected item
            //as a product, so need to find a way around that. 
            //remanufactureProducts.Add((Product)lstDefProd.SelectedItem);
            //remanufactureProducts.Add(NewtonSoft.Serialize); //use Matthew's product code for syntax
            MessageBox.Show("This defective product will be remanufactured");
        }
    }
}
