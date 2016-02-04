using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Controller;
namespace Team3_AirLineProject.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        
        protected void btnlogin_Click(object sender, EventArgs e)
        {
            string name = txtUser.Text;
            string password = txtPassword.Text;

            if (LoginRegister.CheckLoginUser(name, password))
            {
                txtMessage.Text = "User Correct";
                FormsAuthentication.RedirectFromLoginPage(name, false);
            }
            else
            {
                txtMessage.Text = "User inCorrect";
            }
            
        }
    }
}