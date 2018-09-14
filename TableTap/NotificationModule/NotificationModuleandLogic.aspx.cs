﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// take note of the modules below:
using MimeKit;
using MailKit.Net.Smtp;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

/// <summary>
/// This module uses Mailkit and Twilio from NuGet
/// This module contains a functional email form for confirmation
/// This module contains a fucntional email form for account creation
/// this module contains a functional SMS form for confirmation
/// this module includes a functional SMS form for account creation
/// this module includes supporting methods for above
/// when applying methods from this module be sure to take ALL the linked methods or the logic will break
/// </summary>
namespace TableTap.NotificationModule
{
    public partial class NotificationModuleandLogic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        // Testing Method
        // please avoid testing this method due to it using twilio credit, all methods  have already been tested and are working
        protected void Tester_Click(object sender, EventArgs e)
        {
            // if its here the methods need it for a input
            string email = "hayden.bartlett1@hotmail.com";
            string phone = "0434346773";
            string fName = "Hayden";
            string sName = "Bartlett";
            string tableID = "6604";
            string roomName = "testing room";
            startaccountnotification(email, phone, fName, sName);
            startbookNotify(email, phone, fName, sName, tableID, roomName);

        }






        // booking notification code requires sendmail(), phNumFormat() and sendSMS methods
        protected void startbookNotify(string email, string phone, string fName, string sName, string tableID, string roomName)
        {
            ///--------------------EMAIL SECTION -------------------------\\\

            // variables for the email address, email subject line, and message respectively
            string subject = fName + "  your TableTap booking";
            string message = "Hi " + fName + Environment.NewLine + "Thank you, " + fName + " " 
                + sName + ", your tabletap booking has been created for the table: " 
                + Environment.NewLine + tableID + " in " + roomName + Environment.NewLine + Environment.NewLine 
                + "Regards, TableTap team       www.etabletap.com";
            /// ---- Start EMAIL NOTIFICATION ----\\\

            // new Mail instance
            var eMail = new MimeMessage();
            // Specifies sending address
            eMail.From.Add(new MailboxAddress("eTableTap", "eTableTap@GMail.com"));
            // specifies target address
            eMail.To.Add(new MailboxAddress(fName + " " + sName, email));
            // email subject line
            eMail.Subject = subject;
            // email body
            eMail.Body = new TextPart("plain") { Text = message };

            // calls external method to SmtpClient method to send email
            sendemail(eMail);


            ///--------------------------SMS SECTION----------------------\\\
            // creates strings for SMS message, forPhone generated by the Method phNumFormat
            string smsMessage = "Thank you for choosing TableTap, your booking for table " + tableID + " in room " + roomName;
            string forPhone = phNumFormat(phone);

            //if statement preventing the application from failing if there was a issue detected with "phone" in method phNumFormat  
            if (forPhone == null)
            {
                // POSSIBLE ERROR MESSAGE TO BE ADDED, ELSE LEAVE BLANK
            }
            else
            {
                //calls external method to send SMS via twilio
                sendSMS(smsMessage, forPhone);
            }

        }






        // formats phonenumber to twilio standards input string phone output formattedPhone
        protected string phNumFormat(string phone)
        {
            int length = phone.Length;
            string formattedPhone;

            // if statement level one detects +614 numbers and passes it on
            if (phone.Substring(0, 4) == "+614" && length == 12)
            {
                formattedPhone = phone;
            }
            // Detects if number is a 04 number and replaces 0 with +614
            else if (length == 10 && phone.Substring(0,1) == "0")
            {
                formattedPhone = "+614" + phone.Substring(2);
            }
            // if number does not meet number requirements its passed back as a null
            else
            {
                formattedPhone = null;
            }
                


            return formattedPhone;
        }







        // account creation notification code includes both email and SMS notification requires sendmail(), phNumFormat() and sendSMS methods
        protected void startaccountnotification(string email, string phone, string fName, string sName)
        {
            ///--------------------EMAIL SECTION -------------------------\\\

            // variables for the email address, email subject line, and message respectively
            string subject = fName + "  your TableTap account";
            string message = "Hi " + fName + Environment.NewLine + "Thank you, " + fName + " " 
                + sName + ", your table tap account has been created with the email: " + Environment.NewLine 
                + email + Environment.NewLine + "And the mobile number: " + Environment.NewLine 
                + phone + Environment.NewLine + Environment.NewLine 
                + "Regards, TableTap team       www.etabletap.com";
            /// ---- Start EMAIL NOTIFICATION ----\\\

            // new Mail instance
            var eMail = new MimeMessage();
            // Specifies sending address
            eMail.From.Add(new MailboxAddress("eTableTap", "eTableTap@GMail.com"));
            // specifies target address
            eMail.To.Add(new MailboxAddress(fName + " " + sName, email));
            // email subject line
            eMail.Subject = subject;
            // email body
            eMail.Body = new TextPart("plain") { Text = message };

            // calls external method to SmtpClient method to send email
            sendemail(eMail);


            ///--------------------------SMS SECTION----------------------\\\
            // creates strings for SMS message, forPhone generated by the Method phNumFormat
            string smsMessage = "Thank you for choosing TableTap, your account has been activated";
            string forPhone = phNumFormat(phone);

            //if statement preventing the application from failing if there was a issue detected with "phone" in method phNumFormat  
            if(forPhone == null)
            {
                // POSSIBLE ERROR MESSAGE TO BE ADDED, ELSE LEAVE BLANK
            }
            else
            {
                //calls external method to send SMS via twilio
                sendSMS(smsMessage, forPhone);
            }
            
        }







        // method for sending Emails using SmtpClient, requires input of MimeMessage Variable
        protected void sendemail(MimeMessage eMail)
        {
            using (var client = new SmtpClient())
            {
                // smtp details for G-mail
                client.Connect("smtp.gmail.com", 587);

                // Email account details
                client.Authenticate("eTableTap@GMail.com", "INFT3970");

                client.Send(eMail);
                client.Disconnect(true);
            }
        }





        // Twilio SMS notification method, requires input of a message and a phone number as +614 format
        protected void sendSMS(string message, string phone)
        {
        /// ------------------------------------------------------SUPPLIED BY TWILIO -------------------------- \\\
        // Account Information from Twilio account
        const string accountSid = "ACb3c8b45d687f30b390eace020d89fe75";
        const string authToken = "964f618c7094b7051e85fb65d13c676d";



        TwilioClient.Init(accountSid, authToken);
            // creates message and specifies numbers
            var smsMessage = MessageResource.Create(
                // contains message to be sent
                body: message,
                // Number supplied by Twilio account
                from: new PhoneNumber("+61447465857"),
                // Destination number
                to: new PhoneNumber(phone)
            );

        Console.WriteLine(smsMessage.Sid);
        /// ------------------------------------------------------SUPPLIED BY TWILIO END-------------------------- \\\
        }

    }
}