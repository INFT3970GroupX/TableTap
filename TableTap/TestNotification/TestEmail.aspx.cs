using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Net;
using System.Net.Mail;
using System.Web.UI.WebControls;


/// <summary>
/// SENDS BASIC EMAIL USING 
/// using System.Net;
/// using System.Net.Mail;
/// does not need addon or API
/// can be used to create more complex with extra commands
/// </summary>
namespace TableTap.TestNotification
{
    public partial class TestEmail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

protected void Button1_Click(object sender, EventArgs e)
        {
            // variables for the email address, email subject line, and message respectively
            string email = txbData.Text;
            string subject = txbSubject.Text;
            string message = txbMessage.Text;
            /// ---- Start EMAIL NOTIFICATION ----\\\
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            // Email address login details
            smtp.Credentials = new NetworkCredential("eTableTap@GMail.com",
               "INFT3970");
            // Sent from address, target address, subject and message
            smtp.Send("eTableTap@GMail.com", email,
                   subject, message);
        }
    }
}