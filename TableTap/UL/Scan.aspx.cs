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
using System.Drawing;
using System.Drawing.Imaging;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace TableTap.UL
{
    public partial class Scan : System.Web.UI.Page
    {
        string DBConn;

        protected void Page_Load(object sender, EventArgs e)
        {
            DBConn = ConfigurationManager.ConnectionStrings["udbTableTapConnectionString"].ConnectionString;
        }

        //when reserve button clicked, (temporarily) displays the qrcodes string (doesn't yet) activate EditAvailability() function
        protected void btnReserve_Click(object sender, EventArgs e) {

            /*
            tableManager.EditAvailability("mvne439j0d");

            Bitmap qrcode = new Bitmap("E:\\Users\\Desktop\\LastQRCodeCreated.png");

            QRCodeDecoder dec = new QRCodeDecoder();
            textBox2.Text = (dec.Decode(new QRCodeBitmapImage(qrcode)));

            //var tableManager = new TableManager();
            //tableManager.EditAvailability("mvne439j0d");

                */
        }

    }
}