using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductDetail : System.Web.UI.Page
{
    DataTable ProductInfoDt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) {

            Products product = new Products();
            string productid="773237a8-26a3-4a68-a8ec-1a72be86b0ed";
            product._productid = new Guid(productid);
            ProductInfoDt = product.RetrieveProductInfo();
            lblProductName.Text = ProductInfoDt.Rows[0]["name"].ToString();
            lblPrice.Text = ProductInfoDt.Rows[0]["price"].ToString();
            lblDescription.Text = ProductInfoDt.Rows[0]["description"].ToString();
            imgMainPicture.ImageUrl = ProductInfoDt.Rows[0]["photo1"].ToString();
            imgPictureOne.ImageUrl = ProductInfoDt.Rows[0]["photo1"].ToString();
            imgPictureTwo.ImageUrl = ProductInfoDt.Rows[0]["photo2"].ToString();
            imgPictureThree.ImageUrl = ProductInfoDt.Rows[0]["photo3"].ToString();
            imgPictureFour.ImageUrl = ProductInfoDt.Rows[0]["photo4"].ToString();

        
        }
    }
    
    protected void btnAddCart_Click(object sender, EventArgs e)
    {
        string productid = "773237a8-26a3-4a68-a8ec-1a72be86b0ed";
        Carts cart = new Carts();
        cart._cartid = Guid.NewGuid();
        cart._clientid = new Guid(Session["id"].ToString());
        cart._productid = new Guid(productid);
        cart.SaveCart();
        btnAddCart.Enabled = false;
        btnAddCart.Text = "Added";
    }
}