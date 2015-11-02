using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    DataTable ClientUserInfo = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Clients clnobj = new Clients();
        clnobj._email = emailtxt.Text;
        clnobj._password = passwordtxt.Text;
        ClientUserInfo = clnobj.RetrieveClientInfo();
        if (ClientUserInfo.Rows.Count >= 1)
        {
            Session["UserInfo"] = ClientUserInfo;
            Session["id"] = ClientUserInfo.Rows[0]["id"];
            Session["name"] = ClientUserInfo.Rows[0]["name"];
            Session["password"] = ClientUserInfo.Rows[0]["Password"];
            Session["ProfilePicture"] = ClientUserInfo.Rows[0]["ProfilePicture"];
            Session["email"] = ClientUserInfo.Rows[0]["email"];
            Response.Redirect("Default.aspx");
        }
        else {
            
            Server.Transfer("Login.aspx?message=Incorrect password.");            
        }
    }
}