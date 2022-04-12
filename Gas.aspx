<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Gas.aspx.cs" Inherits="Gas" %>







<%@ Import namespace="System.Data" %>
<%@ Import namespace="System.Data.SqlClient" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>GAS RECORD</title>
    <style type="text/css">
        .style4
        {
            width: 709px;
        }
        .style5
        {
        	font-size:small;
        }
        


        .style7
        {
            width: 224px;
        }
        .style8
        {
            width: 209px;
        }
        .style9
        {
            width: 170px;
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
                                                              PostBackUrl="Home1.aspx" CausesValidation="False" 
                                                          >Home</asp:LinkButton> &nbsp;| &nbsp;<asp:LinkButton 
                                                             ID="LinkButton1" runat="server" ForeColor="White" 
                                                              PostBackUrl="Admin.aspx" CausesValidation="False" onclick="LinkButton1_Click" 
                                                      >Sign out</asp:LinkButton>
                            &nbsp;</td>
                            </tr>
                        </table>
                
                <br />
                
                <br />
                    <br />
                    <br />
                    <br />
                    <br />
                
                        <br />
                <br />
                
                        <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; GAS RECORD<br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <table style="width: 100%; font-family: 'Gill Sans MT Condensed'; font-weight: normal; font-size: large;" 
                    align="center" border="1">
                    <tr>
                        <td class="style9">
                            Record Empty Gas Cylinder</td>
                        <td class="style7">
                            Record Swaping of Cylinder</td>
                        <td class="style8">
                            Record Filling Of Gas Cylinder</td>
                    </tr>
                    <tr>
                        <td class="style9">
                            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                                Text="Record Empty Gas Cylinder" Width="235px" />
                        </td>
                        <td class="style7">
                            <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                                Text="Record Swaping of Cylinder" Width="238px" />
                        </td>
                        <td class="style8">
                            <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
                                Text="Record Filling Of Gas Cylinder" Width="231px" />
                        </td>
                    </tr>
                    </table>
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
                        <img src="Images/Down.jpg" style="width: 849px; height: 120px" /><br />
                </td>
        </tr>
    </table>
       
    
    </div>
    </form>
</body>
</html>



