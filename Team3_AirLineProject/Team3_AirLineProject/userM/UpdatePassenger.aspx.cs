using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;

namespace Team3_AirLineProject.userM
{
    public partial class UpdatePassenger : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Session["LoginUser"] !=null)
            {
                TextBox1.Text = (string)Session["value1"];
                AirlionEntities ctx = new AirlionEntities();
                Passenger p = new Passenger();
                p = ctx.Passengers.Where(x => x.pasName == TextBox1.Text).First();
                Label5.Text = p.passportNo;
                if (p.gender == "male")
                {
                    RadioButton1.Checked = true;
                }
                if (p.gender == "female")
                {
                    RadioButton2.Checked = true;
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AirlionEntities ctx = new AirlionEntities();
            Passenger p = new Passenger();
            p = ctx.Passengers.Where(x => x.passportNo == Label5.Text).First();
            p.pasName = TextBox1.Text;
            if (RadioButton1.Checked)
            {
                p.gender = "male";
            }
            if (RadioButton2.Checked)
            {
                p.gender = "female";
            }
            ctx.SaveChanges();
            Response.Redirect("MaintainPassenger");
        }

       
    }
}