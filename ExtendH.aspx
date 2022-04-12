<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExtendH.aspx.cs" Inherits="ExtendH" %>





<%@ Import namespace="System.Data" %>
<%@ Import namespace="System.Data.SqlClient" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>CONFIRMATION PAGE</title>
    <style type="text/css">
        .style4
        {
            width: 709px;
        }
        .style5
        {
        	font-size:small;
        }
        


        .style6
        {
            width: 338px;
        }
        .style7
        {
            width: 338px;
            height: 25px;
        }
        .style8
        {
            height: 25px;
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
                                                              PostBackUrl="Home.aspx" CausesValidation="False" 
                                                          >Home</asp:LinkButton> &nbsp;| &nbsp;<asp:LinkButton 
                                                             ID="LinkButton1" runat="server" ForeColor="White" 
                                                              PostBackUrl="Admin.aspx" CausesValidation="False" onclick="LinkButton1_Click" 
                                                      >Sign out</asp:LinkButton>
                            &nbsp;</td>
                            </tr>
                        </table>
                
                <br />
                
                EXTEND HOTEL OR APARTMENT BOOKINGS<br />
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
                <table align="center" border="1" style="width: 100%;">
                        <tr>
                            <td class="style7">
                                Extend&nbsp; Hotel Bookings</td>
                            <td class="style8">
                                Extend Apartment Bookings</td>
                        </tr>
                        <tr>
                            <td class="style6">
                                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Extend " 
                                    Width="198px" />
                            </td>
                            <td>
                                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Extend" 
                                    Width="197px" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style6">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                </table>
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
                        <img src="Images/Down.jpg" style="width: 800px; height: 120px" /><br />
                </td>
        </tr>
    </table>
         
    
    </div>
    </form>
</body>
</html>
