using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TableTap.Models
{
    public class TableModel
    {
        public int ReservationID { get; set; }

        public int UserID { get; set; }

        public int TableID { get; set; }

        public DateTime ReservationStartTime { get; set; }

        public DateTime ReservationEndTime { get; set; }

        public string GroupName { get; set; }

        //public TableModel()
        //{

        //}

        public TableModel(int resid, int uid, int tid, DateTime resstart, DateTime resend, string group)
        {
            this.ReservationID = resid;
            this.UserID = uid;
            this.TableID = tid;
            this.ReservationStartTime = resstart;
            this.ReservationEndTime = resend;
            this.GroupName = group;  
        }
    }
}