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
        HttpContext _context = HttpContext.Current;
        string action = "";
        if (_context.Items["action"] != null)
        {
            action = _context.Items["action"].ToString();
        }        

        if (action.Equals("login"))
        {
            Response.Write(_context.Items["name"]);
            Response.Write(_context.Items["password"]);    
        }            
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
            Session["ProfilePicture"] = ClientUserInfo.Rows[0]["ProfilePicture"];
            Session["email"] = ClientUserInfo.Rows[0]["email"];
            Response.Redirect("Default.aspx");
        }
        else {
            HttpContext _context = HttpContext.Current;
            _context.Items.Add("name", "Name test");
            _context.Items.Add("password", "Password test");
            _context.Items.Add("action", "login");
            Server.Transfer("Login.aspx");            
        }
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        Server.Transfer("Signup.aspx");
    }
}