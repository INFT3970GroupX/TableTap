using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TableTap.DataAccessLayer.Classes;
using TableTap.Models;

namespace TableTap.BusinessLayer.Classes
{
    public class BuildingBL
    {
        public static void ProcessAddNewBuilding(BuildingModel building)
        {
            BuildingModel newBuilding = building;

            BuildingDAL.AddNewBuilding(newBuilding);

        }
    }
}