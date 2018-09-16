using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TableTap.DataAccessLayer;
using TableTap.Models;
using System.Configuration;




namespace TableTap.BusinessLayer
{
    public class UserBL
    {
        public static List<UserModel> FillUsersList()
        {
            List<UserModel> users = new List<UserModel>();

            users = UserDAL.LoadUsersList();

            return users;
        }

        public static UserModel getUserByID(int id)
        {
            UserModel user = UserDAL.loadUserByID(id);

            return user;
        }

        public static void ProcessAddNewUser(UserModel user)
        {
            UserModel newUser = user;

            UserDAL.AddNewUser(user);

        }



        /// <summary>
        /// CREATED BY HAYDEN BARTLETT
        /// scripting for login, passes information from login page to datalayer USERDB.
        /// A return of INT 3 = username failure
        /// A return of INT 2 = Password failure
        /// A return of INT 1 = Login success
        /// INPUT email Password, from Login
        /// OUTPUT INT 1/3 passed from USERDAL
        /// </summary>
        public static int loginScripting(string email, string password)
        {
            int status = 3;
            try
            {
                // PLACE ADDITIONAL CODE HERE
              status =  UserDAL.loginCheck(email, password);
            }
            catch
            {
                status = 3;
            }

            return status;
        }



        //detects if email already exists in database (by contacting AdminUserEditCheck)
        public static bool emailDuplicateCheck(string email)
        {

            bool exists;

            List<String> listing = new List<string>();
            try
            {
                listing = UserDAL.AdminUserEditCheck(email);

                if(listing == null)
                {
                    exists = false;
                }
                else
                {
                    exists = true;
                }
            }
            catch
            {
                exists = false;
            }

            return exists;
        }



    }
}