﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteGym.aspx.cs" Inherits="DeleteGym" %>




<%@ Import namespace="System.Data" %>
<%@ Import namespace="System.Data.SqlClient" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>ERROR PAGE</title>
    <style type="text/css">
        .style4
        {
            width: 709px;
        }
        .style5
        {
        	font-size:small;
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
                                                             onclick="LinkButton2_Click">Home</asp:LinkButton> &nbsp;| &nbsp;<asp:LinkButton 
                                                             ID="LinkButton1" runat="server" ForeColor="White" 
                                                              PostBackUrl="Admin.aspx" CausesValidation="False" 
                                                             onclick="LinkButton1_Click">Sign out</asp:LinkButton>
                            </td>
                            </tr>
                        </table>
                
                    ERROR PAGE<br />
                
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
                &nbsp;&nbsp;&nbsp; <br />
                        <br />
                        <br />
                        <asp:Label ID="Label1" runat="server"></asp:Label>
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
                        <img src="Images/Down.jpg" style="width: 799px; height: 120px" /><br />
                </td>
        </tr>
    </table>
       
    
    </div>
    </form>
</body>
</html>



