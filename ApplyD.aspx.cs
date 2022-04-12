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


public partial class ApplyD : System.Web.UI.Page
{
    String selectSQL33;
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
    SqlCommand cmd33 = new SqlCommand();
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
    SqlConnection dbConn33 = new SqlConnection();
    SqlDataReader dr, dr1, dr6, dr16, dr4, dr14, dr15,dr33;
    protected void Page_Load(object sender, EventArgs e)
    {

        Label9.Text = Session["1"].ToString();
        Label10.Text = Session["2"].ToString();
        Label11.Text = Session["3"].ToString();
        Label12.Text = Session["4"].ToString();
       

        Label13.Text = Session["6"].ToString();


        var bb = Session["7"].ToString();
        var cc = Session["8"].ToString();


        var g = DateTime.Parse(bb).ToShortDateString();
        var h = DateTime.Parse(cc).ToShortDateString();
        Label15.Text = g;
        Label16.Text = h;
        Label17.Text = Session["price"].ToString();


        if (Session["price"].ToString() == "30000")
        {
            DropDownList6.Items[1].Attributes.Add("disabled", "disabled");
        }
        else
        {

            DropDownList6.Items[2].Attributes.Add("disabled", "disabled");
            DropDownList6.Items[3].Attributes.Add("disabled", "disabled");
            DropDownList6.Items[4].Attributes.Add("disabled", "disabled");
            DropDownList6.Items[5].Attributes.Add("disabled", "disabled");
            DropDownList6.Items[6].Attributes.Add("disabled", "disabled");
            DropDownList6.Items[7].Attributes.Add("disabled", "disabled");
            DropDownList6.Items[8].Attributes.Add("disabled", "disabled");
            DropDownList6.Items[9].Attributes.Add("disabled", "disabled");
            DropDownList6.Items[10].Attributes.Add("disabled", "disabled");
            DropDownList6.Items[11].Attributes.Add("disabled", "disabled");


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


            selectSQL = "  SELECT Room_Name,Room_Type,ArrivalD,DepatureD,Price,Status,Status2,Status3 from Booking  where   Room_Name='" + DropDownList6.SelectedItem.ToString() + "' and Room_Type='" + Session["6"].ToString() + "'  and ArrivalD =  '" + Session["7"].ToString() + "' and DepatureD =  '" + Session["8"].ToString() + "' and  Status='Done' and Status2='Approved' and Status3='Approved'  ";
            //yimak.Src = "passport/" + Session["AdmissionNo"].ToString() + ".jpg";

            dbConn3.ConnectionString =  "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
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
                    if (Session["6"].ToString() == "2 Bed Apartment")
                    {





                        selectSQL14 = "  SELECT TOP 1 'AA'=( max(ArrivalD)),  'DD'=( max(DepatureD)) FROM Booking   where  Status='Done'and Status2='Approved' and Status3='Approved'and Room_Type='" + Session["6"].ToString() + "'   ";
                        //yimak.Src = "passport/" + Session["AdmissionNo"].ToString() + ".jpg";

                        dbConn14.ConnectionString =  "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
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

                                Session["AA"] = dr14["AA"].ToString();
                                Session["DD"] = dr14["DD"].ToString();

                                if (Session["AA"] == "" && Session["DD"] == "")
                                {

                                    // Response.Write("empty");

                                    selectSQL33 = "select * from Discount WHERE Dis ='" + TextBox1.Text.Trim() + "' ";
                                    //Response.Write(selectSQL23);


                                    dbConn33.ConnectionString  =  "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
                                    //dbConn1.ConnectionString = "Data Source=NEW-VITAL\\SCHOOLSERVER; Initial Catalog=emma;Integrated Security=True;";

                                    cmd33.Connection = dbConn33;
                                    cmd33.CommandText = selectSQL33;
                                    cmd33.CommandType = CommandType.Text;



                                    try
                                    {



                                        dbConn33.Open();
                                        dr33 = cmd33.ExecuteReader();

                                        if (dr33.Read())
                                        {

                                           
                                            Session["N"] = dr33["Number"].ToString();
                                            int hs = Int32.Parse(Label17.Text);
                                            //  Response.Write(ss);

                                            int ww = Int32.Parse(Session["N"].ToString());
                                            // Response.Write(ww);
                                            int f1 = hs - (hs * ww / 100);
                                            Label8.Text = f1.ToString();
                                            // Response.Write(f1);

                                            updateSQL6 = "update Booking set Status='Done',Amount='" + Int32.Parse(Label8.Text) + "', Status2='Approved',Status3='Approved',Discount='Yes',Payment ='" + DropDownList2.SelectedItem.Text + "' where  id ='" + Session["id"].ToString() + "'";
                                            // Response.Write(updateSQL6);
                                            dbConn6.ConnectionString =  "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";

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
                                                    updateSQL1 = "update Rooms set  Status='Occupied' where  Room_Name ='" + DropDownList6.SelectedItem + "'";

                                                    dbConn4.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";

                                                    cmd2.Connection = dbConn4;
                                                    cmd2.CommandText = updateSQL1;
                                                    cmd2.CommandType = CommandType.Text;
                                                    try
                                                    {

                                                        dbConn4.Open();
                                                        // Response.Write(updateSQL1);
                                                        int updated1 = cmd2.ExecuteNonQuery();
                                                        if (updated1 == 1)
                                                        {
                                                            Response.Redirect("ViewB.aspx");


                                                        }
                                                        else
                                                        {

                                                        }
                                                        // Label1.Text = added.ToString() + "records Inserted";
                                                    }



                                                    catch (Exception err)
                                                    {

                                                        Label6.Text += err.ToString();
                                                    }
                                                    finally
                                                    {
                                                        dbConn.Close();
                                                    }
                                                    //Response.Redirect("ViewB.aspx");
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





                                            Label6.Text = "Reservation Not Successful 111";



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
                                    DateTime A1 = Convert.ToDateTime(Session["AA"].ToString());
                                    // Convert.ToDateTime();
                                    DateTime D1 = Convert.ToDateTime(Session["DD"].ToString());

                                    string V = D1.ToString("dd/M/yyyy");
                                    // Response.Write(V);
                                    // Response.Write(D1);

                                    if (ss <= A1 && tt <= D1)
                                    {
                                        Label6.Text = Session["6"].ToString() + " Not Available till" + "   " + V;
                                    }
                                    else if (ss <= A1 && tt >= D1)
                                    {
                                        Label6.Text = Session["6"].ToString() + " Not Available till" + "   " + V;

                                    }
                                    else if (ss >= A1 && tt <= D1)
                                    {
                                        Label6.Text = Session["6"].ToString() + " Not Available till" + "   " + V;

                                    }
                                    else if (ss <= D1 && tt >= D1)
                                    {
                                        Label6.Text = Session["6"].ToString() + " Not Available till" + "   " + V;

                                    }
                                    else if (ss >= D1 && tt >= D1)
                                    {
                                        Label6.Text = Session["6"].ToString() + " Not Available till" + "   " + V;

                                    }

                                    else
                                    {

                                        selectSQL33 = "select * from Discount WHERE Dis ='" + TextBox1.Text.Trim() + "' ";
                                        //Response.Write(selectSQL23);


                                        dbConn33.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
                                        //dbConn1.ConnectionString = "Data Source=NEW-VITAL\\SCHOOLSERVER; Initial Catalog=emma;Integrated Security=True;";

                                        cmd33.Connection = dbConn33;
                                        cmd33.CommandText = selectSQL33;
                                        cmd33.CommandType = CommandType.Text;



                                        try
                                        {



                                            dbConn33.Open();
                                            dr33 = cmd33.ExecuteReader();

                                            if (dr33.Read())
                                            {


                                                Session["N"] = dr33["Number"].ToString();
                                                int hs = Int32.Parse(Label17.Text);
                                                //  Response.Write(ss);

                                                int ww = Int32.Parse(Session["N"].ToString());
                                                // Response.Write(ww);
                                                int f1 = hs - (hs * ww / 100);
                                                Label8.Text = f1.ToString();
                                                // Response.Write(f1);

                                                updateSQL6 = "update Booking set Status='Done',Amount='" + Int32.Parse(Label8.Text) + "', Status2='Approved',Status3='Approved',Discount='Yes',Payment ='" + DropDownList2.SelectedItem.Text + "' where  id ='" + Session["id"].ToString() + "'";
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
                                                        updateSQL1 = "update Rooms set  Status='Occupied' where  Room_Name ='" + DropDownList6.SelectedItem + "'";

                                                        dbConn4.ConnectionString =  "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";

                                                        cmd2.Connection = dbConn4;
                                                        cmd2.CommandText = updateSQL1;
                                                        cmd2.CommandType = CommandType.Text;
                                                        try
                                                        {

                                                            dbConn4.Open();
                                                            // Response.Write(updateSQL1);
                                                            int updated1 = cmd2.ExecuteNonQuery();
                                                            if (updated1 == 1)
                                                            {
                                                                Response.Redirect("ViewB.aspx");


                                                            }
                                                            else
                                                            {

                                                            }
                                                            // Label1.Text = added.ToString() + "records Inserted";
                                                        }



                                                        catch (Exception err)
                                                        {

                                                            Label6.Text += err.ToString();
                                                        }
                                                        finally
                                                        {
                                                            dbConn.Close();
                                                        }
                                                        //Response.Redirect("ViewB.aspx");
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





                                                Label6.Text = "Reservation Not Successful 112";



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


                            }


                            else
                            {

           



                            }

                            dr14.Close();
                        }
                        catch (Exception err)
                        {
                            Label6.Text = "Error  Getting Apartment ";
                            Label6.Text += err.ToString();
                        }
                        finally
                        {
                            dbConn5.Close();
                        }








                    }

                    else if (Session["6"].ToString() == "1 Bed Apartment")
                    {





                        selectSQL1 = "  SELECT id ,'Count'=(select count(id)  FROM Booking where  ArrivalD =     '" + ss + "' and  DepatureD  = '" + tt + "' and Status='Done'and Status2='Approved' and Status3='Approved'and Room_Type='" + Session["6"].ToString() + "') FROM Booking ";




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

                                if (dd >= 10)
                                {


                                    selectSQL14 = "  SELECT  'AA'=( min(ArrivalD)),  'DD'=( min(DepatureD)) FROM Booking   where  Status='Done'and Status2='Approved' and Status3='Approved'and Room_Type='" + Session["6"].ToString() + "'   ";
                                    //yimak.Src = "passport/" + Session["AdmissionNo"].ToString() + ".jpg";

                                    dbConn14.ConnectionString =  "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
                                    //dbConn1.ConnectionString = "Data Source=NEW-VITAL\\SCHOOLSERVER; Initial Catalog=emma;Integrated Security=True;";

                                    cmd14.Connection = dbConn14;
                                    cmd14.CommandText = selectSQL14;
                                    cmd14.CommandType = CommandType.Text;


                                    try
                                    {


                                        dbConn14.Open();
                                        dr14 = cmd14.ExecuteReader();
                                        Response.Write(selectSQL14);
                                        if (dr14.Read())
                                        {

                                            Session["AA"] = dr14["AA"].ToString();
                                            Session["DD"] = dr14["DD"].ToString();

                                            DateTime A1 = Convert.ToDateTime(Session["AA"].ToString());
                                            // Convert.ToDateTime();
                                            DateTime D1 = Convert.ToDateTime(Session["DD"].ToString());

                                            string V = D1.ToString("dd/M/yyyy");
                                            Response.Write(Session["AA"]);
                                            Response.Write(Session["DD"]);
                                            Response.Write(V);
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








                                    Label6.Text = "1 Bed Apartment Not Available";
                                }
                                else if (dd < 10)
                                {





                                    selectSQL33 = "select * from Discount WHERE Dis ='" + TextBox1.Text.Trim() + "' ";
                                    //Response.Write(selectSQL23);


                                    dbConn33.ConnectionString =  "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
                                    //dbConn1.ConnectionString = "Data Source=NEW-VITAL\\SCHOOLSERVER; Initial Catalog=emma;Integrated Security=True;";

                                    cmd33.Connection = dbConn33;
                                    cmd33.CommandText = selectSQL33;
                                    cmd33.CommandType = CommandType.Text;



                                    try
                                    {



                                        dbConn33.Open();
                                        dr33 = cmd33.ExecuteReader();

                                        if (dr33.Read())
                                        {


                                            Session["N"] = dr33["Number"].ToString();
                                            int hs = Int32.Parse(Label17.Text);
                                            //  Response.Write(ss);

                                            int ww = Int32.Parse(Session["N"].ToString());
                                            // Response.Write(ww);
                                            int f1 = hs - (hs * ww / 100);
                                            Label8.Text = f1.ToString();
                                            // Response.Write(f1);

                                            updateSQL6 = "update Booking set Status='Done',Amount='" + Int32.Parse(Label8.Text) + "', Status2='Approved',Status3='Approved',Discount='Yes',Payment ='" + DropDownList2.SelectedItem.Text + "' where  id ='" + Session["id"].ToString() + "'";
                                            // Response.Write(updateSQL6);
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
                                                    updateSQL1 = "update Rooms set  Status='Occupied' where  Room_Name ='" + DropDownList6.SelectedItem + "'";

                                                    dbConn4.ConnectionString =  "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";

                                                    cmd2.Connection = dbConn4;
                                                    cmd2.CommandText = updateSQL1;
                                                    cmd2.CommandType = CommandType.Text;
                                                    try
                                                    {

                                                        dbConn4.Open();
                                                        // Response.Write(updateSQL1);
                                                        int updated1 = cmd2.ExecuteNonQuery();
                                                        if (updated1 == 1)
                                                        {
                                                            Response.Redirect("ViewB.aspx");


                                                        }
                                                        else
                                                        {

                                                        }
                                                        // Label1.Text = added.ToString() + "records Inserted";
                                                    }



                                                    catch (Exception err)
                                                    {

                                                        Label6.Text += err.ToString();
                                                    }
                                                    finally
                                                    {
                                                        dbConn.Close();
                                                    }
                                                    //Response.Redirect("ViewB.aspx");
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





                                            Label6.Text = "Reservation Not Successful  114";



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





                                //Label6.Text = "1  Bedroom Apartment Not Availbale";
                            }
                            else
                            {


                                selectSQL33 = "select * from Discount WHERE Dis ='" + TextBox1.Text.Trim() + "' ";
                                //Response.Write(selectSQL23);


                                dbConn33.ConnectionString =  "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
                                //dbConn1.ConnectionString = "Data Source=NEW-VITAL\\SCHOOLSERVER; Initial Catalog=emma;Integrated Security=True;";

                                cmd33.Connection = dbConn33;
                                cmd33.CommandText = selectSQL33;
                                cmd33.CommandType = CommandType.Text;



                                try
                                {



                                    dbConn33.Open();
                                    dr33 = cmd33.ExecuteReader();

                                    if (dr33.Read())
                                    {


                                        Session["N"] = dr33["Number"].ToString();
                                        int hs = Int32.Parse(Label17.Text);
                                        //  Response.Write(ss);

                                        int ww = Int32.Parse(Session["N"].ToString());
                                        // Response.Write(ww);
                                        int f1 = hs - (hs * ww / 100);
                                        Label8.Text = f1.ToString();
                                        // Response.Write(f1);

                                        updateSQL6 = "update Booking set Status='Done',Amount='" + Int32.Parse(Label8.Text) + "', Status2='Approved',Status3='Approved',Discount='Yes',Payment ='" + DropDownList2.SelectedItem.Text + "' where  id ='" + Session["id"].ToString() + "'";
                                        // Response.Write(updateSQL6);
                                        dbConn6.ConnectionString =  "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";

                                        cmd6.Connection = dbConn6;
                                        cmd6.CommandText = updateSQL6;
                                        cmd6.CommandType = CommandType.Text;
                                        try
                                        {

                                            dbConn6.Open();
                                            // Response.Write(updateSQL6);
                                            int updated2 = cmd6.ExecuteNonQuery();
                                            if (updated2 == 1)
                                            {
                                                updateSQL1 = "update Rooms set  Status='Occupied' where  Room_Name ='" + DropDownList6.SelectedItem + "'";

                                                dbConn4.ConnectionString =  "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";

                                                cmd2.Connection = dbConn4;
                                                cmd2.CommandText = updateSQL1;
                                                cmd2.CommandType = CommandType.Text;
                                                try
                                                {

                                                    dbConn4.Open();
                                                    // Response.Write(updateSQL1);
                                                    int updated1 = cmd2.ExecuteNonQuery();
                                                    if (updated1 == 1)
                                                    {
                                                        Response.Redirect("ViewB.aspx");


                                                    }
                                                    else
                                                    {

                                                    }
                                                    // Label1.Text = added.ToString() + "records Inserted";
                                                }



                                                catch (Exception err)
                                                {

                                                    Label6.Text += err.ToString();
                                                }
                                                finally
                                                {
                                                    dbConn.Close();
                                                }
                                                //Response.Redirect("ViewB.aspx");
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





                                        Label6.Text = "Reservation Not Successful 116";



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
}
