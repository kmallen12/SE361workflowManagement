using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WorkFlowManagement
{
    class MB
    {
        string messageBoxTxt;
        string caption;

        public bool UpdateProduct(Product P,string id, string name, string materials, string quantity)
        {
            messageBoxTxt = "Are you sure you want to change product: " + P.productDiscription() + " to " + "ID: " +id + " Name: " + name + " Materials: " + materials + " Quantity: " +quantity+"?";
            caption = "Confirm Product Update";
            if (System.Windows.Forms.MessageBox.Show(messageBoxTxt, caption, System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                return true;
            else
                return false;
        }
        public bool CreateProduct(string name, string materials, string quantity)
        {
            messageBoxTxt = "Are you sure you want to creat Product: " + name + " using Materials: " + materials + " of quantity " + quantity + "?"; 
            caption = "Confirm Product Creation";
            if (System.Windows.Forms.MessageBox.Show(messageBoxTxt, caption, System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                return true;
            else
                return false;
        }
        public void NegativeMaterial(string material, int matQuantity, int productQuantity, int matActual)
        {
            messageBoxTxt = "The product or amount of product you are trying to create requires "+ matQuantity*productQuantity+" "+material+" but there is only "+ matActual + " available.";
            caption = "Insufficient Materials";
            System.Windows.Forms.MessageBox.Show(messageBoxTxt, caption, System.Windows.Forms.MessageBoxButtons.OK);
        }
        public void IncorrectEntry()
        {
            messageBoxTxt = "Please use the correct entry format.";
            caption = "Incorrect Format";
            System.Windows.Forms.MessageBox.Show(messageBoxTxt, caption, System.Windows.Forms.MessageBoxButtons.OK);
        }
    }
}
