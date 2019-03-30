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

    }
}
