<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<%@ Import namespace="System.Data" %>
<%@ Import namespace="System.Data.SqlClient" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Home</title>
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
                                                             onclick="LinkButton1_Click">Sign out</asp:LinkButton>
                            </td>
                            </tr>
                        </table>
                
                    ADMIN HOMEPAGE<br />
                
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
                        <table align="center" bgcolor="#DAC16B" border="2" style="width: 37%;">
                            <tr>
                                <td align="center">
                                    <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="White" 
                                        NavigateUrl="AdminH.aspx">Add & Delete Users</asp:HyperLink>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <asp:HyperLink ID="HyperLink10" runat="server" ForeColor="White" 
                                        NavigateUrl="Password.aspx">Change Password</asp:HyperLink>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <asp:HyperLink ID="HyperLink6" runat="server" ForeColor="White" 
                                        NavigateUrl="Discount.aspx">Create Discount Code</asp:HyperLink>
                                </td>
                            </tr>
 <tr>
                                <td align="center">
                                    <asp:HyperLink ID="HyperLink23" runat="server" ForeColor="White" 
                                        NavigateUrl="Gym.aspx">Register Apartment Gym Clients</asp:HyperLink>
                                </td>
                            </tr>
							
						 <tr>
                                <td align="center">
                                    <asp:HyperLink ID="HyperLink22" runat="server" ForeColor="White" 
                                        NavigateUrl="ViewGym.aspx">View Apartment Gym Records</asp:HyperLink>
                                </td>
                            </tr>	
							


 <tr>
                                <td align="center">
                                    <asp:HyperLink ID="HyperLink290" runat="server" ForeColor="White" 
                                        NavigateUrl="Gym2nd.aspx">Register  Hotel Gym Clients</asp:HyperLink>
                                </td>
                            </tr>
							
							
				 <tr>
                                <td align="center">
                                    <asp:HyperLink ID="HyperLink220" runat="server" ForeColor="White" 
                                        NavigateUrl="ViewGym2.aspx">View Hotel Gym Records</asp:HyperLink>
                                </td>
                            </tr>			
							
							
						
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
							
					 <tr>
                                <td align="center">
                                    <asp:HyperLink ID="HyperLink2901" runat="server" ForeColor="White" 
                                        NavigateUrl="Gas2nd.aspx">View Gas Record</asp:HyperLink>
                                </td>
                            </tr>
							
							
				 <tr>
                                <td align="center">
                                    <asp:HyperLink ID="HyperLink2201" runat="server" ForeColor="White" 
                                        NavigateUrl="Debit2nd.aspx">View Debit Notes</asp:HyperLink>
                                </td>
                            </tr>			
							
							
								
							
							
							
							
							
							
							
							
							

                            <tr>
                                <td align="center">
                                    <asp:HyperLink ID="HyperLink7" runat="server" ForeColor="White" 
                                        NavigateUrl="DeleteD.aspx">Delete Discount Code</asp:HyperLink>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <asp:HyperLink ID="HyperLink4" runat="server" ForeColor="White" 
                                        NavigateUrl="Report.aspx">View Report</asp:HyperLink>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <asp:HyperLink ID="HyperLink9" runat="server" ForeColor="White" 
                                        NavigateUrl="CBooking.aspx">View Current Apartment Booking</asp:HyperLink>
                                </td>
                            </tr>

 <tr>
                                <td align="center"> 
                                    <asp:HyperLink ID="HyperLink90" runat="server" ForeColor="White" 
                                        NavigateUrl="HBooking.aspx">View Current Hotel Booking</asp:HyperLink>
                                </td>
                            </tr>

                            <tr>
                                <td align="center">
                                    <asp:HyperLink ID="HyperLink5" runat="server" ForeColor="White" 
                                        NavigateUrl="Ro.aspx">Create Roaster</asp:HyperLink>
                                </td>
                            </tr>
                            <tr>
                                <td class="style6" align="center">
                                    <asp:HyperLink ID="HyperLink2" runat="server" ForeColor="White" 
                                        NavigateUrl="Va.aspx">View Vacant Apartment</asp:HyperLink>
                                </td>
                            </tr>
                            <tr>
                                <td class="style6" align="center">
                                    <asp:HyperLink ID="HyperLink3" runat="server" ForeColor="White" 
                                        NavigateUrl="Vo.aspx">View Occupied Apartment</asp:HyperLink>
                                </td>
                            </tr>



 <tr>
                                <td class="style6" align="center">
                                    <asp:HyperLink ID="HyperLink25" runat="server" ForeColor="White" 
                                        NavigateUrl="Vacant2.aspx">View Vacant Hotel Room</asp:HyperLink>
                                </td>
                            </tr>
                            <tr>
                                <td class="style6" align="center">
                                    <asp:HyperLink ID="HyperLink35" runat="server" ForeColor="White" 
                                        NavigateUrl="Booked2.aspx">View Occupied Hotel Room</asp:HyperLink>
                                </td>
                            </tr>











<tr>
                                <td class="style6" align="center">
                                    <asp:HyperLink ID="HyperLink30" runat="server" ForeColor="White" 
                                        NavigateUrl="DeleteBooking.aspx">Delete Bookings</asp:HyperLink>
                                </td>
                            </tr>

<tr>
                                <td class="style6" align="center">
                                    <asp:HyperLink ID="HyperLink306" runat="server" ForeColor="White" 
                                        NavigateUrl="ExtendH.aspx">Extend Bookings</asp:HyperLink>
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



