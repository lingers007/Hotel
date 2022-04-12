<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Vo.aspx.cs" Inherits="Vo" %>






<%@ Import namespace="System.Data" %>
<%@ Import namespace="System.Data.SqlClient" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>VIEW BOOKED APARTMENT</title>
    <style type="text/css">
        .style4
        {
            width: 709px;
        }
        .style5
        {
        	font-size:small;
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
                                                              PostBackUrl="Home.aspx" CausesValidation="False" 
                                                            >Home</asp:LinkButton> &nbsp;| &nbsp;<asp:LinkButton 
                                                             ID="LinkButton1" runat="server" ForeColor="White" 
                                                              PostBackUrl="Admin.aspx" CausesValidation="False" 
                                                             onclick="LinkButton1_Click">Sign out</asp:LinkButton>
                            &nbsp;</td>
                            </tr>
                        </table>
                
                VIEW OCCUPIED APARTMENT<br />
                <br />
                <br />
                <br />
               <table border="1" 
                    
                    id='tab1' 
                    
                    style="width: 601px; font-family: Candara; font-size: small; font-weight: normal;">
            <tr>
            <td class="style47" 
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;">
                   S/N</td>
                <td class="style48" 
                    
                    
                    
                    style="font-size: medium; font-weight: bold; font-family: candara; background-color: #DAC16B;">
                Apartment Name</td>
                <td class="style60" style="font-size: medium; font-weight: bold">
                 Apartment Type</td>
                <td class="style52" style="font-size: medium; font-weight: bold">
                    Status</td>
                
            </tr>
           

 <%
                
                
                   SqlCommand scz = new SqlCommand("select Room_Name,Room_Type from Booking  where   Status='Done' and  Status2='Approved'  and  Status3='Approved  ' ", dbConn);
                            scz.CommandType = CommandType.Text;
                            dbConn.Open();


                            SqlDataReader sdz = scz.ExecuteReader();
                            int ct = 1;
                            string kk;
                            while (sdz.Read())
                            {

                                


                                Response.Write("<tr style><td class='style2'>" + ct++ + "</td><td class='style2'>" + sdz["Room_Name"].ToString() + "</td><td class='style2'>" + sdz["Room_Type"].ToString() + "</td><td class='style2'>" + " Occupied "+ "</td></tr>");
                               // ct++;
                               // Session["id"] = Request.QueryString["id"].ToString();
                            }

                dbConn.Close();

                          
                 %>



                    
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
                        <img src="Images/Down.jpg" style="width: 805px; height: 120px" /><br />
                </td>
        </tr>
    </table>
       
    
    </div>
    </form>
</body>
</html>



