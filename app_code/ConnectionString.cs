using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ConnectionString
/// </summary>
public class ConnectionString
{
    #region DataMember
    public static string Connstr = ConfigurationManager.ConnectionStrings["Shopm8SolutionString"].ConnectionString;
    #endregion

    public ConnectionString()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}