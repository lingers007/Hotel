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


public partial class Admin : System.Web.UI.Page
{
    string selectSQL;
    string updateSQL;
    SqlCommand cmd = new SqlCommand();
    SqlConnection dbConn = new SqlConnection();
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Session["username"] = TextBox1.Text;
        string USERNAME = TextBox1.Text;
  string PASSWORD = TextBox2.Text;
        selectSQL = "select * from Users  WHERE " + "USERNAME = @USERNAME AND PASSWORD  = @PASSWORD ";
        dbConn.ConnectionString =   "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
        cmd.Connection = dbConn;
        cmd.CommandText = selectSQL;
        cmd.CommandType = CommandType.Text;

    // Create the parameter objects as specific as possible.
    cmd.Parameters.Add("@USERNAME", System.Data.SqlDbType.NVarChar, 50);
    cmd.Parameters.Add("@PASSWORD", System.Data.SqlDbType.NVarChar, 25);
  
    // Add the parameter values.  Validation should have already happened.
    cmd.Parameters["@USERNAME"].Value = USERNAME;
    cmd.Parameters["@PASSWORD"].Value = PASSWORD;
    cmd.Connection = dbConn;
  
  
        try
        {
            dbConn.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["Role"] = dr["Role"].ToString();
                if (dr["Role"].ToString() == "ADMIN HOTEL")
                {
                    Response.Redirect("Home3.aspx");
                }
                else if (dr["Role"].ToString() == "ADMIN APARTMENT")
                {
                    Response.Redirect("Home1.aspx");
                }
                else if (dr["Role"].ToString() == "SUPERUSER")
                {
                    Response.Redirect("Home.aspx");
                }
             else if (dr["Role"].ToString() == "GYM  APARTMENT")
                {
                    Response.Redirect("Home2.aspx");
                }
          else if (dr["Role"].ToString() == "GYM HOTEL")
                {
                    Response.Redirect("Home4.aspx");
                }

            }
            else
            {
                Label1.Text = "Sorry You Can't Login  ";
            }
            dr.Close();
        }
        catch (Exception err)
        {
            Label1.Text = "Error  Logging in  ";
            Label1.Text += err.Message;
        }
        finally
        {
            dbConn.Close();
        }
    }
}
