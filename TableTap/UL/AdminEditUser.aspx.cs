using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TableTap.DataAccessLayer;


namespace TableTap.UL
{
    public partial class AdminEditUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void searchButton_Click(Object sender, EventArgs e)
        {
            if(txbUsername.Value == null)
            {
            }
            else
            {
                List<string> record = new List<string>();
                record = UserDAL.AdminUserEditCheck(txbUsername.Value);
            }



        }
    }
}