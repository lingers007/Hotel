<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteU.aspx.cs" Inherits="DeleteU" %>



<%@ Import namespace="System.Data" %>
<%@ Import namespace="System.Data.SqlClient" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title> DELETE USER</title>
    <style type="text/css">
        .style4
        {
            width: 709px;
        }
        .style5
        {
        	font-size:small;
        }
        


        .style8
        {
            font-weight: bold;
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
                                                              PostBackUrl="Admin.aspx" CausesValidation="False" onclick="LinkButton1_Click" 
                                                      >Sign out</asp:LinkButton>
                            &nbsp;</td>
                            </tr>
                        </table>
                
                <br />
                <br />
                DELETE A USER                 <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <table border="1" 
                    style="width: 605px; font-family: Cambria; font-size: medium; font-weight: normal;">
                    <tr>
                        <td class="style8">
                            S/N</td>
                        <td class="style8">
                            Username</td>
                        <td class="style8">
                            Operations</td>
                            </tr>
            <%
                
                SqlCommand scz = new SqlCommand("SELECT  id ,Username  FROM Users ", dbConn);
                            scz.CommandType = CommandType.Text;
                            dbConn.Open();
                               

                            SqlDataReader sdz = scz.ExecuteReader();
                            int ct = 1;
                            while (sdz.Read())
                            {



                                Response.Write("<tr style><td class='style2'>" + sdz["id"].ToString() + "</td><td class='style5'>" + sdz["Username"].ToString() + "</td><td class='style5'>&nbsp;&nbsp;&nbsp;  <a href='Delete2.aspx?id=" + sdz["id"].ToString() + " '>Delete</a> </td> </tr>");
                                    
                                    
                        
                                ct++;
                            }

                dbConn.Close();

                          
                 %>

                    
                        </table>
                        <br />
                        <asp:Label ID="Label109" runat="server" ForeColor="#3366CC"></asp:Label>
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
                        <img src="Images/Down.jpg" style="width: 800px; height: 120px" /><br />
                </td>
        </tr>
    </table>
       
    
    </div>
    </form>
</body>
</html>



