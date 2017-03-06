using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        if (textbox1.Text != null)
         {
             string connection = @"Data Source=TOMAL-PC\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True";
             string sqlinsert = "INSERT INTO [Table] values(@fname,@lname,@phone,@email,@pass)";
             SqlConnection conn = new SqlConnection(connection);
             try
             {

                 conn.Open();
                 SqlCommand sqlcmd = new SqlCommand(sqlinsert, conn);
                 sqlcmd.Parameters.AddWithValue("@fname", textbox1.Text);
                 sqlcmd.Parameters.AddWithValue("@lname", textbox2.Text);
                 sqlcmd.Parameters.AddWithValue("@phone", textbox3.Text);
                 sqlcmd.Parameters.AddWithValue("@email", textbox4.Text);
                 sqlcmd.Parameters.AddWithValue("@pass", textbox5.Text);
                // ClearInputs(Page.Controls);
                 sqlcmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception ex)
             {
                 //TextBox6.Text = ex.Message;
             }
            // Response.Redirect("Login.aspx");
         }
         
    }
    protected void reset_Click(object sender, EventArgs e)
    {
       
        Response.Redirect("Register.aspx");

    }
}