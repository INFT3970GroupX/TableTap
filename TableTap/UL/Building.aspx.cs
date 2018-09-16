using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TableTap.Models;
using TableTap.BusinessLayer.Classes;
using System.Configuration;

namespace TableTap.UL
{
    public partial class Building : System.Web.UI.Page
    {
        List<RoomModel> rooms = new List<RoomModel>();

        protected void Page_Load(object sender, EventArgs e)
        {
            int ID = Int32.Parse(Request.QueryString["ID"]);
            rooms = RoomBL.fillRoomsList();

            if (!IsPostBack) //need this to stop it reverting to the top value every button click
            {
                roomDropdown.DataSource = rooms;
                roomDropdown.DataValueField = "RoomID";
                roomDropdown.DataTextField = "RoomName";
                roomDropdown.DataBind();
            }
        }

        protected void goToRoomButton_Click(Object sender, EventArgs e)
        {
            RoomModel rm = new RoomModel();

            rm = rooms.Where(r => r.RoomID == Int32.Parse(roomDropdown.Text)).FirstOrDefault(); //grabs single selected building

            int id = rm.BuildingID;

            string url = ConfigurationManager.AppSettings["UnsecurePath"] + "Room.aspx?id=" + id;
            Response.Redirect(url);

        }
    }
}