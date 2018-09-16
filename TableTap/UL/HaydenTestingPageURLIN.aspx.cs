using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TableTap.UL
{
    public partial class HaydenTestingPageURLIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            reee();
        }

        protected void reee()
        {
            string IDstring;

            string baseUrl = Request.Url.AbsoluteUri;

            IDstring = baseUrl.Substring(baseUrl.IndexOf("?=ID"));

            Label2.Text = IDstring;

            Label3.Text = IDstring.Replace("?=ID", "");

            Label1.Text = baseUrl;
        }
    }
}