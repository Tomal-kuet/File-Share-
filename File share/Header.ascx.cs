using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Header : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["user"] != "logout")
            Response.Redirect("Menu.aspx");
        if (Session["user"] == "logout")
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(),
                "alert", "myFunction();", true);
        }

    }
    protected void Button4_Click1(object sender, EventArgs e)
    {
        if (Session["user"] == "logout")
            Response.Redirect("Register.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (Session["user"] == "logout")
            Response.Redirect("Login.aspx");
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Session["user"] != "logout")
            Response.Redirect("Mydrive.aspx");
        if (Session["user"] == "logout")
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(),
                "alert", "myFunction();", true);
        }
        
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
      
    }
}