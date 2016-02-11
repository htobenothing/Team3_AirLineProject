using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;

namespace Team3_AirLineProject.userM
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginUser"] != null)
            {
                User ur = (User)Session["LoginUser"];
                LabName.Text = ur.idUser;
            }
            
        }
    }
}