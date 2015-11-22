using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductDetail : System.Web.UI.Page
{
    DataTable productInfoDt = new DataTable();
    DataTable cartInfoDt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        divSuccess.Visible = false;
        divError.Visible = false;
        if (!Page.IsPostBack) {
            Products product = new Products();            
            product._productid = new Guid(Request.QueryString.Get("ProductID").ToString());
            productInfoDt = product.RetrieveProductInfo();
            lblProductName.Text = productInfoDt.Rows[0]["name"].ToString();
            lblPrice.Text = productInfoDt.Rows[0]["price"].ToString();
            lblDescription.Text = productInfoDt.Rows[0]["description"].ToString();
            imgMainPicture.ImageUrl = productInfoDt.Rows[0]["photo1"].ToString();
            imgPictureOne.ImageUrl = productInfoDt.Rows[0]["photo1"].ToString();
            imgPictureTwo.ImageUrl = productInfoDt.Rows[0]["photo2"].ToString();
            imgPictureThree.ImageUrl = productInfoDt.Rows[0]["photo3"].ToString();
            imgPictureFour.ImageUrl = productInfoDt.Rows[0]["photo4"].ToString();        
        }
    }
    
    protected void btnAddCart_Click(object sender, EventArgs e)
    {
        //Validate the session
        if (Session["id"] == null || Session["id"].Equals(""))
        {
            Server.Transfer("/Login.aspx");    
        }

        string productid = Request.QueryString.Get("ProductID").ToString();
        Carts cart = new Carts();
        cart._cartid = Guid.NewGuid();
        cart._clientid = new Guid(Session["id"].ToString());
        cart._productid = new Guid(productid);

        //Validates if the product was already added to the cart
        cartInfoDt = cart.RetrieveCartByClientProduct();
        if (cartInfoDt.Rows.Count >  0)
        {
            divSuccess.Visible = false;
            divError.Visible = true;    
        }
        else{
            cart.SaveCart();
            btnAddCart.Enabled = false;
            btnAddCart.Text = "Added";
            var MasterRepeater = (Repeater)Master.FindControl("RepeaterMaster");
            MasterRepeater.DataSource = cart.RetrieveCarts();
            MasterRepeater.DataBind();
            divSuccess.Visible = true;
            divError.Visible = false; 
        }        
    }
}