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

        public int UserTypeID { get; set; }
       
        public CurrentUser(string Username,string UserType, int UserTypeID)
        {
            this.Username = Username;
            this.UserType = UserType;
            this.UserTypeID = UserTypeID;
        }

        //Boolean Function To Return if a User can view certain windows/forms
        public Boolean canView(Object Form)
        {
            if (UserTypeID == 1)
                return true;

            if (UserTypeID == 2)
            {
                if(Form.GetType().ToString() == "WorkFlowManagement.StockReportForm"
                    || Form.GetType().ToString() == "WorkFlowManagement.AddMaterialForm"
                    || Form.GetType().ToString() == "WorkFlowManagement.UpdateStockForm")
                    return true;
            }

            if (UserTypeID == 3)
            {
                if (Form.GetType().ToString() == "WorkFlowManagement.AddProduct"
                    || Form.GetType().ToString() == "WorkFlowManagement.ViewProducts"
                    || Form.GetType().ToString() == "WorkFlowManagement.RemanufactureForm")
                    return true;
            }

            if (UserTypeID == 4)
            {
                if (Form.GetType().ToString() == "WorkFlowManagement.ViewProductsForm"
                    || Form.GetType().ToString() == "WorkFlowManagement.CheckQuality")
                    return true;
            }

            if (UserTypeID == 5)
            {
                if (Form.GetType().ToString() == "WorkFlowManagement.ViewProductsForm"
                    || Form.GetType().ToString() == "WorkFlowManagement.RouteProducts")
                    return true;
            }

            if (UserTypeID == 6)
            {
                if (Form.GetType().ToString() == "WorkFlowManagement.StockReportForm"
                    || Form.GetType().ToString() == "WorkFlowManagement.RemanufactureForm")
                    return true;
            }

            return false;
        }
    }
}
