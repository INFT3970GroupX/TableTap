using System;
// remove data access
using TableTap.DataAccessLayer;
// remove end
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

            string password = txbPassword.Value;
            string username = txbUsername.Value;
            bool test = UserDAL.loginCheck(username, password);
            if(test == true)
            {
                TextBox1.Text = "LOGGED ON";
                    
            }
            else
            {
                TextBox1.Text = "Failed";
            }






        }


    }
}