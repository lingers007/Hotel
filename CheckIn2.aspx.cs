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


public partial class CheckIn2 : System.Web.UI.Page
{
    String selectSQL91;
    String selectSQL95;
    String selectSQL13;
    String selectSQL14;
    String selectSQL;
    String selectSQL16;
    String selectSQL23;
    String selectSQL15;
    String updateSQL1;
    String selectSQL1;
    String selectSQL45;
    String updateSQL45;
    String selectSQL46;
    String updateSQL46;
    String selectSQL47;
    String updateSQL6;
    String updateSQL95;
    String updateSQL2;
    SqlCommand cmd = new SqlCommand();
    SqlCommand cmd13 = new SqlCommand();
    SqlCommand cmd1 = new SqlCommand();
    SqlCommand cmd2 = new SqlCommand();
    SqlCommand cmd6 = new SqlCommand();
    SqlCommand cmd3 = new SqlCommand();
    SqlCommand cmd16 = new SqlCommand();
    SqlCommand cmd14 = new SqlCommand();
    SqlCommand cmd15 = new SqlCommand();
    SqlConnection dbConn = new SqlConnection();
    SqlConnection dbConn1 = new SqlConnection();
    SqlConnection dbConn13 = new SqlConnection();
    SqlConnection dbConn2 = new SqlConnection();
    SqlConnection dbConn6 = new SqlConnection();
    SqlConnection dbConn3 = new SqlConnection();
    SqlConnection dbConn4 = new SqlConnection();
    SqlConnection dbConn5 = new SqlConnection();
    SqlConnection dbConn7 = new SqlConnection();
    SqlConnection dbConn16 = new SqlConnection();
    SqlConnection dbConn14 = new SqlConnection();
    SqlConnection dbConn15 = new SqlConnection();
    SqlDataReader dr, dr1, dr6, dr16, dr4, dr14, dr15;
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Enabled = false;
        TextBox2.Enabled = false;
        TextBox3.Enabled = false;

        Session["id"] = Request.QueryString["id"].ToString();
        //Response.Write();
        selectSQL23 = "select * from Booking WHERE id ='" + Session["id"].ToString() + "' and Status='Pending' and Type='Hotel'";
        //Response.Write(selectSQL23);


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


                Label9.Text = dr["Surname"].ToString();
                Session["1"] = dr["Surname"].ToString();
                Label10.Text = dr["Firstname"].ToString();
                Session["2"] = dr["Firstname"].ToString();
                Label11.Text = dr["Email"].ToString();
                Session["3"] = dr["Email"].ToString();
                Label12.Text = dr["Phone"].ToString();
                Session["4"] = dr["Phone"].ToString();


                Label13.Text = dr["Room_Type"].ToString();
                Session["6"] = dr["Room_Type"].ToString();
                Session["price"] = dr["Price"].ToString();

                var tt2 = dr["ArrivalD"].ToString();

                var tt1 = dr["DepatureD"].ToString();

                var x = DateTime.Parse(tt2).ToShortDateString();
                Session["x"] = x;
                var y = DateTime.Parse(tt1).ToShortDateString();
                Session["y"] = y;
                Label15.Text = x;
                Label16.Text = y;
                Session["7"] = x;
                Session["8"] = y;
                if (Session["price"].ToString() == "20000")
                {
                    DropDownList4.Items[12].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[13].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[14].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[15].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[16].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[17].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[18].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[19].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[20].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[21].Attributes.Add("disabled", "disabled");

                    DropDownList4.Items[22].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[23].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[24].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[25].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[26].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[27].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[28].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[29].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[30].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[31].Attributes.Add("disabled", "disabled");

                    DropDownList4.Items[32].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[33].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[34].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[35].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[36].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[37].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[38].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[39].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[40].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[41].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[42].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[43].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[44].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[45].Attributes.Add("disabled", "disabled");

                }
                else if (Session["price"].ToString() == "25000")
                {
                    DropDownList4.Items[1].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[2].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[3].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[4].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[5].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[6].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[7].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[8].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[9].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[10].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[11].Attributes.Add("disabled", "disabled");


                    DropDownList4.Items[21].Attributes.Add("disabled", "disabled");

                    DropDownList4.Items[22].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[23].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[24].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[25].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[26].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[27].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[28].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[29].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[30].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[31].Attributes.Add("disabled", "disabled");

                    DropDownList4.Items[32].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[33].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[34].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[35].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[36].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[37].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[38].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[39].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[40].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[41].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[42].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[43].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[44].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[45].Attributes.Add("disabled", "disabled");


                }
                else if (Session["price"].ToString() == "30000")
                {

                    DropDownList4.Items[1].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[2].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[3].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[4].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[5].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[6].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[7].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[8].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[9].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[10].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[11].Attributes.Add("disabled", "disabled");



                    DropDownList4.Items[12].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[13].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[14].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[15].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[16].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[17].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[18].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[19].Attributes.Add("disabled", "disabled");
                    DropDownList4.Items[20].Attributes.Add("disabled", "disabled");





                }
                else
                {

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

    protected void OnConfirm(object sender, EventArgs e)
    {

        //Session["T"] = DropDownList1.SelectedItem.ToString();
        DateTime ss = Convert.ToDateTime(Session["x"].ToString());
        DateTime tt = Convert.ToDateTime(Session["y"].ToString());
        DateTime endTime = DateTime.Now;
        var shortDate = endTime.Date;
        TimeSpan span = endTime.Subtract(ss);

        int F = (int)span.TotalHours;

        //Response.Write(F);



        string confirmValue = Request.Form["confirm_value"];
        if (confirmValue == "Yes")
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert", true);


            selectSQL = "  SELECT Room_Name,Room_Type,ArrivalD,DepatureD,Price,Status,Status2,Status3 from Booking  where   Room_Name='" + DropDownList4.SelectedItem.ToString() + "' and Room_Type='" + Session["6"].ToString() + "'  and ArrivalD =  '" + Session["7"].ToString() + "' and DepatureD =  '" + Session["8"].ToString() + "' and  Status='Done' and Status2='Approved' and Status3='Approved' and Type='Hotel'  ";
            //yimak.Src = "passport/" + Session["AdmissionNo"].ToString() + ".jpg";

            dbConn3.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
            //dbConn1.ConnectionString = "Data Source=NEW-VITAL\\SCHOOLSERVER; Initial Catalog=emma;Integrated Security=True;";

            cmd1.Connection = dbConn3;
            cmd1.CommandText = selectSQL;
            cmd1.CommandType = CommandType.Text;


            try
            {



                dbConn3.Open();
                dr = cmd1.ExecuteReader();
                // Response.Write(selectSQL);
                if (dr.Read())
                {


                    // Response.Write(selectSQL);
                    //Response.Write("xxxxxxxxxxxxxx" + dr["Teller"].ToString());
                    //AuthenButton.Enabled = true;
                    Label6.Text = "You have Checked In a Customer";

                }



                else
                {


                    if (Session["6"].ToString() == "Deluxe")
                    {





                        selectSQL1 = "  SELECT id ,'Count'=(select count(id)  FROM Booking where  ArrivalD =     '" + ss + "' and  DepatureD  = '" + tt + "' and Status='Done'and Status2='Approved' and Status3='Approved'and Room_Type='" + Session["6"].ToString() + "'  and Type='Hotel' ) FROM Booking ";




                        //yimak.Src = "passport/" + Session["AdmissionNo"].ToString() + ".jpg";

                        dbConn5.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
                        //dbConn1.ConnectionString = "Data Source=NEW-VITAL\\SCHOOLSERVER; Initial Catalog=emma;Integrated Security=True;";

                        cmd3.Connection = dbConn5;
                        cmd3.CommandText = selectSQL1;
                        cmd3.CommandType = CommandType.Text;


                        try
                        {


                            dbConn5.Open();
                            dr1 = cmd3.ExecuteReader();
                            //Response.Write(selectSQL1);
                            if (dr1.Read())
                            {



                                Session["q"] = dr1["Count"].ToString();
                                int dd = Int32.Parse(Session["q"].ToString());
                                //Response.Write(dd);
                                Session["qt"] = dd;

                                if (dd >= 9)
                                {

                                    // Response.Write("dd ");
                                    Label6.Text = "1 Bed Apartment Not Available";
                                }
                                else if (dd < 9)
                                {





                                    selectSQL15 = "  SELECT *  from Booking where  Status='Done'and Status2='Approved' and Status3='Approved' and Room_Type='" + Session["6"].ToString() + "' and Room_Name='" + DropDownList4.SelectedItem + "' and Type='Hotel'   ORDER BY ID DESC  ";
                                    //yimak.Src = "passport/" + Session["AdmissionNo"].ToString() + ".jpg";

                                    dbConn15.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
                                    //dbConn1.ConnectionString = "Data Source=NEW-VITAL\\SCHOOLSERVER; Initial Catalog=emma;Integrated Security=True;";

                                    cmd15.Connection = dbConn15;
                                    cmd15.CommandText = selectSQL15;
                                    cmd15.CommandType = CommandType.Text;
                                    // Response.Write("na3");

                                    try
                                    {


                                        dbConn15.Open();
                                        dr15 = cmd15.ExecuteReader();
                                        //Response.Write(selectSQL15);
                                        if (dr15.Read())
                                        {


                                            Label6.Text = DropDownList4.SelectedItem + " Not Available";
                                        }


                                        else
                                        {




                                            if (DropDownList3.SelectedItem.ToString() == "FULL PAYMENT")
                                            {
                                                updateSQL6 = "update Booking set Room_Name='" +DropDownList4.SelectedItem+ "' , Status='Done',Status2='Approved',Status3='Approved',Checkin='Yes',Status5='run',pp ='0',bp ='0',Payment ='" + DropDownList2.SelectedItem.Text + "',Pt ='" + DropDownList3.SelectedItem.Text + "',Amount ='" + TextBox1.Text + "' where  id ='" + Session["id"].ToString() + "' and Type='Hotel' ";
                                                //Response.Write(updateSQL6);
                                                dbConn6.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";

                                                cmd6.Connection = dbConn6;
                                                cmd6.CommandText = updateSQL6;
                                                cmd6.CommandType = CommandType.Text;
                                                try
                                                {

                                                    dbConn6.Open();
                                                   Response.Write(updateSQL6);
                                                    //Response.Write("na london");
                                                    int updated2 = cmd6.ExecuteNonQuery();
                                                    if (updated2 == 1)
                                                    {
                                                        updateSQL1 = "update Rooms set  Status='Occupied' where  Room_Name ='"+DropDownList4.SelectedItem+"' and Type='Hotel' ";

                                                        dbConn4.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
                                                        cmd2.Connection = dbConn4;
                                                        cmd2.CommandText = updateSQL1;
                                                        cmd2.CommandType = CommandType.Text;


                                                        dbConn4.Open();
                                                       Response.Write(updateSQL1);
                                                        int updated1 = cmd2.ExecuteNonQuery();
                                                        if (updated1 == 1)
                                                        {


                                                            Response.Redirect("ViewB1.aspx");
                                                        }
                                                        else
                                                        {
                                                            Label6.Text =  "records  not Inserted";
                                                        }
                                                        // Label1.Text = added.ToString() + "records Inserted";





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
                                            else if (DropDownList3.SelectedValue == "PART PAYMENT")
                                            {

                                                updateSQL6 = "update Booking set Room_Name='" +DropDownList4.SelectedItem+ "', Status='Done',Amount='0',Status2='Approved',Status3='Approved',Checkin='Yes',Status5='run',Payment ='" + DropDownList2.SelectedItem.Text + "',Pt ='" + DropDownList3.SelectedItem.Text + "',pp ='" + TextBox2.Text + "' ,bp ='" + TextBox3.Text + "' where  id ='" + Session["id"].ToString() + "'";
                                                //Response.Write(updateSQL6);
                                                dbConn6.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";

                                                cmd6.Connection = dbConn6;
                                                cmd6.CommandText = updateSQL6;
                                                cmd6.CommandType = CommandType.Text;
                                                try
                                                {

                                                    dbConn6.Open();
                                                    //Response.Write(updateSQL6);
                                                    int updated2 = cmd6.ExecuteNonQuery();
                                                    if (updated2 == 1)
                                                    {
                                                        updateSQL1 = "update Rooms set  Status='Occupied' where  Room_Name ='" +DropDownList4.SelectedItem+ "' and Type='Hotel' ";

                                                        dbConn4.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";

                                                        cmd2.Connection = dbConn4;
                                                        cmd2.CommandText = updateSQL1;
                                                        cmd2.CommandType = CommandType.Text;


                                                        dbConn4.Open();
                                                        //Response.Write(updateSQL2);
                                                        int updated1 = cmd2.ExecuteNonQuery();
                                                        if (updated1 == 1)
                                                        {


                                                            Response.Redirect("ViewB1.aspx");
                                                        }
                                                        else
                                                        {

                                                        }
                                                        // Label1.Text = added.ToString() + "records Inserted";





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

                                        dr15.Close();
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





                                //Label6.Text = "1  Bedroom Apartment Not Availbale";
                            }
                            else
                            {


                              





                            }

                            dr1.Close();
                        }
                        catch (Exception err)
                        {
                            Label6.Text = "fffError  Getting Room ";
                            Label6.Text += err.ToString();
                        }
                        finally
                        {
                            dbConn5.Close();
                        }






                    }













                    if (Session["6"].ToString() == "Standard")
                    {





                        selectSQL1 = "  SELECT id ,'Count'=(select count(id)  FROM Booking where  ArrivalD =     '" + ss + "' and  DepatureD  = '" + tt + "' and Status='Done'and Status2='Approved' and Status3='Approved'and Room_Type='" + Session["6"].ToString() + "'  and Type='Hotel' ) FROM Booking ";




                        //yimak.Src = "passport/" + Session["AdmissionNo"].ToString() + ".jpg";

                        dbConn5.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
                        //dbConn1.ConnectionString = "Data Source=NEW-VITAL\\SCHOOLSERVER; Initial Catalog=emma;Integrated Security=True;";

                        cmd3.Connection = dbConn5;
                        cmd3.CommandText = selectSQL1;
                        cmd3.CommandType = CommandType.Text;


                        try
                        {


                            dbConn5.Open();
                            dr1 = cmd3.ExecuteReader();
                            //Response.Write(selectSQL1);
                            if (dr1.Read())
                            {



                                Session["q"] = dr1["Count"].ToString();
                                int dd = Int32.Parse(Session["q"].ToString());
                                //Response.Write(dd);
                                Session["qt"] = dd;

                                if (dd >= 11)
                                {

                                    // Response.Write("dd ");
                                    Label6.Text = "1 Bed Apartment Not Available";
                                }
                                else if (dd < 11)
                                {





                                    selectSQL15 = "  SELECT *  from Booking where  Status='Done'and Status2='Approved' and Status3='Approved' and Room_Type='" + Session["6"].ToString() + "' and Room_Name='" + DropDownList4.SelectedItem + "' and Type='Hotel'   ORDER BY ID DESC  ";
                                    //yimak.Src = "passport/" + Session["AdmissionNo"].ToString() + ".jpg";

                                    dbConn15.ConnectionString ="Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
                                    //dbConn1.ConnectionString = "Data Source=NEW-VITAL\\SCHOOLSERVER; Initial Catalog=emma;Integrated Security=True;";

                                    cmd15.Connection = dbConn15;
                                    cmd15.CommandText = selectSQL15;
                                    cmd15.CommandType = CommandType.Text;
                                    // Response.Write("na3");

                                    try
                                    {


                                        dbConn15.Open();
                                        dr15 = cmd15.ExecuteReader();
                                        //Response.Write(selectSQL15);
                                        if (dr15.Read())
                                        {


                                            Label6.Text = DropDownList4.SelectedItem + " Not Available";
                                        }


                                        else
                                        {




                                            if (DropDownList3.SelectedItem.ToString() == "FULL PAYMENT")
                                            {
                                                updateSQL6 = "update Booking set Room_Name='" + DropDownList4.SelectedItem + "' , Status='Done',Status2='Approved',Status3='Approved',Checkin='Yes',Status5='run',pp ='0',bp ='0',Payment ='" + DropDownList2.SelectedItem.Text + "',Pt ='" + DropDownList3.SelectedItem.Text + "',Amount ='" + TextBox1.Text + "' where  id ='" + Session["id"].ToString() + "' and Type='Hotel' ";
                                                //Response.Write(updateSQL6);
                                                dbConn6.ConnectionString ="Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";

                                                cmd6.Connection = dbConn6;
                                                cmd6.CommandText = updateSQL6;
                                                cmd6.CommandType = CommandType.Text;
                                                try
                                                {

                                                    dbConn6.Open();
                                                    Response.Write(updateSQL6);
                                                    //Response.Write("na london");
                                                    int updated2 = cmd6.ExecuteNonQuery();
                                                    if (updated2 == 1)
                                                    {
                                                        updateSQL1 = "update Rooms set  Status='Occupied' where  Room_Name ='" + DropDownList4.SelectedItem + "' and Type='Hotel' ";

                                                        dbConn4.ConnectionString ="Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
                                                        cmd2.Connection = dbConn4;
                                                        cmd2.CommandText = updateSQL1;
                                                        cmd2.CommandType = CommandType.Text;


                                                        dbConn4.Open();
                                                        Response.Write(updateSQL1);
                                                        int updated1 = cmd2.ExecuteNonQuery();
                                                        if (updated1 == 1)
                                                        {


                                                            Response.Redirect("ViewB1.aspx");
                                                        }
                                                        else
                                                        {
                                                            Label6.Text = "records  not Inserted";
                                                        }
                                                        // Label1.Text = added.ToString() + "records Inserted";





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
                                            else if (DropDownList3.SelectedValue == "PART PAYMENT")
                                            {

                                                updateSQL6 = "update Booking set Room_Name='" + DropDownList4.SelectedItem + "', Status='Done',Amount='0',Status2='Approved',Status3='Approved',Checkin='Yes',Status5='run',Payment ='" + DropDownList2.SelectedItem.Text + "',Pt ='" + DropDownList3.SelectedItem.Text + "',pp ='" + TextBox2.Text + "' ,bp ='" + TextBox3.Text + "' where  id ='" + Session["id"].ToString() + "'";
                                                //Response.Write(updateSQL6);
                                                dbConn6.ConnectionString ="Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
                                                cmd6.Connection = dbConn6;
                                                cmd6.CommandText = updateSQL6;
                                                cmd6.CommandType = CommandType.Text;
                                                try
                                                {

                                                    dbConn6.Open();
                                                    //Response.Write(updateSQL6);
                                                    int updated2 = cmd6.ExecuteNonQuery();
                                                    if (updated2 == 1)
                                                    {
                                                        updateSQL1 = "update Rooms set  Status='Occupied' where  Room_Name ='" + DropDownList4.SelectedItem + "' and Type='Hotel' ";

                                                        dbConn4.ConnectionString ="Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";

                                                        cmd2.Connection = dbConn4;
                                                        cmd2.CommandText = updateSQL1;
                                                        cmd2.CommandType = CommandType.Text;


                                                        dbConn4.Open();
                                                        //Response.Write(updateSQL2);
                                                        int updated1 = cmd2.ExecuteNonQuery();
                                                        if (updated1 == 1)
                                                        {


                                                            Response.Redirect("ViewB1.aspx");
                                                        }
                                                        else
                                                        {

                                                        }
                                                        // Label1.Text = added.ToString() + "records Inserted";





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

                                        dr15.Close();
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





                                //Label6.Text = "1  Bedroom Apartment Not Availbale";
                            }
                            else
                            {








                            }

                            dr1.Close();
                        }
                        catch (Exception err)
                        {
                            Label6.Text = "fffError  Getting Room ";
                            Label6.Text += err.ToString();
                        }
                        finally
                        {
                            dbConn5.Close();
                        }






                    }






                    else  if (Session["6"].ToString() == "Executive")
                    {





                        selectSQL1 = "  SELECT id ,'Count'=(select count(id)  FROM Booking where  ArrivalD =     '" + ss + "' and  DepatureD  = '" + tt + "' and Status='Done'and Status2='Approved' and Status3='Approved'and Room_Type='" + Session["6"].ToString() + "'  and Type='Hotel' ) FROM Booking ";




                        //yimak.Src = "passport/" + Session["AdmissionNo"].ToString() + ".jpg";

                        dbConn5.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
                        //dbConn1.ConnectionString = "Data Source=NEW-VITAL\\SCHOOLSERVER; Initial Catalog=emma;Integrated Security=True;";

                        cmd3.Connection = dbConn5;
                        cmd3.CommandText = selectSQL1;
                        cmd3.CommandType = CommandType.Text;


                        try
                        {


                            dbConn5.Open();
                            dr1 = cmd3.ExecuteReader();
                            //Response.Write(selectSQL1);
                            if (dr1.Read())
                            {



                                Session["q"] = dr1["Count"].ToString();
                                int dd = Int32.Parse(Session["q"].ToString());
                                //Response.Write(dd);
                                Session["qt"] = dd;

                                if (dd >= 25)
                                {

                                    // Response.Write("dd ");
                                    Label6.Text = "1 Bed Apartment Not Available";
                                }
                                else if (dd < 25)
                                {





                                    selectSQL15 = "  SELECT *  from Booking where  Status='Done'and Status2='Approved' and Status3='Approved' and Room_Type='" + Session["6"].ToString() + "' and Room_Name='" + DropDownList4.SelectedItem + "' and Type='Hotel'   ORDER BY ID DESC  ";
                                    //yimak.Src = "passport/" + Session["AdmissionNo"].ToString() + ".jpg";

                                    dbConn15.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
                                    //dbConn1.ConnectionString = "Data Source=NEW-VITAL\\SCHOOLSERVER; Initial Catalog=emma;Integrated Security=True;";

                                    cmd15.Connection = dbConn15;
                                    cmd15.CommandText = selectSQL15;
                                    cmd15.CommandType = CommandType.Text;
                                    // Response.Write("na3");

                                    try
                                    {


                                        dbConn15.Open();
                                        dr15 = cmd15.ExecuteReader();
                                        //Response.Write(selectSQL15);
                                        if (dr15.Read())
                                        {


                                            Label6.Text = DropDownList4.SelectedItem + " Not Available";
                                        }


                                        else
                                        {




                                            if (DropDownList3.SelectedItem.ToString() == "FULL PAYMENT")
                                            {
                                                updateSQL6 = "update Booking set Room_Name='" + DropDownList4.SelectedItem + "' , Status='Done',Status2='Approved',Status3='Approved',Status5='run',Checkin='Yes',pp ='0',bp ='0',Payment ='" + DropDownList2.SelectedItem.Text + "',Pt ='" + DropDownList3.SelectedItem.Text + "',Amount ='" + TextBox1.Text + "' where  id ='" + Session["id"].ToString() + "' and Type='Hotel' ";
                                                //Response.Write(updateSQL6);
                                                dbConn6.ConnectionString ="Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";

                                                cmd6.Connection = dbConn6;
                                                cmd6.CommandText = updateSQL6;
                                                cmd6.CommandType = CommandType.Text;
                                                try
                                                {

                                                    dbConn6.Open();
                                                    Response.Write(updateSQL6);
                                                    //Response.Write("na london");
                                                    int updated2 = cmd6.ExecuteNonQuery();
                                                    if (updated2 == 1)
                                                    {
                                                        updateSQL1 = "update Rooms set  Status='Occupied' where  Room_Name ='" + DropDownList4.SelectedItem + "' and Type='Hotel' ";

                                                        dbConn4.ConnectionString ="Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
                                                        cmd2.Connection = dbConn4;
                                                        cmd2.CommandText = updateSQL1;
                                                        cmd2.CommandType = CommandType.Text;


                                                        dbConn4.Open();
                                                        Response.Write(updateSQL1);
                                                        int updated1 = cmd2.ExecuteNonQuery();
                                                        if (updated1 == 1)
                                                        {


                                                            Response.Redirect("ViewB1.aspx");
                                                        }
                                                        else
                                                        {
                                                            Label6.Text = "records  not Inserted";
                                                        }
                                                        // Label1.Text = added.ToString() + "records Inserted";





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
                                            else if (DropDownList3.SelectedValue == "PART PAYMENT")
                                            {

                                                updateSQL6 = "update Booking set Room_Name='" + DropDownList4.SelectedItem + "', Status='Done',Amount='0',Status2='Approved',Status3='Approved',Status5='run',Checkin='Yes',Payment ='" + DropDownList2.SelectedItem.Text + "',Pt ='" + DropDownList3.SelectedItem.Text + "',pp ='" + TextBox2.Text + "' ,bp ='" + TextBox3.Text + "' where  id ='" + Session["id"].ToString() + "'";
                                                //Response.Write(updateSQL6);
                                                dbConn6.ConnectionString ="Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";

                                                cmd6.Connection = dbConn6;
                                                cmd6.CommandText = updateSQL6;
                                                cmd6.CommandType = CommandType.Text;
                                                try
                                                {

                                                    dbConn6.Open();
                                                    //Response.Write(updateSQL6);
                                                    int updated2 = cmd6.ExecuteNonQuery();
                                                    if (updated2 == 1)
                                                    {
                                                        updateSQL1 = "update Rooms set  Status='Occupied' where  Room_Name ='" + DropDownList4.SelectedItem + "' and Type='Hotel' ";

                                                        dbConn4.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";

                                                        cmd2.Connection = dbConn4;
                                                        cmd2.CommandText = updateSQL1;
                                                        cmd2.CommandType = CommandType.Text;


                                                        dbConn4.Open();
                                                        //Response.Write(updateSQL2);
                                                        int updated1 = cmd2.ExecuteNonQuery();
                                                        if (updated1 == 1)
                                                        {


                                                            Response.Redirect("ViewB1.aspx");
                                                        }
                                                        else
                                                        {

                                                        }
                                                        // Label1.Text = added.ToString() + "records Inserted";





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

                                        dr15.Close();
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





                                //Label6.Text = "1  Bedroom Apartment Not Availbale";
                            }
                            else
                            {








                            }

                            dr1.Close();
                        }
                        catch (Exception err)
                        {
                            Label6.Text = "fffError  Getting Room ";
                            Label6.Text += err.ToString();
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

            catch (Exception err)
            {

                Label6.Text += err.ToString();
            }
            finally
            {
                dbConn3.Close();
            }








        }


        else
        {
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert", true);
            Label6.Text = "Reservation Not Complete ";

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
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void Button2_Click1(object sender, EventArgs e)
    {
        Response.Redirect("ApplyD.aspx");
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (DropDownList3.SelectedItem.ToString() == "FULL PAYMENT")
        {
            RequiredFieldValidator2.Enabled = false;
            RequiredFieldValidator3.Enabled = false;
            TextBox1.Enabled = true;
            TextBox2.Enabled = false;
            TextBox3.Enabled = false;
            TextBox2.Text = "";
            TextBox3.Text = "";


        }
        else if (DropDownList3.SelectedItem.ToString() == "PART PAYMENT")
        {
            vv.Enabled = false;
            TextBox1.Enabled = false;
            TextBox2.Enabled = true;
            TextBox3.Enabled = true;
            TextBox1.Text = "";

        }
        else
        {
        }

    }
}
