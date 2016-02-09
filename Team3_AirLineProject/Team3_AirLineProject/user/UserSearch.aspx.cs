using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;

namespace Team3_AirLineProject.user
{
    public partial class UserSearch1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //AirlionEntities1 ctx = new AirlionEntities1();
            //var q = from x in ctx.Bookings
            //        where x.idUser == TextBox1.Text
            //        select new { x.idUser, x.bookingDate, x.bookingStatus, x.totalPrice };
            //GridView1.DataSource = q.ToList();
            //GridView1.DataBind();
            // TextBox1.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Visible = false;
            TextBox1.Visible = false;
            Button1.Visible = false;
            AirlionEntities ctx = new AirlionEntities();
            var q = from x in ctx.Bookings
                    join d in ctx.Departures on x.idDeparture equals d.idDeparture
                    where x.idUser == TextBox1.Text
                    select new { x.idUser, x.bookingDate, d.idFlight, d.startDate, d.endDate, x.bookingStatus, x.totalPrice };
            GridView1.DataSource = q.ToList();
            GridView1.DataBind();
            TextBox1.Text = "";
        }

        //protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        //{
        //    Calendar1.Visible = true;
        //}

        //protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        //{
        //    Calendar2.Visible = true;
        //}

        //protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        //{
        //    TextBox2.Text = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
        //    Calendar1.Visible = false;
        //}

        //protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        //{
        //    TextBox3.Text = Calendar2.SelectedDate.ToString("dd/MM/yyyy");
        //    Calendar2.Visible = false;
        //}
    }
}