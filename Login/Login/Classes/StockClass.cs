﻿using System;
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
        public int OrderID { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string MaterialType { get; set; }
        public string Status { get; set; }
        public StockOrderRequest(int initID, int initQuantity, string initDescription, string initStatus, string initMaterialType)
        {
            OrderID = initID;
            Quantity = initQuantity;
            Description = initDescription;
            MaterialType = initMaterialType;
            Status = initStatus;
        }
        public override string ToString()
        {
            return string.Format("Material: {0}, Quantity: {1}, Description: {2}, Status: {3}", MaterialType, Quantity, Description, Status);
        }
        public string returnOrders()
        {
            return string.Format("StockID: {0}, Quantity: {1}", MaterialType, Quantity);
        }
    };
    public class Stock
    {
        private string MaterialType;

        DatabaseManager objDatabaseManager = new DatabaseManager();
        public string materialType { get { return MaterialType; } set { MaterialType = value;  } }
        public decimal quantity { get; set; }
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
        public void UpdateStockOrderStatus(int OrderID)
        {
            objDatabaseManager.UpdateStockOrderStatus(OrderID);
        }
        public void newOrder(int initQuantity, string initDescription, string initStatus, string materialType)
        {
            StockOrder = new StockOrderRequest(0, initQuantity, initDescription, initStatus, materialType);
            StockOrderRequests.Add(StockOrder);
        }
        public void InsertStockOrder()
        {
            objDatabaseManager.InsertStockOrders(StockOrderRequests);
        }
        public Stock(string material, decimal quan, double uCost, double defectNo, DateTime dtAcq, DateTime dtUsed)
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
            return unitCost * (double)quantity;
        }
       
        //Overriding the ToString method
        public override string ToString()
        {
            return string.Format("Material: {0}, Quantity: {1}, Defects: {2}, Unit Cost: {3:c}, Total Cost: {4:c}, Date Acquired: {5}, Date Used: {6}",
                materialType, quantity, defects, unitCost, totalCost(), dateAcquired, dateUsed);
        }


    }
}
