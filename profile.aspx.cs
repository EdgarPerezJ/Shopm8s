using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class profile : System.Web.UI.Page
{
    DataTable ProfileInfoDt = new DataTable();
    DataTable passwordDt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["name"] != null)
            {
                nametxt.Text = Session["name"].ToString();
                emailtxt.Text = Session["email"].ToString();
                profileimg.ImageUrl = Session["profilepicture"].ToString();
            }
            else
            {
                nametxt.Text = "";
                emailtxt.Text = "";
                profileimg.ImageUrl = "";
            }
        }
        
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        Clients client = new Clients();
        client._id = new Guid(Session["id"].ToString());
        client._name = nametxt.Text;
        client._email = emailtxt.Text;
        if (picupload.FileBytes.Length > 0)
        {
            FileUpload FileUpload1 = (FileUpload)FindControl("picupload");
            string virtualFolder = "~/ProfilePics/";
            string physicalFolder = Server.MapPath(virtualFolder);
            string fileName = Guid.NewGuid().ToString();
            string extension = System.IO.Path.GetExtension(picupload.FileName);
            picupload.SaveAs(System.IO.Path.Combine(physicalFolder, fileName + extension));
            client._ProfilePicture = virtualFolder + fileName + extension;
        }
        else { 
            client._ProfilePicture = Session["profilepicture"].ToString(); 
        }
        client.EditClient();
        Session["name"] = client._name;
        Session["email"] = client._email;
        Session["profilepicture"] = client._ProfilePicture;      
        Response.Redirect("profile.aspx");
    }


    protected void btnchange_Click(object sender, EventArgs e)
    {
        Clients client = new Clients();
        string oldPassword = oldpasstxt.Text;
        string newPassword= newpasstxt.Text;


        //Validate the password with the actual password of the user
        client._id = new Guid(Session["id"].ToString());
        passwordDt = client.RetrievePassword();
        if (passwordDt.Rows[0]["password"].ToString() == oldPassword)
        {
            client._password = newPassword;           
            client.EditPassword();
            Response.Redirect("profile.aspx");
        }
        else {
            Response.Write("wrong password!");
        }
        
    }
}