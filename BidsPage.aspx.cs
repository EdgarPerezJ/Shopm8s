using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BidsPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        divSuccess.Visible = false;
        divError.Visible = false;
        Bids bid = new Bids();
        bid._productid = new Guid(Request.QueryString.Get("ProductID").ToString());
        Repeater1.DataSource = bid.RetrieveBids();
        Repeater1.DataBind();

    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        hfbidid.Value = e.CommandArgument.ToString();
        //Get the status and bidId
        string[] commandArgs = e.CommandArgument.ToString().Split(new char[] { ',' });
        string bidId = commandArgs[0];
        string bidStatus = commandArgs[1];
        if (e.CommandName == "accept")
        {            
            //Validate the current status
            if (bidStatus == "Accepted")
            {
                divError.Visible = true;
                divSuccess.Visible = false;
                lblError.Text = "This bid was already accepted before";
            }
            
            //If there is another bid accepted. It cannot be accepted.
            Bids bid = new Bids();
            bid._productid = new Guid(Request.QueryString.Get("ProductID").ToString());
            if(this.bidStatusExist("Accepted", bid)){
                divError.Visible = true;
                divSuccess.Visible = false;
                lblError.Text = "There is another bid currently accepted for this product.";
            }
            else
            {
                bid._bidid = new Guid(bidId);
                bid.UpdateStatus();

                //Refresh the data
                Repeater1.DataSource = bid.RetrieveBids();
                Repeater1.DataBind();
                divSuccess.Visible = true;
                divError.Visible = false;
                lblSuccess.Text = "The bid was accepted correctly";
            }

        }
        else if (e.CommandName == "reject") {
            //Validate the status
            if (bidStatus == "Rejected")
            {
                divError.Visible = true;
                divSuccess.Visible = false;
                lblError.Text = "This bid was already rejected before";
            }
            else
            {
                Bids bid = new Bids();
                bid._bidid = new Guid(bidId);
                bid._productid = new Guid(Request.QueryString.Get("ProductID").ToString());
                bid.RejectBid();

                //Refresh the data
                Repeater1.DataSource = bid.RetrieveBids();
                Repeater1.DataBind();
                divSuccess.Visible = true;
                divError.Visible = false;
                lblSuccess.Text = "The bid was rejected correctly";
            }
        }
    }

    private bool bidStatusExist(string status, Bids bid)
    {
        bool exists = false;
        DataTable bids = bid.RetrieveBids();
        foreach (DataRow row in bids.Rows)
        {
            string bidStatus = row["status"].ToString();
            if (bidStatus == status)
            {
                exists = true;
                break;
            }
        }

        return exists;
    }
}