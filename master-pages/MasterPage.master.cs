using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class master_pages_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["name"] != null)
            {
                loginlinks.Visible = false;
                logoutdiv.Visible = true;
            }
            else
            {
                loginlinks.Visible = true;
                logoutdiv.Visible = false;
            }
        }
    }
    protected void logoutlnk_Click(object sender, EventArgs e)
    {
        {
            Session["UserInfo"] = null;
            Session["name"] = null;
            Session["Password"] = null;
            Response.Redirect("Default.aspx");
        }
    }

    protected void messagesIcon_Click(object sender, EventArgs e)
    {
        if (Session["name"] != null)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            Response.Redirect("Login.aspx");
        }   
    }


    protected void profileIcon_Click(object sender, EventArgs e)
    {
        if (Session["name"] != null)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            Response.Redirect("Login.aspx");
        } 
    }


    protected void notifIcon_Click(object sender, EventArgs e)
    {
        if (Session["name"] != null)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            Response.Redirect("Login.aspx");
        } 
    }

    protected void cartIcon_Click(object sender, EventArgs e)
    {
        if (Session["name"] != null)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            Response.Redirect("Login.aspx");
        } 
    }
}
