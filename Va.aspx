<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Va.aspx.cs" Inherits="Va" %>



<%@ Import namespace="System.Data" %>
<%@ Import namespace="System.Data.SqlClient" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>VIEW VACANT APARTMENT</title>
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
            width: 151px;
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
                            &nbsp;</td>
                            </tr>
                        </table>
                
                VIEW VACANT APARTMENT<br />
                <br />
                <br />
                <br />
               <table border="1" 
                    
                    id='tab1' 
                    
                    
                    
                    style="width: 726px; font-family: Candara; font-size: small; font-weight: normal;" 
                    align="center">
            <tr>
            <td class="style47" 
                    
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;" 
                    align="center">
                   S/N</td>
                <td class="style48" 
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;">
                Apartment Name</td>
                <td class="style60" style="font-size: medium; font-weight: bold">
                 Apartment Type</td>
                <td class="style6" style="font-size: medium; font-weight: bold">
                    Status</td>
                
            </tr>
         

                    
            <tr>
            <td class="style47" 
                    
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;" 
                    align="center">
                   1</td>
                <td class="style48" 
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;">
                    Apartment 1</td>
                <td class="style60" style="font-size: medium; font-weight: bold">
                    2 Bedroom Apartment</td>
                <td class="style6" style="font-size: medium; font-weight: bold">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
            <td class="style47" 
                    
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;" 
                    align="center">
                   2</td>
                <td class="style48" 
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;">
                    Apartment 2</td>
                <td class="style60" style="font-size: medium; font-weight: bold">
                    1 Bedroom Apartment</td>
                <td class="style6" style="font-size: medium; font-weight: bold">
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
            <td class="style47" 
                    
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;" 
                    align="center">
                   3</td>
                <td class="style48" 
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;">
                    Apartment 3</td>
                <td class="style60" style="font-size: medium; font-weight: bold">
                    1 Bedroom Apartment</td>
                <td class="style6" style="font-size: medium; font-weight: bold">
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
            <td class="style47" 
                    
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;" 
                    align="center">
                   4</td>
                <td class="style48" 
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;">
                    Apartment 4</td>
                <td class="style60" style="font-size: medium; font-weight: bold">
                    1 Bedroom Apartment</td>
                <td class="style6" style="font-size: medium; font-weight: bold">
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
            <td class="style47" 
                    
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;" 
                    align="center">
                   5</td>
                <td class="style48" 
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;">
                    Apartment 5</td>
                <td class="style60" style="font-size: medium; font-weight: bold">
                    1 Bedroom Apartment</td>
                <td class="style6" style="font-size: medium; font-weight: bold">
                    <asp:Label ID="Label5" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
            <td class="style47" 
                    
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;" 
                    align="center">
                   6</td>
                <td class="style48" 
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;">
                    Apartment 6</td>
                <td class="style60" style="font-size: medium; font-weight: bold">
                    1 Bedroom Apartment</td>
                <td class="style6" style="font-size: medium; font-weight: bold">
                    <asp:Label ID="Label6" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
            <td class="style47" 
                    
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;" 
                    align="center">
                   7</td>
                <td class="style48" 
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;">
                    Apartment 7</td>
                <td class="style60" style="font-size: medium; font-weight: bold">
                    1 Bedroom Apartment</td>
                <td class="style6" style="font-size: medium; font-weight: bold">
                    <asp:Label ID="Label7" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
            <td class="style47" 
                    
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;" 
                    align="center">
                   8</td>
                <td class="style48" 
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;">
                    Apartment 8</td>
                <td class="style60" style="font-size: medium; font-weight: bold">
                    1 Bedroom Apartment</td>
                <td class="style6" style="font-size: medium; font-weight: bold">
                    <asp:Label ID="Label8" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
            <td class="style47" 
                    
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;" 
                    align="center">
                   9</td>
                <td class="style48" 
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;">
                    Apartment 9</td>
                <td class="style60" style="font-size: medium; font-weight: bold">
                    1 Bedroom Apartment</td>
                <td class="style6" style="font-size: medium; font-weight: bold">
                    <asp:Label ID="Label9" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
            <td class="style47" 
                    
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;" 
                    align="center">
                   10</td>
                <td class="style48" 
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;">
                    Apartment 10</td>
                <td class="style60" style="font-size: medium; font-weight: bold">
                    1 Bedroom Apartment</td>
                <td class="style6" style="font-size: medium; font-weight: bold">
                    <asp:Label ID="Label10" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
            <td class="style47" 
                    
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;" 
                    align="center">
                   11</td>
                <td class="style48" 
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;">
                    Apartment 11</td>
                <td class="style60" style="font-size: medium; font-weight: bold">
                    1 Bedroom Apartment</td>
                <td class="style6" style="font-size: medium; font-weight: bold">
                    <asp:Label ID="Label11" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
            <td class="style47" 
                    
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;" 
                    align="center">
                   12</td>
                <td class="style48" 
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;">
                    Roof Top</td>
                <td class="style60" style="font-size: medium; font-weight: bold">
                    Roof Top</td>
                <td class="style6" style="font-size: medium; font-weight: bold">
                    <asp:Label ID="Label12" runat="server"></asp:Label>
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



