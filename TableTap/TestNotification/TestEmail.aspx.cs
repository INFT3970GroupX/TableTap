using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MimeKit;
using MailKit.Net.Smtp;


/// <summary>
/// SENDS BASIC EMAIL USING 
/// using MimeKit;
/// using MailKit.Net.Smtp;
/// Requires Mailkit from NUGET
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
            var eMail = new MimeMessage();

            eMail.From.Add(new MailboxAddress("eTableTap", "eTableTap@GMail.com"));
            eMail.To.Add(new MailboxAddress("Valued Client", email));
            eMail.Subject = "Test mail";
            eMail.Body = new TextPart("plain") { Text = @"This is a test" };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587);

                ////Note: only needed if the SMTP server requires authentication
                client.Authenticate("eTableTap@GMail.com", "INFT3970");

                client.Send(eMail);
                client.Disconnect(true);
            }
    }
}