using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;

namespace Team3_AirLineProject.userM
{
    public partial class AddPassenger : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            User ur = (User)Session["LoginUser"];
            AirlionEntities ctx = new AirlionEntities();
            Passenger p = new Passenger();

            p.idUser = ur.idUser;
            p.pasName = TextBox1.Text;
            p.passportNo = TextBox2.Text;
            p.dateOfBirth = Calendar1.SelectedDate.Date;

            p.createDate = DateTime.Now.Date;


            if (RadioButton1.Checked)
            {
                p.gender = "male";
            }
            if (RadioButton2.Checked)
            {
                p.gender = "female";
            }
            if (ctx.Passengers.Find(ur.idUser, p.passportNo) == null)
            {
                ctx.Passengers.Add(p);
                ctx.SaveChanges();
                Response.Redirect("MaintainPassenger.aspx");
            }
            else
            {
                Label5.Text = "The User already exist.";
            }
            
        }

       
    }
}