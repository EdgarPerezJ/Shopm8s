using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Products
/// </summary>
public class Products:ConnectionString
{
    #region DataMember
    private Guid productid;
    public Guid _productid
    {
        get
        {
            return productid;
        }
        set
        {
            this.productid = value;
        }
    }
    private string name;
    public string _name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }

    }
    private string type;
    public string _type
    {
        get
        {
            return type;
        }
        set
        {
            type = value;
        }
    }
    private string price;
    public string _price
    {
        get
        {
            return price;
        }
        set
        {
            price = value;
        }
    }
    private string description;
    public string _description
    {
        get
        {
            return description;
        }
        set
        {
            description = value;
        }
    }
    private object photo1;
    public object _photo1
    {
        get
        {
            return photo1;
        }
        set
        {
            photo1 = value;
        }






    }

    private object photo2;
    public object _photo2
    {
        get
        {
            return photo2;
        }
        set
        {
            photo2 = value;
        }






    }

    private object photo3;
    public object _photo3
    {
        get
        {
            return photo3;
        }
        set
        {
            photo3 = value;
        }






    }

    private object photo4;
    public object _photo4
    {
        get
        {
            return photo4;
        }
        set
        {
            photo4 = value;
        }






    }

    private Guid clientid;
    public Guid _clientid
    {
        get
        {
            return clientid;
        }
        set
        {
            this.clientid = value;
        }
    }




    #endregion

    public void SaveProduct()
    {
        SqlConnection conn = new SqlConnection(Connstr);
        conn.Open();
        try
        {
            SqlCommand cmd = new SqlCommand("SP_SaveProduct");
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Fld_ProductID", _productid);
            cmd.Parameters.AddWithValue("@Fld_ProductName", _name);
            cmd.Parameters.AddWithValue("@Fld_ProductCat", _type);
            cmd.Parameters.AddWithValue("@Fld_Description", _description);
            cmd.Parameters.AddWithValue("@Fld_Price", _price);
            cmd.Parameters.AddWithValue("@Fld_pphoto1", _photo1);
            cmd.Parameters.AddWithValue("@Fld_pphoto2", _photo2);
            cmd.Parameters.AddWithValue("@Fld_pphoto3", _photo3);
            cmd.Parameters.AddWithValue("@Fld_pphoto4", _photo4);
            cmd.Parameters.AddWithValue("@Fld_ClientID", _clientid);
            cmd.ExecuteNonQuery();
        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            conn.Close();
            conn.Dispose();
        }
    }



}