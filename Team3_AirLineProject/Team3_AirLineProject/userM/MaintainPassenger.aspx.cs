using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controller;

namespace Team3_AirLineProject.userM
{
    public partial class MaintainPassenger : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Session["LoginUser"]!=null)
            {
                User ur = (User)Session["LoginUser"];
                string urid = ur.idUser;
                AirlionEntities ctx = new AirlionEntities();
                var q = from x in ctx.Passengers
                        where x.idUser == urid
                        select new { x.pasName, x.passportNo, dateOfBirth = x.dateOfBirth.ToString(), x.gender, createDate = x.createDate.ToString() };
                GridView1.DataSource = q.ToList();
                GridView1.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow r in GridView1.Rows)
            {
                if (((CheckBox)r.Cells[0].FindControl("CheckBox1")).Checked)
                {
                    Session["value1"] = r.Cells[1].Text;
                }
            }
            Response.Redirect("UpdatePassenger");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddPassenger");
        }
    }
}