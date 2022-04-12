﻿using System;
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

public partial class EmptyG : System.Web.UI.Page
{
    String selectSQL91;
    String selectSQL95;
    String selectSQL13;
    String selectSQL14;
    String selectSQL;
    String selectSQL16;
    String selectSQL15;
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
    SqlCommand cmd13 = new SqlCommand();
    SqlCommand cmd1 = new SqlCommand();
    SqlCommand cmd2 = new SqlCommand();
    SqlCommand cmd3 = new SqlCommand();
    SqlCommand cmd16 = new SqlCommand();
    SqlCommand cmd14 = new SqlCommand();
    SqlCommand cmd15 = new SqlCommand();
    SqlConnection dbConn = new SqlConnection();
    SqlConnection dbConn1 = new SqlConnection();
    SqlConnection dbConn13 = new SqlConnection();
    SqlConnection dbConn2 = new SqlConnection();
    SqlConnection dbConn3 = new SqlConnection();
    SqlConnection l = new SqlConnection();
    SqlConnection dbConn5 = new SqlConnection();
    SqlConnection dbConn7 = new SqlConnection();
    SqlConnection dbConn16 = new SqlConnection();
    SqlConnection dbConn14 = new SqlConnection();
    SqlConnection dbConn15 = new SqlConnection();
    SqlDataReader dr, dr1, dr16, dr4, dr14, dr15;
    // public string dbstring = WebConfigurationManager.ConnectionStrings["DB_SCH"].ConnectionString;
    public SqlConnection MyConnection, MyConnection1;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String insertSQL;

        DateTime endTime = DateTime.Now;
        var tt = endTime.ToString();
        var x = DateTime.Parse(tt).ToShortDateString();


        insertSQL = "INSERT INTO Gas(";
        insertSQL += "Flatname,Original,Destination,Action,LongD,ShortD,Posted,Type)";
        insertSQL += "VALUES('";
        insertSQL += DropDownList1.SelectedItem.Text + "','";
        insertSQL += "NIL" + "','";
        insertSQL += "NIL" + "','";
        insertSQL += "EMPTY" + "','";


        insertSQL += endTime + "','";

        insertSQL += x + "','";
        insertSQL += Session["username"] + "','";
        insertSQL += "Hotel" + "')";



        // insertSQL += TextBox5.Text + "@yahoo.com  ')";
        // insertSQL += TextBox5.Text + "@yahoo.com  ')";




        String connectionString =  "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
        // "Data Source=NERO-SIGBENU\\SQLEXPRESS01;Initial Catalog=da24;Integrated Security=false;";
        SqlConnection con4 = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(insertSQL, con4);
        int added = 0;


        try
        {
            //Response.Write(insertSQL);
            con4.Open();
            added = cmd.ExecuteNonQuery();



            // Label6.Text = added.ToString();


            if (added == 1)
            {

                Response.Redirect("EThanks.aspx");


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
    protected void LinkButton2_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["username"] = "";
        Session.Remove("username");
    }
}