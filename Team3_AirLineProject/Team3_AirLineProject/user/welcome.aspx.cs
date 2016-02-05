using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Team3_AirLineProject.userPage
{
    public partial class welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            labMessage.Text = Roles.GetUsersInRole();
        }
    }
}