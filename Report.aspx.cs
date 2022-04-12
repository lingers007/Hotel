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
public partial class Report: System.Web.UI.Page
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

    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.ToString() == "View Completed Reservation")
        {
            //  Response.Write(selectSQL);
            // Session["session"] = RadComboBox2.SelectedItem.Text;
            Session["D"] = RadDatePicker3.SelectedDate.Value.ToShortDateString();
            Session["D1"] = RadDatePicker4.SelectedDate.Value.ToShortDateString();
            Session["C"] = DropDownList1.SelectedItem.Value;

           
            //DateTime d1 = RadDatePicker1.SelectedDate.Value.ToShortDateString();
            selectSQL = "select * from Booking where ArrivalD >=  '" + RadDatePicker3.SelectedDate.Value.ToShortDateString() + "' and  DepatureD <= '" + RadDatePicker4.SelectedDate.Value.ToShortDateString() + "' and Status3='" + DropDownList1.SelectedItem.Value + "' and Status='Done' ";
            dbConn.ConnectionString =  "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
            cmd.Connection = dbConn;
            cmd.CommandText = selectSQL;
            cmd.CommandType = CommandType.Text;





            try
            {
                dbConn.Open();
            Response.Write(selectSQL);

                // Response.Write(Session["E"].ToString());
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    Response.Redirect("ReportD.aspx");
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
        else if (DropDownList1.SelectedItem.ToString() == "View Cancelled Reservation")
        {


            // ;
            // Session["session"] = RadComboBox2.SelectedItem.Text;
            Session["D"] = RadDatePicker3.SelectedDate.Value.ToShortDateString();
            Session["D1"] = RadDatePicker4.SelectedDate.Value.ToShortDateString();
            Session["C"] = DropDownList1.SelectedItem.Value;


            //DateTime d1 = RadDatePicker1.SelectedDate.Value.ToShortDateString();
            selectSQL = "select * from Booking where ArrivalD >=  '" + RadDatePicker3.SelectedDate.Value.ToShortDateString() + "' and  DepatureD <= '" + RadDatePicker4.SelectedDate.Value.ToShortDateString() + "' and Status3='" + DropDownList1.SelectedItem.Value + "' and Status='cancel' and Status2='cancel' ";
            dbConn.ConnectionString =  "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
            cmd.Connection = dbConn;
            cmd.CommandText = selectSQL;
            cmd.CommandType = CommandType.Text;


            Response.Write(selectSQL);


            try
            {
                dbConn.Open();
                Response.Write(selectSQL);

                // Response.Write(Session["E"].ToString());
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    Response.Redirect("ReportD.aspx");
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
        else
        {

        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
}
