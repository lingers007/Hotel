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
using System.Data;
using System.Data.SqlClient;
public partial class ViewGym2 : System.Web.UI.Page
{
    string updateSQL, updateSQL1, updateSQL5, updateSQL6, updateSQL2, selectSQL;
    SqlCommand cmd = new SqlCommand();
    SqlCommand cmd1 = new SqlCommand();
    SqlCommand cmd2 = new SqlCommand();
    SqlCommand cmd3 = new SqlCommand();
    SqlCommand cmd5 = new SqlCommand();
    SqlCommand cmd6 = new SqlCommand();
    SqlCommand cmd9 = new SqlCommand();
    SqlConnection dbConn = new SqlConnection();
    SqlConnection dbConn1 = new SqlConnection();
    SqlConnection dbConn2 = new SqlConnection();
    SqlConnection dbConn3 = new SqlConnection();
    SqlConnection dbConn4 = new SqlConnection();
    SqlConnection dbConn5 = new SqlConnection();
    SqlConnection dbConn6 = new SqlConnection();
    SqlDataReader dr, dr1, dr2, dr3, dr5, dr6, dr8;
    // public string dbstring = WebConfigurationManager.ConnectionStrings["DB_SCH"].ConnectionString;
    protected SqlConnection MyConnection, MyConnection1;
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
    protected void Button1_Click1(object sender, EventArgs e)
    {


        Session["D"] = RadDatePicker3.SelectedDate.Value.ToShortDateString();
        Session["D1"] = RadDatePicker4.SelectedDate.Value.ToShortDateString();
      

         DateTime ss = Convert.ToDateTime(RadDatePicker3.SelectedDate.Value);
        DateTime endTime = DateTime.Now;
        var shortDate = endTime.Date;
        TimeSpan span = endTime.Subtract(ss);

  int F = (int)span.TotalHours ;

      //  Response.Write(F);


        //DateTime p = Convert.ToDateTime(RadDatePicker3.SelectedDate.Value.ToShortDateString());
        //DateTime cd = DateTime.Now;
        //var shortDate = cd.Date;

      //  Response.Write(cd);
       // Response.Write(Convert.ToDateTime(RadDatePicker1.SelectedDate.Value.ToShortDateString()));
        if (Convert.ToDateTime(RadDatePicker3.SelectedDate.Value) > Convert.ToDateTime(RadDatePicker4.SelectedDate.Value))
         {
             Label1.Text = " Start Date Must Be Less Than End Date ";
         }

        
        else if (Convert.ToDateTime(RadDatePicker3.SelectedDate.Value) == Convert.ToDateTime(RadDatePicker4.SelectedDate.Value))
        {
            Label1.Text = "Start Date and End Date Must Not Be The Same ";
        }
        else
        {

            //DateTime d1 = RadDatePicker1.SelectedDate.Value.ToShortDateString();
            selectSQL = "select * from Gym where ArrivalD >=  '" + RadDatePicker3.SelectedDate.Value.ToShortDateString() + "' and  DepatureD <= '" + RadDatePicker4.SelectedDate.Value.ToShortDateString() + "' and Type='Hotel' ";
         dbConn.ConnectionString = "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
           // dbConn.ConnectionString = "Data Source=LAPTOP-VOQ43JBA\\SQLEXPRESS; Initial Catalog=da24;Integrated Security=True;"; 
            cmd.Connection = dbConn;
            cmd.CommandText = selectSQL;
            cmd.CommandType = CommandType.Text;





            try
            {
                dbConn.Open();
               // Response.Write(selectSQL);

                // Response.Write(Session["E"].ToString());
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    Response.Redirect("GymView2.aspx");
                }


                else
                {
                    Label1.Text = "No Records For The Selected Dates ";
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
    protected void LinkButton2_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
}