﻿
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Vacant2.aspx.cs" Inherits="Vacant2" %>


<%@ Import namespace="System.Data" %>
<%@ Import namespace="System.Data.SqlClient" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>VIEW PENDING AND BOOKED APARTMENT</title>
    <style type="text/css">
        .style4
        {
            width: 709px;
        }
        .style5
        {
        	font-size:small;
        }
        


        .style47
        {
            width: 20px;
            }
        .style63
        {
            width: 19px;
            }
                
        .style66
        {
            width: 74px;
            }
        .style71
        {
            width: 78px;
            }
        
        </style>
   <meta http-equiv="refresh" content="5" />
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center" border="1px" bordercolor="blue" style="width: 825px">
        <tr>
            <td align="center" class="style4" 
                
                
                
                
                
                style="font-size: large; color: #006699; font-family: Cambria; font-weight: bold;">
              
                
                <table style="width: 100%; height: 28px; color: #000080; background-color: #000099;">
                    <tr>
                        <td style="background-color: #DAC16B" class="style5" align="right">
                                                         <asp:LinkButton ID="LinkButton2" runat="server" ForeColor="White" 
                                                              PostBackUrl="Home.aspx" CausesValidation="False" 
                                                             onclick="LinkButton2_Click">Home</asp:LinkButton> &nbsp;| &nbsp;<asp:LinkButton 
                                                             ID="LinkButton1" runat="server" ForeColor="White" 
                                                              PostBackUrl="Admin.aspx" CausesValidation="False" 
                                                             onclick="LinkButton1_Click">Sign out</asp:LinkButton>
                            &nbsp;</td>
                            </tr>
                        </table>
                
                VIEW&nbsp; VACANT&nbsp; 
                HOTEL ROOM<br />
                <br />
        <table border="1" 
                    
                    id='tab1' 
                    
                    
                    
                    
                    
                    style="width: 574px; font-family: Candara; font-size: small; font-weight: normal;">
            <tr>
            <td class="style47" 
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;">
                   S/N</td>
                <td class="style66" 
                    
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;">
                    Room&nbsp;&nbsp;Name</td>
                <td class="style63" style="font-size: medium; font-weight: bold">
                    Room&nbsp;&nbsp;Type</td>
                <td class="style71" style="font-size: medium; font-weight: bold">
                    Status</td>
            </tr>
            <%
                
                
                SqlCommand scz = new SqlCommand("select sid, Room_Name,Room_Type,Status from Rooms where  Type='Hotel' and Status='Free'   order by Room_Type Asc ", dbConn);
                            scz.CommandType = CommandType.Text;
                            dbConn.Open();


                            SqlDataReader sdz = scz.ExecuteReader();
                            int ct = 1;
                            string kk;
                            while (sdz.Read())
                            {

                               
                               
                               
                              //var tt = sdz["Dates"].ToString();
                               // var tt1 = sdz["DepatureD"].ToString();

                               //  var x = DateTime.Parse(tt).ToShortDateString();
                              //  var y = DateTime.Parse(tt1).ToShortDateString();

                                
                                    Response.Write("<tr style><td class='style2'>" + ct++ + "</td><td class='style2'>" + sdz["Room_Name"].ToString() + "</td><td class='style2'>" + sdz["Room_Type"].ToString() + "</td><td class='style2'>" + sdz["Status"].ToString() + "</td></tr>");
                                

                



                           
                            }
                            // Label1.Text="No Record";

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
                        <img src="Images/Down.jpg" style="width: 879px; height: 120px" /><br />
                </td>
        </tr>
    </table>
       
    
    </div>
    </form>
</body>
</html>


