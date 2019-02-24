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
        /// DATE: 2/15/19
        /// DESCRIPTION: Class to store basic details about the current user who is logged in. 
        /// Currently holds two strings, Username and UserType.
        public string Username { get; set; }
        public string UserType { get; set; }
        public CurrentUser()
        {
            Username = ""; 
            UserType = "";
        }

        public CurrentUser(string Username,string UserType)
        {
            this.Username = Username;
            this.UserType = UserType;
        }

        public string GetUsername()
        {
            return Username;
        }

        public string GetUserType()
        {
            return UserType;
        }
    }
}
