using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;

namespace Team3_AirLineProject.userM
{
    public partial class NestedMasterUser : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session != null)
            {
                if (Session["LoginUser"] != null)
                {

                    User u = (User)Session["LoginUser"];
                    if (u.idRole != "user")
                    {
                        illeagleUser();
                    }

                }
                else
                {
                    illeagleUser();
                }
            }
            else
            {
                Response.Redirect("~/view/Login.aspx");

            }
        }
        public  void illeagleUser()
        {
            Session.Clear();
            Response.Redirect("~/view/Login.aspx");
        }
    }
}