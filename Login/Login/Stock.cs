using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Stock
    {
        public string materialType;
        public double quantity, totalCost, defects;
        public DateTime dateAcquired, dateUsed;

        public Stock()
        {
            materialType = "";
            quantity = 0;
            totalCost = 0;
            defects = 0;
            dateAcquired = DateTime.Today;
            dateUsed = DateTime.Today;
        }

        public Stock(string material, double quan, double tCost, double defectNo, DateTime dtAcq, DateTime dtUsed)
        {
            materialType = material;
            quantity = quan;
            totalCost = tCost;
            defects = defectNo;
            dateAcquired = dtAcq;
            dateUsed = dtUsed;
        }

        //returns the unit cost of materials purchased
        public double unitCost()
        {
            return totalCost / quantity;
        }

        //returns the percent of unusable materials by dividing the defect number by quantity purchased
        public string defectRate()
        {
            return (defects / quantity * 100).ToString() + "%";
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
