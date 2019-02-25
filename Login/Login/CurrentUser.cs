using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowManagement
{
    public class CurrentUser
    {
        /// AUTHOR: Cowen Shears
        /// DATE: 2/25/19
        /// DESCRIPTION: Class to store basic details about the current user who is logged in. 

        //Automatic Properties
        public string Username { get; set; }
        public string UserType { get; set; }
       
        public CurrentUser(string Username,string UserType)
        {
            this.Username = Username;
            this.UserType = UserType;
        }
    }
}
