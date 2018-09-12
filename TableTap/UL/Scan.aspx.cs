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

namespace TableTap.UL
{
    public partial class Scan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReserve_Click(object sender, EventArgs e)
        {
            var tableManager = new TableManager();

            tableManager.EditAvailability("mvne439j0d");
        }
    }
}