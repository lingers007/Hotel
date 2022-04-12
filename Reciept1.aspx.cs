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


public partial class Reciept1 : System.Web.UI.Page
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

        selectSQL5 = "select Value1 from Static WHERE id ='1'";
        dbConn5.ConnectionString = "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
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
                Session["Val"] = dr5["Value1"].ToString();
                Label10.Text = "000" + Session["Val"].ToString();
                //  Response.Write(Session["Val"]);
                int G = Convert.ToInt32(Session["Val"]);
                int H = G + 1;
                string j = H.ToString();
                Session["V1"] = H.ToString();
                // Response.Write(Session["V1"]);
                //Session["T"] = dr["Employ"].ToString();

                updateSQL6 = "update Static set  Value1='" + Session["V1"].ToString() + "' where  id ='1'";
                // Response.Write(updateSQL6);
                dbConn6.ConnectionString = "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";

                cmd6.Connection = dbConn6;
                cmd6.CommandText = updateSQL6;
                cmd6.CommandType = CommandType.Text;
                try
                {

                    dbConn6.Open();
                    int updated2 = cmd6.ExecuteNonQuery();
                    if (updated2 == 1)
                    {
                    }
                    else
                    {
                        /// Response.Redirect("No.aspx");
                    }
                    // Label1.Text = added.ToString() + "records Inserted";
                }



                catch (Exception err)
                {

                    Label6.Text += err.ToString();
                }
                finally
                {
                    dbConn6.Close();
                }

            }
            else
            {
                //   Response.Write("he happen");



            }

        }
        catch (Exception err)
        {
            Label6.Text = "Error  Updating ";
            Label6.Text += err.ToString();
        }
        finally
        {
            dbConn5.Close();
        }

       // Session["id"] = Request.QueryString["id"].ToString();
        //Response.Write();
        selectSQL23 = "select * from Booking WHERE id ='" + Session["id"].ToString() + "' and Status='Done'and Status2='Approved' and Status3='Approved'";
        //Response.Write(selectSQL23);


        dbConn3.ConnectionString = "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
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
                DateTime ft = Convert.ToDateTime(dr["Arrival"].ToString());
                DateTime ft1 = Convert.ToDateTime(dr["Depature"].ToString());

                int Days = ft1.Subtract(ft).Days;
                // Response.Write(Days);
                int Hours = Days;
                Session["H"] = Hours;

                Label8.Text = dr["Surname"].ToString() + "              " + "                 " + dr["Firstname"].ToString();


                Label12.Text = dr["Room_Name"].ToString();
                Label11.Text = dr["Room_Type"].ToString();

                Label5.Text = dr["pt"].ToString();

                Label6.Text = dr["Amount"].ToString();
               
                Label9.Text = Session["H"].ToString();

                var tt = dr["ArrivalD"].ToString();
                var tt1 = dr["DepatureD"].ToString();

                var x = DateTime.Parse(tt).ToShortDateString();
                var y = DateTime.Parse(tt1).ToShortDateString();
                Label4.Text = x;
                Label3.Text = y;

            }
            else
            {





                Label1.Text = "Staff Does Not Exist";



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
    protected void LinkButton2_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Remove("username");
        Session["username"] = "";
    }
    protected void btnpopup_Click(object sender, EventArgs e)
    {
        ScriptManager.RegisterClientScriptBlock(this.Page, typeof(string), "print", "window.print();", true);
    }
}
