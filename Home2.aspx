<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home2.aspx.cs" Inherits="Home2" %>




<%@ Import namespace="System.Data" %>
<%@ Import namespace="System.Data.SqlClient" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>HOME</title>
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
            height: 5px;
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
                                                         &nbsp;&nbsp;<asp:LinkButton 
                                                             ID="LinkButton1" runat="server" ForeColor="White" 
                                                              PostBackUrl="Admin.aspx" CausesValidation="False" 
                                                             onclick="LinkButton1_Click">Sign out</asp:LinkButton>
                            </td>
                            </tr>
                        </table>
                
                    ADMIN HOMEPAGE<br />
                
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
                        <table align="center" bgcolor="#DAC16B" border="2" style="width: 42%;">
                           
<tr>
                                <td class="style6" align="center">
                                    <asp:HyperLink ID="HyperLink25" runat="server" ForeColor="White" 
                                        NavigateUrl="Gym1.aspx">Register Gym Clients</asp:HyperLink>
                                </td>
                            </tr>


<tr>
                                <td class="style6" align="center">
                                    <asp:HyperLink ID="HyperLink29" runat="server" ForeColor="White" 
                                        NavigateUrl="ViewGym1.aspx">View Gym Record</asp:HyperLink>
                                </td>
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



