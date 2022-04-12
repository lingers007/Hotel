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

public partial class Gym2nd : System.Web.UI.Page
{
    String selectSQL91;
    String selectSQL95;

    String selectSQL;
    String selectSQL32;
    String updateSQL1;
    String selectSQL1;
    String selectSQL45;
    String updateSQL45;
    String selectSQL46;
    String updateSQL46;
    String selectSQL47;
    String updateSQL47;
    String updateSQL95;
    String updateSQL2;
    SqlCommand cmd = new SqlCommand();
    SqlCommand cmd1 = new SqlCommand();
    SqlCommand cmd2 = new SqlCommand();
    SqlCommand cmd3 = new SqlCommand();
    SqlCommand cmd9 = new SqlCommand();
    SqlConnection dbConn = new SqlConnection();
    SqlConnection dbConn1 = new SqlConnection();
    SqlConnection dbConn2 = new SqlConnection();
    SqlConnection dbConn3 = new SqlConnection();
    SqlConnection dbConn4 = new SqlConnection();
    SqlConnection dbConn5 = new SqlConnection();
    SqlConnection dbConn7 = new SqlConnection();
    SqlConnection dbConn9 = new SqlConnection();
    SqlDataReader dr, dr1, dr9;
    // public string dbstring = WebConfigurationManager.ConnectionStrings["DB_SCH"].ConnectionString;
    public SqlConnection MyConnection, MyConnection1;
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

 DateTime ss = Convert.ToDateTime(RadDatePicker1.SelectedDate.Value);
        DateTime endTime = DateTime.Now;
        var shortDate = endTime.Date;
        TimeSpan span = endTime.Subtract(ss);

  int F = (int)span.TotalHours ;

      //  Response.Write(F);







        if (Convert.ToDateTime(RadDatePicker2.SelectedDate.Value) < Convert.ToDateTime(RadDatePicker1.SelectedDate.Value))
        {
            Label1.Text = " End Date Must Be Less Than Start Date ";
        }
 else if (F > 24)
        {
            Label1.Text = "Start Date Must Not Be Less Than Today ";
        }
        else
        {

        String insertSQL;
        insertSQL = "INSERT INTO Gym(";
        insertSQL += "Surname,Firstname,Phone,Status,Price,Type,Arrival,Depature,ArrivalD,DepatureD)";
        insertSQL += "VALUES('";
        insertSQL += TextBox1.Text.Trim() + "','";
        insertSQL += TextBox2.Text.Trim() + "','";
     
        insertSQL += TextBox4.Text.Trim() + "','";
        insertSQL += DropDownList1.SelectedItem + "','";
        insertSQL += DropDownList1.SelectedValue + "','";

        insertSQL += "Hotel" + "','";
        insertSQL += RadDatePicker1.SelectedDate.Value + "','";
        insertSQL += RadDatePicker2.SelectedDate.Value + "','";
        insertSQL += RadDatePicker1.SelectedDate.Value.ToShortDateString() + "','";
        insertSQL += RadDatePicker2.SelectedDate.Value.ToShortDateString() +  "')";
    



        // insertSQL += TextBox5.Text + "@yahoo.com  ')";
        // insertSQL += TextBox5.Text + "@yahoo.com  ')";




      //String connectionString = "Data Source=LAPTOP-VOQ43JBA\\SQLEXPRESS; Initial Catalog=da24;Integrated Security=True;";
       String connectionString = "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
   
        SqlConnection con4 = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(insertSQL, con4);
        int added = 0;


        try
        {
            // Response.Write(insertSQL);
            con4.Open();
            added = cmd.ExecuteNonQuery();



            // Label6.Text = added.ToString();


            if (added == 1)
            {

                Response.Redirect("Done.aspx");


            }
            else
            {
                Label1.Text = "Records Not Inserted";

            }
            // Label1.Text = added.ToString() + "records Inserted";
        }



        catch (Exception err)
        {

            Label1.Text += err.ToString();
        }
        finally
        {
            con4.Close();
        }

        }
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
    protected void RadDatePicker1_SelectedDateChanged(object sender, Telerik.Web.UI.Calendar.SelectedDateChangedEventArgs e)
    {

    }
    protected void RadDatePicker2_SelectedDateChanged(object sender, Telerik.Web.UI.Calendar.SelectedDateChangedEventArgs e)
    {

    }
}