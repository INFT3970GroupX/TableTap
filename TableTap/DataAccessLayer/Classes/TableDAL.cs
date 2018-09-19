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
        public static List<TableModel> loadTableList(int id)
        {
            List<TableModel> tables = new List<TableModel>();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            using (conn)
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(
                    "SELECT * FROM tblTable WHERE tableID=" + id.ToString(),
                    conn))
                {
                    SqlDataReader dr = command.ExecuteReader();
                    TableModel table;
                    while (dr.Read())
                    {
                        table = new TableModel();
                        table.TableID = Convert.ToInt32(dr["tableID"]);
                        table.RoomID = Convert.ToInt32(dr["tableID"]);
                        table.PersonCapacity = Convert.ToInt32(dr["personCapacity"]);
                        table.Category = dr["category"].ToString();

                        tables.Add(table);
                    }
                    dr.Close();
                }
                conn.Close();
            }

            return tables;
        }

        public static bool checkTableStatus(int id)
        {
            bool hasData = false; //for testing purpuses
            string sTest = "0";


            DateTime dateNow = DateTime.Now;
            string hour = dateNow.ToString("HH");
            //string date = dateNow.ToString("yyyy-MM-d");
            string date = dateNow.ToString("dd-MM-yyyy");
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            using (conn)
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(
                    "SELECT " + hour + " FROM tblStatus WHERE tableID=" + "'" + id.ToString() + ", date=" + "'" + date + "'",
                    conn))
                
                {
                    SqlDataReader dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        sTest = dr[dateNow.ToString("mm")].ToString();
                    }
                    dr.Close();
                }
                conn.Close();
            }

            if (sTest != "0")
            {
                hasData = true;
            }

            return hasData;
        }
    }
}