using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TableTap.BusinessLayer;
using TableTap.Models;

namespace TableTap.UL
{
    public partial class BeauTestPage : System.Web.UI.Page
    {

        //List<UserModel> users = new List<UserModel>();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void TestButton_Click(object sender, EventArgs e)
        {

            UserModel user = new UserModel();

            int id = 1;
            user = UserBL.getUserByID(id);
            txtbxUserID.Text = user.UserID.ToString();

            




        }
    }
}