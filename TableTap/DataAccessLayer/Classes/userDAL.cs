﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TableTap.Models;

namespace TableTap.DataAccessLayer
{
    public class UserDAL
    {
        public static List<UserModel> LoadUsersList()
        {
            List<UserModel> users = new List<UserModel>();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            using (conn)
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(
                    "SELECT * FROM tblUser",
                    conn))
                {
                    SqlDataReader dr = command.ExecuteReader();
                    UserModel user;
                    while (dr.Read())
                    {
                        user = new UserModel();
                        user.UserID = Convert.ToInt32(dr["userID"]);
                        user.Email = dr["emailAddress"].ToString();
                        user.Password = dr["passcode"].ToString();
                        user.FirstName = dr["firstName"].ToString();
                        user.LastName = dr["lastName"].ToString();
                        user.AdminPermission = Convert.ToByte(dr["adminPermission"]);

                        users.Add(user);
                    }
                    dr.Close();
                }
                conn.Close();
            }

            return users;
        }

        public static UserModel loadUserByID(int id)
        {
            UserModel user = new UserModel();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            using (conn)
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(
                    "SELECT * FROM tblUser WHERE userID=" + id.ToString(),
                    conn))
                {
                    SqlDataReader dr = command.ExecuteReader();
                    dr.Read();



                    //user = new UserModel();
                    user.UserID = Convert.ToInt32(dr["userID"]);
                    user.Email = dr["emailAddress"].ToString();
                    user.Password = dr["passcode"].ToString();
                    user.FirstName = dr["firstName"].ToString();
                    user.LastName = dr["lastName"].ToString();
                    user.AdminPermission = Convert.ToByte(dr["adminPermission"]);


                    dr.Close();
                }
                conn.Close();
            }

            return user;
        }

        public static void AddNewUser(UserModel user)
        {
            UserModel newUser = user;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

              using (conn)
              {
                  conn.Open();

                    

                  using (SqlCommand command = new SqlCommand(
                  "INSERT INTO tblUser (emailAddress, passcode, firstName, lastName, adminPermission) VALUES ("
                      + "'" + newUser.Email.ToString() + "'" + ", "
                      + "'" + newUser.Password.ToString() + "'" + ", "
                      + "'" + newUser.FirstName + "'" + ", "
                      + "'" + newUser.LastName + "'" + ", "
                      + "'" + newUser.AdminPermission+ "'"
                      + ")"
                      ,
                      conn))
                  {
                      command.ExecuteNonQuery();
                  }
                  conn.Close();
              } 
            
        }


        // login function - check username + password
        public static bool loginCheck(string email, string password)
        {
            bool exists = false;


            UserModel user = new UserModel();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            using (conn)
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(
                    "SELECT * FROM tblUser WHERE emailAddress=" + "'" + email.ToString() + "'", conn))
                {

                    
                    SqlDataReader dr = command.ExecuteReader();
                    dr.Read();

                    user.Email = dr["emailAddress"].ToString();

                    if (user.Email == email)
                    {
                        exists = true;
                    }
                    else
                    {
                        exists = false;
                    }

                    dr.Close();
                }
              
            }
         return exists;
        }

    }
}