using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowManagement
{
    public class Stock
    {
        public string materialType { get; set; }
        public double quantity { get; set; }
        public double unitCost { get; set; }
        public double defects { get; set; }
        public DateTime dateAcquired { get; set; }
        public DateTime dateUsed { get; set; }
        
        public Stock()
        {
            materialType = "";
            quantity = 0;
            unitCost = 0;
            defects = 0;
            dateAcquired = DateTime.Today;
            dateUsed = DateTime.Today;
        }

        public Stock(string material, double quan, double uCost, double defectNo, DateTime dtAcq, DateTime dtUsed)
        {
            materialType = material;
            quantity = quan;
            unitCost = uCost;
            defects = defectNo;
            dateAcquired = dtAcq;
            dateUsed = dtUsed;
        }

        //returns the unit cost of materials purchased
        public double totalCost()
        {
            return unitCost * quantity;
        }

        //returns the percent of unusable materials by dividing the defect number by quantity purchased
        public double defectRate()
        {
            return (defects / quantity * 100);
        }

        //returns the time materials sit idle (difference between received date and use date)
        public TimeSpan idleTime()
        {
            return dateUsed - dateAcquired;
        }
        
        public Boolean isValidQuantity(double quantity)
        {
            try
            {
                double quan = quantity;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean CheckValidStock()
        {
            if (!isValidQuantity(quantity))
            {
                System.Windows.Forms.MessageBox.Show("Quantity must be an integer (e.g. 30, 1000, etc.");
                return false;
            }

            return true;
        }

    }
}
