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

namespace Team3_AirLineProject.view
{
    public partial class FlightResult : System.Web.UI.Page
    {
        SqlDataReader sqlReader;
        string cs = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack )
            {
                if (Session["startDate"] != null)
                {
                    // string departuredate = Request.QueryString["DepartureDate"];
                    string startDate = (string)Session["startDate"];
                    DateTime myDate = DateTime.Parse(startDate);
                    string format = "yyyy-MM-dd";
                    Response.Write(myDate.ToString(format));
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("select distinct f.idFlight as [Flight No.], f.StartTime as [Departure Time], f.endTime as [Arrival Time],  f.price as [Price] from Flight f,Departure d where " +
                              " startCity='" + Request.QueryString["From"] + "' and endCity='" + Request.QueryString["To"] + "' and startDate='" + myDate.ToString(format) + "'");
                        cmd.Connection = con;
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        flightgridView.DataSource = dt;
                        flightgridView.DataBind();

                    }
                }
                
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            int departureId = 0;
            string startDate = (string)Session["startDate"];        ///////////
            DateTime myDate = DateTime.Parse(startDate);
            string format = "yyyy-MM-dd";
            foreach (GridViewRow row in flightgridView.Rows)//name the gridview correctly
            {
                int count = flightgridView.Rows.Count;
                RadioButton rb = (RadioButton)row.FindControl("RadioButton1");
                if (rb != null)
                {
                    if (rb.Checked == true)
                    {
                        String flightId = row.Cells[1].Text;
                        using (SqlConnection con = new SqlConnection(cs))
                        {
                            con.Open();
                            SqlCommand cmd1 = new SqlCommand("select  idDeparture from Departure where idFlight='" + flightId + "' and startDate='" + myDate.ToString(format) + "'");
                            cmd1.Connection = con;
                            sqlReader = cmd1.ExecuteReader();
                            while (sqlReader.Read())
                            {
                                departureId = Convert.ToInt32(sqlReader.GetValue(0));
                            }
                            sqlReader.Close();
                        }
                        Session["flightId"] = flightId;
                        Session["departureId"] = departureId;

                        if (Session["LoginUser"] != null)
                        {
                            string basepath = "";
                            User ur =(User) Session["LoginUser"];
                            string role = ur.idRole;
                            switch (role)
                            {
                                case "user":
                                    basepath = "~/userM/";
                                    break;
                                case "staff":
                                    basepath = "~/staff/";
                                    break;
                            }
                                
                            Response.Redirect(basepath+"SelectPassenger.aspx");

                        }
                        else
                        {
                            Response.Redirect("~/view/Login.aspx");
                        }
                        
                    }
                }

            }

        }
    }
}