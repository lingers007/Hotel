<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ApplyD.aspx.cs" Inherits="ApplyD" %>




<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>COMPLETE RESERVATION</title>
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

           .style2
           {
            width: 183px;
        }
           
           .style1
           {
               width: 251px;
           }
           .style6
        {
            width: 323px;
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
    <script type="text/javascript">

    function openPopup() {

            window.open("Reciept.aspx", "_blank", "WIDTH=350,HEIGHT=400,scrollbars=no, menubar=no,resizable=no,directories=no,location=no");  
              
                }
//<![CDATA[    
//
</script>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center" border="1px" bordercolor="blue" style="width: 811px">
        <tr>
            <td align="left" class="style4" 
                
                
                
                
                style="font-size: large; color: #006699; font-family: Cambria; font-weight: bold;">
             
                
                <table style="width: 100%; height: 7px; color: #000080; background-color: #000099;">
                    <tr>
                        <td style="background-color: #DAC16B" class="style5" align="right">
                                                         <asp:LinkButton ID="LinkButton2" runat="server" ForeColor="White" 
                                                              PostBackUrl="Home1.aspx" CausesValidation="False" 
                                                             onclick="LinkButton2_Click">Home</asp:LinkButton> &nbsp;| &nbsp;<asp:LinkButton 
                                                             ID="LinkButton1" runat="server" ForeColor="White" 
                                                              PostBackUrl="Admin.aspx" CausesValidation="False" 
                                                             onclick="LinkButton1_Click">Sign out</asp:LinkButton>
                            &nbsp;</td>
                            </tr>
                        </table>
                
                        <br />
                <br />
                <br />
        <table align="center" 
            
            
            style="border-style: dotted; border-color: #CC9900; width: 76%; font-family: 'AR JULIAN'; color: #000000; font-weight: normal;" 
            border="1">
            <tr>
                <td class="style3" align="center" colspan="2">
                     complete reservation with discount code</td>
            </tr>
            <tr>
                <td class="style2" style="font-family: 'AR JULIAN'">
                    surname</td>
                <td class="style6">
                    <asp:Label ID="Label9" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Firstname</td>
                <td class="style6">
                    <asp:Label ID="Label10" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    E-mail</td>
                <td class="style6">
                    <asp:Label ID="Label11" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Phone Number</td>
                <td class="style6">
                    <asp:Label ID="Label12" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Apartment type</td>
                <td class="style6">
                    <asp:Label ID="Label13" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Arrival Date</td>
                <td class="style6">
                    <asp:Label ID="Label15" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Depature Date</td>
                <td class="style6">
                    <asp:Label ID="Label16" runat="server"></asp:Label>
                                </td>
            </tr>
            <tr>
                <td class="style2">
                    Mode Of Payment</td>
                <td class="style6">
                    <asp:DropDownList ID="DropDownList2" runat="server" Font-Names="AR JULIAN" 
                        Height="22px"  
                        Width="188px">
                        <asp:ListItem Selected="True">Choose Payment Method</asp:ListItem>
                        <asp:ListItem>CASH</asp:ListItem>
                        <asp:ListItem>TRANSFER</asp:ListItem>
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToValidate="DropDownList2" ErrorMessage="Choose Payment Method" 
                        Font-Size="X-Small" Operator="NotEqual" 
                        ValueToCompare="Choose Payment Method"  ForeColor="#FF3300"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    ENTER Full Payment</td>
                <td class="style6">
                    <asp:Label ID="Label17" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Enter DiscouNt Code</td>
                <td class="style6">
                    <asp:TextBox ID="TextBox1" runat="server" Width="184px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="vv0" runat="server" 
                        ControlToValidate="TextBox1" ErrorMessage="Eneter Amount" 
                        Font-Size="Small"  ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Apartment Name</td>
                <td class="style6">
                    <asp:DropDownList ID="DropDownList6" runat="server" Height="24px" Width="188px">
                        
                        
                        
                        <asp:ListItem Selected="True">Choose an Apartment</asp:ListItem>
                        <asp:ListItem Value="Apartment 1">Apartment 1</asp:ListItem>
                       
                        <asp:ListItem Value="Apartment 2">Apartment 2</asp:ListItem>
                        <asp:ListItem>Apartment 3</asp:ListItem>
                        <asp:ListItem Value="Apartment 4">Apartment 4</asp:ListItem>
                        <asp:ListItem Value="Apartment 5">Apartment 5</asp:ListItem>
                        <asp:ListItem Value="Apartment 6">Apartment 6</asp:ListItem>
                        <asp:ListItem Value="Apartment 7">Apartment 7</asp:ListItem>
                        <asp:ListItem Value="Apartment 8">Apartment 8</asp:ListItem>
                        <asp:ListItem Value="Apartment 9">Apartment 9</asp:ListItem>
                        <asp:ListItem Value="Apartment 10">Apartment 10</asp:ListItem>
                        
                        
                        
                        
                        
                        
                        <asp:ListItem Value="Apartment 11">Apartment 11</asp:ListItem>
                        
                        
                        
                        
                        
                        
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator5" runat="server" 
                        ControlToValidate="DropDownList6" ErrorMessage="Choose an Apartment" 
                        Font-Size="X-Small" Operator="NotEqual" 
                        ValueToCompare="Choose an Apartment"  ForeColor="#FF3300"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="style1" align="center" colspan="2">
                    &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" OnClick="OnConfirm" OnClientClick="Confirm()"
                                            Text="Enter Discount Code and CheckIn" Width="221px" />
                </td>
            </tr>
        </table>
    
                        <br />
                        <br />
                        <br />
                        <br />
    
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
                        <img src="Images/Down.jpg" style="width: 811px; height: 120px" /><br />
                </td>
        </tr>
    </table>
       
    
    </div>
    </form>
</body>
</html>


