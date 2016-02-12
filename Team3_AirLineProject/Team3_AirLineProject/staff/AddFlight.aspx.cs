using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;

namespace Team3_AirLineProject.staff
{
    public partial class AddFlight : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AirlionEntities ctx = new AirlionEntities();

            Flight f = new Flight();
            f.idFlight = TextBox1.Text;
            f.startCity = TextBox2.Text;
            f.endCity = TextBox3.Text;
            f.StartTime = TimeSpan.Parse(TextBox4.Text);
            f.endTime = TimeSpan.Parse(TextBox5.Text);
            f.price = Convert.ToInt32(TextBox6.Text);
            f.totalSeatNo = Convert.ToInt32(TextBox7.Text);
            if (RadioButton1.Checked)
            {
                f.status = "active";
            }
            if (RadioButton2.Checked)
            {
                f.status = "inactive";
            }
            
            // check whether the flightid exist 
            if (ctx.Flights.Find(f.idFlight) == null)
            {
                ctx.Flights.Add(f);
                ctx.SaveChanges();
                Response.Redirect("MaintainFlight.aspx");
            }
            else
            {
                Label9.Text = "This ID has been used";
            }

            


        }

      
    }
}