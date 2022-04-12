
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


public partial class Checkout2 : System.Web.UI.Page
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
        Session["id"] = Request.QueryString["id"].ToString();
        //Response.Write();
        selectSQL23 = "select * from Booking WHERE id ='" + Session["id"].ToString() + "' and Status2='Approved' ";
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

            if (dr.Read())
            {
                Session["R"] = dr["Room_Name"].ToString();
                Session["T"] = dr["Room_Type"].ToString();
                updateSQL6 = "update Booking set Status3 ='Checkout',Status5='free' , Checkin='NULL' where  id ='" + Session["id"].ToString() + "'";
                // Response.Write(updateSQL6);
                dbConn6.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";

                cmd6.Connection = dbConn6;
                cmd6.CommandText = updateSQL6;
                cmd6.CommandType = CommandType.Text;
                try
                {

                    dbConn6.Open();
                    Response.Write(updateSQL6);
                    int updated2 = cmd6.ExecuteNonQuery();
                    if (updated2 == 1)
                    {
                        updateSQL7 = "update Rooms set Status ='Free' where  Room_Name ='" + Session["R"].ToString() + "' and Room_Type ='" + Session["T"].ToString() + "' ";
                        Response.Write(updateSQL7);
                        dbConn7.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
                        cmd7.Connection = dbConn7;
                        cmd7.CommandText = updateSQL7;
                        cmd7.CommandType = CommandType.Text;
                        try
                        {

                            dbConn7.Open();
                            // Response.Write(updateSQL6);
                            int updated7 = cmd7.ExecuteNonQuery();
                            if (updated7 == 1)
                            {
                                Response.Redirect("ViewB1.aspx");
                            }
                            else
                            {
                               // Response.Redirect("VB.aspx");
                            }
                            // Label1.Text = added.ToString() + "records Inserted";
                        }



                        catch (Exception err)
                        {

                            Label6.Text += err.ToString();
                        }
                        finally
                        {
                            dbConn7.Close();
                        }


                    }
                    else
                    {
                        Label6.Text = "Operations not Successful ";
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





                Label6.Text = "Staff Does Not Exist";



            }
        }

        catch (Exception err)
        {

            Label6.Text += err.ToString();
        }
        finally
        {
            dbConn3.Close();
        }
    }
}
