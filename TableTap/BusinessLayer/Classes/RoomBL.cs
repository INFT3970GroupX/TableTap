using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TableTap.DataAccessLayer.Classes;
using TableTap.Models;

namespace TableTap.BusinessLayer.Classes
{
    public class RoomBL
    {
        public static List<RoomModel> fillRoomsList(int id)
        {
            List<RoomModel> buildings = new List<RoomModel>();

            buildings = RoomDAL.loadRoomList(id);

            return buildings;
        }
    }
}