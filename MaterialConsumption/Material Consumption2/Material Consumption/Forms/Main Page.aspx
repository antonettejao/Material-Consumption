<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main Page.aspx.cs" Inherits="Material_Consumption.Forms.Main_Page" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 353px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <body bgcolor="#000000">
<div>
  <table border="0" cellpadding="0" cellspacing="0" 
        style="height: 624px; width: 1350px">
  <tr>
    <td height="30" colspan="3" background="../Images/Mian-page_01.gif" body 
          align="right" >
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" 
            Font-Names="Garamond" Font-Size="Large" PostBackUrl="~/Forms/Log In.aspx">[LOG IN]</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton2" runat="server" Font-Bold="True" 
            Font-Names="Garamond" Font-Size="Large" 
            PostBackUrl="~/Forms/Register.aspx">[REGISTER]</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; </td>
  </tr>
  <tr>
    <td height="229" colspan="3" background="../Images/Mian-page_02.gif" body>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton1" runat="server" Height="45px" 
            ImageUrl="~/Images/homebtn.gif" PostBackUrl="~/Forms/Main Page.aspx" 
            style="margin-left: 0px" Width="262px" />
        <asp:ImageButton ID="ImageButton2" runat="server" Height="45px" 
            ImageUrl="~/Images/supplybtn.gif" Width="262px" />
        <asp:ImageButton ID="ImageButton3" runat="server" Height="44px" 
            ImageUrl="~/Images/orderbtn.gif" Width="262px" />
        <asp:ImageButton ID="ImageButton4" runat="server" Height="45px" 
            ImageUrl="~/Images/inventorybtn.gif" Width="252px" />
      </td>
  <div id ="Main_page" 
  </Main_Page>
  </tr>
  <tr>
    <td height="299" background="../Images/Mian-page_03.gif" body class="style1"><center>
        <asp:Image ID="Image1" runat="server" BorderColor="Black" BorderStyle="Double" 
            Height="264px" ImageUrl="~/Images/anigif.gif" Width="317px" />
    </center></td>
    <td width="997" height="298" rowspan="2" background="../Images/Mian-page_04.gif" body>
        &nbsp;</td>
    
  <tr>
    <td height="71" background="../Images/Mian-page_05.gif" body class="style1">&nbsp;</td>
  </tr>
  </table>
</div>
</body>
    </div>
    </form>
</body>
</html>
