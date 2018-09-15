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

        ///------------ test method ---------\\\ OBSELETE DELETE ME 
        protected void loginButton_Click(object sender, EventArgs e)
        {

            string password = txbPassword.Value;
            string username = txbUsername.Value;
            int status = UserDAL.loginCheck(username, password);
            if(status == 1)
            {

                // 1 = login success
                TextBox1.Text = "LOGGED ON";
                    
            }
            else if(status == 2)
            {
                // 2 = password failure
                TextBox1.Text = "Password Incorrect";
            }
            else
            {
                TextBox1.Text = "Username not found";
            }






        }


    }
}