using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using TableTap.BusinessLayer.Classes;
using TableTap.Models;

namespace TableTap.DataAccessLayer.Classes
{
    public class TableDAL
    {

        public static void AddNewTable(TableModel table)
        {
            TableModel newTable = table;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            using (conn)
            {
                conn.Open();



               /* using (SqlCommand command = new SqlCommand(
                "INSERT INTO tblTable (emailAddress, passcode, firstName, lastName, adminPermission) VALUES ("
                    + "'" + newTable.Email.ToString() + "'" + ", "

                    + ")"
                    ,
                    conn))
                {
                    command.ExecuteNonQuery();
                }
                conn.Close(); */
            }

        }
        //Add user with input strings from registration page
        /*public void AddTable(string TableQR, int RoomID, int PersonCapacity, string Category, Boolean Reservable)
        {
            string DBConn;
            DBConn = ConfigurationManager.ConnectionStrings["udbTableTapConnectionString"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(DBConn))
            {
                sqlConnection.Open();

                using (SqlCommand command = sqlConnection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO tblTable (tableQR, roomID, personCapacity, category, reservable) VALUES (@tableQR, @roomID, @personCapacity, @category, @reservable)";

                    command.Parameters.AddWithValue("@tableQR", TableQR);
                    command.Parameters.AddWithValue("@roomID", RoomID);
                    command.Parameters.AddWithValue("@personCapacity", PersonCapacity);
                    command.Parameters.AddWithValue("@category", Category);
                    command.Parameters.AddWithValue("@reservable", Reservable);

                    int result = command.ExecuteNonQuery();
                }

            }
        }*/



    }
}