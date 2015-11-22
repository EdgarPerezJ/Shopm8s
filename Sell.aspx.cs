using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Sell : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            divSuccess.Visible = false;
            //validate the Session
            if (Session["id"] == null || Session["id"].Equals(""))
            {
                Server.Transfer("/Login.aspx");
            }
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        Products product = new Products();
        product._productid = Guid.NewGuid();
        product._name = producttxt.Text;
        product._price = pricetxt.Text;
        product._type = typedbl.SelectedValue;
        product._description = descriptiontxt.Text;

        FileUpload fileupload1 = (FileUpload)FindControl("productload1");
        string virtualFolder = "~/ProductPhotos/";
        string physicalFolder = Server.MapPath(virtualFolder);
        string fileName = Guid.NewGuid().ToString();
        string extension = System.IO.Path.GetExtension(productload1.FileName);
        productload1.SaveAs(System.IO.Path.Combine(physicalFolder, fileName + extension));

        product._photo1 = virtualFolder + fileName + extension;

        FileUpload fileupload2 = (FileUpload)FindControl("productload2");
        virtualFolder = "~/ProductPhotos/";
        physicalFolder = Server.MapPath(virtualFolder);
        fileName = Guid.NewGuid().ToString();
        extension = System.IO.Path.GetExtension(productload2.FileName);
        productload2.SaveAs(System.IO.Path.Combine(physicalFolder, fileName + extension));

        product._photo2 = virtualFolder + fileName + extension;

        FileUpload fileupload3 = (FileUpload)FindControl("productload3");
        virtualFolder = "~/ProductPhotos/";
        physicalFolder = Server.MapPath(virtualFolder);
        fileName = Guid.NewGuid().ToString();
        extension = System.IO.Path.GetExtension(productload3.FileName);
        productload3.SaveAs(System.IO.Path.Combine(physicalFolder, fileName + extension));

        product._photo3 = virtualFolder + fileName + extension;


        FileUpload fileupload4 = (FileUpload)FindControl("productload4");
        virtualFolder = "~/ProductPhotos/";
        physicalFolder = Server.MapPath(virtualFolder);
        fileName = Guid.NewGuid().ToString();
        extension = System.IO.Path.GetExtension(productload4.FileName);
        productload4.SaveAs(System.IO.Path.Combine(physicalFolder, fileName + extension));

        product._photo4 = virtualFolder + fileName + extension;

        product._clientid = new Guid(Session["id"].ToString());
        product.SaveProduct();

        divSuccess.Visible = true;
    }
}