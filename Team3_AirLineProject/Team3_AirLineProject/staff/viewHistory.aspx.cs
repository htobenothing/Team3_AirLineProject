using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;

namespace Team3_AirLineProject.staff
{
    public partial class ViewHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Visible = false;
        }
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

            Calendar1.Visible = !Calendar1.Visible;
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Calendar2.Visible = !Calendar2.Visible;
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
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            // change something about it
            AirlionEntities ctx = new AirlionEntities();

            if ((!string.IsNullOrEmpty(txtuid.Text)) && (!string.IsNullOrEmpty(txtFID.Text))
                && (!string.IsNullOrEmpty(txtFDT.Text)) && (!string.IsNullOrEmpty(txtTDT.Text)))
            {
                //  Label4.Text = txtFDT.Text;
                String dates = txtFDT.Text;
                DateTime fd = Convert.ToDateTime(dates);
                String dates2 = txtTDT.Text;
                DateTime td = Convert.ToDateTime(dates2);

                var q = from x in ctx.Bookings
                        join u in ctx.Users on x.idUser equals u.idUser
                        join t in ctx.Ticktes on x.idBooking equals t.idBooking
                        join d in ctx.Departures on x.idDeparture equals d.idDeparture
                        join f in ctx.Flights on d.idFlight equals f.idFlight
                        where x.bookingDate > fd && x.bookingDate < td && f.idFlight == txtFID.Text && x.idUser == txtuid.Text
                        select new
                        {
                            x.idUser,
                            u.phoneNo,
                            x.bookingDate,
                            t.passportNo,
                            d.idFlight,
                            startdate = d.startDate.ToString(),
                            enddate = d.endDate.ToString()
                            ,
                            f.startCity,
                            f.endCity,
                            f.StartTime,
                            f.endTime,
                            x.totalPrice,
                            x.bookingStatus
                        };
                GridView1.DataSource = q.ToList();
                GridView1.DataBind();
            }
            else if ((!string.IsNullOrEmpty(txtuid.Text)) && (string.IsNullOrEmpty(txtFID.Text))
                && (string.IsNullOrEmpty(txtFDT.Text)) && (string.IsNullOrEmpty(txtTDT.Text)))
            {
                var query = from b in ctx.Bookings
                            where b.idUser == txtuid.Text
                            join t in ctx.Ticktes on b.idBooking equals t.idBooking
                            join u in ctx.Users on b.idUser equals u.idUser
                            join d in ctx.Departures on b.idDeparture equals d.idDeparture
                            join f in ctx.Flights on d.idFlight equals f.idFlight
                            select new { b.idBooking, b.idUser, d.idFlight, u.phoneNo, t.passportNo, startdate = d.startDate.ToString(), enddate = d.endDate.ToString(), f.startCity, f.endCity, f.StartTime, f.endTime, b.bookingDate, b.totalPrice, b.bookingStatus };
                GridView1.DataSource = query.ToList();
                GridView1.DataBind();
            }
            else if ((string.IsNullOrEmpty(txtuid.Text)) && (!string.IsNullOrEmpty(txtFID.Text))
                && (string.IsNullOrEmpty(txtFDT.Text)) && (string.IsNullOrEmpty(txtTDT.Text)))
            {
                var q = from b in ctx.Bookings
                        join d in ctx.Departures on b.idDeparture equals d.idDeparture
                        join t in ctx.Ticktes on b.idBooking equals t.idBooking
                        join f in ctx.Flights on d.idFlight equals f.idFlight
                        join u in ctx.Users on b.idUser equals u.idUser
                        where f.idFlight == txtFID.Text
                        select new { b.idBooking, b.idUser, d.idFlight, u.phoneNo, t.passportNo, startdate = d.startDate.ToString(), enddate = d.endDate.ToString(), f.startCity, f.endCity, f.StartTime, f.endTime, b.bookingDate, b.totalPrice, b.bookingStatus };
                GridView1.DataSource = q.ToList();
                GridView1.DataBind();

            }
            else if ((!string.IsNullOrEmpty(txtuid.Text)) && (!string.IsNullOrEmpty(txtFID.Text))
            && (string.IsNullOrEmpty(txtFDT.Text)) && (string.IsNullOrEmpty(txtTDT.Text)))
            {
                var query = from b in ctx.Bookings
                            join d in ctx.Departures on b.idDeparture equals d.idDeparture
                            join t in ctx.Ticktes on b.idBooking equals t.idBooking
                            join f in ctx.Flights on d.idFlight equals f.idFlight
                            join u in ctx.Users on b.idUser equals u.idUser
                            where f.idFlight == txtFID.Text && b.idUser == txtuid.Text
                            select new { b.idBooking, b.idUser, d.idFlight, u.phoneNo, t.passportNo, startdate = d.startDate.ToString(), enddate = d.endDate.ToString(), f.startCity, f.endCity, f.StartTime, f.endTime, b.bookingDate, b.totalPrice, b.bookingStatus };
                GridView1.DataSource = query.ToList();
                GridView1.DataBind();

            }
            else if ((!string.IsNullOrEmpty(txtuid.Text)) && (string.IsNullOrEmpty(txtFID.Text))
                && (!string.IsNullOrEmpty(txtFDT.Text)) && (!string.IsNullOrEmpty(txtTDT.Text)))
            {
                //String fromdate = txtFDT.Text;
                //String todate = txtTDT.Text;
                //Date fd = Date.ParseExact(fromdate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                //Date td = Date.ParseExact(todate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                String dates = txtFDT.Text;
                DateTime fd = Convert.ToDateTime(dates);
                String dates2 = txtTDT.Text;
                DateTime td = Convert.ToDateTime(dates2);
                var q = from x in ctx.Bookings
                        join u in ctx.Users on x.idUser equals u.idUser
                        join d in ctx.Departures on x.idDeparture equals d.idDeparture
                        join f in ctx.Flights on d.idFlight equals f.idFlight
                        where x.bookingDate > fd && x.bookingDate < td && x.idUser == txtuid.Text
                        select new { x.idUser, u.phoneNo, x.bookingDate, d.idFlight, startdate = d.startDate.ToString(), enddate = d.endDate.ToString(), f.startCity, f.endCity, f.StartTime, f.endTime, x.totalPrice, x.bookingStatus };
                GridView1.DataSource = q.ToList();
                GridView1.DataBind();

            }
            else if ((string.IsNullOrEmpty(txtuid.Text)) && (!string.IsNullOrEmpty(txtFID.Text))
                && (!string.IsNullOrEmpty(txtFDT.Text)) && (!string.IsNullOrEmpty(txtTDT.Text)))
            {
                String dates = txtFDT.Text;
                DateTime fd = Convert.ToDateTime(dates);
                String dates2 = txtTDT.Text;
                DateTime td = Convert.ToDateTime(dates2);
                var q = from x in ctx.Bookings
                        join u in ctx.Users on x.idUser equals u.idUser
                        join d in ctx.Departures on x.idDeparture equals d.idDeparture
                        join f in ctx.Flights on d.idFlight equals f.idFlight
                        where x.bookingDate > fd && x.bookingDate < td && f.idFlight == txtFID.Text
                        select new { x.idUser, u.phoneNo, x.bookingDate, d.idFlight, startdate = d.startDate.ToString(), enddate = d.endDate.ToString(), f.startCity, f.endCity, f.StartTime, f.endTime, x.totalPrice, x.bookingStatus };
                GridView1.DataSource = q.ToList();
                GridView1.DataBind();
            }
            else if ((string.IsNullOrEmpty(txtuid.Text)) && (string.IsNullOrEmpty(txtFID.Text))
            && (!string.IsNullOrEmpty(txtFDT.Text)) && (!string.IsNullOrEmpty(txtTDT.Text)))
            {
                //DateTime d1 = DateTime.Parse(txtFDT.Text);
                //DateTime d2 = DateTime.Parse(txtTDT.Text);
                String dates = txtFDT.Text;
                DateTime fd = Convert.ToDateTime(dates);
                String dates2 = txtTDT.Text;
                DateTime td = Convert.ToDateTime(dates2);
                var q = from x in ctx.Bookings
                        join u in ctx.Users on x.idUser equals u.idUser
                        join d in ctx.Departures on x.idDeparture equals d.idDeparture
                        join f in ctx.Flights on d.idFlight equals f.idFlight
                        where x.bookingDate > fd && x.bookingDate < td
                        select new { x.idUser, u.phoneNo, x.bookingDate, d.idFlight, startdate = d.startDate.ToString(), enddate = d.endDate.ToString(), f.startCity, f.endCity, f.StartTime, f.endTime, x.totalPrice, x.bookingStatus };
                GridView1.DataSource = q.ToList();
                GridView1.DataBind();
            }
            else if ((string.IsNullOrEmpty(txtuid.Text)) && (string.IsNullOrEmpty(txtFID.Text))
            && (!string.IsNullOrEmpty(txtFDT.Text)) && (string.IsNullOrEmpty(txtTDT.Text)))
            {

                String dates = txtFDT.Text;
                DateTime fd = Convert.ToDateTime(dates);

                var q = from x in ctx.Bookings
                        join u in ctx.Users on x.idUser equals u.idUser
                        join d in ctx.Departures on x.idDeparture equals d.idDeparture
                        join f in ctx.Flights on d.idFlight equals f.idFlight
                        where x.bookingDate > fd
                        select new { x.idUser, u.phoneNo, x.bookingDate, d.idFlight, startdate = d.startDate.ToString(), enddate = d.endDate.ToString(), f.startCity, f.endCity, f.StartTime, f.endTime, x.totalPrice, x.bookingStatus };
                GridView1.DataSource = q.ToList();
                GridView1.DataBind();
            }
            else if ((string.IsNullOrEmpty(txtuid.Text)) && (string.IsNullOrEmpty(txtFID.Text))
            && (string.IsNullOrEmpty(txtFDT.Text)) && (!string.IsNullOrEmpty(txtTDT.Text)))
            {
                String dates2 = txtTDT.Text;
                DateTime td = Convert.ToDateTime(dates2);
                var q = from x in ctx.Bookings
                        join u in ctx.Users on x.idUser equals u.idUser
                        join d in ctx.Departures on x.idDeparture equals d.idDeparture
                        join f in ctx.Flights on d.idFlight equals f.idFlight
                        where x.bookingDate < td
                        select new { x.idUser, u.phoneNo, x.bookingDate, d.idFlight, startdate = d.startDate.ToString(), enddate = d.endDate.ToString(), f.startCity, f.endCity, f.StartTime, f.endTime, x.totalPrice, x.bookingStatus };
                GridView1.DataSource = q.ToList();
                GridView1.DataBind();
            }
            else if ((!string.IsNullOrEmpty(txtuid.Text)) && (string.IsNullOrEmpty(txtFID.Text))
            && (string.IsNullOrEmpty(txtFDT.Text)) && (!string.IsNullOrEmpty(txtTDT.Text)))
            {
                String dates2 = txtTDT.Text;
                DateTime td = Convert.ToDateTime(dates2);
                var q = from x in ctx.Bookings
                        join u in ctx.Users on x.idUser equals u.idUser
                        join d in ctx.Departures on x.idDeparture equals d.idDeparture
                        join f in ctx.Flights on d.idFlight equals f.idFlight
                        where x.bookingDate < td && x.idUser == txtuid.Text
                        select new { x.idUser, u.phoneNo, x.bookingDate, d.idFlight, startdate = d.startDate.ToString(), enddate = d.endDate.ToString(), f.startCity, f.endCity, f.StartTime, f.endTime, x.totalPrice, x.bookingStatus };
                GridView1.DataSource = q.ToList();
                GridView1.DataBind();
            }
            else if ((!string.IsNullOrEmpty(txtuid.Text)) && (string.IsNullOrEmpty(txtFID.Text))
        && (!string.IsNullOrEmpty(txtFDT.Text)) && (string.IsNullOrEmpty(txtTDT.Text)))
            {

                String dates = txtFDT.Text;
                DateTime fd = Convert.ToDateTime(dates);

                var q = from x in ctx.Bookings
                        join u in ctx.Users on x.idUser equals u.idUser
                        join d in ctx.Departures on x.idDeparture equals d.idDeparture
                        join f in ctx.Flights on d.idFlight equals f.idFlight
                        where x.bookingDate > fd && x.idUser == txtuid.Text
                        select new { x.idUser, u.phoneNo, x.bookingDate, d.idFlight, startdate = d.startDate.ToString(), enddate = d.endDate.ToString(), f.startCity, f.endCity, f.StartTime, f.endTime, x.totalPrice, x.bookingStatus };
                GridView1.DataSource = q.ToList();
                GridView1.DataBind();
            }
            else if ((string.IsNullOrEmpty(txtuid.Text)) && (!string.IsNullOrEmpty(txtFID.Text))
    && (!string.IsNullOrEmpty(txtFDT.Text)) && (string.IsNullOrEmpty(txtTDT.Text)))
            {

                String dates = txtFDT.Text;
                DateTime fd = Convert.ToDateTime(dates);

                var q = from x in ctx.Bookings
                        join u in ctx.Users on x.idUser equals u.idUser
                        join d in ctx.Departures on x.idDeparture equals d.idDeparture
                        join f in ctx.Flights on d.idFlight equals f.idFlight
                        where x.bookingDate > fd && f.idFlight == txtFID.Text
                        select new { x.idUser, u.phoneNo, x.bookingDate, d.idFlight, startdate = d.startDate.ToString(), enddate = d.endDate.ToString(), f.startCity, f.endCity, f.StartTime, f.endTime, x.totalPrice, x.bookingStatus };
                GridView1.DataSource = q.ToList();
                GridView1.DataBind();
            }
            else if ((string.IsNullOrEmpty(txtuid.Text)) && (!string.IsNullOrEmpty(txtFID.Text))
       && (string.IsNullOrEmpty(txtFDT.Text)) && (!string.IsNullOrEmpty(txtTDT.Text)))
            {
                String dates2 = txtTDT.Text;
                DateTime td = Convert.ToDateTime(dates2);
                var q = from x in ctx.Bookings
                        join u in ctx.Users on x.idUser equals u.idUser
                        join d in ctx.Departures on x.idDeparture equals d.idDeparture
                        join f in ctx.Flights on d.idFlight equals f.idFlight
                        where x.bookingDate < td && f.idFlight == txtFID.Text
                        select new { x.idUser, u.phoneNo, x.bookingDate, d.idFlight, startdate = d.startDate.ToString(), enddate = d.endDate.ToString(), f.startCity, f.endCity, f.StartTime, f.endTime, x.totalPrice, x.bookingStatus };
                GridView1.DataSource = q.ToList();
                GridView1.DataBind();
            }
            else
            {
                Label3.Visible = true;
                Label3.Text = "No Records Available";
            }
        }
    }
}