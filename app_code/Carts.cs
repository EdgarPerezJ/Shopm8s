using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Carts
/// </summary>
public class Carts:ConnectionString
{
    #region DataMember
    private Guid cartid;
    public Guid _cartid
    {
        get
        {
            return cartid;
        }
        set
        {
            this.cartid = value;
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
            clientid = value;
        }

    }
    private Guid productid;
    public Guid _productid
    {
        get
        {
            return productid;
        }
        set
        {
            productid = value;
        }
    }
   



    #endregion



    public void SaveCart()
    {
        SqlConnection conn = new SqlConnection(Connstr);
        conn.Open();
        try
        {
            SqlCommand cmd = new SqlCommand("SP_SaveCart");
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Fld_CartID", _cartid);
            cmd.Parameters.AddWithValue("@Fld_ClientID", _clientid);
            cmd.Parameters.AddWithValue("@Fld_ProductID", _productid);

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