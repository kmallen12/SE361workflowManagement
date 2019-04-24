using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowManagement
{
    class HelpMessage
    {
        private string messageBoxTxt;
        private string caption;

        public void ShowAdministrator()
        {
            messageBoxTxt = "As an Administrator, you have the capabilities of every user type.";
            caption = "Administrator Help";
            System.Windows.Forms.MessageBox.Show(messageBoxTxt, caption);
        }

        public void ShowStockiest()
        {
            messageBoxTxt = "As a Stockiest, you have several capabilities:" +
                "\n-Add Raw Materials: Enter new raw materials to be used in the production of\n     products." +
                "\n-View/Update Stock: View the materials currently in stock, and update their\n     details." +
                "\n-Generate Report: View materials with high and low inventory. Change the default\n     thigh/low reporting for items." +
                "\n-Stock Inventory Summary: View a summary of total inventory for all materials." +
                "\n-Manage Stock Orders: View orders put in for needed materials. Fill orders and\n     confirm them.";
            caption = "Stockiest Help";
            System.Windows.Forms.MessageBox.Show(messageBoxTxt, caption);
        }

        public void ShowProductManager()
        {
            messageBoxTxt = "As a Product Manager, you have several capabilities:" +
                "\n-View and Update Products: View all Products and change any details. Order more\n     of a product." +
                "\n-Request More Materials: Send a request to the Stockiest for more materials." +
                "\n-Defective Products to Re-Manufacture: Select poor quality/defective products\n     and remanufacture them." +
                "\n-Add Product: Create a new product using materials in stock." +
                "\n-View Stock Orders: View the stock orders you have requested.";
            caption = "Product Manager Help";
            System.Windows.Forms.MessageBox.Show(messageBoxTxt, caption);
        }

        public void ShowQualityAnalyzer()
        {
            messageBoxTxt = "As a Quality Analyzer, you have several capabilities:" +
                "\n-View Products: View all products in inventory." +
                "\n-Update Product Status: Select products and assign them with a quality from Very\n     Poor to High";
            caption = "Quality Analyzer Help";
            System.Windows.Forms.MessageBox.Show(messageBoxTxt, caption);
        }

        public void ShowDeliveryManager()
        {
            messageBoxTxt = "As a Delivery Manager, you have several capabilities:" +
                "\n-View Products: View all products in inventory." +
                "\n-Route Products: Send qualified products onto sales." +
                "\n-View Qualified Products: View and ship out qualified products." +
                "\n-Product Status Report: View current products in inventory with their qualities or\n     if they have been shipped.";
            caption = "Delivery Manager Help";
            System.Windows.Forms.MessageBox.Show(messageBoxTxt, caption);
        }

        public void ShowReportManager()
        {
            messageBoxTxt = "As a Report Manager, you have several capabilities:" +
                "\n-Warehouse Capacity: View materials with high and low inventory. Change the\n     default high/low reporting for items." +
                "\n-Stock Inventory: View all materials in stock." +
                "\n-Products In Progress: View products that are in progess." +
                "\n-Qualified Products: View and ship out qualified products." +
                "\n-Defective Products: Select poor quality/defective products and remanufacture\n     them.";
            caption = "Report Manager Help";
            System.Windows.Forms.MessageBox.Show(messageBoxTxt, caption);
        }
    }
}
