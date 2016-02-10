using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;

namespace Team3_AirLineProject.View
{
    public partial class Welcome : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnLogout.Visible = false;
            if (!IsPostBack)
            {
                if (Session != null)
                {
                    if (Session["LoginUser"] != null)
                    {
                        btnLogout.Visible = true;
                        btnLogin.Visible = false;
                        btnLRegister.Visible = false;
                        User u = (User)Session["LoginUser"];
                    }
                }
            }
           
        }

        protected void btnLRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/view/Register.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/view/Login.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/view/Login.aspx");
        }

        
    }
}