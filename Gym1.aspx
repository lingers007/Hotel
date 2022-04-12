<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Gym1.aspx.cs" Inherits="Gym1" %>




<%@ Import namespace="System.Data" %>
<%@ Import namespace="System.Data.SqlClient" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>REGISTER CLIENTS FOR GYM</title>
    <style type="text/css">
        .style4
        {
            width: 709px;
        }
        .style5
        {
        	font-size:small;
        }
        


        *{-webkit-box-sizing:border-box;-moz-box-sizing:border-box;box-sizing:border-box}strong{font-weight:700}
        .style6
        {
            font-size: 100%;
            vertical-align: baseline;
            border-style: none;
            border-color: inherit;
            border-width: 0;
            margin: 0;
            padding: 0;
            background: 0 0;
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
                                                              PostBackUrl="Home2.aspx" CausesValidation="False" 
                                                             onclick="LinkButton2_Click">Home</asp:LinkButton> &nbsp;| &nbsp;<asp:LinkButton 
                                                             ID="LinkButton1" runat="server" ForeColor="White" 
                                                              PostBackUrl="Admin.aspx" CausesValidation="False" 
                                                             onclick="LinkButton1_Click">Sign out</asp:LinkButton>
                            </td>
                            </tr>
                        </table>
                
                    REGISTER CLIENTS FOR GYM<br />
                
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
                &nbsp;&nbsp;&nbsp; <br />
                        <br />
    
       <table align="center" 
            
            
            style="border-style: dotted; border-color: #CC9900; width: 70%; font-family: 'AR JULIAN'; color: #646464; font-weight: normal;" 
            border="1">
            <tr>
                <td class="style3" align="center" colspan="2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;BOOK For Gym</td>
            </tr>
            <tr>
                <td class="style7" style="font-family: 'AR JULIAN'">
                    surname</td>
                <td class="style6">
                    <asp:TextBox ID="TextBox1" runat="server" Width="181px"></asp:TextBox>
                    
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ErrorMessage="Surname Required" Font-Size="Small" 
                        ControlToValidate="TextBox1" Font-Names="Agency FB" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    
                  
                </td>
            </tr>
            <tr>
                <td class="style7">
                    Firstname</td>
                <td class="style6">
                    <asp:TextBox ID="TextBox2" runat="server" Width="181px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ErrorMessage="Firstname Required" Font-Size="Small" 
                        ControlToValidate="TextBox2" Font-Names="Agency FB" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    Phone Number</td>
                <td class="style6">
                    <asp:TextBox ID="TextBox4" runat="server" Width="181px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ErrorMessage="Phone No. Required" Font-Size="Small" 
                        ControlToValidate="TextBox4" Font-Names="Agency FB" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    Status</td>
                <td class="style6">
                    <asp:DropDownList ID="DropDownList1" runat="server" Font-Names="AR JULIAN" 
                        Height="26px"  
                        Width="172px">
                        <asp:ListItem Selected="True">Choose A Status</asp:ListItem>
                        <asp:ListItem Value="2000">Day Pass(Non Guest)</asp:ListItem>
                        <asp:ListItem Value="1000">Day Pass(Guest)</asp:ListItem>
                        <asp:ListItem Value="15000">Monthly Client(Non Guest)</asp:ListItem>
                        <asp:ListItem Value="7500">Monthly Client(Guest)</asp:ListItem>
                        <asp:ListItem Value="40000">3 Months Client(Non Guest)</asp:ListItem>
                        <asp:ListItem Value="20000">3 Months Client(Guest)</asp:ListItem>
                        <asp:ListItem Value="75000">6 Months Client(Non Guest)</asp:ListItem>
                        <asp:ListItem Value="37000">6 Months Client(Guest)</asp:ListItem>
                        <asp:ListItem Value="140000">Yearly Client(Non Guest)</asp:ListItem>
                        <asp:ListItem Value="70000">Yearly Client(Guest)</asp:ListItem>
                    </asp:DropDownList>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToValidate="DropDownList1" ErrorMessage="Choose " 
                        Font-Size="Small" Operator="NotEqual" 
                        ValueToCompare="Choose A Status" Font-Names="Agency FB" ForeColor="#FF3300"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    Start Date                     <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ControlToValidate="RadDatePicker1" ErrorMessage="Pick Startdate" 
                        Font-Names="Agency FB" Font-Size="Small" Width="70px" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                   
                    </td>
                <td >
                  
                    <telerik:RadDatePicker ID="RadDatePicker1" Runat="server" 
                        Culture="English (United States)" Skin="WebBlue" 
                        onselecteddatechanged="RadDatePicker1_SelectedDateChanged" Width="150px">
                        <calendar skin="WebBlue" usecolumnheadersasselectors="False" 
                            userowheadersasselectors="False" viewselectortext="x">
                        </calendar>
                        <datepopupbutton hoverimageurl="" imageurl="" />
                    </telerik:RadDatePicker>
                   
                    </td>
            </tr>
            <tr>
                <td class="style7">
                    End&nbsp; Date
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ControlToValidate="RadDatePicker2" ErrorMessage="Pick Enddate" 
                        Font-Names="Agency FB" Font-Size="Small" Width="70px" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                   
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
                    <asp:Button ID="Button1" runat="server" Text="Register Client" 
                        Width="148px" onclick="Button1_Click" />
                </td>
            </tr>
        </table>
                     
                        <br />
                        <asp:Label ID="Label1" runat="server" Width="368px"></asp:Label>
                        <br />
                        <br />
                        <telerik:RadFormDecorator 
                    ID="RadFormDecorator1" Runat="server" DecoratedControls="All" Skin="Web20" />
                    <asp:ScriptManager ID="ScriptManager2" runat="server">
                </asp:ScriptManager>
                <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                <br />
                <br />
                <br />
                        <img src="Images/Down.jpg" style="width: 799px; height: 120px" /><br />
                </td>
        </tr>
    </table>
       
    
    </div>
    </form>
</body>
</html>



