<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddUser.aspx.cs" Inherits="AddUser" %>


<%@ Import namespace="System.Data" %>
<%@ Import namespace="System.Data.SqlClient" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>ADD USER</title>
    <style type="text/css">
        .style4
        {
            width: 709px;
        }
        .style5
        {
        	font-size:small;
        }
        


        .style23
        {
            height: 16px;
            width: 298px;
            font-weight: bold;
        }
        .style20
        {
            height: 16px;
            width: 170px;
        }
        .style19
        {
            height: 16px;
            width: 141px;
        }
        .style27
        {
            height: 30px;
            width: 298px;
            font-weight: bold;
        }
        .style21
        {
            height: 30px;
            width: 170px;
        }
        .style13
        {
            height: 30px;
            width: 141px;
        }
        .style24
        {
            height: 30px;
            width: 298px;
        }
        .style25
        {
            width: 298px;
        }
        .style26
        {
            width: 170px;
        }
        .style14
        {
            width: 141px;
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
                                                              PostBackUrl="Admin.aspx" CausesValidation="False" onclick="LinkButton1_Click1" 
                                                     >Sign out</asp:LinkButton>
                            &nbsp;</td>
                            </tr>
                        </table>
                
                ADD USER<br />
                <br />
                <br />
                <br />
                <br />
                <b style="font-size: normal;">
                <table style="width: 495px; height: 92px">
                    <tr>
                        <td align="left" class="style23">
                            Role</td>
                        <td class="style20">
                            <asp:DropDownList ID="DropDownList1" runat="server" Height="25px" Width="191px">
                                <asp:ListItem>Select Role</asp:ListItem>
                                <asp:ListItem>ADMIN HOTEL</asp:ListItem>
                            <asp:ListItem>ADMIN APARTMENT</asp:ListItem>
                               <asp:ListItem>GYM HOTEL</asp:ListItem>
                               <asp:ListItem>GYM  APARTMENT</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td class="style19">
                            &nbsp;&nbsp;&nbsp;&nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" 
                                ControlToValidate="DropDownList1" ErrorMessage="Choose Role" Font-Bold="True" 
                                Font-Size="Small" Operator="NotEqual" ValueToCompare="Select Role" 
                                Width="145px"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style27">
                            Username</td>
                        <td class="style21">
                            <asp:TextBox ID="TextBox2" runat="server" Width="187px"></asp:TextBox>
                        </td>
                        <td class="style13">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="TextBox2" ErrorMessage="Enter Username" Font-Size="Small"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style24">
                            <b style="font-size: normal; ">Password</b></td>
                        <td class="style21">
                            <asp:TextBox ID="TextBox3" runat="server" Width="187px"></asp:TextBox>
                        </td>
                        <td class="style13">
                            <b style="font-size: normal;">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ControlToValidate="TextBox3" ErrorMessage="Enter Password" Font-Size="Small"></asp:RequiredFieldValidator>
                            </b>
                        </td>
                    </tr>
                    <tr>
                        <td class="style25">
                            &nbsp;</td>
                        <td class="style26">
                            <asp:Button ID="Button1" runat="server" onclick="Button1_Click1" 
                                Text="Add User" Width="154px" />
                        </td>
                        <td class="style14">
                            &nbsp;</td>
                    </tr>
                </table>
                </b>
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



