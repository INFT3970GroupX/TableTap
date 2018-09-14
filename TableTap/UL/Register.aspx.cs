using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TableTap.BusinessLayer.Classes;
using TableTap.Models;

namespace TableTap.UL
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void registerButton_Click(Object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                UserModel newUser = new UserModel();

                newUser.Email = inEmail.Value;
                newUser.Password = inPassword.Value;
                newUser.FirstName = inFirstName.Value;
                newUser.LastName = inLastName.Value;
                newUser.AdminPermission = 0;
                BusinessLayer.UserBLbeau.ProcessAddNewUser(newUser);
                

                Response.Redirect("Home.aspx");
            }
        }
    }
}