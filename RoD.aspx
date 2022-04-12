<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RoD.aspx.cs" Inherits="RoD" %>




<%@ Import namespace="System.Data" %>
<%@ Import namespace="System.Data.SqlClient" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>VIEW ROASTER</title>
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
            width: 504px;
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
                            </td>
                            </tr>
                        </table>
                
                <br />
            <asp:Label ID="Label1" Width="750px" runat="server"></asp:Label>
                <br />
                <br />
                <br />
                <asp:Button ID="btnpopup" runat="server" BackColor="#0099FF" Font-Bold="True" 
                    ForeColor="White" Height="24px" onclick="btnpopup_Click" Text="Print Now" 
                    Width="89px" />
                <br />
                <br />
               
  
    
               <table 
                    
                    id='tab1' 
                    
                    
                    style="width: 60%; font-family: Candara; font-size: small; font-weight: normal;">
            <tr>
            
                    
                    
                    
                   <td class="style6"  
                       style="font-size: medium; font-weight: bold; font-family: candara; ">
                       &nbsp;</td>
                
            </tr>
           
                    
            
           
                      <%

int m;
        m = Int32.Parse(Session["Days"].ToString());

        for (int i = 1; i <= m; i++)
        {

            Response.Write("<table width=100 border=2>");
            if (i % 2 != 0)
            {


                Response.Write("<tr ><td  width='25' >" + i + "</td><td  width='25' >" + Session["F"].ToString() + "</td> </tr>");


            }
            else
            {

                Response.Write("<tr ><td width='25'>" + i + "</td><td  width='25' >" + Session["F1"].ToString() + "</td> </tr>");

            }
            Response.Write("</table>");

        }  


        
                
               
                          
                 %>  
                </table>
                
    
             
         
                      
                </td>
        </tr>
      
        <tr>
            <td>
                &nbsp;</td>
        </tr>
      
    </table>
       
    
    </div>
    </form>
</body>
</html>




