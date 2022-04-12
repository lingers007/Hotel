using System;
using System.Collections;
using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Collections.Generic;
using System.Text;

public partial class Thanks : System.Web.UI.Page
{
    string selectSQL;
    string updateSQL;
    SqlCommand cmd1 = new SqlCommand();
    public SqlConnection dbConn = new SqlConnection();
    public SqlConnection dbConn3 = new SqlConnection();

    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
      
    }

  
}
