using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TableTap.UL
{
    public partial class Table : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int ID = Int32.Parse(Request.QueryString["ID"]);
            //need to run a check for current date in format (2018-01-01)
            //need to run a check for the current hour and return in 24 hours (2digits)
            //will check ID and date in DAL and pull the row from database to populate
        }
    }
}