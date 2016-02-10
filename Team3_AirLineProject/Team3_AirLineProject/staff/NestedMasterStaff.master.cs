using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;
namespace Team3_AirLineProject.staff
{
    public partial class NestedMasterStaff : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session != null)
            {
                if (Session["LoginUser"] != null)
                {

                    User u = (User)Session["LoginUser"];
                    if (u.idRole != "staff")
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
        public void illeagleUser()
        {
            Session.Clear();
            Response.Redirect("~/view/Login.aspx");
        }
    }
}