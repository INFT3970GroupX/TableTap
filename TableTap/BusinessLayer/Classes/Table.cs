using TableTap.DataAccessLayer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TableTap.BusinessLayer.Classes
{
    //Instantiazation Method Class. Creates User with AddUser method.
    public class Table
    {

        public string TableQR { get; set; }

        public int RoomID { get; set; }

        public int PersonCapacity { get; set; }

        public string Category { get; set; }

        public Boolean Availability { get; set; }

        public Boolean Reservable { get; set; }

        public void AddTable()
        {
            TableDAL obj = new TableDAL();
            obj.AddTable(TableQR, RoomID, PersonCapacity, Category, Reservable);
        }

    }
}