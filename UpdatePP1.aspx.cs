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


public partial class UpdatePP1 : System.Web.UI.Page
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
        selectSQL5 = "select * from Booking WHERE id ='" + Session["id"].ToString() + "' and Type='Hotel'";
        dbConn5.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
        cmd5.Connection = dbConn5;
        cmd5.CommandText = selectSQL5;
        cmd5.CommandType = CommandType.Text;

        try
        {
            dbConn5.Open();

            dr5 = cmd5.ExecuteReader();
            if (dr5.Read())
            {
                // Response.Write(selectSQL5);
                Session["1"] = dr5["pp"].ToString();
                TextBox4.Text = dr5["bp"].ToString();
                Session["2"] = dr5["bp"].ToString();

                // string j = H.ToString();
                //Session["V1"] = H.ToString();
                // Response.Write(Session["V1"]);
                //Session["T"] = dr["Employ"].ToString();


            }
            else
            {
                //   Response.Write("he happen");



            }

        }
        catch (Exception err)
        {
            Label1.Text = "Error  Updating ";
            Label1.Text += err.ToString();
        }
        finally
        {
            dbConn5.Close();
        }
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        int i = Int32.Parse(Session["1"].ToString());
        int g = Int32.Parse(TextBox1.Text);
        int h = Int32.Parse(Session["2"].ToString());
        int j = h - g;
        int k = i + g;
        Session["T"] = j;
        Session["T2"] = k;
        int y = Int32.Parse(Session["T"].ToString());

        int z = Int32.Parse(Session["T2"].ToString());

        updateSQL6 = "update Booking set  bp='" + y + "' , pp='" + z + "'where  id ='" + Session["id"].ToString() + "'  and Type='Hotel'";
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
                Response.Redirect("UpdateP1.aspx");
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
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Session.Remove("username");
        Session["username"] = "";
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
}
