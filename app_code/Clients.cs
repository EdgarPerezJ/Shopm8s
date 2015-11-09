using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Clients
/// </summary>
public class Clients: ConnectionString
{
    #region DataMember
    private Guid id;
    public Guid _id
    {
        get
        {
            return id;
        }
        set
        {
            this.id = value;
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
    private string password;
    public string _password
    {
        get
        {
            return password;
        }
        set
        {
            password = value;
        }
    }
    private string email;
    public string _email
    {
        get
        {
            return email;
        }
        set
        {
            email = value;
        }
    } 
   
    private object ProfilePicture;
    public object _ProfilePicture
    {
        get
        {
            return ProfilePicture;
        }
        set
        {
            ProfilePicture = value;
        }






    }
   


    #endregion

    public void SaveClient()
    {
        SqlConnection conn = new SqlConnection(Connstr);
        conn.Open();
        try
        {
            SqlCommand cmd = new SqlCommand("SP_SaveClient");
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Fld_ClientID", _id);
            cmd.Parameters.AddWithValue("@Fld_Name", _name);
            cmd.Parameters.AddWithValue("@Fld_Email", _email);
            cmd.Parameters.AddWithValue("@Fld_Password", _password);
            cmd.Parameters.AddWithValue("@Fld_profilepic", _ProfilePicture);

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

    public DataTable RetrieveClientInfo()
    {
        DataTable ClientInfoDt = new DataTable();
        SqlConnection conn = new SqlConnection(Connstr);
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SP_RetrieveClientInfo");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@Fld_Email", _email);
            cmd.Parameters.AddWithValue("@Fld_Password", _password);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ClientInfoDt);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {

        }
        return ClientInfoDt;
    }


    public DataTable RetrieveProfileInfo()
    {
        DataTable ProfileInfoDt = new DataTable();
        SqlConnection conn = new SqlConnection(Connstr);
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SP_RetrieveProfileInfo");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@Fld_ClientId", _id);       
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ProfileInfoDt);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {

        }
        return ProfileInfoDt;
    }


    public void EditClient()
    {
        SqlConnection conn = new SqlConnection(Connstr);
        conn.Open();
        try
        {
            SqlCommand cmd = new SqlCommand("SP_EditClient");
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Fld_ClientID ", _id);
            cmd.Parameters.AddWithValue("@Fld_UserName", _name);
            cmd.Parameters.AddWithValue("@Fld_Email", _email);           
            cmd.Parameters.AddWithValue("@Fld_profilepic", _ProfilePicture);
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


    public void EditPassword()
    {
        SqlConnection conn = new SqlConnection(Connstr);
        conn.Open();
        try
        {
            SqlCommand cmd = new SqlCommand("SP_EditPassword");
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Fld_ClientID ", _id);
            cmd.Parameters.AddWithValue("@Fld_UserPassword", _password);
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

    public DataTable RetrievePassword()
    {
        DataTable passwordDt = new DataTable();
        SqlConnection conn = new SqlConnection(Connstr);
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SP_RetrievePassword");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@Fld_ClientId", _id);           
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(passwordDt);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {

        }
        return passwordDt;
    }

    public void DeleteClient()
    {
        SqlConnection conn = new SqlConnection(Connstr);
        conn.Open();
        try
        {
            SqlCommand cmd = new SqlCommand("SP_DeleteClients");
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Fld_ClientID", _id);
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