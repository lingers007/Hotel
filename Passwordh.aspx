<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Passwordh.aspx.cs" Inherits="Passwordh" %>

<%@ Import namespace="System.Data" %>
<%@ Import namespace="System.Data.SqlClient" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>CHANGE PASSWORD</title>
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
            width: 87%;
        }
        .style8
        {
            width: 264px;
        }

        .style9
        {
            width: 123px;
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
                                                              PostBackUrl="Admin.aspx" CausesValidation="False" 
                                                             onclick="LinkButton1_Click">Sign out</asp:LinkButton>
                            &nbsp;</td>
                            </tr>
                        </table>
                
                CHANGE PASSWORD<br />
                <br />
                <br />
                <br />
                
                <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                <table border="1" class="style7" 
                    style="font-family: Arial, Helvetica, sans-serif; font-size: medium; font-weight: normal; font-style: normal; font-variant: normal">
                    <tr>
                        <td class="style8" 
                            style="font-family: Cambria; font-size: medium; font-weight: bold;">
                            Enter New Password</td>
                        <td class="style9">
                            <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style8" 
                            style="font-family: Cambria; font-size: medium; font-weight: bold;">
                            Enter your Password again</td>
                        <td class="style9">
                            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                        <td>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                ControlToCompare="TextBox1" ControlToValidate="TextBox2" 
                                ErrorMessage="The password did not match" Font-Bold="True" Font-Size="Small"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style8">
                            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                                Text="Change Password" Width="147px" />
                        </td>
                        <td class="style9">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
                <br />
                <br />
                <br />
                <asp:Label ID="Label2" runat="server"></asp:Label>
                <br />
                <br />
  
    
                <br />
                    <br />
                        <asp:Label ID="Label1" runat="server"></asp:Label>
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




