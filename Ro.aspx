﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ro.aspx.cs" Inherits="Ro" %>


<%@ Import namespace="System.Data" %>
<%@ Import namespace="System.Data.SqlClient" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>CREATE ROASTER</title>
    <style type="text/css">
        .style4
        {
            width: 709px;
        }
        .style5
        {
        	font-size:small;
        }
        


        .style1
        {
            width: 250px;
        }
        .style2
        {
            width: 154px;
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
                                                              PostBackUrl="Admin.aspx" CausesValidation="False" 
                                                             onclick="LinkButton1_Click">Sign out</asp:LinkButton>
                            &nbsp;</td>
                            </tr>
                        </table>
                
                CREATE ROASTER<br />
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
  
    
        <table style="width: 91%;" align="center">
            <tr>
                <td class="style1">
                    Month</td>
                <td class="style2">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="TextBox1" ErrorMessage="Enter Month" Font-Size="Medium"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Number of&nbsp; Days</td>
                <td class="style2">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="TextBox2" ErrorMessage="Enter No of Days" Font-Size="Medium"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    First Worker</td>
                <td class="style2">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="TextBox3" ErrorMessage="Enter Name of First Worker" 
                        Font-Size="Medium"></asp:RequiredFieldValidator>
                                </td>
            </tr>
            <tr>
                <td class="style1">
                    Second Worker</td>
                <td class="style2">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="TextBox4" ErrorMessage="Enter Name of Second  Worker" 
                        Font-Size="Medium"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Department</td>
                <td class="style2">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="29px" Width="152px">
                        <asp:ListItem Selected="True">Select a Department</asp:ListItem>
                        <asp:ListItem>House Keeping</asp:ListItem>
                        <asp:ListItem>Manager /Receptionist</asp:ListItem>
                        <asp:ListItem>Security</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                <b style="font-size: normal;">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                ControlToValidate="DropDownList1" ErrorMessage="Select a Department" Font-Bold="True" 
                                Font-Size="Small" Operator="NotEqual" ValueToCompare="Select a Department" 
                                Width="145px"></asp:CompareValidator>
                </b>
                                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style2">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click1" Text="Button" 
                        Width="128px" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
  
    
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
                        <img src="Images/Down.jpg" style="width: 800px; height: 120px" /><br />
                </td>
        </tr>
    </table>
       
    
    </div>
    </form>
</body>
</html>




