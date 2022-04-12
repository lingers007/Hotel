<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Reciept.aspx.cs" Inherits="Reciept" %>





<%@ Import namespace="System.Data" %>
<%@ Import namespace="System.Data.SqlClient" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Reciept</title>
    <style type="text/css">
        .style4
        {
            width: 709px;
        }
        .style5
        {
        	font-size:small;
        }
        


        .RadPicker_WebBlue
{
	vertical-align:middle;
}

.RadPicker_WebBlue
{
	vertical-align:middle;
}

.RadPicker_WebBlue
{
	vertical-align:middle;
}

.RadPicker_WebBlue
{
	vertical-align:middle;
}

.RadPicker_WebBlue .rcInputCell
{
	padding:0 4px 0 0;
}

.RadPicker_WebBlue .rcInputCell
{
	padding:0 4px 0 0;
}

.RadPicker_WebBlue .rcInputCell
{
	padding:0 4px 0 0;
}

.RadPicker_WebBlue .rcInputCell
{
	padding:0 4px 0 0;
}

.RadInput_Default
{
	font:12px arial,sans-serif;
}

.RadInput_Default
{
	vertical-align:middle;
}

.RadInput_Default
{
	font:12px arial,sans-serif;
}

.RadInput_Default
{
	vertical-align:middle;
}

.RadInput_Default
{
	vertical-align:middle;
}

.RadInput_Default
{
	font:12px arial,sans-serif;
}

.RadInput_Default
{
	vertical-align:middle;
}

.RadInput_Default
{
	font:12px arial,sans-serif;
}

.RadPicker_WebBlue .rcCalPopup
{
	background-position:0 -200px;
}

.RadPicker_WebBlue .rcCalPopup
{
	width:16px;
	height:16px;
	overflow:hidden;
	background-image:url('mvwres://Telerik.Web.UI, Version=2008.3.1105.35, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.WebBlue.Calendar.sprite.gif');
	background-repeat:no-repeat;
	text-indent:-4444px;
}

.RadPicker_WebBlue .rcCalPopup
{
	background-position:0 -200px;
}

.RadPicker_WebBlue .rcCalPopup
{
	width:16px;
	height:16px;
	overflow:hidden;
	background-image:url('mvwres://Telerik.Web.UI, Version=2008.3.1105.35, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.WebBlue.Calendar.sprite.gif');
	background-repeat:no-repeat;
	text-indent:-4444px;
}

.RadPicker_WebBlue .rcCalPopup
{
	width:16px;
	height:16px;
	overflow:hidden;
	background-image:url('mvwres://Telerik.Web.UI, Version=2008.3.1105.35, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.WebBlue.Calendar.sprite.gif');
	background-repeat:no-repeat;
	text-indent:-4444px;
}

           .RadPicker_WebBlue .rcCalPopup
{
	background-position:0 -200px;
}

.RadPicker_WebBlue .rcCalPopup
{
	width:16px;
	height:16px;
	overflow:hidden;
	background-image:url('mvwres://Telerik.Web.UI, Version=2008.3.1105.35, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.WebBlue.Calendar.sprite.gif');
	background-repeat:no-repeat;
	text-indent:-4444px;
}

.RadPicker_WebBlue .rcCalPopup
{
	background-position:0 -200px;
}

                

        .style6
        {
            width: 173px;
        }

                

        .style7
        {
            width: 332px;
        }
        .style10
        {
            width: 160px;
        }

                

        .style11
        {
            width: 106px;
        }
        .style12
        {
            width: 176px;
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
                <asp:Button ID="btnpopup" runat="server" BackColor="#0099FF" Font-Bold="True" 
                    ForeColor="White" Height="24px" onclick="btnpopup_Click" Text="Print Now" 
                    Width="89px" />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <table style="width: 90%;" align="center" border="1">
                    <tr>
                        <td>
                <table style="width: 100%; height: 109px;">
                    <tr>
                        <td class="style11">
                
                <img src="images/logo.jpg" style="width: 120px; height: 114px" align="middle" /></td>
                        <td>
                                <table style="width:100%; color: #000000; font-family: 'Agency FB';">
                                    <tr>
                                        <td class="style7"  align="center" 
                                            style="color: #CC9900; font-size: x-large; font-weight: bold;">
                                            24|7&nbsp; LUXURY APARTMENTS&nbsp;&nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style7" align="center"  style="color: #CC9900">
                                            INVOICE</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style7">
                                            &nbsp;</td>
                                        <td align="right">
                                            Invoice No</td>
                                    </tr>
                                    <tr>
                                        <td class="style7">
                                            &nbsp;</td>
                                        <td align="right">
                                            <asp:Label ID="Label10" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                    </table>
                            </td>
                    </tr>
                    </table>
                
               
                        </td>
                    </tr>
                    </table>
                
               
                    <table align="center"  border="1"
                    
                    style="width: 90%; height: 37px; font-family: 'Agency FB'; border :1; color: #000000;">
                        <tr>
                            <td class="style6">
                                Names</td>
                            <td colspan="3">
                                <asp:Label ID="Label8" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style6">
                                Arival&nbsp; Date
                            </td>
                            <td class="style10">
                                <asp:Label ID="Label4" runat="server"></asp:Label>
                            </td>
                            <td class="style12">
                            &nbsp;Exit Date</td>
                            <td>
                                <asp:Label ID="Label3" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style6">
                                Room Type</td>
                            <td class="style10">
                                <asp:Label ID="Label11" runat="server"></asp:Label>
                            </td>
                            <td class="style12">
                                Room Name</td>
                            <td>
                                <asp:Label ID="Label12" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style6">
                                Payment Type</td>
                            <td class="style10">
                                <asp:Label ID="Label5" runat="server"></asp:Label>
                            </td>
                            <td class="style12">
                                Days Occupied</td>
                            <td>
                                <asp:Label ID="Label9" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style6">
                                Amount Paid</td>
                            <td class="style10">
                                <asp:Label ID="Label6" runat="server"></asp:Label>
                            </td>
                            <td class="style12">
                                Balance Payment</td>
                            <td>
                                <asp:Label ID="Label7" runat="server"></asp:Label>
                            </td>
                        </tr>
                </table>
                <br />
                
                        <br />
                    <asp:Label ID="Label1" runat="server"></asp:Label>
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
                        <img src="Images/Down.jpg" style="width: 800px; height: 120px" /><br />
                </td>
        </tr>
    </table>
       
    
    </div>
    </form>
</body>
</html>



