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
            StringWriter writer = new StringWriter();
            Server.UrlEncode(IDnumber, writer);
            String EncodedString = writer.ToString();
            Response.Redirect("HaydenTestingPageURLIN.aspx" + IDnumber);

        }

    }
}