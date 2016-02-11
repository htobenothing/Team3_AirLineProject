using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Controller;

namespace Team3_AirLineProject.userM
{
    public partial class BookingConfirmation : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataReader sqlReader;
            int BookingId = 0;
            string startCity = "";
            string startTime = "";
            string endTime = "";
            string endCity = "";
            decimal totalPrice = (decimal)Session["totalPrice"];
            if (!IsPostBack)
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("select TOP 1 idBooking from booking order by idBooking desc ", con);
                    sqlReader = cmd1.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        BookingId = Convert.ToInt32(sqlReader.GetValue(0));
                    }
                    sqlReader.Close();
                    SqlCommand cmd2 = new SqlCommand("select startCity from Flight where idFlight='" + (string)Session["flightId"] + "'", con);
                    sqlReader = cmd2.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        startCity = (string)sqlReader.GetValue(0);
                    }
                    sqlReader.Close();
                    SqlCommand cmd3 = new SqlCommand("select StartTime from Flight where idFlight='" + (string)Session["flightId"] + "'", con);
                    sqlReader = cmd3.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        TimeSpan t = (TimeSpan)sqlReader.GetValue(0);
                        startTime = t.ToString();
                    }
                    sqlReader.Close();
                    SqlCommand cmd4 = new SqlCommand("select endCity from Flight where idFlight='" + (string)Session["flightId"] + "'", con);
                    sqlReader = cmd4.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        endCity = (string)sqlReader.GetValue(0);
                    }
                    sqlReader.Close();
                    SqlCommand cmd5 = new SqlCommand("select endTime from Flight where idFlight='" + (string)Session["flightId"] + "'", con);
                    sqlReader = cmd5.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        TimeSpan t = (TimeSpan)sqlReader.GetValue(0);
                        endTime = t.ToString();
                    }
                }

            }

            Session["BookingId"] = BookingId;
            bookinfIdLbl.Text = BookingId.ToString();
            flightIdLbl.Text = (string)Session["flightId"];
            departuredateLbl.Text = (string)Session["startDate"];
            departCityLbl.Text = startCity;
            departTimeLbl.Text = startTime;
            arrivalCityLbl.Text = endCity;
            arrivalTimeLbl.Text = endTime;
            totalPriceLbl.Text = totalPrice.ToString();
            List<string> passengerNameList = (List<string>)Session["passengerNameList"];
            List<string> passportNoList = (List<string>)Session["passportNoList"];
            decimal price = totalPrice / passengerNameList.Count;
            for (int i = 0; i < passengerNameList.Count; i++)
            {
                pasngrNameLbl.Text = pasngrNameLbl.Text + passengerNameList[i].ToString() + "<br>";
            }
            for (int i = 0; i < passportNoList.Count; i++)
            {
                passportNoLbl.Text = passportNoLbl.Text + passportNoList[i].ToString() + "<br>";
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("insert into Ticktes values(" + Convert.ToInt32(Session["BookingId"]) + ",'" + passportNoList[i].ToString() + "'," + price + ") ", con);
                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();
                }
            }

        }
    }
}