using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TableTap.Models;

namespace TableTap.DataAccessLayer.Classes
{
    public class BuildingDAL
    {
        public static void AddNewBuilding(BuildingModel building)
        {
            BuildingModel newBuilding = building;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            using (conn)
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(
                "INSERT INTO tblBuilding (buildingLabel, buildingName, roomQty) VALUES ("
                    + "'" + newBuilding.BuildingLabel + "'" + ", "
                    + "'" + newBuilding.BuildingName + "'" + ", "
                    + "'" + newBuilding.RoomQty.ToString() + "'"
                    + ")"
                    ,
                    conn))
                {
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }

        }
    }
}