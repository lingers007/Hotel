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

public partial class Reserv : System.Web.UI.Page
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
    SqlConnection dbConn4 = new SqlConnection();
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
        Label6.Text = "";
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        Session["T"] = DropDownList1.SelectedItem.ToString();
        DateTime ss = Convert.ToDateTime(RadDatePicker1.SelectedDate.Value);

        DateTime tt = Convert.ToDateTime(RadDatePicker2.SelectedDate.Value);

        //Response.Write(ss);
        // Response.Write(tt);
        DateTime endTime = DateTime.Now;
        var shortDate = endTime.Date;
        TimeSpan span = endTime.Subtract(ss);

        int F = (int)span.TotalHours;

        // Response.Write(F);


        //DateTime p = Convert.ToDateTime(RadDatePicker3.SelectedDate.Value.ToShortDateString());
        //DateTime cd = DateTime.Now;
        //var shortDate = cd.Date;

        //  Response.Write(cd);
        // Response.Write(Convert.ToDateTime(RadDatePicker1.SelectedDate.Value.ToShortDateString()));
        if (Convert.ToDateTime(RadDatePicker1.SelectedDate.Value) > Convert.ToDateTime(RadDatePicker2.SelectedDate.Value))
        {
            Label6.Text = " Start Date Must Be Less Than End Date ";
        }

        else if (F > 24)
        {
            Label6.Text = "Start Date Must NOT Be Less Than Today ";
        }
        else if (Convert.ToDateTime(RadDatePicker1.SelectedDate.Value) == Convert.ToDateTime(RadDatePicker2.SelectedDate.Value))
        {
            Label6.Text = "Start Date and End Date Must Not Be The Same ";
        }
        else
        {
            if (DropDownList1.SelectedItem.ToString() == "2 Bed Apartment")
            {

                selectSQL = "  SELECT  Price  FROM Rooms where  Room_Type='" + DropDownList1.SelectedItem.Text + "'    ";
                //yimak.Src = "passport/" + Session["AdmissionNo"].ToString() + ".jpg";

                dbConn3.ConnectionString = "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
                //dbConn1.ConnectionString = "Data Source=NEW-VITAL\\SCHOOLSERVER; Initial Catalog=emma;Integrated Security=True;";

                cmd1.Connection = dbConn3;
                cmd1.CommandText = selectSQL;
                cmd1.CommandType = CommandType.Text;


                // Response.Write(selectSQL);


                dbConn3.Open();
                dr = cmd1.ExecuteReader();

                if (dr.Read())
                {




                    Session["P"] = dr["Price"].ToString();








                }

                else
                {
                    Label6.Text = "Could Not Get Price";

                }
                selectSQL1 = "  SELECT * FROM Booking where  ArrivalD  =  '" + RadDatePicker1.SelectedDate.Value.ToShortDateString() + "' and  DepatureD  = '" + RadDatePicker2.SelectedDate.Value.ToShortDateString() + "' and Status='Done'and Status2='Approved' and Status3='Approved'and Room_Type='" + DropDownList1.SelectedItem.ToString() + "'   ";
                //yimak.Src = "passport/" + Session["AdmissionNo"].ToString() + ".jpg";

                dbConn5.ConnectionString = "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
                //dbConn1.ConnectionString = "Data Source=NEW-VITAL\\SCHOOLSERVER; Initial Catalog=emma;Integrated Security=True;";

                cmd3.Connection = dbConn5;
                cmd3.CommandText = selectSQL1;
                cmd3.CommandType = CommandType.Text;


                try
                {


                    dbConn5.Open();
                    dr1 = cmd3.ExecuteReader();
                    //  Response.Write(selectSQL1);
                    if (dr1.Read())
                    {
                        Label6.Text = "2 Bedroom Apartment Not Available";
                    }
                    else
                    {



                        selectSQL14 = "  SELECT ArrivalD, DepatureD FROM Booking   where  Status='Done'and Status2='Approved' and Status3='Approved'and Room_Type='" + DropDownList1.SelectedItem.ToString() + "'   ";
                        //yimak.Src = "passport/" + Session["AdmissionNo"].ToString() + ".jpg";

                        dbConn14.ConnectionString = "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
                        //dbConn1.ConnectionString = "Data Source=NEW-VITAL\\SCHOOLSERVER; Initial Catalog=emma;Integrated Security=True;";

                        cmd14.Connection = dbConn14;
                        cmd14.CommandText = selectSQL14;
                        cmd14.CommandType = CommandType.Text;


                        try
                        {


                            dbConn14.Open();
                            dr14 = cmd14.ExecuteReader();
                            //  Response.Write(selectSQL14);
                            if (dr14.Read())
                            {

                                Session["AA"] = dr14["ArrivalD"].ToString();
                                Session["DD"] = dr14["DepatureD"].ToString();
                                //Response.Write(Session["AA"] );
                                // Response.Write(Session["DD"]);

                                if (Session["AA"] == "" && Session["DD"] == "")
                                {
                                    //Response.Write("na 4");
                                    String insertSQL;


                                    int Days = RadDatePicker2.SelectedDate.Value.Subtract(RadDatePicker1.SelectedDate.Value).Days;
                                    // Response.Write(Days);
                                    int Hours = Days * 24 + 12;
                                    // Response.Write(Hours);

                                    DateTime startTime = DateTime.Now;
                                    // 





                                    insertSQL = "INSERT INTO Booking(";
                                    insertSQL += "Surname,Firstname,Email,Phone,Price,Room_Type,Arrival,Depature,ArrivalD,DepatureD,Smoking,CT,Status,Type,Discount,Control)";
                                    insertSQL += "VALUES('";
                                    insertSQL += TextBox1.Text.Trim() + "','";
                                    insertSQL += TextBox2.Text.Trim() + "','";
                                    insertSQL += TextBox3.Text.Trim() + "','";
                                    insertSQL += TextBox4.Text.Trim() + "','";
                                    insertSQL += Session["P"] + "','";
                                    insertSQL += Session["T"] + "','";
                                    insertSQL += RadDatePicker1.SelectedDate.Value + "','";
                                    insertSQL += RadDatePicker2.SelectedDate.Value + "','";
                                    insertSQL += RadDatePicker1.SelectedDate.Value.ToShortDateString() + "','";
                                    insertSQL += RadDatePicker2.SelectedDate.Value.ToShortDateString() + "','";
                                    insertSQL += DropDownList2.SelectedValue.ToString() + "','";
                                    insertSQL += startTime + "','";
                                    insertSQL += "Pending" + "','";

                                    insertSQL += "Apartment" + "','";

                                    insertSQL += "No" + "','";
                                    insertSQL += Hours + "')";



                                    // insertSQL += TextBox5.Text + "@yahoo.com  ')";
                                    // insertSQL += TextBox5.Text + "@yahoo.com  ')";




                                    String connectionString = "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
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

                                            Response.Redirect("Thanks.aspx");


                                        }
                                        else
                                        {
                                            Label6.Text = "Records Not Inserted";

                                        }
                                        // Label1.Text = added.ToString() + "records Inserted";
                                    }



                                    catch (Exception err)
                                    {

                                        Label6.Text += err.ToString();
                                    }
                                    finally
                                    {
                                        con4.Close();
                                    }
                                }
                                else
                                {
                                    DateTime A1 = Convert.ToDateTime(Session["AA"].ToString());
                                    // Convert.ToDateTime();
                                    DateTime D1 = Convert.ToDateTime(Session["DD"].ToString());

                                    string V = D1.ToString("dd/M/yyyy");
                                    // Response.Write(A1);
                                    //   Response.Write(D1);

                                    if (ss <= A1 && tt <= D1)
                                    {
                                        Label6.Text = "2 Bed Apartment Not Available Till" + "   " + V;
                                    }
                                    else if (ss <= A1 && tt >= D1)
                                    {
                                        Label6.Text = "2 Bed Apartment Not Available Till" + "   " + V;

                                    }
                                    else if (ss >= A1 && tt <= D1)
                                    {
                                        Label6.Text = "2 Bed Apartment Not Available Till" + "   " + V;

                                    }
                                    else if (ss <= D1 && tt >= D1)
                                    {
                                        Label6.Text = "2 Bed Apartment Not Available Till" + "   " + V;

                                    }

                                    else
                                    {

                                        String insertSQL;


                                        int Days = RadDatePicker2.SelectedDate.Value.Subtract(RadDatePicker1.SelectedDate.Value).Days;
                                        // Response.Write(Days);
                                        int Hours = Days * 24 + 12;
                                        // Response.Write(Hours);

                                        DateTime startTime = DateTime.Now;
                                        // 



                                        insertSQL = "INSERT INTO Booking(";
                                        insertSQL += "Surname,Firstname,Email,Phone,Price,Room_Type,Arrival,Depature,ArrivalD,DepatureD,Smoking,CT,Status,Type,Discount,Control)";
                                    

                                         insertSQL += "VALUES('";
                                        insertSQL += TextBox1.Text.Trim() + "','";
                                        insertSQL += TextBox2.Text.Trim() + "','";
                                        insertSQL += TextBox3.Text.Trim() + "','";
                                        insertSQL += TextBox4.Text.Trim() + "','";
                                        insertSQL += Session["P"] + "','";
                                        insertSQL += Session["T"] + "','";
                                        insertSQL += RadDatePicker1.SelectedDate.Value + "','";
                                        insertSQL += RadDatePicker2.SelectedDate.Value + "','";
                                        insertSQL += RadDatePicker1.SelectedDate.Value.ToShortDateString() + "','";
                                        insertSQL += RadDatePicker2.SelectedDate.Value.ToShortDateString() + "','";
                                        insertSQL += DropDownList2.SelectedValue.ToString() + "','";
                                        insertSQL += startTime + "','";
                                        insertSQL += "Pending" + "','";
                                        insertSQL += "Apartment" + "','";
                                        insertSQL += "No" + "','";
                                        insertSQL += Hours + "')";



                                        // insertSQL += TextBox5.Text + "@yahoo.com  ')";
                                        // insertSQL += TextBox5.Text + "@yahoo.com  ')";




                                        String connectionString = "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
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

                                                Response.Redirect("Thanks.aspx");


                                            }
                                            else
                                            {
                                                Label6.Text = "Records Not Inserted";

                                            }
                                            // Label1.Text = added.ToString() + "records Inserted";
                                        }



                                        catch (Exception err)
                                        {

                                            Label6.Text += err.ToString();
                                        }
                                        finally
                                        {
                                            con4.Close();
                                        }

                                    }

                                }


                            }


                            else
                            {

                                String insertSQL;


                                int Days = RadDatePicker2.SelectedDate.Value.Subtract(RadDatePicker1.SelectedDate.Value).Days;
                                // Response.Write(Days);
                                int Hours = Days * 24 + 12;
                                // Response.Write(Hours);

                                DateTime startTime = DateTime.Now;
                                // 




                                        insertSQL = "INSERT INTO Booking(";
                                        insertSQL += "Surname,Firstname,Email,Phone,Price,Room_Type,Arrival,Depature,ArrivalD,DepatureD,Smoking,CT,Status,Type,Discount,Control)";
                                    

                               insertSQL += "VALUES('";
                                insertSQL += TextBox1.Text.Trim() + "','";
                                insertSQL += TextBox2.Text.Trim() + "','";
                                insertSQL += TextBox3.Text.Trim() + "','";
                                insertSQL += TextBox4.Text.Trim() + "','";
                                insertSQL += Session["P"] + "','";
                                insertSQL += Session["T"] + "','";
                                insertSQL += RadDatePicker1.SelectedDate.Value + "','";
                                insertSQL += RadDatePicker2.SelectedDate.Value + "','";
                                insertSQL += RadDatePicker1.SelectedDate.Value.ToShortDateString() + "','";
                                insertSQL += RadDatePicker2.SelectedDate.Value.ToShortDateString() + "','";
                                insertSQL += DropDownList2.SelectedValue.ToString() + "','";
                                insertSQL += startTime + "','";
                                insertSQL += "Pending" + "','";

                                insertSQL += "Apartment" + "','";

                                insertSQL += "No" + "','";
                                insertSQL += Hours + "')";



                                // insertSQL += TextBox5.Text + "@yahoo.com  ')";
                                // insertSQL += TextBox5.Text + "@yahoo.com  ')";




                                String connectionString = "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
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

                                        Response.Redirect("Thanks.aspx");


                                    }
                                    else
                                    {
                                        Label6.Text = "Records Not Inserted";

                                    }
                                    // Label1.Text = added.ToString() + "records Inserted";
                                }



                                catch (Exception err)
                                {

                                    Label6.Text += err.ToString();
                                }
                                finally
                                {
                                    con4.Close();
                                }






                            }

                            dr14.Close();
                        }
                        catch (Exception err)
                        {
                            Label6.Text = "Error  Getting Room ";
                            Label6.Text += err.ToString();
                        }
                        finally
                        {
                            dbConn5.Close();
                        }






                    }

                    dr1.Close();
                }
                catch (Exception err)
                {
                    Label6.Text = "Error  Getting Room ";
                    Label6.Text += err.Message;
                }
                finally
                {
                    dbConn5.Close();
                }


            }
            else if (DropDownList1.SelectedItem.ToString() == "1 Bed Apartment")
            {
                selectSQL = "  SELECT  Price  FROM Rooms where  Room_Type='" + DropDownList1.SelectedItem.Text + "'    ";
                //yimak.Src = "passport/" + Session["AdmissionNo"].ToString() + ".jpg";

                dbConn3.ConnectionString = "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
                //dbConn1.ConnectionString = "Data Source=NEW-VITAL\\SCHOOLSERVER; Initial Catalog=emma;Integrated Security=True;";

                cmd1.Connection = dbConn3;
                cmd1.CommandText = selectSQL;
                cmd1.CommandType = CommandType.Text;


                //Response.Write(selectSQL);


                dbConn3.Open();
                dr = cmd1.ExecuteReader();

                if (dr.Read())
                {




                    Session["P"] = dr["Price"].ToString();








                }

                else
                {
                    Label6.Text = "Could Not Get Price";

                }

                selectSQL1 = "  SELECT id ,'Count'=(select count(id)  FROM Booking where  Status='Done'and Status2='Approved' and Status3='Approved'and Room_Type='" + DropDownList1.SelectedItem.ToString() + "') FROM Booking ";




                //yimak.Src = "passport/" + Session["AdmissionNo"].ToString() + ".jpg";

                dbConn5.ConnectionString = "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
                //dbConn1.ConnectionString = "Data Source=NEW-VITAL\\SCHOOLSERVER; Initial Catalog=emma;Integrated Security=True;";

                cmd3.Connection = dbConn5;
                cmd3.CommandText = selectSQL1;
                cmd3.CommandType = CommandType.Text;


                try
                {


                    dbConn5.Open();
                    dr1 = cmd3.ExecuteReader();
                    //   Response.Write(selectSQL1);
                    if (dr1.Read())
                    {



                        Session["q"] = dr1["Count"].ToString();
                        int dd = Int32.Parse(Session["q"].ToString());
                        //Response.Write(dd);
                        Session["qt"] = dd;

                        if (dd >= 11)
                        {

                            selectSQL14 = "  SELECT  'AA'=( min(ArrivalD)),  'DD'=( min(DepatureD)) FROM Booking   where  Status='Done'and Status2='Approved' and Status3='Approved'and Room_Type='" + DropDownList1.SelectedItem.ToString() + "'   ";


                            dbConn14.ConnectionString = "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";



                            cmd14.Connection = dbConn14;
                            cmd14.CommandText = selectSQL14;
                            cmd14.CommandType = CommandType.Text;


                            try
                            {


                                dbConn14.Open();
                                dr14 = cmd14.ExecuteReader();
                                //  Response.Write(selectSQL14);
                                if (dr14.Read())
                                {

                                    Session["AA"] = dr14["AA"].ToString();
                                    Session["DD"] = dr14["DD"].ToString();

                                    DateTime A1 = Convert.ToDateTime(Session["AA"].ToString());
                                    // Convert.ToDateTime();
                                    DateTime D1 = Convert.ToDateTime(Session["DD"].ToString());

                                    string V = D1.ToString("dd/M/yyyy");

                                    //   Response.Write(Session["AA"]);
                                    // Response.Write(Session["DD"]);
                                    //  Response.Write(V);

                                    Label6.Text = "1 Bed Apartment Not Available Till " + V;



                                }


                                else
                                {





                                }

                                dr14.Close();
                            }
                            catch (Exception err)
                            {
                                Label6.Text = "Error  Getting Room ";
                                Label6.Text += err.ToString();
                            }
                            finally
                            {
                                dbConn5.Close();
                            }



                        }
                        else if (dd < 11)
                        {


                            String insertSQL;


                            int Days = RadDatePicker2.SelectedDate.Value.Subtract(RadDatePicker1.SelectedDate.Value).Days;
                            // Response.Write(Days);
                            int Hours = Days * 24 + 12;
                            // Response.Write(Hours);

                            DateTime startTime = DateTime.Now;
                            // 




                            insertSQL = "INSERT INTO Booking(";
                            insertSQL += "Surname,Firstname,Email,Phone,Price,Room_Type,Arrival,Depature,ArrivalD,DepatureD,Smoking,CT,Status,Type,Discount,Control)";
                            insertSQL += "VALUES('";
                            insertSQL += TextBox1.Text.Trim() + "','";
                            insertSQL += TextBox2.Text.Trim() + "','";
                            insertSQL += TextBox3.Text.Trim() + "','";
                            insertSQL += TextBox4.Text.Trim() + "','";
                            insertSQL += Session["P"] + "','";
                            insertSQL += Session["T"] + "','";
                            insertSQL += RadDatePicker1.SelectedDate.Value + "','";
                            insertSQL += RadDatePicker2.SelectedDate.Value + "','";
                            insertSQL += RadDatePicker1.SelectedDate.Value.ToShortDateString() + "','";
                            insertSQL += RadDatePicker2.SelectedDate.Value.ToShortDateString() + "','";
                            insertSQL += DropDownList2.SelectedValue.ToString() + "','";
                            insertSQL += startTime + "','";
                            insertSQL += "Pending" + "','";
                            insertSQL += "Apartment" + "','";
                            insertSQL += "No" + "','";
                            insertSQL += Hours + "')";



                            // insertSQL += TextBox5.Text + "@yahoo.com  ')";
                            // insertSQL += TextBox5.Text + "@yahoo.com  ')";




                            String connectionString = "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
                            SqlConnection con4 = new SqlConnection(connectionString);
                            SqlCommand cmd = new SqlCommand(insertSQL, con4);
                            int added = 0;


                            try
                            {
                                Response.Write(insertSQL);
                                con4.Open();
                                added = cmd.ExecuteNonQuery();



                                // Label6.Text = added.ToString();


                                if (added == 1)
                                {

                                    Response.Redirect("Thanks.aspx");


                                }
                                else
                                {
                                    Label6.Text = "Records Not Inserted";

                                }
                                // Label1.Text = added.ToString() + "records Inserted";
                            }



                            catch (Exception err)
                            {

                                Label6.Text += err.ToString();
                            }
                            finally
                            {
                                con4.Close();
                            }






                        }





                        //Label6.Text = "1  Bedroom Apartment Not Availbale";
                    }
                    else
                    {





                    }

                    dr1.Close();
                }
                catch (Exception err)
                {
                    Label6.Text = "Error  Getting Room ";
                    Label6.Text += err.ToString();
                }
                finally
                {
                    dbConn5.Close();
                }






            }
            else if (DropDownList1.SelectedItem.ToString() == "Roof  Top")
            {


                selectSQL = "  SELECT  Price  FROM Rooms where  Room_Type='" + DropDownList1.SelectedItem.Text + "'    ";
                //yimak.Src = "passport/" + Session["AdmissionNo"].ToString() + ".jpg";

                dbConn3.ConnectionString = "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
                //dbConn1.ConnectionString = "Data Source=NEW-VITAL\\SCHOOLSERVER; Initial Catalog=emma;Integrated Security=True;";

                cmd1.Connection = dbConn3;
                cmd1.CommandText = selectSQL;
                cmd1.CommandType = CommandType.Text;


                // Response.Write(selectSQL);


                dbConn3.Open();
                dr = cmd1.ExecuteReader();

                if (dr.Read())
                {




                    Session["P"] = dr["Price"].ToString();








                }

                else
                {
                    Label6.Text = "Could Not Get Price";

                }
                selectSQL1 = "  SELECT * FROM Booking where  ArrivalD  =  '" + RadDatePicker1.SelectedDate.Value.ToShortDateString() + "' and  DepatureD  = '" + RadDatePicker2.SelectedDate.Value.ToShortDateString() + "' and Status='Done'and Status2='Approved' and Status3='Approved'and Room_Type='" + DropDownList1.SelectedItem.ToString() + "'   ";
                //yimak.Src = "passport/" + Session["AdmissionNo"].ToString() + ".jpg";

                dbConn5.ConnectionString = "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
                //dbConn1.ConnectionString = "Data Source=NEW-VITAL\\SCHOOLSERVER; Initial Catalog=emma;Integrated Security=True;";

                cmd3.Connection = dbConn5;
                cmd3.CommandText = selectSQL1;
                cmd3.CommandType = CommandType.Text;


                try
                {


                    dbConn5.Open();
                    dr1 = cmd3.ExecuteReader();
                    //  Response.Write(selectSQL1);
                    if (dr1.Read())
                    {
                        Label6.Text = "Roof Top Not Available";
                    }
                    else
                    {



                        selectSQL14 = "  SELECT ArrivalD, DepatureD FROM Booking   where  Status='Done'and Status2='Approved' and Status3='Approved'and Room_Type='" + DropDownList1.SelectedItem.ToString() + "'   ";
                        //yimak.Src = "passport/" + Session["AdmissionNo"].ToString() + ".jpg";

                        dbConn14.ConnectionString = "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
                        //dbConn1.ConnectionString = "Data Source=NEW-VITAL\\SCHOOLSERVER; Initial Catalog=emma;Integrated Security=True;";

                        cmd14.Connection = dbConn14;
                        cmd14.CommandText = selectSQL14;
                        cmd14.CommandType = CommandType.Text;


                        try
                        {


                            dbConn14.Open();
                            dr14 = cmd14.ExecuteReader();
                            //  Response.Write(selectSQL14);
                            if (dr14.Read())
                            {

                                Session["AA"] = dr14["ArrivalD"].ToString();
                                Session["DD"] = dr14["DepatureD"].ToString();
                                //Response.Write(Session["AA"] );
                                // Response.Write(Session["DD"]);

                                if (Session["AA"] == "" && Session["DD"] == "")
                                {
                                    //Response.Write("na 4");
                                    String insertSQL;


                                    int Days = RadDatePicker2.SelectedDate.Value.Subtract(RadDatePicker1.SelectedDate.Value).Days;
                                    // Response.Write(Days);
                                    int Hours = Days * 24 + 12;
                                    // Response.Write(Hours);

                                    DateTime startTime = DateTime.Now;
                                    // 





                                    insertSQL = "INSERT INTO Booking(";
                                    insertSQL += "Surname,Firstname,Email,Phone,Price,Room_Type,Arrival,Depature,ArrivalD,DepatureD,Smoking,CT,Status,Type,Discount,Control)";
                                    insertSQL += "VALUES('";
                                    insertSQL += TextBox1.Text.Trim() + "','";
                                    insertSQL += TextBox2.Text.Trim() + "','";
                                    insertSQL += TextBox3.Text.Trim() + "','";
                                    insertSQL += TextBox4.Text.Trim() + "','";
                                    insertSQL += Session["P"] + "','";
                                    insertSQL += Session["T"] + "','";
                                    insertSQL += RadDatePicker1.SelectedDate.Value + "','";
                                    insertSQL += RadDatePicker2.SelectedDate.Value + "','";
                                    insertSQL += RadDatePicker1.SelectedDate.Value.ToShortDateString() + "','";
                                    insertSQL += RadDatePicker2.SelectedDate.Value.ToShortDateString() + "','";
                                    insertSQL += DropDownList2.SelectedValue.ToString() + "','";
                                    insertSQL += startTime + "','";
                                    insertSQL += "Pending" + "','";
                                    insertSQL += "Apartment" + "','";
                                    insertSQL += "No" + "','";
                                    insertSQL += Hours + "')";



                                    // insertSQL += TextBox5.Text + "@yahoo.com  ')";
                                    // insertSQL += TextBox5.Text + "@yahoo.com  ')";




                                    String connectionString = "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
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

                                            Response.Redirect("Thanks.aspx");


                                        }
                                        else
                                        {
                                            Label6.Text = "Records Not Inserted";

                                        }
                                        // Label1.Text = added.ToString() + "records Inserted";
                                    }



                                    catch (Exception err)
                                    {

                                        Label6.Text += err.ToString();
                                    }
                                    finally
                                    {
                                        con4.Close();
                                    }
                                }
                                else
                                {
                                    DateTime A1 = Convert.ToDateTime(Session["AA"].ToString());
                                    // Convert.ToDateTime();
                                    DateTime D1 = Convert.ToDateTime(Session["DD"].ToString());

                                    string V = D1.ToString("dd/M/yyyy");
                                    // Response.Write(A1);
                                    //   Response.Write(D1);

                                    if (ss <= A1 && tt <= D1)
                                    {
                                        Label6.Text = "Roof Top Not Available Till" + "   " + V;
                                    }
                                    else if (ss <= A1 && tt >= D1)
                                    {
                                        Label6.Text = "Roof Top Not Available Till" + "   " + V;

                                    }
                                    else if (ss >= A1 && tt <= D1)
                                    {
                                        Label6.Text = "Roof Top Not Available Till" + "   " + V;

                                    }
                                    else if (ss <= D1 && tt >= D1)
                                    {
                                        Label6.Text = "Roof Top Not Available Till" + "   " + V;

                                    }

                                    else
                                    {

                                        String insertSQL;


                                        int Days = RadDatePicker2.SelectedDate.Value.Subtract(RadDatePicker1.SelectedDate.Value).Days;
                                        // Response.Write(Days);
                                        int Hours = Days * 24 + 12;
                                        // Response.Write(Hours);

                                        DateTime startTime = DateTime.Now;
                                        // 





                                        insertSQL = "INSERT INTO Booking(";
                                        insertSQL += "Surname,Firstname,Email,Phone,Price,Room_Type,Arrival,Depature,ArrivalD,DepatureD,Smoking,CT,Status,Type,Discount,Control)";
                                        insertSQL += "VALUES('";
                                        insertSQL += TextBox1.Text.Trim() + "','";
                                        insertSQL += TextBox2.Text.Trim() + "','";
                                        insertSQL += TextBox3.Text.Trim() + "','";
                                        insertSQL += TextBox4.Text.Trim() + "','";
                                        insertSQL += Session["P"] + "','";
                                        insertSQL += Session["T"] + "','";
                                        insertSQL += RadDatePicker1.SelectedDate.Value + "','";
                                        insertSQL += RadDatePicker2.SelectedDate.Value + "','";
                                        insertSQL += RadDatePicker1.SelectedDate.Value.ToShortDateString() + "','";
                                        insertSQL += RadDatePicker2.SelectedDate.Value.ToShortDateString() + "','";
                                        insertSQL += DropDownList2.SelectedValue.ToString() + "','";
                                        insertSQL += startTime + "','";
                                        insertSQL += "Pending" + "','";
                                        insertSQL += "Apartment" + "','";
                                        insertSQL += "No" + "','";
                                        insertSQL += Hours + "')";



                                        // insertSQL += TextBox5.Text + "@yahoo.com  ')";
                                        // insertSQL += TextBox5.Text + "@yahoo.com  ')";




                                        String connectionString = "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
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

                                                Response.Redirect("Thanks.aspx");


                                            }
                                            else
                                            {
                                                Label6.Text = "Records Not Inserted";

                                            }
                                            // Label1.Text = added.ToString() + "records Inserted";
                                        }



                                        catch (Exception err)
                                        {

                                            Label6.Text += err.ToString();
                                        }
                                        finally
                                        {
                                            con4.Close();
                                        }

                                    }

                                }


                            }


                            else
                            {

                                String insertSQL;


                                int Days = RadDatePicker2.SelectedDate.Value.Subtract(RadDatePicker1.SelectedDate.Value).Days;
                                // Response.Write(Days);
                                int Hours = Days * 24 + 12;
                                // Response.Write(Hours);

                                DateTime startTime = DateTime.Now;
                                // 





                                insertSQL = "INSERT INTO Booking(";
                                insertSQL += "Surname,Firstname,Email,Phone,Price,Room_Type,Arrival,Depature,ArrivalD,DepatureD,Smoking,CT,Status,Type,Discount,Control)";
                                insertSQL += "VALUES('";
                                insertSQL += TextBox1.Text.Trim() + "','";
                                insertSQL += TextBox2.Text.Trim() + "','";
                                insertSQL += TextBox3.Text.Trim() + "','";
                                insertSQL += TextBox4.Text.Trim() + "','";
                                insertSQL += Session["P"] + "','";
                                insertSQL += Session["T"] + "','";
                                insertSQL += RadDatePicker1.SelectedDate.Value + "','";
                                insertSQL += RadDatePicker2.SelectedDate.Value + "','";
                                insertSQL += RadDatePicker1.SelectedDate.Value.ToShortDateString() + "','";
                                insertSQL += RadDatePicker2.SelectedDate.Value.ToShortDateString() + "','";
                                insertSQL += DropDownList2.SelectedValue.ToString() + "','";
                                insertSQL += startTime + "','";
                                insertSQL += "Pending" + "','";
                                insertSQL += "Apartment" + "','";
                                insertSQL += "No" + "','";
                                insertSQL += Hours + "')";



                                // insertSQL += TextBox5.Text + "@yahoo.com  ')";
                                // insertSQL += TextBox5.Text + "@yahoo.com  ')";




                                String connectionString = "Data Source=67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
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

                                        Response.Redirect("Thanks.aspx");


                                    }
                                    else
                                    {
                                        Label6.Text = "Records Not Inserted";

                                    }
                                    // Label1.Text = added.ToString() + "records Inserted";
                                }



                                catch (Exception err)
                                {

                                    Label6.Text += err.ToString();
                                }
                                finally
                                {
                                    con4.Close();
                                }






                            }

                            dr14.Close();
                        }
                        catch (Exception err)
                        {
                            Label6.Text = "Error  Getting Room ";
                            Label6.Text += err.ToString();
                        }
                        finally
                        {
                            dbConn5.Close();
                        }






                    }

                    dr1.Close();
                }
                catch (Exception err)
                {
                    Label6.Text = "Error  Getting Room ";
                    Label6.Text += err.Message;
                }
                finally
                {
                    dbConn5.Close();
                }





























            }







            else
            {

            }
        }


    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void RadDatePicker2_SelectedDateChanged(object sender, Telerik.Web.UI.Calendar.SelectedDateChangedEventArgs e)
    {
    }
    protected void RadDatePicker1_SelectedDateChanged(object sender, Telerik.Web.UI.Calendar.SelectedDateChangedEventArgs e)
    {

    }
}
