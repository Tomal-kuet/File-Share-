using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Menu_header : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
     
       
    }
    protected void Unnamed_Click(object sender, EventArgs e)
    {
        if (Request.Cookies["check"] != null)
        {
            HttpCookie cookie = Request.Cookies["check"];
            cookie.Expires = DateTime.Now.AddMinutes(-10);
            Response.SetCookie(cookie);
        }
        Response.Redirect("Default.aspx");
    }
}