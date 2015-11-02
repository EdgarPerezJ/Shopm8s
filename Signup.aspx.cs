using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Signup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        Clients clientobj= new Clients();
        clientobj._id = Guid.NewGuid();
        clientobj._name = nametxt.Text;
        clientobj._email = emailtxt.Text;
        clientobj._password = passwordtxt.Text;
        FileUpload FileUpload1 = (FileUpload)FindControl("picupload");
        string virtualFolder = "~/ProfilePics/";
        string physicalFolder = Server.MapPath(virtualFolder);
        string fileName = Guid.NewGuid().ToString();
        string extension = System.IO.Path.GetExtension(FileUpload1.FileName);
        FileUpload1.SaveAs(System.IO.Path.Combine(physicalFolder, fileName + extension));

        clientobj._ProfilePicture = virtualFolder + fileName + extension;
        clientobj.SaveClient();

    }
}