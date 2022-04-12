<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Debit2nd.aspx.cs" Inherits="Debit2nd" %>



<%@ Import namespace="System.Data" %>
<%@ Import namespace="System.Data.SqlClient" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>VIEW GYM CLIENTS</title>
    <style type="text/css">
        .style4
        {
            width: 709px;
        }
        .style5
        {
        	font-size:small;
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

        .style25
        {
            width: 226px;
            vertical-align: middle;
            border-style: none;
            border-color: inherit;
            border-width: 0;
            margin: 0;
            padding: 0;
        }
        .style26
        {
            display: block;
            text-decoration: none;
            position: relative;
            z-index: 2;
            margin: 0 2px;
        }
        .style14
        {
            width: 141px;
        }
        .style27
        {
            height: 30px;
            width: 226px;
        }
        .style28
        {
            height: 32px;
            width: 226px;
        }
        .style29
        {
            height: 32px;
            width: 170px;
        }
        .style30
        {
            height: 32px;
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
                                                              PostBackUrl="Home.aspx" CausesValidation="False" onclick="LinkButton2_Click" 
                                                          >Home</asp:LinkButton> &nbsp;| &nbsp;<asp:LinkButton 
                                                             ID="LinkButton1" runat="server" ForeColor="White" 
                                                              PostBackUrl="Admin.aspx" CausesValidation="False" onclick="LinkButton1_Click" 
                                                      >Sign out</asp:LinkButton>
                            &nbsp;</td>
                            </tr>
                        </table>
                
                &nbsp; CHOOSE A DATE TO SEARCH FOR<br />
                
                <br />
                    <br />
                    <br />
                    <br />
                    <br />
                
                        <br />
                <br />
                <br />
                <b style="font-size: normal;">
                <table style="width: 585px; height: 92px">
                            <tr>
                                <td align="left" class="style27">
                                    <b style="font-size: normal; ">Choose Start Date</b></td>
                        <td class="style21">
                            <telerik:RadDatePicker ID="RadDatePicker3" Runat="server" 
                                Culture="English (United States)" Skin="WebBlue">
                                <calendar skin="WebBlue" usecolumnheadersasselectors="False" 
                                    userowheadersasselectors="False">
                                </calendar>
                                <datepopupbutton hoverimageurl="" imageurl="" />
                            </telerik:RadDatePicker>
                        </td>
                        <td class="style13">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="RadDatePicker3" ErrorMessage="Enter Start Date"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="style28">
                            <b style="font-size: normal;"><b style="font-size: normal; ">Choose End&nbsp; Date</b></b></td>
                        <td class="style29">
                            <telerik:RadDatePicker ID="RadDatePicker4" Runat="server" 
                                Culture="English (United States)" Skin="WebBlue">
                                <calendar skin="WebBlue" usecolumnheadersasselectors="False" 
                                    userowheadersasselectors="False">
                                </calendar>
                                <datepopupbutton hoverimageurl="" imageurl="" />
                            </telerik:RadDatePicker>
                        </td>
                        <td class="style30">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ControlToValidate="RadDatePicker4" ErrorMessage="Enter End Date"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style25">
                            &nbsp;</td>
                        <td class="style26">
                            <asp:Button ID="Button2" runat="server" onclick="Button1_Click1" 
                                Text="Get Details" Width="154px" />
                        </td>
                        <td class="style14">
                            &nbsp;</td>
                    </tr>
                </table>
                </b>
                
                        <br />
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                <br />
                <br />
                        <br />
                        <asp:ScriptManager ID="ScriptManager2" runat="server">
                        </asp:ScriptManager>
                        <telerik:RadFormDecorator ID="RadFormDecorator1" Runat="server" 
                            DecoratedControls="All" Skin="Web20" />
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



