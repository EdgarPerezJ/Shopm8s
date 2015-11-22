using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    DataTable ProductsDt = new DataTable();
    DataTable cartInfoDt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        divSuccess.Visible = false;
        divError.Visible = false;
        string type = Request.Params.Get("type");
        Products products = new Products();
        if (type != null && type != "")
        {
            products._type = type;
            Repeater1.DataSource = products.RetrieveProductsByType();
        }
        else
        {
            Repeater1.DataSource = products.RetrieveAllProducts();
        }
        Repeater1.DataBind();        
    }

    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        hfProductID.Value = e.CommandArgument.ToString();
        if (e.CommandName == "view")
        {
            Server.Transfer(string.Format("ProductDetail.aspx?ProductID={0}", hfProductID.Value));
        }
        else
        {
            //Validate the session
            if (Session["id"] == null || Session["id"].Equals(""))
            {
                Server.Transfer("/Login.aspx");
            }
            string productid = hfProductID.Value;
            Carts cart = new Carts();
            cart._cartid = Guid.NewGuid();
            cart._clientid = new Guid(Session["id"].ToString());
            cart._productid = new Guid(productid);
            //Validates if the product was already added to the cart
            cartInfoDt = cart.RetrieveCartByClientProduct();
            if (cartInfoDt.Rows.Count > 0)
            {
                divSuccess.Visible = false;
                divError.Visible = true;
            }
            else
            {
                cart.SaveCart();
                var MasterRepeater = (Repeater)Master.FindControl("RepeaterMaster");
                MasterRepeater.DataSource = cart.RetrieveCarts();
                MasterRepeater.DataBind();
                divSuccess.Visible = true;
                divError.Visible = false;
            }
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
}