﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using TableTap.BusinessLayer.Classes;
using TableTap.DataAccessLayer;
using TableTap.Models;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace TableTap.UL
{
    public partial class TesterHeaderPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void test1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UL/HaydenTestingPage.aspx");
        }

        protected void test2_Click(object sender, EventArgs e)
        {
            Response.Redirect("UL/BeauTestPage.aspx");
        }

        protected void test3_Click(object sender, EventArgs e)
        {
            Response.Redirect("UL/AdminHome.aspx");
        }

        protected void test4_Click(object sender, EventArgs e)
        {

            string domain = "/UL/HaydenTestingPageURLIN.aspx";

            string IDnumber = "?=ID10008";


            string url = "www.etabletap.com";

            string cUrl = url + domain + IDnumber;


            QRCodeEncoder encoder = new QRCodeEncoder();

            Bitmap img = encoder.Encode(cUrl);

            Response.ContentType = "image/png";
            img.Save(Response.OutputStream, System.Drawing.Imaging.ImageFormat.Png);

            //Change to your own location if you want to store a copy-- not needed
            //img.Save("D:\\MyDocuments\\GitHub\\TableTap\\TableTap\\TestQR\\LastQRCodeCreated.png", ImageFormat.Png);
            //QRImage.ImageUrl = "LastQRCodeCreated.png";

            QRCodeDecoder decoder = new QRCodeDecoder();
        }

        protected void test5_Click(object sender, EventArgs e)
        {

        }
    }
}