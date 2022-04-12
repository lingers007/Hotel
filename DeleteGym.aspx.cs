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


public partial class DeleteGym : System.Web.UI.Page
{
    string selectSQL;
    string selectSQL3;
    string selectSQL23;
    string deleteSQL;
    string selectSQL1;


    string updateSQL;

    string updateSQL1;

    string updateSQL2;

    SqlCommand cmd = new SqlCommand();
    SqlCommand cmd1 = new SqlCommand();
    SqlCommand cmd2 = new SqlCommand();
    SqlCommand cmd3 = new SqlCommand();
    public SqlConnection dbConn = new SqlConnection();
    public SqlConnection dbConn1 = new SqlConnection();
    public SqlConnection dbConn3 = new SqlConnection();
    public SqlConnection dbConn4 = new SqlConnection();
    public SqlConnection dbConn5 = new SqlConnection();
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

     



        dbConn.ConnectionString = "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";

        Session["id"] = Request.QueryString["id"].ToString();

        //Session["id"] = dr["id"].ToString();

        deleteSQL = "Delete  from Gym where id='" + Session["id"].ToString() + "'";

        dbConn.ConnectionString = "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
        cmd.Connection = dbConn;
        cmd.CommandText = deleteSQL;
        cmd.CommandType = CommandType.Text;
        //cmd.Parameters.AddWithValue("@AdmissionNo", TextBox1.Text);
        try
        {
            dbConn.Open();

            int deleted = cmd.ExecuteNonQuery();
            if (deleted == 1)
            {
                Label1.Text = "Record Deleted";

                Response.Redirect("GymView.aspx");


            }
            else
            {
                // Response.Write("updated1");
                Label1.Text = "Record Not Deleted";
                // TextBox1.Text = "";



            }




        }

        catch (Exception err)
        {
            Response.Write(err.Message);

        }
        finally
        {
            dbConn.Close();
        }







    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
}
