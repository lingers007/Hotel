<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VGas.aspx.cs" Inherits="VGas" %>

<%@ Import namespace="System.Data" %>
<%@ Import namespace="System.Data.SqlClient" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>VIEW GAS RECORD</title>
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
            height: 14px;
        }
        .style55
        {
            font-size: small;
            width: 279px;
            height: 14px;
        }
        
        .style61
        {
            font-size: small;
            width: 30px;
            height: 14px;
        }
        .style63
        {
            width: 169px;
            height: 14px;
        }
                
        .style66
        {
            width: 152px;
            height: 14px;
        }
        .style71
        {
            width: 209px;
            height: 14px;
        }
        
        .style72
        {
            font-size: small;
            width: 211px;
            height: 14px;
        }
        
        .style73
        {
            width: 129px;
            height: 14px;
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
                                                              PostBackUrl="Home1.aspx" CausesValidation="False" 
                                                             onclick="LinkButton2_Click">Home</asp:LinkButton> &nbsp;| &nbsp;<asp:LinkButton 
                                                             ID="LinkButton1" runat="server" ForeColor="White" 
                                                              PostBackUrl="Admin.aspx" CausesValidation="False" 
                                                             onclick="LinkButton1_Click">Sign out</asp:LinkButton>
                            &nbsp;</td>
                            </tr>
                        </table>
                
                BOOKED AND PENDING&nbsp; HOTEL<br />
                <br />
        <table border="1" 
                    
                    id='tab1' 
                    
                    
                    
                    style="width: 883px; font-family: Candara; font-size: small; font-weight: normal;">
            <tr>
            <td class="style47" 
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;">
                   S/N</td>
                <td class="style66" 
                    
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;">
                    Flatname</td>
                <td class="style71" style="font-size: medium; font-weight: bold">
                    Main&nbsp;&nbsp;&nbsp; Flat</td>
                <td class="style63" style="font-size: medium; font-weight: bold">
                    Destination Flat</td>
                <td class="style73" style="font-size: medium; font-weight: bold">
                    Action</td>
                <td class="style61" style="font-size: medium; font-weight: bold">
                    Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="style72" style="font-size: medium; font-weight: bold">
                    Posted By&nbsp; </td>
                        <td class="style55" style="font-size: medium; font-weight: bold">
                            </td>
            </tr>
            <%
                
                
                SqlCommand scz = new SqlCommand("select id,Flatname,Original,Destination,Action,ShortD,Posted from Gas where  Type='Hotel'    order by ShortD Asc ", dbConn);
                            scz.CommandType = CommandType.Text;
                            dbConn.Open();


                            SqlDataReader sdz = scz.ExecuteReader();
                            int ct = 1;
                            string kk;
                            while (sdz.Read())
                            {

                               
                               
                               
                              var tt = sdz["ShortD"].ToString();
                               // var tt1 = sdz["DepatureD"].ToString();

                                 var x = DateTime.Parse(tt).ToShortDateString();
                              //  var y = DateTime.Parse(tt1).ToShortDateString();

                                
                                    Response.Write("<tr style><td class='style2'>" + ct++ + "</td><td class='style2'>" + sdz["Flatname"].ToString() + "</td><td class='style2'>" + sdz["Original"].ToString() + "</td><td class='style2'>" + sdz["Destination"].ToString() + "</td>   <td class='style2'>" + sdz["Action"].ToString() + "</td><td class='style2'>" + x + "</td><td>" + sdz["Posted"].ToString() + "</td><td class='style5'> <a href='DeleteG.aspx?id=" + sdz["id"].ToString() + "'>Delete</a></td></tr>");
                                

                



                           
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
                        <img src="Images/Down.jpg" style="width: 879px; height: 120px" /><br />
                </td>
        </tr>
    </table>
       
    
    </div>
    </form>
</body>
</html>



