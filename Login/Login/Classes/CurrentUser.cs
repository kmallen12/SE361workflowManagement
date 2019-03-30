using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowManagement
{
    public class CurrentUser
    {
        /// DATE: 2/27/19
        /// DESCRIPTION: Class to store basic details about the current user who is logged in. 
        /// LAST UPDATE BY: Kristen Allen 3/30/19

        //Automatic Properties
        public string Username { get; set; }
        public string UserType { get; set; }
       
        public CurrentUser(string Username,string UserType)
        {
            this.Username = Username;
            this.UserType = UserType;
        }

        //Boolean Function To Return if a User can view certain windows/forms
        public Boolean canView(Object Form)
        {
            if (UserType == "Administrator")
                return true;

            if (UserType == "Stockiest")
            {
                if(Form.GetType().ToString() == "WorkFlowManagement.StockReportForm"
                    || Form.GetType().ToString() == "WorkFlowManagement.AddMaterialForm"
                    || Form.GetType().ToString() == "WorkFlowManagement.UpdateStockForm")
                    return true;
            }

            if (UserType == "Product Manager")
            {
                if (Form.GetType().ToString() == "WorkFlowManagement.AddProduct"
                    || Form.GetType().ToString() == "WorkFlowManagement.ViewProducts"
                    || Form.GetType().ToString() == "WorkFlowManagement.RemanufactureForm")
                    return true;
            }

            if (UserType == "Quality Analyzer")
            {
             
            }

            if (UserType == "Delivery Manager")
            {
                if (Form.GetType().ToString() == "WorkFlowManagement.ViewProducts"
                    || Form.GetType().ToString() == "WorkFlowManagement.RouteProducts")
                    return true;
            }

            if (UserType == "Report Manager")
            {
                if (Form.GetType().ToString() == "WorkFlowManagement.StockReportForm"
                    || Form.GetType().ToString() == "WorkFlowManagement.RemanufactureForm")
                    return true;
            }

            return false;
        }
    }
}
