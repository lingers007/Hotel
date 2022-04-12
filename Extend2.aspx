<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Extend2.aspx.cs" Inherits="Extend2" %>



<%@ Import namespace="System.Data" %>
<%@ Import namespace="System.Data.SqlClient" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>EXTEND BOOKED APARTMENT</title>
    <style type="text/css">
        .style4
        {
            width: 709px;
        }
        .style5
        {
        	font-size:small;
        }
        


        .style46
        {
            font-size: small;
            width: 198px;
            height: 14px;
        }
        
        .style47
        {
            width: 20px;
            height: 14px;
        }
        .style48
        {
            width: 69px;
            height: 14px;
        }
        .style52
        {
            width: 102px;
            height: 14px;
        }
        .style53
        {
            font-size: small;
            width: 88px;
            height: 14px;
        }
        .style54
        {
            font-size: small;
            width: 25px;
            height: 14px;
        }
        .style55
        {
            font-size: small;
            width: 105px;
            height: 14px;
        }
        
        .style60
        {
            width: 11px;
            height: 14px;
        }
        .style61
        {
            font-size: small;
            width: 127px;
            height: 14px;
        }
        .style62
        {
            font-size: small;
            width: 113px;
            height: 14px;
        }
        
        </style>
 
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center" border="1px" bordercolor="blue" style="width: 811px">
        <tr>
            <td align="center" class="style4" 
                
                
                
                
                
                style="font-size: large; color: #006699; font-family: Cambria; font-weight: bold;">
              
                
                <table style="width: 100%; height: 28px; color: #000080; background-color: #000099;">
                    <tr>
                        <td style="background-color: #DAC16B" class="style5" align="right">
                                                         <asp:LinkButton ID="LinkButton2" runat="server" ForeColor="White" 
                                                              PostBackUrl="Home3.aspx" CausesValidation="False" 
                                                             onclick="LinkButton2_Click">Home</asp:LinkButton> &nbsp;| &nbsp;<asp:LinkButton 
                                                             ID="LinkButton1" runat="server" ForeColor="White" 
                                                              PostBackUrl="Admin.aspx" CausesValidation="False" 
                                                             onclick="LinkButton1_Click">Sign out</asp:LinkButton>
                            &nbsp;</td>
                            </tr>
                        </table>
                
                &nbsp;EXTEND BOOKED APARTMENT<br />
                <br />
        <table border="1" 
                    
                    id='tab1' 
                    style="width: 959px; font-family: Candara; font-size: small; font-weight: normal;">
            <tr>
            <td class="style47" 
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;">
                   S/N</td>
                <td class="style48" 
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;">
                 Surname</td>
                <td class="style60" style="font-size: medium; font-weight: bold">
                    Firstname</td>
                <td class="style52" style="font-size: medium; font-weight: bold">
                    Phone</td>
                <td class="style53" style="font-size: medium; font-weight: bold">
                    Arrival</td>
                <td class="style54" style="font-size: medium; font-weight: bold">
                    Depature</td>
                    <td class="style55" style="font-size: medium; font-weight: bold">
                    Room_Name</td>
                    <td class="style61" style="font-size: medium; font-weight: bold">
                    Room_Type</td>
                    <td class="style62" style="font-size: medium; font-weight: bold">
                    Status</td>
                    <td class="style46" style="font-size: medium; font-weight: bold">
                  </td>
            </tr>
            <%
                
                
                SqlCommand scz = new SqlCommand("select id, Surname,Firstname,Phone,Depature,ArrivalD,DepatureD,Room_Name,Room_Type,CT,Status,Control from Booking where  Status='Done' and Status2='Approved'  and  Status3='Approved' and Type='Hotel' order by id,ArrivalD ", dbConn);
                            scz.CommandType = CommandType.Text;
                            dbConn.Open();


                            SqlDataReader sdz = scz.ExecuteReader();
                            int ct = 1;
                            string kk;
                            while (sdz.Read())
                            {

                               
                                string Control = sdz["Control"].ToString();
                                int v = Int32.Parse(Control);
                                DateTime startTime = Convert.ToDateTime(sdz["Depature"].ToString());
                                DateTime endTime = DateTime.Now;
                                TimeSpan span = startTime.Subtract(endTime);
                                
                                int F = (int)span.TotalHours + 12 ;
                              // Response.Write(F);
                              // int A = v - F;

                                //Session["A"] = A;
                           // Response.Write(A);
                         
                                if (  F  <= 1)
                                {

                                    kk = "<span style='color:red;'><b>" + " Expired" + "</b></span>";
                                    //table1.BgColor = "Purple";

                                }
                                else if (F <= 7)
                                {
                                    kk = "<span style='color:red;'><b>" + " Checkout Time" + "</b></span>";
                                }

                                else if (F <= 15)
                                {
                                    kk = "<span style='color:Orange;'><b>" + "Almost Time" + "</b></span>";
                                }
                                else
                                {
                                    kk = "<span style='color:Green;'><b>" + " Okay" + "</b></span>";

                                }


                               
                              var tt = sdz["ArrivalD"].ToString();
                                var tt1 = sdz["DepatureD"].ToString();

                                 var x = DateTime.Parse(tt).ToShortDateString();
                                var y = DateTime.Parse(tt1).ToShortDateString();





                                          if (sdz["Status"].ToString() == "Done")
                                {
								
								
								          Response.Write("<tr style><td class='style2'>" + ct++ + "</td><td class='style2'>" + sdz["Surname"].ToString() + "</td><td class='style2'>" + sdz["Firstname"].ToString() + "</td><td class='style2'>" + sdz["Phone"].ToString() + "</td><td class='style2'>" + x + "</td><td class='style2'>" + y + "</td><td class='style2'>" + sdz["Room_Name"].ToString() + "</td><td>" + sdz["Room_Type"].ToString() + "</td><td >" + kk + "</td><td class='style5'></a>    <a href='Checkout2.aspx?id=" + sdz["id"].ToString() + "'>Checkout</a>&nbsp;&nbsp;&nbsp;&nbsp;  <a href='Extended2.aspx?id=" + sdz["id"].ToString() + "'>Extend Booking</a> </td></tr>");
								
								
								
								
								
								}
								else
								{
                                Response.Write("<tr style><td class='style2'>" + ct++ + "</td><td class='style2'>" + sdz["Surname"].ToString() + "</td><td class='style2'>" + sdz["Firstname"].ToString() + "</td><td class='style2'>" + sdz["Phone"].ToString() + "</td><td class='style2'>" + x + "</td><td class='style2'>" + y + "</td><td class='style2'>" + sdz["Room_Name"].ToString() + "</td><td>" + sdz["Room_Type"].ToString() + "</td><td >" + kk + "</td><td class='style5'></a>&nbsp;&nbsp;&nbsp;&nbsp;  <a href='Extended2.aspx?id=" + sdz["id"].ToString() + "'>Extend Booking</a> </td></tr>");
                                     
                                }
                                
                                
                                //Response.Write("<tr style><td class='style2'>" + ct++ + "</td><td class='style2'>" + sdz["Surname"].ToString() + "</td><td class='style2'>" + sdz["Firstname"].ToString() + "</td><td class='style2'>" + sdz["Phone"].ToString() + "</td><td class='style2'>" + x + "</td><td class='style2'>" + y + "</td><td class='style2'>" + sdz["Room_Name"].ToString() + "</td><td>" + sdz["Room_Type"].ToString() + "</td><td >" + kk + "</td><td class='style5'><a href='Addition.aspx?id=" + sdz["id"].ToString() + "'>Approve</a>&nbsp;&nbsp;&nbsp;&nbsp;  <a href='Delete.aspx?id=" + sdz["id"].ToString() + "'>Decline</a> </td></tr>");
                                ct++;
                               // Session["id"] = Request.QueryString["id"].ToString();
                            }

                dbConn.Close();

                          
                 %>

                    
                </table>
                
                <br />
                    <br />
                    <br />
                        <asp:Label ID="Label1" runat="server" BackColor="White"></asp:Label>
                    <br />
                    <br />
                    <br />
                <br />
                <br />
                    <br />
                    <br />
                &nbsp;<br />
                        <br />
                        <br />
                        <br />
                        <br />
                <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                <br />
                <br />
                <br />
                        <img src="Images/Down.jpg" style="width: 960px; height: 120px" /><br />
                </td>
        </tr>
    </table>
       
    
    </div>
    </form>
</body>
</html>




