using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;

namespace Team3_AirLineProject.staff
{
    public partial class UpdateFlight : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label9.Text = (string)Session["value1"];
                string s = Label9.Text;
                AirlionEntities ctx = new AirlionEntities();
                Flight f = new Flight();
                f = ctx.Flights.Where(x => x.idFlight == s).First();
                TextBox2.Text = f.startCity;
                TextBox3.Text = f.endCity;
                string fmt = @"hh\:mm\:ss";
                TextBox4.Text = f.StartTime.ToString(fmt);
                TextBox5.Text = f.endTime.ToString(fmt);
                TextBox6.Text = f.price.ToString("0");
                TextBox7.Text = f.totalSeatNo.ToString("0");
                if (f.status == "active")
                {
                    RadioButton1.Checked = true;
                }
                if (f.status == "inactive")
                {
                    RadioButton1.Checked = true;
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AirlionEntities ctx = new AirlionEntities();
            Flight f = new Flight();
            string s = Label9.Text;
            f = ctx.Flights.Where(x => x.idFlight == s).First();
            f.startCity = TextBox2.Text;
            f.endCity = TextBox3.Text;
            f.StartTime = TimeSpan.Parse(TextBox4.Text);
            f.endTime = TimeSpan.Parse(TextBox5.Text);
            f.price = Convert.ToDecimal(TextBox6.Text);
            f.totalSeatNo = Convert.ToInt32(TextBox7.Text);
            if (RadioButton1.Checked)
            {
                f.status = "active";
            }
            if (RadioButton2.Checked)
            {
                f.status = "inactive";
            }
            ctx.SaveChanges();
            Response.Redirect("MaintainFlight.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("MaintainFlight.aspx");
        }
    }
}