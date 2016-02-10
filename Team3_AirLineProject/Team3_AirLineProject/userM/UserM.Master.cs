using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;

namespace Team3_AirLineProject.user
{
    public partial class UserM : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session != null)
            {
                if (Session["LoginUser"] != null)
                {

                    User u = (User)Session["LoginUser"];
                    if (u.idRole == "user")
                    {
                        btnLogout.Text = u.idUser;
                    }
                    else
                    {
                        btnLogout_Click(btnLogout, null);
                    }

                }
                else
                {
                    btnLogout_Click(btnLogout, null);
                }
            }
            else
            {
                Response.Redirect("~/view/Login.aspx");

            }
        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/view/Login.aspx");
        }
    }
}