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


public partial class Decide1 : System.Web.UI.Page
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
        //Response.Write();
        selectSQL23 = "select * from Booking WHERE id ='" + Session["id"].ToString() + "' and Status='Done'and Status2='Approved' and Status3='Approved' and Type='Hotel'";
        //Response.Write(selectSQL23);


        dbConn3.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
        //dbConn1.ConnectionString = "Data Source=NEW-VITAL\\SCHOOLSERVER; Initial Catalog=emma;Integrated Security=True;";

        cmd1.Connection = dbConn3;
        cmd1.CommandText = selectSQL23;
        cmd1.CommandType = CommandType.Text;



        try
        {



            dbConn3.Open();
            dr = cmd1.ExecuteReader();

            if (dr.Read())
            {


                Label2.Text = dr["pt"].ToString();

                if (dr["pt"].ToString() == "PART PAYMENT")
                {
                    Response.Redirect("Reciept2.aspx");
                }
                else
                {
                    Response.Redirect("Reciept3.aspx");
                }

            }
            else
            {





                Label1.Text = "Process Not Complete";



            }
        }

        catch (Exception err)
        {

            Label1.Text += err.ToString();
        }
        finally
        {
            dbConn3.Close();
        }


    }
}
