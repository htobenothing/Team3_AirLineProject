using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;

namespace Team3_AirLineProject.admin
{
    public partial class MaintainUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginUser"] != null)
            {
                User ur = (User)Session["LoginUser"];
                if (ur.idRole == "admin")
                {
                        if(!IsPostBack){
                            AirlionEntities ctx = new AirlionEntities();
                            var q = from x in ctx.Users select x;
                            GridView1.DataSource = q.ToList();
                            GridView1.DataBind();

                        }
                        
                }
                else
                {
                    Session.Clear();
                    Response.Redirect("~/view/Login.aspx");
                }
            }
            else
            {
                Session.Clear();
                Response.Redirect("~/view/Login.aspx");
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow r in GridView1.Rows)
            {

                if (((CheckBox)r.Cells[0].FindControl("CheckBox1")).Checked)
                {
                    Session["value1"] = r.Cells[1].Text;
                    Session["value2"] = r.Cells[2].Text;
                    Session["value3"] = r.Cells[3].Text;
                    Session["value4"] = r.Cells[4].Text;
                    Session["value5"] = r.Cells[5].Text;
                }
            }
            Response.Redirect("UpdateUser");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddUser");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow r in GridView1.Rows)
            {

                if (((CheckBox)r.Cells[0].FindControl("CheckBox1")).Checked)
                {
                    AirlionEntities ctx = new AirlionEntities();
                    User u = new User();
                    string s = r.Cells[1].Text;
                    u = ctx.Users.Where(x => x.idUser == s).First();
                    u.status = "inactive";
                    ctx.SaveChanges();
                    Response.Redirect("CRUDuser");

                }

            }
        }
    }
}