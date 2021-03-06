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
        //returns int values 1/3 
        //Input email and password
        //CREATED BY HAYDEN
        public static Int32 loginCheck(string email, string password)
        {
            int exists = 3;


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
                    try
                    {
                        user.Email = dr["emailAddress"].ToString();
                    }
                    catch
                    {
                        user.Email = null;
                    }

                    try
                    { 
                    user.Password = dr["passcode"].ToString();
                    }
                    catch
                    {
                        user.Password = null;
                    }

                    if (user.Email == email && user.Password == password)
                    {
                        exists = 1;
                    }
                    else if(user.Email == email && user.Password != password)
                    {
                        exists = 2;
                    }
                    else
                    {
                        exists = 3;
                    }
                    

                    dr.Close();
                }
              
            }
         return exists;
        }

        /// <summary>
        /// CREATED BY HAYDEN
        /// Takes input of email
        /// returns matching record as a list<string>
        public static List<string> EmailSearch(string email)
        {

            List<string> userRecord = new List<string>();


            UserModel user = new UserModel();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            using (conn)
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(
                    "SELECT * FROM tblUser WHERE emailAddress=" + "'" + email + "'", conn))
                {


                    SqlDataReader dr = command.ExecuteReader();
                    dr.Read();

                    try
                    {

                        user.UserID = Convert.ToInt32(dr["userID"]);
                        user.Email = dr["emailAddress"].ToString();
                        user.Password = dr["passcode"].ToString();
                        user.FirstName = dr["firstName"].ToString();
                        user.LastName = dr["lastName"].ToString();
                        user.AdminPermission = Convert.ToByte(dr["adminPermission"]);
                        // these lines of code are seperated for debugging
                        userRecord.Add(user.UserID.ToString());
                        userRecord.Add(user.Email);
                        userRecord.Add(user.Password);
                        userRecord.Add(user.FirstName);
                        userRecord.Add(user.LastName);
                        userRecord.Add(user.AdminPermission.ToString());

                        dr.Close();
                    }
                    catch
                    {
                        userRecord = null;
                    }
                }

                conn.Close();
            }
           



            return userRecord;
        }



        /// <summary>
        /// Modifys user record from associated email passed in
        /// Uses list (userdata) to store all data
        /// </summary>
        public static void modifyUser(List<string> userdata)
        {
            string UserID = userdata[0];
            string email = userdata[1];
            string password = userdata[2];
            string firstname = userdata[3];
            string lastname = userdata[4];
            string admin = userdata[5];

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlCommand modify = new SqlCommand();
            SqlDataReader reader;
            modify.CommandText = "UPDATE tblUser SET emailAddress=" + "'" + email + "', passcode=" + "'" + password + "', firstName=" + "'" + firstname 
                + "', lastName=" + "'" + lastname + "', adminPermission=" + "'" + admin + "'" + "WHERE userID=" + "'" + UserID + "'";
            modify.CommandType = System.Data.CommandType.Text;
            modify.Connection = conn;
            conn.Open();
            reader = modify.ExecuteReader();

            conn.Close();


            
        }



        /// <summary>
        /// deletes user associated with userID
        /// </summary>
        public static void deleteUser(int UserID)
        {

            /*
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlCommand modify = new SqlCommand();
            SqlDataReader reader;
            modify.CommandText = "DELETE FROM tblUser " + "WHERE userID=" + "'" + UserID + "'";
            modify.CommandType = System.Data.CommandType.Text;
            modify.Connection = conn;
            conn.Open();
            reader = modify.ExecuteReader();

            conn.Close();
            */
            UserModel newUser = new UserModel();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            
            using (conn)
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(
                "DELETE FROM tblUser WHERE userID=" + UserID.ToString(), conn))
                {
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }

        }




    }
}