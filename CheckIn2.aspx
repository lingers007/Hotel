<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckIn2.aspx.cs" Inherits="CheckIn2" %>




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
            width: 222px;
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
     <script type = "text/javascript">
         function Confirm1() {
             var confirm1_value = document.createElement("INPUT");
             confirm1_value.type = "hidden";
             confirm1_value.name = "confirm_value";
             if (confirm1("Are You Sure You Want To Complete the Reservation with Discount Code?")) {
                 confirm1_value.value = "Yes";
             } else {
                 confirm1_value.value = "No";
             }
             document.forms[0].appendChild(confirm1_value);
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
                                                              PostBackUrl="Home3.aspx" CausesValidation="False" 
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
            
            
            style="border-style: dotted; border-color: #CC9900; width: 80%; font-family: 'AR JULIAN'; color: #000000; font-weight: normal;" 
            border="1">
            <tr>
                <td class="style3" align="center" colspan="2">
                    &nbsp; COMPLETE&nbsp;&nbsp; RESERVATION</td>
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
                    E-mail</td>
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
                    Arrival Date</td>
                <td class="style6">
                    <asp:Label ID="Label15" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    Depature Date</td>
                <td class="style6">
                    <asp:Label ID="Label16" runat="server"></asp:Label>
                                </td>
            </tr>
            <tr>
                <td class="style7">
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
                <td class="style7">
                    PAYMENT TYPE</td>
                <td class="style6">
                    <asp:DropDownList ID="DropDownList3" runat="server" Font-Names="AR JULIAN" 
                        Height="22px"  
                        Width="188px" AutoPostBack="True" 
                        onselectedindexchanged="DropDownList3_SelectedIndexChanged">
                        <asp:ListItem Selected="True">Choose Payment Type</asp:ListItem>
                        <asp:ListItem>FULL PAYMENT</asp:ListItem>
                        <asp:ListItem>PART PAYMENT</asp:ListItem>
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator2" runat="server" 
                        ControlToValidate="DropDownList3" ErrorMessage="Choose Payment Type" 
                        Font-Size="X-Small" Operator="NotEqual" 
                        ValueToCompare="Choose Payment Method"  ForeColor="#FF3300"></asp:CompareValidator>
                </td>
            </tr>
           
            <tr>
                <td class="style7">
                    ENTER FULL Payment</td>
                <td class="style6">
                    <asp:TextBox ID="TextBox1" runat="server" Height="24px" Width="181px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="vv" runat="server" 
                        ControlToValidate="TextBox1" ErrorMessage="Eneter Amount" Font-Size="Small"  ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                </td>
            </tr>
            <tr>
                <td class="style7">                    
                    ENTER PART Payment</td>
                <td class="style6">
                    <asp:TextBox ID="TextBox2" runat="server" Height="24px" Width="181px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="TextBox2" ErrorMessage="Eneter Amount" 
                        Font-Size="Small"  ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                </td>
            </tr>
            <tr>
                <td class="style7">
                    ENTER BALANCE Payment</td>
                <td class="style6">
                    <asp:TextBox ID="TextBox3" runat="server" Height="24px" Width="181px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="TextBox3" ErrorMessage="Eneter Amount" 
                        Font-Size="Small"  ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                </td>
            </tr>
             <tr>
                <td class="style7">
                    APARTMENT NAME</td>
                <td class="style6">
                    <asp:DropDownList ID="DropDownList4" runat="server" Height="24px" Width="188px">
                     

                      <asp:ListItem Selected="True">Choose an Apartment</asp:ListItem>
<asp:ListItem>Room 208</asp:ListItem>
<asp:ListItem>Room 209</asp:ListItem>
<asp:ListItem>Room 210</asp:ListItem>
<asp:ListItem>Room 308</asp:ListItem>
<asp:ListItem>Room 309</asp:ListItem>
<asp:ListItem>Room 310</asp:ListItem>
<asp:ListItem>Room 408</asp:ListItem>
<asp:ListItem>Room 409</asp:ListItem>
<asp:ListItem>Room 505</asp:ListItem>
<asp:ListItem>Room 506</asp:ListItem>
<asp:ListItem>Room 507</asp:ListItem>
<asp:ListItem>Room 101</asp:ListItem>
<asp:ListItem>Room 103</asp:ListItem>
<asp:ListItem>Room 105</asp:ListItem>
<asp:ListItem>Room 107</asp:ListItem>
<asp:ListItem>Room 303</asp:ListItem>
<asp:ListItem>Room 403</asp:ListItem>
<asp:ListItem>Room 405</asp:ListItem>
<asp:ListItem>Room 407</asp:ListItem>
<asp:ListItem>Room 410</asp:ListItem>
<asp:ListItem>Room 102</asp:ListItem>
<asp:ListItem>Room 104</asp:ListItem>
<asp:ListItem>Room 106</asp:ListItem>
<asp:ListItem>Room 108</asp:ListItem>
<asp:ListItem>Room 201</asp:ListItem>
<asp:ListItem>Room 202</asp:ListItem>
<asp:ListItem>Room 203</asp:ListItem>
<asp:ListItem>Room 204</asp:ListItem>
<asp:ListItem>Room 205</asp:ListItem>
<asp:ListItem>Room 206</asp:ListItem>
<asp:ListItem>Room 207</asp:ListItem>
<asp:ListItem>Room 301</asp:ListItem>
<asp:ListItem>Room 302</asp:ListItem>
<asp:ListItem>Room 304</asp:ListItem>
<asp:ListItem>Room 305</asp:ListItem>
<asp:ListItem>Room 306</asp:ListItem>
<asp:ListItem>Room 307</asp:ListItem>
<asp:ListItem>Room 401</asp:ListItem>
<asp:ListItem>Room 402</asp:ListItem>
<asp:ListItem>Room 404</asp:ListItem>
<asp:ListItem>Room 406</asp:ListItem>
<asp:ListItem>Room 501</asp:ListItem>
<asp:ListItem>Room 502</asp:ListItem>
<asp:ListItem>Room 503</asp:ListItem>
<asp:ListItem>Room 504</asp:ListItem>
  
  


                        
                        
                        
                        
                        
                        
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator3" runat="server" 
                        ControlToValidate="DropDownList4" ErrorMessage="Choose an Apartment" 
                        Font-Size="X-Small" Operator="NotEqual" 
                        ValueToCompare="Choose an Apartment"  ForeColor="#FF3300"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="style1" align="center" colspan="2">
                    &nbsp;<asp:Button ID="Button1" runat="server" OnClick="OnConfirm" OnClientClick="Confirm()"
                                            Text="Check In" Width="156px" />
                </td>
            </tr>
            <tr>
                <td class="style2" align="center" colspan="2">
                    &nbsp;<asp:Button ID="Button2" runat="server" CausesValidation="False" 
                        onclick="Button2_Click1" Text="Apply Discount Code" Width="156px" />
                    
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


