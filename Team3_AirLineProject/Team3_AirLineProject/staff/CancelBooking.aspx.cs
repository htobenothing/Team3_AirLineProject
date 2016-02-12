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

namespace Team3_AirLineProject.staff
{
    public partial class CancellBooking : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        SqlDataReader sqlReader;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlTransaction transaction;
            int bookingId = Convert.ToInt32(bookinIdTxt.Text);
            int pasCount = 0;
            Session["idBooking"] = bookinIdTxt.Text;
            AirlionEntities cnx = new AirlionEntities();
            Booking b = cnx.Bookings.Find(Convert.ToInt32 (bookinIdTxt.Text));
            if (b != null)
            {
                if (b.bookingStatus != "cancelled")
                {
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        con.Open();
                        SqlCommand cmd1 = new SqlCommand("select count(*) from Ticktes where idBooking=" + bookingId + ";", con);
                        sqlReader = cmd1.ExecuteReader();
                        while (sqlReader.Read())
                        {
                            pasCount = Convert.ToInt32(sqlReader.GetValue(0));
                        }
                        sqlReader.Close();
                        try
                        {
                            SqlCommand cmd2 = new SqlCommand("update Booking set bookingStatus='cancelled' where idBooking=" + bookingId + ";", con);
                            cmd2.Connection = con;
                            int x = cmd2.ExecuteNonQuery();
                            SqlCommand cmd3 = new SqlCommand("update Departure set vacancy=vacancy+" + pasCount + " where idDeparture in(select idDeparture from Booking where idBooking=" + bookingId + " );", con);
                            cmd3.Connection = con;
                            int y = cmd3.ExecuteNonQuery();

                        }
                        catch (SqlException sqlError)
                        {
                            Console.Write(sqlError);

                        }
                        Response.Redirect("CancelConfirm.aspx");

                    }
                }
                else
                {
                    Label2.Text = "The Booking already Cancel";
                }
            }
            else
            {
                Label2.Text = "The Booking not exist";
            }
            
           
        }
    }
}