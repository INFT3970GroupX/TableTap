using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TableTap.BusinessLayer;
using TableTap.Models;
using TableTap.DataAccessLayer; //REMOVE
using TableTap.DataAccessLayer.Classes;

namespace TableTap.UL
{
    public partial class AdminEditTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void submitButton_Click(object sender, EventArgs e)
        {

        }



        protected void searchButton_Click(Object sender, EventArgs e)
        {
            string tableID = inptable.Value;
            List<string> record = new List<string>();
            record = TableDAL.LoadTable(tableID);
            lblTableID.Text = record[0];
            INroomID.Value = record[1];
            inpersonCapacity.Value = record[2];
            inCatagory.Value = record[3];
        }

        protected void deleteButton_Click(Object sender, EventArgs e)
        {

        }

        protected void cancelButton_Click(Object sender, EventArgs e)
        {
            Response.Redirect("AdminHome.aspx");
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}