<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateP.aspx.cs" Inherits="UpdateP" %>

<%@ Import namespace="System.Data" %>
<%@ Import namespace="System.Data.SqlClient" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title> UPDATE PAYMENT & PRINT RECIEPT</title>
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
            height: 7px;
        }
        

        
        .style10
        {
            font-weight: bold;
            height: 7px;
            width: 98px;
        }
        .style12
        {
            font-weight: bold;
            height: 7px;
            width: 123px;
        }
        .style13
        {
            font-weight: bold;
            height: 7px;
            width: 25px;
        }
        .style14
        {
            font-weight: bold;
            height: 7px;
            width: 114px;
        }
        .style15
        {
            font-weight: bold;
            height: 7px;
            width: 89px;
        }
        .style16
        {
            font-weight: bold;
            height: 7px;
            width: 117px;
        }
        .style17
        {
            font-weight: bold;
            height: 7px;
            width: 92px;
        }
        

        
        .style18
        {
            font-weight: bold;
            height: 7px;
            width: 101px;
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
                                                              PostBackUrl="Home1.aspx" CausesValidation="False" onclick="LinkButton2_Click"  
                                                          >Home</asp:LinkButton> &nbsp;| &nbsp;<asp:LinkButton 
                                                             ID="LinkButton1" runat="server" ForeColor="White" 
                                                              PostBackUrl="Admin.aspx" CausesValidation="False" onclick="LinkButton1_Click" 
                                                      >Sign out</asp:LinkButton>
                            &nbsp;</td>
                            </tr>
                        </table>
                
                <br />
                <br />
                UPDATE PAYMENT OR PRINT RECIEPT<br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <table border="1" 
                    
                    
                    style="width: 978px; font-family: 'Agency FB'; font-size: medium; font-weight: normal;">
                    <tr>
                        <td class="style13">
                            S/N</td>
                        <td class="style14">
                            Surname</td>
                        <td class="style12">
                            Firstname</td>
                            <td class="style15">
                            Room Name</td>
                            <td class="style16">
                           Room Type</td>
                             <td class="style17">
                           Amount</td>
                            <td class="style10">
                         Part&nbsp; Payment</td>
                         <td class="style18">
                         Balance Payment</td>
                            <td class="style8">
                       </td>
                           
                           
                            </tr>
            <%
                
                SqlCommand scz = new SqlCommand("SELECT  id ,Surname,Firstname,Room_Name,Room_Type,Amount,pp,bp  from Booking where Status='Done'and Status2='Approved' and Status3='Approved'     and Type='Apartment' ", dbConn);
                            scz.CommandType = CommandType.Text;
                            dbConn.Open();
                               

                            SqlDataReader sdz = scz.ExecuteReader();
                            int ct = 1;
                            while (sdz.Read())
                            {
                                 if (Int32.Parse(sdz["Amount"].ToString()) != 0)
                                {
                                    Response.Write("<tr style><td class='style2'>" + ct + "</td><td class='style5'>" + sdz["Surname"].ToString() + "</td><td class='style5'>" + sdz["Firstname"].ToString() + "</td><td class='style5'>" + sdz["Room_Name"].ToString() + "</td><td class='style5'>" + sdz["Room_Type"].ToString() + "</td><td class='style5'>" + sdz["Amount"].ToString() + "</td><td class='style5'>" + sdz["pp"].ToString() + "</td><td class='style5'>" + sdz["bp"].ToString() + "</td><td class='style5'> &nbsp;&nbsp;&nbsp;  <a href='Decide.aspx?id=" + sdz["id"].ToString() + " '>Print Reciept</a> </td> </tr>");
                                    

                                }



                                else
                                {

                                     Response.Write("<tr style><td class='style2'>" + ct + "</td><td class='style5'>" + sdz["Surname"].ToString() + "</td><td class='style5'>" + sdz["Firstname"].ToString() + "</td><td class='style5'>" + sdz["Room_Name"].ToString() + "</td><td class='style5'>" + sdz["Room_Type"].ToString() + "</td><td class='style5'>" + sdz["Amount"].ToString() + "</td><td class='style5'>" + sdz["pp"].ToString() + "</td><td class='style5'>" + sdz["bp"].ToString() + "</td><td class='style5'><a href='UpdatePP.aspx?id=" + sdz["id"].ToString() + " '>Update Payment</a> &nbsp;&nbsp;&nbsp;  <a href='Decide.aspx?id=" + sdz["id"].ToString() + " '>Print Reciept</a> </td> </tr>");
                                      
                                    
                                }


                              //  Response.Write("<tr style><td class='style2'>" + ct + "</td><td class='style5'>" + sdz["Surname"].ToString() + "</td><td class='style5'>" + sdz["Firstname"].ToString() + "</td><td class='style5'>" + sdz["Room_Name"].ToString() + "</td><td class='style5'>" + sdz["Room_Type"].ToString() + "</td><td class='style5'>" + sdz["Amount"].ToString() + "</td><td class='style5'>" + sdz["pp"].ToString() + "</td><td class='style5'>" + sdz["bp"].ToString() + "</td><td class='style5'><a href='UpdatePP.aspx?id=" + sdz["id"].ToString() + " '>Update Payment</a> &nbsp;&nbsp;&nbsp;  <a href='Decide.aspx?id=" + sdz["id"].ToString() + " '>Print Reciept</a> </td> </tr>");
                                    
                                    
                        
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
                        <img src="Images/Down.jpg" style="width: 979px; height: 120px" /><br />
                </td>
        </tr>
    </table>
       
    
    </div>
    </form> 
</body>
</html>



