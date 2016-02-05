using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;

namespace Team3_AirLineProject.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Userid_ServerValidate(object source, ServerValidateEventArgs args)
        {
            
            if (LoginRegister.CheckUserid(txtUser.Text))
            {
                valEmail2.IsValid = true;
            }
            valEmail2.IsValid = false;
            labmessage.Text="The Email already exit";
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            if (valEmail1.IsValid && valEmail2.IsValid && valPassword.IsValid && valConfirmPwd.IsValid && valPhone.IsValid)
            {
                if (LoginRegister.RegisterUser(txtUser.Text, txtPassword.Text, txtPhoneNumber.Text))
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Register Successful')", true);
                    Response.Redirect("~/user/welcome.apsx");
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Register failed, Pls try again')", true);
                }
            }
        }
    }
}