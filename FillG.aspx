<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FillG.aspx.cs" Inherits="FillG" %>







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
        


        .style6
        {
            width: 240px;
        }
        


        .style7
        {
            width: 218px;
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
                                                              PostBackUrl="Home1.aspx" CausesValidation="False" onclick="LinkButton2_Click" 
                                                          >Home</asp:LinkButton> &nbsp;| &nbsp;<asp:LinkButton 
                                                             ID="LinkButton1" runat="server" ForeColor="White" 
                                                              PostBackUrl="Admin.aspx" CausesValidation="False" onclick="LinkButton1_Click" 
                                                      >Sign out</asp:LinkButton>
                            &nbsp;</td>
                            </tr>
                        </table>
                
                <br />
                
                <br />
                    ENTER RECORD FOR GAS CYLINDER FILLED<br />
                    <br />
                    <br />
                    <br />
                
                        <br />
                <br />
                
                        <table style="width:100%;" align="center" border="1">
                            <tr>
                                <td class="style6">
                                    &nbsp;</td>
                                <td class="style7">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style6">
                                    ENTER ROOM NUMBER</td>
                                <td class="style7">
                                    <asp:DropDownList ID="DropDownList1" runat="server" Height="31px" Width="260px">
                                        <asp:ListItem>Choose A Room</asp:ListItem>
                                        

 
   <asp:ListItem Value="Apartment 1">Apartment 1</asp:ListItem>
                       
                        <asp:ListItem Value="Apartment 2">Apartment 2</asp:ListItem>
                        <asp:ListItem Value="Apartment 3">Apartment 3</asp:ListItem>
                        <asp:ListItem Value="Apartment 4">Apartment 4</asp:ListItem>
                        <asp:ListItem Value="Apartment 5">Apartment 5</asp:ListItem>
                        <asp:ListItem Value="Apartment 6">Apartment 6</asp:ListItem>
                        <asp:ListItem Value="Apartment 7">Apartment 7</asp:ListItem>
                        <asp:ListItem Value="Apartment 8">Apartment 8</asp:ListItem>
                        <asp:ListItem Value="Apartment 9">Apartment 9</asp:ListItem>
                        <asp:ListItem Value="Apartment 10">Apartment 10</asp:ListItem>
                    <asp:ListItem Value="Apartment 11">Apartment 11</asp:ListItem>



                                    </asp:DropDownList>
                                </td>
                                <td>
                                   <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToValidate="DropDownList1" ErrorMessage="Choose A Room" 
                        Font-Size="Small" Operator="NotEqual" 
                        ValueToCompare="Choose A Room" Font-Names="Agency FB" ForeColor="#FF3300"></asp:CompareValidator> </td>
                            </tr>
                            <tr>
                                <td class="style6">
                                    &nbsp;</td>
                                <td class="style7">
                                    <asp:Button ID="Button1" runat="server" Text="Submit Record" Width="173px" 
                                        onclick="Button1_Click" />
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                </table>
                
                        <br />
                    &nbsp;<br />
                <br />
                <asp:Label ID="Label1" runat="server"></asp:Label>
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
                        <img src="Images/Down.jpg" style="width: 800px; height: 120px" /><br />
                </td>
        </tr>
    </table>
       
    
    </div>
    </form>
</body>
</html>



