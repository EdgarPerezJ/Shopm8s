using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyProducts : System.Web.UI.Page
{
    DataTable ProductsDt = new DataTable();
    DataTable cartInfoDt = new DataTable();
    DataTable ProductsbysellerDt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
       
        
        Products products = new Products();
        products._clientid = new Guid(Session["id"].ToString());
        Repeater1.DataSource = products.RetrieveProductsBySeller();
        Repeater1.DataBind();
    }

    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        hfProductID.Value = e.CommandArgument.ToString();
        if (e.CommandName == "viewbids")
        {
            Server.Transfer(string.Format("BidsPage.aspx?ProductID={0}", hfProductID.Value));
        }
        
        
    }
}