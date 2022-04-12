
using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


public partial class Updatedd : System.Web.UI.Page
{
    string selectSQL;
    string selectSQL5;
    string selectSQL3;
    string selectSQL23;

    string selectSQL1;


    string updateSQL;
    string updateSQL1;
    string updateSQL6;

    string updateSQL2;

    SqlCommand cmd = new SqlCommand();
    SqlCommand cmd2 = new SqlCommand();
    SqlCommand cmd1 = new SqlCommand();
    SqlCommand cmd6 = new SqlCommand();
    SqlCommand cmd5 = new SqlCommand();
    SqlCommand cmd3 = new SqlCommand();
    public SqlConnection dbConn = new SqlConnection();
    public SqlConnection dbConn1 = new SqlConnection();
    public SqlConnection dbConn4 = new SqlConnection();
    public SqlConnection dbConn3 = new SqlConnection();
    public SqlConnection dbConn6 = new SqlConnection();
    public SqlConnection dbConn5 = new SqlConnection();
    SqlDataReader dr, dr5;
    protected void Page_Load(object sender, EventArgs e)
    {
      Session["id"] = Request.QueryString["id"].ToString();
        updateSQL6 = "update Debit set  Updated='" + Session["username"] + "'  where  id ='" + Session["id"].ToString() + "'";
        // Response.Write(updateSQL6);
        dbConn6.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";

        cmd6.Connection = dbConn6;
        cmd6.CommandText = updateSQL6;
        cmd6.CommandType = CommandType.Text;
        try
        {

            dbConn6.Open();
            int updated2 = cmd6.ExecuteNonQuery();
            if (updated2 == 1)
            {
                Response.Redirect("VDebit.aspx");
            }
            else
            {
                /// Response.Redirect("No.aspx");
            }
            // Label1.Text = added.ToString() + "records Inserted";
        }



        catch (Exception err)
        {

            Label1.Text += err.ToString();
        }
        finally
        {
            dbConn6.Close();
        }
    }


}
