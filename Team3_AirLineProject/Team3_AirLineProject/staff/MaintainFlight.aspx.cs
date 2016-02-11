using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;

namespace Team3_AirLineProject.staff
{
    public partial class MaintainFlight : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Session["LoginUser"] !=null)
            {
                AirlionEntities ctx = new AirlionEntities();
                var q = from x in ctx.Flights select x;
                GridView1.DataSource = q.ToList();
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow r in GridView1.Rows)
            {
                if (((CheckBox)r.Cells[0].FindControl("CheckBox1")).Checked)
                {
                    Session["value1"] = r.Cells[1].Text;
                }
            }
            Response.Redirect("Updateflight");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddFlight");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow r in GridView1.Rows)
            {
                if (((CheckBox)r.Cells[0].FindControl("CheckBox1")).Checked)
                {
                    string s = r.Cells[1].Text;
                    AirlionEntities ctx = new AirlionEntities();
                    Flight f = new Flight();
                    f = ctx.Flights.Where(x => x.idFlight == s).First();
                    f.status = "inactive";
                    ctx.SaveChanges();
                    Response.Redirect("MaintainFlight.aspx");
                }
            }
        }
    }
}