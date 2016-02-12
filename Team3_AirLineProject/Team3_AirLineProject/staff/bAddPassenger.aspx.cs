﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;

namespace Team3_AirLineProject.staff
{
    public partial class bAddPassenger : System.Web.UI.Page
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

            ctx.Passengers.Add(p);
            ctx.SaveChanges();

            Response.Redirect("SelectPassenger.aspx");
        }

       
    }
}