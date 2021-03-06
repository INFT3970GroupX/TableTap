﻿using System;
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
                listing = UserDAL.EmailSearch(email);

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


        /// <summary>
        /// passes list from fed from input (adminedituser) to ModifyUser class
        /// </summary>
        public static bool PassInModifyString(List<string> record)
        {
            bool success = false;
            try
            {
                UserDAL.modifyUser(record);

                success = true;
                return success;

            }
            catch
            {
                return success;
            }
            
        }


        /// <summary>
        /// Passes accesses data from data access layer
        /// input a email
        /// outputs list of user info associated with email
        /// if no email found or in the event of a error returns null
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        public static List<string> passUserSearch(string email)
        {
            List<string> record = new List<string>();
            try
            {

               record = UserDAL.EmailSearch(email);
            }
            catch
            {
                record = null;
            }

            return record;

        }


        /// <summary>
        /// accesses user delete function, if successful returns true else
        /// returns false
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static void userDelete(int userID)
        {

            UserDAL.deleteUser(userID);
            /*bool success;
            try
            {
                
                return success = true;
            }
            catch
            {
                return success = false;
            }*/
        }



    }
}