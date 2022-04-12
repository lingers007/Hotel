<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Extended2.aspx.cs" Inherits="Extended2" %>




<%@ Import namespace="System.Data" %>
<%@ Import namespace="System.Data.SqlClient" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>EXTEND BOOKED APARTMENT</title>
   <style type="text/css">
        .style4
        {
            width: 709px;
        }
        .style5
        {
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

           .style3
           {
               width: 251px;
               height: 24px;
           }

           .style1
           {
               width: 251px;
           }
           .style6
        {
            width: 323px;
        }

        .style7
        {
           width: 242px;
       }

        </style>
         <script type = "text/javascript">
             function Confirm() {
                 var confirm_value = document.createElement("INPUT");
                 confirm_value.type = "hidden";
                 confirm_value.name = "confirm_value";
                 if (confirm("Are You Sure You Want To Complete the Reservation?")) {
                     confirm_value.value = "Yes";
                 } else {
                     confirm_value.value = "No";
                 }
                 document.forms[0].appendChild(confirm_value);
             }
    </script>
 
    
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
                                                              PostBackUrl="Home3.aspx" CausesValidation="False" 
                                                             onclick="LinkButton2_Click">Home</asp:LinkButton> &nbsp;| &nbsp;<asp:LinkButton 
                                                             ID="LinkButton1" runat="server" ForeColor="White" 
                                                              PostBackUrl="Admin.aspx" CausesValidation="False" 
                                                             onclick="LinkButton1_Click">Sign out</asp:LinkButton>
                            </td>
                            </tr>
                        </table>
                
                &nbsp;COMPLETE&nbsp; EXTENSION OF BOOKED APARTMENT<br />
                <br />
                
                <br />
                    <br />
                <br />
                <br />
                <br />
                <br />
        <table align="center" 
            
            
            style="border-style: dotted; border-color: #CC9900; width: 72%; font-family: 'AR JULIAN'; color: #646464; font-weight: normal;" 
            border="1">
            <tr>
                <td class="style3" align="center" colspan="2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;EXTEND RESERVATION</td>
            </tr>
            <tr>
                <td class="style7" style="font-family: 'AR JULIAN'">
                    surname</td>
                <td class="style6">
                    <asp:Label ID="Label9" runat="server"></asp:Label>
                    
                  
                </td>
            </tr>
            <tr>
                <td class="style7">
                    Firstname</td>
                <td class="style6">
                    <asp:Label ID="Label10" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    E-mail&nbsp;&nbsp;&nbsp;
                                </td>
                <td class="style6">
                    <asp:Label ID="Label11" runat="server"></asp:Label>
                    
                  
                </td>
            </tr>
            <tr>
                <td class="style7">
                    Phone Number</td>
                <td class="style6">
                    <asp:Label ID="Label12" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    Apartment type</td>
                <td class="style6">
                    <asp:Label ID="Label13" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    Formal Depature Date</td>
                <td class="style6">
                    <asp:Label ID="Label14" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    Depature Date
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ControlToValidate="RadDatePicker2" ErrorMessage="Pick Enddate" 
                        Font-Names="Agency FB" Font-Size="Small" Width="70px"></asp:RequiredFieldValidator>
                   
                                </td>
                <td class="style6">
                    <b style="font-size: normal;">
                    <telerik:RadDatePicker ID="RadDatePicker2" Runat="server" 
                        Culture="English (United States)" Skin="WebBlue" 
                        onselecteddatechanged="RadDatePicker2_SelectedDateChanged" Width="150px">
                        <calendar skin="WebBlue" usecolumnheadersasselectors="False" 
                            userowheadersasselectors="False" viewselectortext="x">
                        </calendar>
                        <datepopupbutton hoverimageurl="" imageurl="" />
                    </telerik:RadDatePicker>
                    </b></td>
            </tr>
            <tr>
                <td class="style1" align="center" colspan="2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   
                        
                        
                        <asp:Button ID="Button1" runat="server" OnClick="OnConfirm" OnClientClick="Confirm()"
                                            Text="Extend Booking" Width="156px" />
                </td>
            </tr>
        </table>
    
                <br />
                
                        <asp:Label ID="Label6" runat="server" Width="425px" Height="21px"></asp:Label>
                        <br />
                
                        <asp:Label ID="Label8" runat="server" Width="425px" Height="21px"></asp:Label>
                    <asp:ScriptManager ID="ScriptManager2" runat="server">
                </asp:ScriptManager>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<telerik:RadFormDecorator 
                    ID="RadFormDecorator1" Runat="server" DecoratedControls="All" Skin="Web20" />
                        <br />
                        <br />
                
                        <asp:Label ID="Label7" runat="server" Width="663px" Height="21px"></asp:Label>
                
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                        <asp:Label ID="Label1" runat="server" BackColor="White"></asp:Label>
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
                        <img src="Images/Down.jpg" style="width: 819px; height: 120px" /><br />
                </td>
        </tr>
    </table>
       
    
    </div>
    </form>
</body>
</html>



