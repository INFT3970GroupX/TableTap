using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using TableTap.BusinessLayer.Classes;
using TableTap.Models;

namespace TableTap.UL
{
    public partial class HaydenTestingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string IDnumber = "?=ID10008";
            Response.Redirect("HaydenTestingPageURLIN.aspx" + IDnumber);

            //<add name="ConnectionString" connectionString="Data Source=ORBIT1\SQLSERVER;Initial Catalog=udbTableTap;Integrated Security=False;User ID=etableTap;Password=123" providerName="System.Data.SqlClient" />

        }

    }
}