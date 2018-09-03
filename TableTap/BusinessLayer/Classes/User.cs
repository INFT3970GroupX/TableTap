using TableTap.DataAccessLayer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TableTap.BusinessLayer.Classes
{
    //Instantiazation Method Class. Creates User with AddUser method.
    public class User
    {

        public string UserEmail { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserPasscode { get; set; }

        public byte AdminPermssion { get; set; }

        public void AddUser()
        {
            UserDAL obj = new UserDAL();
            obj.AddUser(UserEmail, FirstName, LastName, UserPasscode);
        }

    }
}