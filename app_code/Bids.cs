using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Bids
/// </summary>
public class Bids: ConnectionString
{
    #region DataMember
    private Guid bidid;
    public Guid _bidid
    {
        get
        {
            return bidid;
        }
        set
        {
            this.bidid = value;
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
    private string amount;
    public string _amount
    {
        get
        {
            return amount;
        }
        set
        {
            amount = value;
        }
    }
    private string status;
    public string _status
    {
        get
        {
            return status;
        }
        set
        {
            status = value;
        }
    }




    #endregion



    public void SaveBid()
    {
        SqlConnection conn = new SqlConnection(Connstr);
        conn.Open();
        try
        {
            SqlCommand cmd = new SqlCommand("SP_SaveBid");
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fld_bidid", _bidid);
            cmd.Parameters.AddWithValue("@fld_clientid", _clientid);
            cmd.Parameters.AddWithValue("@fld_productid", _productid);
            cmd.Parameters.AddWithValue("@fld_amount", _amount);
            cmd.Parameters.AddWithValue("@fld_status", _status);
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

    public DataTable RetrieveBidsStatus()
    {
        DataTable BidsStatusDt = new DataTable();
        SqlConnection conn = new SqlConnection(Connstr);
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SP_RetreiveBidStatus");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@fld_clientid", _clientid);
            cmd.Parameters.AddWithValue("@fld_productid", _productid);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(BidsStatusDt);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {

        }
        return BidsStatusDt;
    }

    public void ModifyBid()
    {
        SqlConnection conn = new SqlConnection(Connstr);
        conn.Open();
        try
        {
            SqlCommand cmd = new SqlCommand("SP_ModifyBid");
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fld_clientid ", _clientid);
            cmd.Parameters.AddWithValue("@fld_productid", _productid);
            cmd.Parameters.AddWithValue("@fld_amount", _amount);
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
    public DataTable RetrieveBids()
    {
        DataTable BidsDt = new DataTable();
        SqlConnection conn = new SqlConnection(Connstr);
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SP_RetrieveBids");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@fld_productid", _productid);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(BidsDt);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {

        }
        return BidsDt;
    }
    public void UpdateStatus()
    {
        SqlConnection conn = new SqlConnection(Connstr);
        conn.Open();
        try
        {
            SqlCommand cmd = new SqlCommand("SP_UpdateStatus");
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fld_bidid ", _bidid);
            cmd.Parameters.AddWithValue("@fld_productid", _productid);
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
    public void RejectBid()
    {
        SqlConnection conn = new SqlConnection(Connstr);
        conn.Open();
        try
        {
            SqlCommand cmd = new SqlCommand("SP_RejectBid");
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fld_bidid ", _bidid);
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