﻿using System;
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

                User LoginUser = UserManager.getUser(name);
                Session["LoginUser"] = LoginUser;
                
                // redirect base on role
                if (Session["departureId"] != null)
                {
                    switch (LoginUser.idRole)
                    {
                        case "user":
                            Response.Redirect("~/userM/SelectPassenger.aspx");
                            break;

                        case "staff":
                            Response.Redirect("~/staff/SelectPassenger.aspx");
                            break;
                        
                    }
                }
                else
                {
                    switch (LoginUser.idRole)
                    {
                        case "user":
                            Response.Redirect("~/userM/welcome.aspx");
                            break;

                        case "staff":
                            Response.Redirect("~/staff/welcome.aspx");
                            break;
                        case "admin":
                            Response.Redirect("~/admin/MaintainUser.aspx");
                            break;
                    }
                }
                
                
                
            }
            else
            {
                txtMessage.Text = "UserId or password not correct";
            }
            
        }
    }
}