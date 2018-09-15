using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TableTap.UL
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void tester()
        {


        }

        ///------------ test method ---------\\\
        protected void loginButton_Click(object sender, EventArgs e)
        {

            string firstName = "Hayden";
            string Surname = "bartlett";
            string email = "hayden.bartlett1@hotmail.com";
            TextBox1.Text = txbUsername.Value;

        }
    }
}