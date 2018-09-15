using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/// REMOVE
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
                lblStatus.Text = "Please enter a valid Email";
            }
            else
            {
                List<string> record = new List<string>();

                /// REDIRECT VIA BL LAYER
                record = UserDAL.AdminUserEditCheck(txbUsername.Value);

                if(record == null)
                {
                    lblStatus.Text = "User not found, please try again";
                }
                else
                {
                    lblUserID.Text = record[0];
                    Email.Value = record[1];
                    inPassword.Value = record[2];
                    inFirstName.Value = record[3];
                    inLastName.Value = record[4];

                    if(record[5] != "0")
                    {
                        chkAdmin.Checked = true;
                    }
                    else
                    {
                        chkAdmin.Checked = false;
                    }

                }
            }
        }

        protected void saveButton_Click(Object sender, EventArgs e)
        {

        }
    }
}