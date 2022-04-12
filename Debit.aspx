<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Debit.aspx.cs" Inherits="Debit" %>






<%@ Import namespace="System.Data" %>
<%@ Import namespace="System.Data.SqlClient" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>HOME</title>
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
            width: 281px;
        }
        #TextArea1
        {
            height: 27px;
            width: 321px;
        }
        


        .style9
        {
            width: 346px;
        }
        .style10
        {
            width: 136px;
        }
        


        .style11
        {
            width: 281px;
            height: 23px;
        }
        .style12
        {
            width: 346px;
            height: 23px;
        }
        .style13
        {
            width: 136px;
            height: 23px;
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
                                                             >Home</asp:LinkButton> &nbsp;| &nbsp;<asp:LinkButton 
                                                             ID="LinkButton1" runat="server" ForeColor="White" 
                                                              PostBackUrl="Admin.aspx" CausesValidation="False" onclick="LinkButton1_Click" 
                                                             >Sign out</asp:LinkButton>
                            </td>
                            </tr>
                        </table>
                
                    ADD&nbsp; DEBIT NOTE<br />
                
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
                        <table align="center" style="width: 100%; height: 161px;" border="1">
                            <tr>
                                <td align="left" class="style6">
                                    Client Name</td>
                                <td class="style9">
                                    <asp:TextBox ID="TextBox1" runat="server" Width="348px"></asp:TextBox>
                                </td>
                                <td class="style10">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                        ErrorMessage="Enter &nbsp; &nbsp; &nbsp; &nbsp; Name" 
                                        ControlToValidate="TextBox1" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="left" class="style6">
                                    Room Number</td>
                                <td class="style9">
                                   <asp:DropDownList ID="DropDownList4" runat="server" Height="24px" Width="350px">
                     

                      <asp:ListItem Selected="True">Choose a Room</asp:ListItem>
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
  
  


                        
                        
                        
                        
                        
                        
                    </asp:DropDownList></td>
                                <td class="style10">
                                     <asp:CompareValidator ID="CompareValidator3" runat="server" 
                        ControlToValidate="DropDownList4" ErrorMessage="Choose a Room" 
                        Font-Size="X-Small" Operator="NotEqual" 
                        ValueToCompare="Choose a Room"  ForeColor="#FF3300"></asp:CompareValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="left" class="style6">
                                    Debit Note Description</td>
                                <td class="style9">
                                    <asp:TextBox ID="TextBox3" runat="server" Width="348px"></asp:TextBox>
                                </td>
                                <td class="style10">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                        ErrorMessage="Enter &nbsp; &nbsp;Descrip." 
                                        ControlToValidate="TextBox3" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="left" class="style11">
                                    Amount Owed</td>
                                <td class="style12">
                                    <asp:TextBox ID="TextBox4" runat="server" Width="347px"></asp:TextBox>
                                </td>
                                <td class="style13">
                                    &nbsp;<asp:RequiredFieldValidator 
                                        ID="RequiredFieldValidator4" runat="server" 
                                        ErrorMessage="Enter Amount" 
                                        ControlToValidate="TextBox4" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
                                    &nbsp;&nbsp;&nbsp;</td>
                            </tr>
                            <tr>
                                <td align="left" class="style6">
                                    &nbsp;</td>
                                <td class="style9">
                                    <asp:Button ID="Button1" runat="server"  OnClick="OnConfirm" Text="Submit Record" 
                                        Width="147px" onclientclick="Confirm()" />
                                </td>
                                <td class="style10">
                                    &nbsp;</td>
                            </tr>
                            </table>
                        <br />
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
                        <img src="Images/Down.jpg" style="width: 799px; height: 120px" /><br />
                </td>
        </tr>
    </table>
       
    
    </div>
    </form>
</body>
</html>



