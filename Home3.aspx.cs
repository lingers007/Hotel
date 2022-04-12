using System;
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



public partial class Home3 : System.Web.UI.Page
{
    string selectSQL;
    string selectSQL3;
    string selectSQL23;

    string selectSQL1;


    string updateSQL;

    string updateSQL6;
    string updateSQL7;
    string updateSQL2;

    SqlCommand cmd = new SqlCommand();
    SqlCommand cmd1 = new SqlCommand();
    SqlCommand cmd6 = new SqlCommand();
    SqlCommand cmd3 = new SqlCommand();
    SqlCommand cmd7 = new SqlCommand();
    public SqlConnection dbConn = new SqlConnection();
    public SqlConnection dbConn1 = new SqlConnection();
    public SqlConnection dbConn3 = new SqlConnection();
    public SqlConnection dbConn6 = new SqlConnection();
    public SqlConnection dbConn5 = new SqlConnection();
    public SqlConnection dbConn7 = new SqlConnection();
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        // Response.Write();
        selectSQL23 = "select * from Debit WHERE updated ='pending' and Type='Hotel' ";
        // Response.Write(selectSQL23);


        dbConn3.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
        //dbConn1.ConnectionString = "Data Source=NEW-VITAL\\SCHOOLSERVER; Initial Catalog=emma;Integrated Security=True;";

        cmd1.Connection = dbConn3;
        cmd1.CommandText = selectSQL23;
        cmd1.CommandType = CommandType.Text;



        try
        {



            dbConn3.Open();
            dr = cmd1.ExecuteReader();
           // Response.Write(selectSQL23);
            if (dr.Read())
            {
                Label1.BackColor =System.Drawing.Color.Red;

                Label1.Text = "yes ";

                Label2.Text = "Debit Note Available";
            }
            else
            {





                Label1.BackColor = System.Drawing.Color.Green;

                 Label1.Text = "No ";

                 Label2.Text = "No Debit Note";

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