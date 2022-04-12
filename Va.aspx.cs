using System;
using System.Collections;
using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Collections.Generic;
using System.Text;

public partial class Va : System.Web.UI.Page
{
    string selectSQL;
    string updateSQL;
    SqlCommand cmd = new SqlCommand();
    SqlConnection dbConn = new SqlConnection();
    SqlDataReader dr;

  
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

     
 dbConn.ConnectionString ="Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";


        selectSQL = "select * from Booking WHERE Room_Name ='Apartment 1'  and    Status3='Approved' and    Status5='run'  ";
        dbConn.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
        cmd.Connection = dbConn;
        cmd.CommandText = selectSQL;
        cmd.CommandType = CommandType.Text;
        try
        {
            dbConn.Open();
           
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Label1.Text = "Occupied ";

            }
            else
            {
                Label1.Text = "Free ";
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



        selectSQL = "select * from Booking WHERE Room_Name ='Apartment 2'  and    Status3='Approved' and    Status5='run'  ";
      dbConn.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
        cmd.Connection = dbConn;
        cmd.CommandText = selectSQL;
        cmd.CommandType = CommandType.Text;
        try
        {
            dbConn.Open();
           
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Label2.Text = "Occupied ";

            }
            else
            {
                Label2.Text = "Free ";
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



        selectSQL = "select * from Booking WHERE Room_Name ='Apartment 3'  and    Status3='Approved' and    Status5='run'  ";
         dbConn.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
        cmd.Connection = dbConn;
        cmd.CommandText = selectSQL;
        cmd.CommandType = CommandType.Text;
        try
        {
            dbConn.Open();
           
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Label3.Text = "Occupied ";

            }
            else
            {
                Label3.Text = "Free ";
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


        selectSQL = "select * from Booking WHERE Room_Name ='Apartment 4'  and    Status3='Approved' and    Status5='run'  ";
         dbConn.ConnectionString ="Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
        cmd.Connection = dbConn;
        cmd.CommandText = selectSQL;
        cmd.CommandType = CommandType.Text;
        try
        {
            dbConn.Open();
           
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Label4.Text = "Occupied ";

            }
            else
            {
                Label4.Text = "Free ";
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





        selectSQL = "select * from Booking WHERE Room_Name ='Apartment 5'  and    Status3='Approved' and    Status5='run'  ";
        dbConn.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
        cmd.Connection = dbConn;
        cmd.CommandText = selectSQL;
        cmd.CommandType = CommandType.Text;
        try
        {
            dbConn.Open();
           
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Label5.Text = "Occupied ";

            }
            else
            {
                Label5.Text = "Free ";
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



        selectSQL = "select * from Booking WHERE Room_Name ='Apartment 6'  and    Status3='Approved' and    Status5='run'  ";
         dbConn.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
        cmd.Connection = dbConn;
        cmd.CommandText = selectSQL;
        cmd.CommandType = CommandType.Text;
        try
        {
            dbConn.Open();
           
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Label6.Text = "Occupied ";

            }
            else
            {
                Label6.Text = "Free ";
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



        selectSQL = "select * from Booking WHERE Room_Name ='Apartment 7'  and    Status3='Approved' and    Status5='run'  ";
         dbConn.ConnectionString ="Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
        cmd.Connection = dbConn;
        cmd.CommandText = selectSQL;
        cmd.CommandType = CommandType.Text;
        try
        {
            dbConn.Open();
           
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Label7.Text = "Occupied ";

            }
            else
            {
                Label7.Text = "Free ";
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


        selectSQL = "select * from Booking WHERE Room_Name ='Apartment 8'  and    Status3='Approved' and    Status5='run'  ";
         dbConn.ConnectionString ="Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
        cmd.Connection = dbConn;
        cmd.CommandText = selectSQL;
        cmd.CommandType = CommandType.Text;
        try
        {
            dbConn.Open();
           
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Label8.Text = "Occupied ";

            }
            else
            {
                Label8.Text = "Free ";
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







        selectSQL = "select * from Booking WHERE Room_Name ='Apartment 9'  and    Status3='Approved' and    Status5='run'  ";
      dbConn.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
        cmd.Connection = dbConn;
        cmd.CommandText = selectSQL;
        cmd.CommandType = CommandType.Text;
        try
        {
            dbConn.Open();
           
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Label9.Text = "Occupied ";

            }
            else
            {
                Label9.Text = "Free ";
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



        selectSQL = "select * from Booking WHERE Room_Name ='Apartment 10'  and    Status3='Approved' and    Status5='run'  ";
        dbConn.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
        cmd.Connection = dbConn;
        cmd.CommandText = selectSQL;
        cmd.CommandType = CommandType.Text;
        try
        {
            dbConn.Open();
           
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Label10.Text = "Occupied ";

            }
            else
            {
                Label10.Text = "Free ";
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


        selectSQL = "select * from Booking WHERE Room_Name ='Apartment 11'  and    Status3='Approved' and    Status5='run'  ";
       dbConn.ConnectionString ="Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
        cmd.Connection = dbConn;
        cmd.CommandText = selectSQL;
        cmd.CommandType = CommandType.Text;
        try
        {
            dbConn.Open();
           
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Label11.Text = "Occupied ";

            }
            else
            {
                Label11.Text = "Free ";
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


        selectSQL = "select * from Booking WHERE Room_Name ='Roof  Top'  and    Status3='Approved' and    Status5='run'  ";
        dbConn.ConnectionString = "Data Source= 67.211.215.196;Initial Catalog=da24;User ID=sa;password=Dao247server%;Integrated Security=false;";
        cmd.Connection = dbConn;
        cmd.CommandText = selectSQL;
        cmd.CommandType = CommandType.Text;
        try
        {
            dbConn.Open();
          
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Label12.Text = "Occupied ";

            }
            else
            {
                Label12.Text = "Free ";
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

    protected void LinkButton2_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["username"] = "";
        Session.Remove("username");
    }
}
