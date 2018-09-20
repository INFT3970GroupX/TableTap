using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System.Drawing;
using System.Drawing.Imaging;


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

        protected void Button1_Click(object sender, EventArgs e)
        {



            //Change to your own location if you want to store a copy-- not needed
            ///          img.Save("C:\\Users\\kepst\\Desktop\\LastQRCodeCreated.png", ImageFormat.Png);
        }
    }
}