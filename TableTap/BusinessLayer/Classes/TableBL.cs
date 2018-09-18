using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TableTap.DataAccessLayer.Classes;
using TableTap.Models;

namespace TableTap.BusinessLayer.Classes
{
    public class TableBL
    {
        public static List<TableModel> fillTableList(int id)
        {
            List<TableModel> buildings = new List<TableModel>();

            buildings = TableDAL.loadTableList(id);

            return buildings;
        }
    }
}