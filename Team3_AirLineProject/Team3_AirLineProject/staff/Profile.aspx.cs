using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;

namespace Team3_AirLineProject.staff
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginUser"] != null && !IsPostBack)
            {
                User ur = (User)Session["LoginUser"];
                txtUser.Text = ur.idUser;
                txtPassword.Text = ur.password;
                txtConfirmPassword.Text = ur.password;
                txtPhoneNumber.Text = ur.phoneNo;
            }
            
        }
        
        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            if (valEmail1.IsValid && valPassword.IsValid && valConfirmPwd.IsValid && valPhone.IsValid)
            {
                User ur = (User)Session["LoginUser"];
                User newuser = new User();
                newuser.idUser = ur.idUser;
                newuser.password = txtPassword.Text;
                newuser.phoneNo = txtPhoneNumber.Text;
                UserManager.UpdateUser(newuser);
                System.Windows.Forms.MessageBox.Show("Update Successful");
                
                Response.Redirect("Welcome.aspx");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Update Failed, Pls try again");
               
            }
        }
    }
}