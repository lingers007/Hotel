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

public partial class GymView2 : System.Web.UI.Page
{
    string selectSQL;
    string updateSQL;
    SqlCommand cmd1 = new SqlCommand();
    SqlCommand cmd = new SqlCommand();
    public SqlConnection dbConn = new SqlConnection();
    public SqlConnection dbConn3 = new SqlConnection();

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





        //   dbConn.ConnectionString = "Data Source=LAPTOP-VOQ43JBA\\SQLEXPRESS; Initial Catalog=NampAK;Integrated Security=True;";

       // dbConn.ConnectionString = "Data Source=LAPTOP-VOQ43JBA\\SQLEXPRESS; Initial Catalog=da24;Integrated Security=True;"; 
     dbConn.ConnectionString = "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";




     
        cmd.Connection = dbConn;
        cmd.CommandText = selectSQL;
        //dbConn1.ConnectionString = "Data Source=HP-55A070CC0320\\SQLEXPRESS; Initial Catalog=emma;Integrated Security=True;";
        selectSQL = "select 'Nam1'=(select Sum(Price)   from Gym    where  Arrival  >= '" + Session["D"].ToString() + "' and Depature <= '" + Session["D1"].ToString()+ "' and Type='Hotel')  from Gym ";
        //yimak.Src = "passport/" + Session["AdmissionNo"].ToString() + ".jpg";


        cmd.Connection = dbConn;
        cmd.CommandText = selectSQL;
        cmd.CommandType = CommandType.Text;
        try
        {


            dbConn.Open();
            //dbConn1.Open();
            // Response.Write(selectSQL);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                Label2.Text = "&#8358;" + dr["Nam1"].ToString();
                
               

               // Label13.Text = dr["VIST"].ToString();
              //  Label14.Text = "&#8358;" + dr["VIST1"].ToString();



               

            
       
            }
            dr.Close();
        }


        catch (Exception err)
        {

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
        Session["username"] = "";
        Session.Remove("username");
    }
}
