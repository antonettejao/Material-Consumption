
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Log In.aspx.cs" Inherits="Dentista__Inc.LogIn.Log_In" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script type="text/javascript" src="../Jquery/prototype.js"></script>
<script type="text/javascript" src="../Jquery/scriptaculous.js?load=effects,builder"></script>
<script type="text/javascript" src="../Jquery/lightbox.js"></script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    

    <style type="text/css">
        .style1 {
            height: 69px;
        }
        .style2
        {
            width: 162px;
        }
        .style5
        {
            height: 44px;
        }
        .style7
        {
            height: 47px;
        }
        .style8
        {
            height: 11px;
        }
        .style9
        {}
        .style10
        {
            width: 500px;
        }
        .style11
        {
            width: 136px;
        }
         .style4
        {
            font-size: medium;
            color: #FFFFFF;
        }
        .style3
        {
            font-family: "Tw Cen MT";
        }
         </style>
</head>
<link rel="stylesheet" href="../Jquery/lightbox.css" type="text/css" media="screen" />
<body bgcolor="black">
    <form id="form1" runat="server">
    <div align="center">
<table width="500" border="0" cellspacing="0" cellpadding="0" bgcolor="Black" 
            class="style10">
<br />
    <tr>
      <td height="150" colspan="3" background="../Images/log-in-form_01.gif" body ></td>
  </tr>
  <tr>
    <td colspan="3" background="../Images/log-in-form_02.gif" body class="style1">
    <center>
      <table width="500" height="50" border="0" cellpadding="0" cellspacing="0">
        <caption>&nbsp;
        </caption>
        <caption>
menunav
        </caption>
        <tr>
        </tr>
      </table></center></td>
  </tr>
  <tr>
    <td colspan="3" background="../Images/log-in-form_05.gif" body class="style7">
        &nbsp;
        <br />
      </td>
  </tr>
  <tr>
    <td rowspan="3" background="../Images/log-in-form_06.gif" body 
          class="style2"></td> 
    <td width="202" body background="../Images/log-in-form_07.gif" class="style5"><form id="form2" name="form1" method="post" action="">
        <asp:TextBox ID="eid" runat="server" style="margin-top: 0px" Width="193px" 
            Height="25px" ValidationGroup="8"></asp:TextBox>
      &nbsp;</form></td>
    <td width="138" rowspan="3" body background="../Images/log-in-form_08.gif" 
            class="style11">&nbsp;</td>
  </tr>
  <tr>
    <td width="202" height="2" body background="../Images/log-in-form_09.gif">
        <asp:TextBox ID="pwd" runat="server" style="margin-top: 0px" Width="193px" 
            TextMode="Password" Height="25px" ValidationGroup="10"></asp:TextBox>
      </td>
    </tr>
  <tr>
    <td width="202" body background="../Images/log-in-form_10.gif" class="style8">
      </td>
    </tr>
  <tr>
    <td height="25" colspan="3" body background="../Images/log-in-form_13.gif" 
          align="right" class="style9">&nbsp;&nbsp;<strong><span class="style4"><span 
            class="style3"><asp:Label ID="Label5" runat="server" style="color: #FF0000" 
            Text="Invalid Username or Password!" Visible="False"></asp:Label>
        </span></span></strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
    </tr>
  <tr>
    <td colspan="3" body background="../Images/BBBBBBBBBBBBB.gif" body style="height: 27px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:ImageButton 
            ID="ImageButton1" runat="server" Height="31px" 
            ImageUrl="~/Images/loginbtn.gif" Width="92px" onclick="ImageButton1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:ImageButton ID="ImageButton2" runat="server" Height="31px" 
            ImageUrl="~/Images/cancelbtn.gif" Width="92px" 
            PostBackUrl="~/Forms/Main Page.aspx" />
        &nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
  </tr>
  <tr>
    <td height="51" colspan="3" background="../Images/log-in-form_24.gif" body>&nbsp;</td>
  </tr>
</table>
</div>
    </form>
</body>
</html>
