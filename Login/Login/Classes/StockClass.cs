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
    /// LAST EDITED BY: Kristen 
    /// DATE: 2/24/2019
    /// DESCRIPTION: Class to manage Stock. It calculates idle time (time in storage before being used). 
    /// It calculates the defect rate.
    /// 
    public struct StockOrderRequest
    {
        public int OrderID;
        public int Quantity;
        public string Discription;
        public int StockID;
        public StockOrderRequest(int initID, int initQuantity, string initDiscription, int initStockID)
        {
            OrderID = initID;
            Quantity = initQuantity;
            Discription = initDiscription;
            StockID = initStockID;
        }
        public override string ToString()
        {
            return string.Format("StockID: {0}, Quantity: {1}, Discription: {2}", StockID, Quantity, Discription);
        }
        public string returnOrders()
        {
            return string.Format("StockID: {0}, Quantity: {1}", StockID, Quantity);
        }
    };
    public class Stock
    {
        private string MaterialType;

        DatabaseManager objDatabaseManager = new DatabaseManager();
        public string materialType { get { return MaterialType; } set { MaterialType = value;  } }
        public double quantity { get; set; }
        public double unitCost { get; set; }
        public double defects { get; set; }
        public DateTime dateAcquired { get; set; }
        public DateTime dateUsed { get; set; }
        public int id { get; set; }

        public List<StockOrderRequest> StockOrderRequests;
        public StockOrderRequest StockOrder;
        public Stock()
        {
            materialType = "";
            quantity = 0;
            unitCost = 0;
            defects = 0;
            dateAcquired = DateTime.Today;
            dateUsed = DateTime.Today;
        }
        public List<StockOrderRequest> LoadStockOrders()
        {
            StockOrderRequests = objDatabaseManager.LoadStockOrders();
            return StockOrderRequests;
        }
        public void newOrders()
        {
            StockOrderRequests = new List<StockOrderRequest>();
        }
        public void newOrder(int initQuantity, string initDiscription, int initID)
        {
            StockOrder = new StockOrderRequest(0, initQuantity, initDiscription, initID);
            StockOrderRequests.Add(StockOrder);
        }
        public void InsertStockOrder()
        {
            objDatabaseManager.InsertStockOrders(StockOrderRequests);
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
        public void UpdateStock(int key, string material, string quantity, string unitCost, string totalCost, string dateAcquired, string dateUsed, string amtDefected)
        {
            objDatabaseManager.UpdateStock(key, material, quantity, unitCost, totalCost, dateAcquired, dateUsed, amtDefected);
        }
        public void InsertStock(string material, string quantity, string unitCost, string totalCost, string dateAcquired, string dateUsed, string amtDefected)
        {
            objDatabaseManager.InsertStock(material, quantity, unitCost, totalCost, dateAcquired, dateUsed, amtDefected);
        }
        public DataTable StockTable()
        {
            return objDatabaseManager.LoadStocks();
        }
        public List<RawMaterials> LoadRawMat()
        {
            return objDatabaseManager.LoadRawMat();
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

       

        //Overriding the ToString method
        public override string ToString()
        {
            return string.Format("Material: {0}, Quantity: {1}, Defects: {2}, Unit Cost: {3:c}, Total Cost: {4:c}, Date Acquired: {5}, Date Used: {6}",
                materialType, quantity, defects, unitCost, totalCost(), dateAcquired, dateUsed);
        }


    }
}
