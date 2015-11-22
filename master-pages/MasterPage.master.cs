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
                Carts cart = new Carts();
                cart._clientid = new Guid(Session["id"].ToString());
                RepeaterMaster.DataSource = cart.RetrieveCarts();
                RepeaterMaster.DataBind();
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
            Session["id"] = null;
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
            Response.Redirect("profile.aspx");
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

    protected void RepeaterMaster_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        hdcartid.Value = e.CommandArgument.ToString();

        if (e.CommandName == "DeleteCart")
        {
            Carts carts = new Carts();
            carts._cartid = new Guid(hdcartid.Value.ToString());
            carts.DeleteCart();
            carts._clientid = new Guid(Session["id"].ToString());
            RepeaterMaster.DataSource = carts.RetrieveCarts();
            RepeaterMaster.DataBind();

        }


    }

    protected void Image_Click(object sender, CommandEventArgs e)
    {
        hfProductID.Value = e.CommandArgument.ToString();
        if (e.CommandName == "ImageClick")
        {
            Server.Transfer(string.Format("ProductDetail.aspx?ProductID={0}", hfProductID.Value));
        }
    }

    protected void lnkWomen_Click(object sender, EventArgs e)
    {
        Server.Transfer(string.Format("Default.aspx?type={0}", "Women"));
    }

    protected void lnkMen_Click(object sender, EventArgs e)
    {
        Server.Transfer(string.Format("Default.aspx?type={0}", "Men"));
    }

    protected void lnkBaby_Click(object sender, EventArgs e)
    {
        Server.Transfer(string.Format("Default.aspx?type={0}", "BabyKids"));
    }

    protected void lnkHome_Click(object sender, EventArgs e)
    {
        Server.Transfer(string.Format("Default.aspx?type={0}", "Home"));
    }

    protected void lnkElectronics_Click(object sender, EventArgs e)
    {
        Server.Transfer(string.Format("Default.aspx?type={0}", "Electronics"));
    }
}
