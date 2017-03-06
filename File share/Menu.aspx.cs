using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class Menu : System.Web.UI.Page
{
    string check = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        /*HttpCookie cookie = Request.Cookies["check"];
        if()*/
        check = (string) Session["user"] ;
       
   
    }
    public void ensure_folder()
    {
        if (!System.IO.Directory.Exists("C:\\Uploads\\" + check))
        {
            System.IO.Directory.CreateDirectory("C:\\Uploads\\" + check);
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
            try
            {
                ensure_folder();
                FileUpload1.SaveAs("C:\\Uploads\\" + check + "\\" +
                     FileUpload1.FileName);
                Label1.Text = "File name: " +
                     FileUpload1.PostedFile.FileName + "<br>" +
                     FileUpload1.PostedFile.ContentLength + " kb<br>" +
                     "Content type: " +
                     FileUpload1.PostedFile.ContentType;
            }
            catch (Exception ex)
            {
                Label1.Text = "ERROR: " + ex.Message.ToString();
            }
        else
        {
            Label1.Text = "You have not specified a file.";
        }
        check = null;
    }
}