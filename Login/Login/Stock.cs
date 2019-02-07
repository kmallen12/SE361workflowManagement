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
        

    }
}
