<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GymView1.aspx.cs" Inherits="GymView1" %>


<%@ Import namespace="System.Data" %>
<%@ Import namespace="System.Data.SqlClient" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>VIEW GYM CLIENTS</title>
    <style type="text/css">
        .style4
        {
            width: 516px;
        }
        .style5
        {
        	font-size:small;
        }
        


        .style47
        {
            height: 14px;
        }
        .style48
        {
            width: 127px;
            height: 14px;
        }
        .style52
        {
            width: 86px;
            height: 14px;
        }
                
        .style63
        {
            font-size: small;
            width: 93px;
            height: 14px;
        }
        .style65
        {
            font-size: small;
            width: 176px;
            height: 14px;
        }
        .style66
        {
            font-size: small;
            width: 75px;
            height: 14px;
        }
        
        .style67
        {
            font-size: small;
            width: 223px;
            height: 14px;
        }
        
        .style68
        {
            width: 98px;
            height: 14px;
        }
        .style69
        {
            font-size: small;
            width: 95px;
            height: 14px;
        }
        
        </style>
  
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center" border="1px" bordercolor="blue" 
            style="width: 672px; height: 728px;">
        <tr>
            <td align="center" class="style4" 
                
                
                
                
                
                style="font-size: large; color: #006699; font-family: Cambria; font-weight: bold;">
              
                
                <table style="width: 100%; height: 28px; color: #000080; background-color: #000099;">
                    <tr>
                        <td style="background-color: #DAC16B" class="style5" align="right">
                                                         <asp:LinkButton ID="LinkButton2" runat="server" ForeColor="White" 
                                                              PostBackUrl="Home2.aspx" CausesValidation="False" 
                                                             onclick="LinkButton2_Click">Home</asp:LinkButton> &nbsp;| &nbsp;<asp:LinkButton 
                                                             ID="LinkButton1" runat="server" ForeColor="White" 
                                                              PostBackUrl="Admin.aspx" CausesValidation="False" 
                                                             onclick="LinkButton1_Click">Sign out</asp:LinkButton>
                            &nbsp;</td>
                            </tr>
                        </table>
                
                VIEW&nbsp;&nbsp; GYM&nbsp; RECORD<br />
                <br />
        <table border="1" 
                    
                    id='tab1' 
                    
                    
                    
                    style="width: 876px; font-family: Candara; font-size: small; font-weight: normal;">
            <tr>
            <td class="style47" 
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;">
                   S/N</td>
                <td class="style48" 
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;">
                 Surname</td>
                <td class="style68" style="font-size: medium; font-weight: bold">
                    Firstname</td>
                <td class="style52" style="font-size: medium; font-weight: bold">
                    Phone</td>
                <td class="style69" style="font-size: medium; font-weight: bold">
                    Start&nbsp;&nbsp; Date</td>
                    <td class="style63" style="font-size: medium; font-weight: bold">
                    End
                    Date</td>
                <td class="style67" style="font-size: medium; font-weight: bold">
                    Status</td>
                <td class="style66" style="font-size: medium; font-weight: bold">
                    Price</td>
                
                   
            </tr>
            <%
                
                
                SqlCommand scz = new SqlCommand("select id, Surname,Firstname,Phone,Arrival,Depature,ArrivalD,DepatureD,Status,Price from Gym    where  Arrival  >= '" + (Session["D"].ToString()) + "' and Depature <= '" + (Session["D1"].ToString()) + "' and Type='Apartment' ", dbConn);
                            scz.CommandType = CommandType.Text;
                            dbConn.Open();


                            SqlDataReader sdz = scz.ExecuteReader();
                            int ct = 1;
                         
                            while (sdz.Read())
                            {

                               

                               
                              var tt = sdz["ArrivalD"].ToString();
                                var tt1 = sdz["DepatureD"].ToString();

                                 var x = DateTime.Parse(tt).ToShortDateString();
                                var y = DateTime.Parse(tt1).ToShortDateString();

                                Response.Write("<tr style><td class='style2'>" + ct++ + "</td><td class='style2'>" + sdz["Surname"].ToString() + "</td><td class='style2'>" + sdz["Firstname"].ToString() + "</td> <td class='style2'>" + sdz["Phone"].ToString() + "</td><td class='style2'>" + x + "</td><td class='style2'>" + y + "</td><td class='style2'>" + sdz["Status"].ToString() + "</td> <td class='style2'>" + sdz["Price"].ToString() + "</td></tr>");
                                
                               

                                //Response.Write("<tr style><td class='style2'>" + ct++ + "</td><td class='style2'>" + sdz["Surname"].ToString() + "</td><td class='style2'>" + sdz["Firstname"].ToString() + "</td><td class='style2'>" + sdz["Phone"].ToString() + "</td><td class='style2'>" + x + "</td><td class='style2'>" + y + "</td><td class='style2'>" + sdz["Room_Name"].ToString() + "</td><td>" + sdz["Room_Type"].ToString() + "</td><td >" + kk + "</td><td class='style5'><a href='Addition.aspx?id=" + sdz["id"].ToString() + "'>Approve</a>&nbsp;&nbsp;&nbsp;&nbsp;  <a href='Delete.aspx?id=" + sdz["id"].ToString() + "'>Decline</a> </td></tr>");
                              
                               // Session["id"] = Request.QueryString["id"].ToString();
                            }

                dbConn.Close();

                          
                 %>

                    
            <tr>
            <td class="style47" 
                    
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;" 
                    align="right" colspan="7">
                   Total</td>
                <td class="style66" style="font-size: medium; font-weight: bold">
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
                
                    
            </tr>
            
                    
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
                        <img src="Images/Down.jpg" style="width: 100%; height: 120px" /><br />
                </td>
        </tr>
    </table>
       
    
    </div>
    </form>
</body>
</html>



