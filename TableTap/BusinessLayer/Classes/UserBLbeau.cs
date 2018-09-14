using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TableTap.DataAccessLayer;
using TableTap.Models;


namespace TableTap.BusinessLayer
{
    public class UserBLbeau
    {
        public static List<UserModel> FillUsersList()
        {
            List<UserModel> users = new List<UserModel>();

            users = UserDALbeau.LoadUsersList();

            return users;
        }

        public static UserModel getUserByID(int id)
        {
            UserModel user = UserDALbeau.loadUserByID(id);

            return user;
        }

        public static void ProcessAddNewUser(UserModel user)
        {
            UserModel newProduct = user;

            UserDALbeau.AddNewUser(user);

        }



    }
}