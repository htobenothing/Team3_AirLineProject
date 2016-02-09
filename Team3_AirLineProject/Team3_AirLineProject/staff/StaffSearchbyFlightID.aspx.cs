using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;

namespace Team3_AirLineProject.staff
{
    public partial class StaffSearchbyFlightID1 : System.Web.UI.Page
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
            var q = from x in ctx.Flights
                    where x.idFlight == TextBox1.Text
                    select new { x.idFlight, x.startCity, x.endCity, x.StartTime, x.endTime, x.price, x.totalSeatNo, x.status };
            GridView1.DataSource = q.ToList();
            GridView1.DataBind();
            TextBox1.Text = "";
        }
    }
}