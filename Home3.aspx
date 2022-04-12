<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home3.aspx.cs" Inherits="Home3" %>




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
            height: 5px;
        }
        
        .style8
        {
            width: 95px;
        }
        
        .style9
        {
            width: 109px;
        }
        .style10
        {
            width: 98px;
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
                                                         &nbsp;&nbsp;<asp:LinkButton 
                                                             ID="LinkButton1" runat="server" ForeColor="White" 
                                                              PostBackUrl="Admin.aspx" CausesValidation="False" 
                                                             >Sign out</asp:LinkButton>
                            </td>
                            </tr>
                        </table>
                
                    ADMIN HOMEPAGE<br />
                
                <br />
                    <br />
                    <table border="1" style="width:67%;">
                        <tr>
                            <td class="style10">
                                Debit Note</td>
                            <td class="style8">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label1" runat="server" Width="45px"></asp:Label>
                            </td>
                            <td class="style9">
                                <asp:Label ID="Label2" runat="server"></asp:Label>
                            </td>
                        </tr>
                        </table>
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
                        <table align="center" bgcolor="#DAC16B" border="2" style="width: 42%;">
                            <tr>
                                <td align="center">
                                    <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="White" 
                                        NavigateUrl="ViewB1.aspx">View Bookings</asp:HyperLink>
                                </td>
                            </tr>

                            


                            <tr>
                                <td align="center">
                                    <asp:HyperLink ID="HyperLink7" runat="server" ForeColor="White" 
                                        NavigateUrl="Debit.aspx">Post Debit Note    </asp:HyperLink>   
                                        
                                      
                                </td>
                            </tr>

                            
                            <tr>
                                <td align="center">
                                    <asp:HyperLink ID="HyperLink8" runat="server" ForeColor="White" 
                                        NavigateUrl="VDebit.aspx">View Debit Note    </asp:HyperLink>   
                                        
                                      
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <asp:HyperLink ID="HyperLink5" runat="server" ForeColor="White" 
                                        NavigateUrl="Passwordh1.aspx">Change Password</asp:HyperLink>
                                </td>
                            </tr>
                            <tr>
                                <td class="style6" align="center">
                                    <asp:HyperLink ID="HyperLink2" runat="server" ForeColor="White" 
                                        NavigateUrl="Vacant1.aspx">View Vacant Apartment</asp:HyperLink>
                                </td>
                            </tr>




                            <tr>
                                <td class="style6" align="center">
                                    <asp:HyperLink ID="HyperLink3" runat="server" ForeColor="White" 
                                        NavigateUrl="Booked1.aspx">View Occupied Apartment</asp:HyperLink>
                                </td>
                            </tr>
                            <tr>
                                <td class="style6" align="center">
                                    <asp:HyperLink ID="HyperLink4" runat="server" ForeColor="White" 
                                        NavigateUrl="UpdateP1.aspx">Update Payment or Print Reciept</asp:HyperLink>
                                </td>
                            </tr>
 <tr>
                                <td class="style6" align="center">
                                    <asp:HyperLink ID="HyperLink40" runat="server" ForeColor="White" 
                                        NavigateUrl="Extend2.aspx">Extend Booking</asp:HyperLink>
                                </td>
                            </tr>
                </table>
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
                        <img src="Images/Down.jpg" style="width: 799px; height: 120px" /><br />
                </td>
        </tr>
    </table>
       
    
    </div>
    </form>
</body>
</html>



