using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductBidPage : System.Web.UI.Page
{
    DataTable productInfoDt = new DataTable();
    DataTable cartInfoDt = new DataTable();
    DataTable BidsStatusDt = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        divSuccess.Visible = false;
        divError.Visible = false;
        if (!Page.IsPostBack)
        {
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
            Bids bid = new Bids();
            bid._productid = new Guid(Request.QueryString.Get("ProductID").ToString());
            bid._clientid = new Guid(Session["id"].ToString());
            BidsStatusDt = bid.RetrieveBidsStatus();
            if (BidsStatusDt.Rows.Count == 0)
            {
                newbid.Visible = true;
                modify.Visible = false;
                changebid.Visible = false;
                checkout.Visible = false;
                Remove.Visible = false;
            }
            else if (BidsStatusDt.Rows[0]["status"].ToString() == "Pending")
            {
                newbid.Visible = false;
                modify.Visible = true;
                modifyamount.Text = BidsStatusDt.Rows[0]["amount"].ToString();
                changebid.Visible = false;
                checkout.Visible = false;
                Remove.Visible = false;
            }
            else if (BidsStatusDt.Rows[0]["status"].ToString() == "Rejected")
            {
                newbid.Visible = false;
                modify.Visible = false;
                changebid.Visible = true;
                checkout.Visible = false;
                Remove.Visible = false;
            }
            else if (BidsStatusDt.Rows[0]["status"].ToString() == "Accepted")
            {
                newbid.Visible = false;
                modify.Visible = false;
                changebid.Visible = false;
                checkout.Visible = true;
                Remove.Visible = false;
            }
            else if (BidsStatusDt.Rows[0]["status"].ToString() == "Sold")
            {
                newbid.Visible = false;
                modify.Visible = false;
                changebid.Visible = false;
                checkout.Visible = false;
                Remove.Visible = true;
            }
        }
        
    
    }
         

     
    

    protected void btnBid_Click(object sender, EventArgs e)
    {
        //Validate the session
        if (Session["id"] == null || Session["id"].Equals(""))
        {
            Server.Transfer("/Login.aspx");
        }

        string productid = Request.QueryString.Get("ProductID").ToString();
        Bids bid = new Bids();
        bid._bidid = Guid.NewGuid();
        bid._productid = new Guid(productid);
        bid._clientid = new Guid(Session["id"].ToString());
        bid._amount = amounttxt.Text;
        bid._status = "Pending";
        bid.SaveBid();
        btnBid.Enabled = false;
        btnBid.Text = "Thank You!";
    }

    protected void btnremove_Click(object sender, EventArgs e)
    {
        Carts carts = new Carts();
        var hiddenField = (HiddenField)Master.FindControl("hdcartid");
        carts._cartid = new Guid(hiddenField.Value.ToString());
        carts.DeleteCart();
        carts._clientid = new Guid(Session["id"].ToString());
        var MasterRepeater = (Repeater)Master.FindControl("RepeaterMaster");
        MasterRepeater.DataSource = carts.RetrieveCarts();
        MasterRepeater.DataBind();
    }

    protected void btnmodify_Click(object sender, EventArgs e)
    {
        Bids bid = new Bids();
        bid._productid = new Guid(Request.QueryString.Get("ProductID").ToString());
        bid._clientid = new Guid(Session["id"].ToString());
        bid._amount = modifyamount.Text;
        bid.ModifyBid();
    }
}