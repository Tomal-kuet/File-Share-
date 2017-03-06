using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindGrid();
        }
    }
    private void BindGrid()
    {
        string constr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Tomal\Documents\Visual Studio 2013\WebSites\WebSite3\App_Data\Users.mdf;Integrated Security=True";
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT Id, Name from [File]";
                cmd.Connection = con;
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
                con.Close();
            }
        }
    }

 /*   public void ensure_folder ()
    {
        if (!System.IO.Directory.Exists("C:\\Uploads\\"+check))
        {
            System.IO.Directory.CreateDirectory("C:\\Uploads\\"+check);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        check = user.Text;
        if (FileUpload1.HasFile)
            try
            {
                ensure_folder();
                FileUpload1.SaveAs("C:\\Uploads\\" + check+"\\"+
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
    protected void show_Click(object sender, EventArgs e)
    {
        check = user.Text;
        if (check != null)
        {
            string[] filePaths = Directory.GetFiles("C:\\Uploads\\" + check + "\\");
            List<ListItem> files = new List<ListItem>();
            foreach (string filePath in filePaths)
            {
                files.Add(new ListItem(Path.GetFileName(filePath), filePath));
            }
            GridView1.DataSource = files;
            GridView1.DataBind();
        }
        else
        {
            user.Focus();
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }
    protected void lnkDownload_Click(object sender, EventArgs e)
    {
        string filePath = (sender as LinkButton).CommandArgument;
        Response.ContentType = ContentType;
        Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(filePath));
        Response.WriteFile(filePath);
        Response.End();
    }
    protected void lnkDelete_Click(object sender, EventArgs e)
    {
        string filePath = (sender as LinkButton).CommandArgument;
        File.Delete(filePath);
        Response.Redirect(Request.Url.AbsoluteUri);
    } */
    protected void btnUpload_Click(object sender, EventArgs e)
    {
        string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
        string contentType = FileUpload1.PostedFile.ContentType;
        using (Stream fs = FileUpload1.PostedFile.InputStream)
        {
            using (BinaryReader br = new BinaryReader(fs))
            {
                byte[] bytes = br.ReadBytes((Int32)fs.Length);
                string constr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Tomal\Documents\Visual Studio 2013\WebSites\WebSite3\App_Data\Users.mdf;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(constr))
                {
                    string query = "INSERT INTO [File] values (@Name, @ContentType, @Data)";
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query,con))
                    {
                       // cmd.Connection = con;

                        //cmd.Parameters.AddWithValue("@id", 2);
                        if (FileUpload1.HasFile)
                        {
                            cmd.Parameters.AddWithValue("@Name", filename);
                            cmd.Parameters.AddWithValue("@ContentType", contentType);
                            cmd.Parameters.AddWithValue("@Data", bytes);

                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            label1.Text = "Select a specefic file";
                        }
                        con.Close();
                    }
                }
            }
        }
        Response.Redirect(Request.Url.AbsoluteUri);
    }
    protected void lnkDownload_Click(object sender, EventArgs e)
    {
       int id = int.Parse((sender as LinkButton).CommandArgument);
    byte[] bytes;
    string fileName, contentType;
    string constr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Tomal\Documents\Visual Studio 2013\WebSites\WebSite3\App_Data\Users.mdf;Integrated Security=True";
    using (SqlConnection con = new SqlConnection(constr))
    {
        using (SqlCommand cmd = new SqlCommand())
        {
            cmd.CommandText = "SELECT Name, Data, ContentType from [File] where Id=@Id";
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Connection = con;
            con.Open();
            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                sdr.Read();
                bytes = (byte[])sdr["Data"];
                contentType = sdr["ContentType"].ToString();
                fileName = sdr["Name"].ToString();
            }
            con.Close();
        }
    }
    Response.Clear();
    Response.Buffer = true;
    Response.Charset = "";
    Response.Cache.SetCacheability(HttpCacheability.NoCache);
    Response.ContentType = contentType;
    Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);
    Response.BinaryWrite(bytes);
    Response.Flush();
    Response.End();
}
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}