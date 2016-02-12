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
            Label6.Text = "";
            u.idUser = TextBox1.Text;
            u.password = TextBox2.Text;
            u.phoneNo = TextBox3.Text;
            u.status = rdblStatus.SelectedValue;
            u.idRole = rdblRole.SelectedValue;
            if (ctx.Users.Find(u.idUser) == null)
            {
                ctx.Users.Add(u);
                ctx.SaveChanges();
                Response.Redirect("MaintainUser.aspx");
            }
            else
            {
                Label6.Text = "The User already exist";
            }
            
        }

       
    }
}