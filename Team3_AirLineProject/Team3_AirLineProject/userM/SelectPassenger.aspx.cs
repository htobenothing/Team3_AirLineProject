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
    public partial class SelectPassenger : System.Web.UI.Page
    {
        public static int departureId = 0;
        
        
        string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            // List<>
            SqlDataReader sqlReader;
            if (!IsPostBack)
            {
                User ur =(User)Session["LoginUser"];
                string userId = ur.idUser;
                departureId = Convert.ToInt32(Session["deparureId"]);
                
                string startDate = (string)Session["startDate"];
                DateTime myDate = DateTime.Parse(startDate);
                string format = "yyyy-MM-dd";
                Response.Write(myDate.ToString(format));
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("select pasName as [Passenger Name],passportNo as [Passport No.],CONVERT(VARCHAR(11),dateOfBirth,106) as [DOB],gender as [Gender] from Passengers where idUser='" + userId + "'");
                    cmd2.Connection = con;
                    DataTable dt = new DataTable();
                    dt.Load(cmd2.ExecuteReader());
                    SelectPessengerView.DataSource = dt;
                    SelectPessengerView.DataBind();
                    // con.Close();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int PassengerCount = Convert.ToInt32(Session["NoOfPassenger"]);
            SqlDataReader sqlReader;
            string name = "";
            string passportNo = "";
            decimal price = 0;
            decimal totalPrice = 0;
            List<string> passengerNameList = new List<string>();
            List<string> passportNoList = new List<string>();
            departureId = Convert.ToInt32(Session["departureId"]);
            string flightId = (string)Session["flightId"];

            User ur = (User)Session["LoginUser"];
            string userId = ur.idUser;

            int count = 0;
            if (SelectPessengerView.Rows.Count > 0)
            {
                for (int i = 0; i < SelectPessengerView.Rows.Count; i++)
                {
                    CheckBox cbx = (CheckBox)SelectPessengerView.Rows[i].FindControl("selectPasngrChkBox");
                    if (cbx != null)
                    {
                        if (cbx.Checked)
                        {
                            count = count + 1;
                            name = SelectPessengerView.Rows[i].Cells[1].Text;
                            passportNo = SelectPessengerView.Rows[i].Cells[2].Text;
                            passengerNameList.Add(name);
                            passportNoList.Add(passportNo);

                        }

                    }
                }
                Session["passengerNameList"] = passengerNameList;
                Session["passportNoList"] = passportNoList;
                if (count != PassengerCount)
                {

                    System.Windows.Forms.MessageBox.Show("No. of passengers and seleced passengers are not matched,select again!");
                    Response.Redirect("SelectPassenger.aspx");

                }

                else
                {
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        SqlTransaction transaction;
                        con.Open();
                        SqlCommand cmd3 = new SqlCommand("select price  from Flight where idFlight='" + flightId + "'", con);
                        sqlReader = cmd3.ExecuteReader();
                        while (sqlReader.Read())
                        {
                            price = Convert.ToDecimal(sqlReader.GetValue(0));
                        }
                        sqlReader.Close();
                        totalPrice = price * count;
                        Session["totalPrice"] = totalPrice;
                        try
                        {
                            SqlCommand cmd4 = new SqlCommand("insert into Booking values(" + departureId + ",'" + userId + "','" + DateTime.Now.ToShortDateString() + "','Booked'," + (price * count) + ");", con);
                            int x = cmd4.ExecuteNonQuery();
                            SqlCommand cmd5 = new SqlCommand(" update Departure set vacancy=(vacancy-" + count + ") where idDeparture=" + departureId + ";", con);
                            int y = cmd5.ExecuteNonQuery();

                        }
                        catch (SqlException sqlError)
                        {
                            Console.Write(sqlError);
                        }
                        Response.Redirect("BookingConfirmation.aspx");
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(" Please Select Passenger!");
                Response.Redirect("SelectPassenger.aspx");

            }
        }

        protected void AddPsnBtn_Click(object sender, EventArgs e)
        {
            // Response.Redirect(String.Format("AddPassengerForm.aspx?userId={0}&departureId={1}", userId, departureId));
            Response.Redirect("AddPassengerForm.aspx");
        }
    }
}