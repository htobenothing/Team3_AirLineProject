using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using Controller;
using System.Data.SqlClient;

namespace Team3_AirLineProject.staff
{
    public partial class CancelConfirm : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataReader sqlReader;
            string idFlight = "";
            string startDate = "";
            string departureCity = "";
            string arrivalCity = "";
            string departureTime = "";
            string arrivalTime = "";
            decimal totalPrice = 0;
            int idBooking = Convert.ToInt32(Session["idBooking"]);
            List<string> passportNoList = new List<string>();
            List<string> pasngraNameList = new List<string>();

            if (!IsPostBack)
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("select idFlight from  Departure where idDeparture in(select idDeparture from Booking where idBooking=" + idBooking + ") ", con);
                    sqlReader = cmd1.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        idFlight = (string)sqlReader.GetValue(0);

                    }
                    sqlReader.Close();
                    SqlCommand cmd2 = new SqlCommand("select startDate from  Departure where idDeparture in(select idDeparture from Booking where idBooking=" + idBooking + ") ", con);
                    sqlReader = cmd2.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        DateTime dt = (DateTime)sqlReader.GetValue(0);
                        startDate = dt.ToShortDateString();

                    }
                    sqlReader.Close();
                    SqlCommand cmd3 = new SqlCommand("select startCity,endCity,StartTime,endTime from Flight where idFlight in(select idFlight from  Departure where idDeparture in(select idDeparture from Booking where idBooking=" + idBooking + ")); ", con);
                    sqlReader = cmd3.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        departureCity = (string)sqlReader.GetValue(0);
                        arrivalCity = (string)sqlReader.GetValue(1);
                        TimeSpan t1 = (TimeSpan)sqlReader.GetValue(2);
                        departureTime = t1.ToString();
                        TimeSpan t2 = (TimeSpan)sqlReader.GetValue(3);
                        arrivalTime = t2.ToString();
                    }
                    sqlReader.Close();
                    SqlCommand cmd4 = new SqlCommand("select passportNo from Ticktes where idBooking=" + idBooking + ";", con);
                    sqlReader = cmd4.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        string passportNo = (string)sqlReader.GetValue(0);
                        passportNoList.Add(passportNo);

                    }
                    sqlReader.Close();
                    SqlCommand cmd5 = new SqlCommand(" select pasName from Passengers where passportNo in(select passportNo from Ticktes where idBooking=" + idBooking + ");", con);
                    sqlReader = cmd5.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        string name = (string)sqlReader.GetValue(0);
                        pasngraNameList.Add(name);

                    }
                    sqlReader.Close();
                    SqlCommand cmd6 = new SqlCommand("select totalPrice from Booking where idBooking=" + idBooking + ";", con);
                    sqlReader = cmd6.ExecuteReader();
                    while (sqlReader.Read())
                    {
                        totalPrice = Convert.ToDecimal(sqlReader.GetValue(0));

                    }


                }
                bookinfIdLbl.Text = idBooking.ToString();
                flightIdLbl.Text = idFlight;
                departuredateLbl.Text = startDate;
                departCityLbl.Text = departureCity;
                departTimeLbl.Text = departureTime;
                arrivalCityLbl.Text = arrivalCity;
                arrivalTimeLbl.Text = arrivalTime;
                totalPriceLbl.Text = totalPrice.ToString();

                for (int i = 0; i < passportNoList.Count; i++)
                {
                    passportNoLbl.Text = passportNoLbl.Text + passportNoList[i].ToString() + "<br>";
                }
                for (int j = 0; j < pasngraNameList.Count; j++)
                {
                    pasngrNameLbl.Text = pasngrNameLbl.Text + pasngraNameList[j].ToString() + "<br>";
                }


            }
        }
    }
}