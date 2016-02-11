using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;
using System.Drawing;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Team3_AirLineProject.view
{
    public partial class SearchFlight : System.Web.UI.Page
    {

        
        
        //string cs = "Data Source=MAMTA-PC\\SQLEXPRESS;Initial Catalog=Airlion;Integrated Security=True";
         string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Calendar1.Visible = false;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    
                    SqlCommand cmd = new SqlCommand("Select distinct(startCity) from Flight");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    FromDropDown.DataSource = cmd.ExecuteReader();
                    FromDropDown.DataBind();
                }
                FromDropDown.Items.Insert(0, new ListItem("--select City--", "0"));
                
            }

        }

        protected void FromDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("Select distinct endCity from Flight where  startCity='" + FromDropDown.SelectedItem.Value + "'");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                con.Open();
                ToDropDownList.DataSource = cmd.ExecuteReader();
                ToDropDownList.DataBind();
            }
            ToDropDownList.Items.Insert(0, new ListItem("--select City--", "0"));
        }

        protected void FinfFlightBtn_Click(object sender, EventArgs e)
        {
            Session["NoOfPassenger"] = passengerNoTxt.Text;
            string startDate = DepDateTxt.Text;
            Session["startDate"] = startDate;
            Response.Redirect(String.Format("FlightResult.aspx?From={0}&To={1}&NoOfPassenger={2}&startDate={3}", FromDropDown.SelectedItem.Value, ToDropDownList.SelectedItem.Value, Convert.ToInt32(passengerNoTxt.Text), DepDateTxt.Text));
        }

        protected void Calendar1_SelectionChanged1(object sender, EventArgs e)
        {
            DepDateTxt.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date <= DateTime.Now)
            {
                e.Cell.BackColor = ColorTranslator.FromHtml("#a9a9a9");
                e.Day.IsSelectable = false;

            }

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = !Calendar1.Visible;
        }
    }
}