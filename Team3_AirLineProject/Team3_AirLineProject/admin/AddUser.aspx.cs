using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;

namespace Team3_AirLineProject.admin
{
    public partial class AddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AirlionEntities ctx = new AirlionEntities();
            User u = new User();
            u.idUser = TextBox1.Text;
            u.password = TextBox2.Text;
            u.phoneNo = TextBox3.Text;
            if (RadioButton1.Checked)
            { u.status = RadioButton1.Text; }
            if (RadioButton2.Checked)
            { u.status = RadioButton2.Text; }
            if (RadioButton3.Checked)
            {
                u.idRole = RadioButton3.Text;
            }
            if (RadioButton4.Checked)
            {
                u.idRole = RadioButton4.Text;
            }
            if (RadioButton5.Checked)
            {
                u.idRole = RadioButton5.Text;
            }
            ctx.Users.Add(u);
            ctx.SaveChanges();
            Response.Redirect("MaintainUser.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("MaintainUser.aspx");
        }
    }
}