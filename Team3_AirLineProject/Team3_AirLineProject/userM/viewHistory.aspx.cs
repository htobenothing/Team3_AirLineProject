using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;

namespace Team3_AirLineProject.userM
{
    public partial class ViewHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            User ur = (User)Session["LoginUser"];
            
            
            String dates = txtFDT.Text;
            String dates2 = txtTDT.Text;
            if (dates != "" && dates2 != "")
            {
                DateTime fd = Convert.ToDateTime(dates);

                DateTime td = Convert.ToDateTime(dates2);
                string userID = ur.idUser;
                AirlionEntities ctx = new AirlionEntities();

                var q = from x in ctx.Bookings
                        join u in ctx.Users on x.idUser equals u.idUser
                        join d in ctx.Departures on x.idDeparture equals d.idDeparture
                        join f in ctx.Flights on d.idFlight equals f.idFlight
                        where x.bookingDate > fd && x.bookingDate < td && x.idUser == userID
                        select new { x.idUser, x.bookingDate, d.idFlight, startdate = d.startDate.ToString(), enddate = d.endDate.ToString(), f.startCity, f.endCity, f.StartTime, f.endTime, x.totalPrice, x.bookingStatus };
                GridView1.DataSource = q.ToList();
                GridView1.DataBind();
            }
            if (dates != "" && dates2 == "")
            {
                DateTime fd = Convert.ToDateTime(dates);

                
                string userID = ur.idUser;
                AirlionEntities ctx = new AirlionEntities();

                var q = from x in ctx.Bookings
                        join u in ctx.Users on x.idUser equals u.idUser
                        join d in ctx.Departures on x.idDeparture equals d.idDeparture
                        join f in ctx.Flights on d.idFlight equals f.idFlight
                        where x.bookingDate > fd  && x.idUser == userID
                        select new { x.idUser, x.bookingDate, d.idFlight, startdate = d.startDate.ToString(), enddate = d.endDate.ToString(), f.startCity, f.endCity, f.StartTime, f.endTime, x.totalPrice, x.bookingStatus };
                GridView1.DataSource = q.ToList();
                GridView1.DataBind();
            }
            if (dates == "" && dates2 != "")
            {
                

                DateTime td = Convert.ToDateTime(dates2);
                string userID = ur.idUser;
                AirlionEntities ctx = new AirlionEntities();

                var q = from x in ctx.Bookings
                        join u in ctx.Users on x.idUser equals u.idUser
                        join d in ctx.Departures on x.idDeparture equals d.idDeparture
                        join f in ctx.Flights on d.idFlight equals f.idFlight
                        where  x.bookingDate < td && x.idUser == userID
                        select new { x.idUser, x.bookingDate, d.idFlight, startdate = d.startDate.ToString(), enddate = d.endDate.ToString(), f.startCity, f.endCity, f.StartTime, f.endTime, x.totalPrice, x.bookingStatus };
                GridView1.DataSource = q.ToList();
                GridView1.DataBind();
            }
            if (dates == "" && dates2 == "")
            {
                string userID = ur.idUser;
                AirlionEntities ctx = new AirlionEntities();

                var q = from x in ctx.Bookings
                        join u in ctx.Users on x.idUser equals u.idUser
                        join d in ctx.Departures on x.idDeparture equals d.idDeparture
                        join f in ctx.Flights on d.idFlight equals f.idFlight
                        where x.idUser == userID
                        select new { x.idUser, x.bookingDate, d.idFlight, startdate = d.startDate.ToString(), enddate = d.endDate.ToString(), f.startCity, f.endCity, f.StartTime, f.endTime, x.totalPrice, x.bookingStatus };
                GridView1.DataSource = q.ToList();
                GridView1.DataBind();
            }
            
        }

        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void ImageButton2_Click1(object sender, ImageClickEventArgs e)
        {
            Calendar2.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtFDT.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            txtTDT.Text = Calendar2.SelectedDate.ToShortDateString();
            Calendar2.Visible = false;
        }
    }
}