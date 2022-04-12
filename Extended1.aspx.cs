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


public partial class Extended1: System.Web.UI.Page
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
        // Response.Write();
        selectSQL23 = "select * from Booking WHERE id ='" + Session["id"].ToString() + "' and Status2='Approved' ";
       // Response.Write(selectSQL23);


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
                Label9.Text = dr["Surname"].ToString();
                Label10.Text = dr["Firstname"].ToString();
                Label11.Text = dr["Email"].ToString();
                Label12.Text = dr["Phone"].ToString();
                Label13.Text = dr["Room_Name"].ToString();
                Session["BB"] = dr["DepatureD"].ToString();
                DateTime A1 = Convert.ToDateTime(Session["BB"].ToString());

                Label14.Text = A1.ToString("dd/M/yyyy");

            }
            else
            {





                Label6.Text = "No Record";



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
  
    protected void LinkButton2_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["username"] = "";
        Session.Remove("username");
    }
    protected void RadDatePicker2_SelectedDateChanged(object sender, Telerik.Web.UI.Calendar.SelectedDateChangedEventArgs e)
    {

    }
    protected void OnConfirm(object sender, EventArgs e)
    {

        // Convert.ToDateTime();

        string confirmValue = Request.Form["confirm_value"];
        if (confirmValue == "Yes")
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert", true);

            DateTime tt = Convert.ToDateTime(RadDatePicker2.SelectedDate.Value);
            DateTime A1 = Convert.ToDateTime(Session["BB"].ToString());

            if (tt <= A1)
            {
                Label6.Text = "Extension Date must be higher that the formal Date";
            }
            else
            {
                updateSQL6 = "update Booking set DepatureD ='" + RadDatePicker2.SelectedDate.Value.ToShortDateString() + "' ,Depature ='" + RadDatePicker2.SelectedDate.Value + "'  where  id ='" + Session["id"].ToString() + "'";

                dbConn6.ConnectionString = "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";

                cmd6.Connection = dbConn6;
                cmd6.CommandText = updateSQL6;
                cmd6.CommandType = CommandType.Text;
                try
                {

                    dbConn6.Open();
                  //  Response.Write(updateSQL6);
                    int updated2 = cmd6.ExecuteNonQuery();
                    if (updated2 == 1)
                    {
                        Response.Redirect("Extend1.aspx");
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



        }


        else
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert", true);
            Label6.Text = "Extension Not Complete ";

        }
    }
}
