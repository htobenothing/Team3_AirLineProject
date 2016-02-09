using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;

namespace Team3_AirLineProject.staff
{
    public partial class SearchbyUserid1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Visible = false;
            TextBox1.Visible = false;
            Button1.Visible = false;
            AirlionEntities ctx = new AirlionEntities();
            var query = from b in ctx.Bookings
                        where b.idUser == TextBox1.Text
                        join t in ctx.Ticktes on b.idBooking equals t.idBooking
                        join u in ctx.Users on b.idUser equals u.idUser
                        join d in ctx.Departures on b.idDeparture equals d.idDeparture

                        select new { b.idBooking, b.idUser, t.passportNo, u.phoneNo, d.idFlight, b.bookingDate, b.totalPrice, b.bookingStatus };
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }
    }
}