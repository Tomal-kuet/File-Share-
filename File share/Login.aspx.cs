using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string connection = @"Data Source=TOMAL-PC\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True";
        string sqlinsert = "SELECT * FROM [profiles] WHERE First_name=@userid AND pass=@password";
        SqlConnection conn = new SqlConnection(connection);
        string name = textbox1.Text;
        string password = textbox5.Text;
        try
        {
            conn.Open();
            SqlCommand mycmd = new SqlCommand(sqlinsert, conn);
            mycmd.Parameters.AddWithValue("@userid", name);
            mycmd.Parameters.AddWithValue("@password", password);
            SqlDataReader dr = mycmd.ExecuteReader();
            if (dr.HasRows)
            {
                Session["user"] = name;
                Response.Redirect("Menu.aspx");
            }
            else
            {
                //invalid login 
                Response.Redirect("Default.aspx");
            }
        }
        catch (Exception ex)
        {
            // TextBox6.Text = ex.Message;
        }
    }
    protected void check_CheckedChanged(object sender, EventArgs e)
    {
        HttpCookie cookie = new HttpCookie("check");
        cookie.Values["check"] = textbox1.Text;
       cookie.Expires = DateTime.Now.AddMinutes(10);
        Response.SetCookie(cookie);
       /* if (  (string) cookie["check"] == textbox1.Text)
            Response.Redirect("Default.aspx");
        else
            Response.Redirect("Menu.aspx");*/

    }

}