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
using System.IO;
public partial class Password : System.Web.UI.Page
{
    string selectSQL;
    string updateSQL;
    SqlCommand cmd = new SqlCommand();
    SqlConnection dbConn = new SqlConnection();
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Admin.aspx");
            }
            else
            {


            }
        }

        catch
        {
            Response.Redirect("Admin.aspx");
        }





    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["PASSWORD"] = TextBox1.Text;
        updateSQL = "update Users set Password='" + TextBox1.Text.ToString() + "' where username='" + Session["username"].ToString() + "'";

        dbConn.ConnectionString =  "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
        cmd.Connection = dbConn;
        cmd.CommandText = updateSQL;
        cmd.CommandType = CommandType.Text;
        try
        {

            dbConn.Open();
            int updated = cmd.ExecuteNonQuery();
            if (updated == 1)
            {
                Response.Redirect("ChangeP.aspx");
            }
            else
            {


                Label1.Text = "Process not Completed";
            }

            dbConn.Close();
        }
        catch (Exception err)
        {
            Response.Write(err.ToString());
        }
        finally
        {
            dbConn.Close();
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Remove("username");
        Session["username"] = "";
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {

    }
}
