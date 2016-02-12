using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;

namespace Team3_AirLineProject.admin
{
    public partial class UpdateUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label2.Text = (string)Session["value1"];
                TextBox1.Text = (string)Session["value2"];
                TextBox2.Text = (string)Session["value3"];
                rdblStatus.SelectedValue = (string)Session["value4"];

                rdblRole.SelectedValue = (string)Session["value5"];
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AirlionEntities ctx = new AirlionEntities();
            User u = new User();
            string s = Label2.Text;
            u = ctx.Users.Where(x => x.idUser == s).First();
            u.password = TextBox1.Text;
            u.phoneNo = TextBox2.Text;
            u.status = rdblStatus.SelectedValue;
            u.idRole = rdblRole.SelectedValue;
           
            ctx.SaveChanges();
            Response.Redirect("MaintainUser.aspx");
        }

      
    }
}