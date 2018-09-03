using System;
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
                    "SELECT * FROM tblUser" ,
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

    }
}