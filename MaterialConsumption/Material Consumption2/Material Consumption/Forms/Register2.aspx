<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register2.aspx.cs" Inherits="Material_Consumption.Register2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style1
        {
            height: 90px;
        }
        .style2
        {
            height: 44px;
        }
        .style7
        {
            font-size: large;
        }
        .style3
        {
            height: 55px;
        }
        .style4
        {
            height: 7px;
        }
        .style6
        {
            font-family: Arial;
            font-size: large;
        }
        .style5
        {
            height: 57px;
        }
        </style>
</head>
<body>
    <form id="form2" runat="server">
    <div>
    <body>
<div>
<table width="797" height="1176"  align="center" border="0" cellpadding="0" cellspacing="0"> 
<br />
  <tr>
    <td height="21" colspan="4" background="Images/register_01.gif" body >&nbsp;</td>
    </tr>
  <tr>
    <td height="202" colspan="4" background="Images/register_02.gif" body></td>
    </tr>
  <tr>
    <td colspan="4" background="Images/register_04.gif" body class="style1">
        &nbsp;</td>
    </tr>
  <tr>
    <td height="81" colspan="4" background="Images/register_05.gif" body>&nbsp;</td>
    </tr>
  <tr>
    <td width="231" rowspan="3" background="Images/register_07.gif" body>&nbsp;</td>
    <td colspan="3" body background="Images/register_08.gif" class="style2" >
        <asp:TextBox ID="eid" runat="server" Height="27px" Width="307px" 
            ValidationGroup="8" CssClass="style7"></asp:TextBox>
      </td>
    </tr>
  <tr>
    <td colspan="3" body background="Images/register_10.gif" class="style3">
        <asp:TextBox ID="pwd" runat="server" Height="27px" Width="307px" 
            ValidationGroup="10" CssClass="style7" TextMode="Password"></asp:TextBox>
      </td>
    </tr>
  <tr>
    <td  colspan="3" body background="Images/register_12.gif" class="style4"></td>
  </tr>
  <tr>
    <td height="78" colspan="4" body background="Images/register_13.gif">&nbsp;</td>
    </tr>
  <tr>
    <td width="231" rowspan="8"" background="Images/register_14.gif"12 body">&nbsp;</td>
    <td height="40" colspan="3" body background="Images/register_15.gif">
        <asp:TextBox ID="fn" runat="server" Height="27px" Width="307px" 
            CssClass="style6"></asp:TextBox>
      </td>

  <tr>
    <td colspan="3" bpody background="Images/register_18.gif" class="style5">
        <asp:TextBox ID="mn" runat="server" Height="27px" Width="307px" 
            CssClass="style6"></asp:TextBox>
      </td>
    </tr>
  <tr>
    <td height="67" colspan="3" body background="Images/register_19.gif">
        <asp:TextBox ID="ln" runat="server" Height="27px" Width="307px" 
            CssClass="style6"></asp:TextBox>
      </td>
    </tr>
  <tr>
    <td height="59" colspan="3" body background="Images/register_20.gif">
        <asp:TextBox ID="address" runat="server" CssClass="style6" Height="27px" 
            TextMode="MultiLine" Width="309px"></asp:TextBox>
      </td>
    </tr>
  <tr>
    <td height="22" colspan="3" body background="Images/register_21.gif">&nbsp;</td>
    </tr>
  <tr>
    <td height="40" colspan="3" body background="Images/register_22.gif">
        <asp:TextBox ID="cno" runat="server" Height="27px" Width="207px" 
            Font-Italic="True" Font-Names="Arial" Font-Size="Large" ForeColor="Black" 
            style="text-align: center">Cellphone</asp:TextBox>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="telno" runat="server" Font-Italic="True" Font-Names="Arial" 
            Font-Overline="False" Font-Size="Large" Font-Strikeout="False" 
            ForeColor="Black" Height="27px" style="text-align: center" Width="207px">Telephone</asp:TextBox>
      </td>
    </tr>
 
  <tr>
    <td height="61" colspan="3" body background="Images/register_23.gif"  >
        <asp:TextBox ID="eadd" runat="server" Height="27px" Width="307px" 
            CssClass="style6"></asp:TextBox>
      </td>
    </tr>
  <tr>
    <td height="61" colspan="3" background="Images/register_25.gif" body>
        <asp:DropDownList ID="pstn" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Dental Assistant</asp:ListItem>
            <asp:ListItem>Supply Coordinator</asp:ListItem>
            <asp:ListItem>Supply Officer</asp:ListItem>
        </asp:DropDownList>
      </td>
    </tr>
  <tr>
    <td width="231"" background="Images/register_28.gif"12 body">&nbsp;</td>
    <td width="259" body background="Images/register_30.gif">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton1" runat="server" 
            ImageUrl="~/Images/button.gif" PostBackUrl="~/Forms/Log In.aspx" 
            onclick="ImageButton1_Click" />
        </td>
    <td width="23" height="41" align="left" background="Images/register_30.gif">&nbsp;</td>
    <td width="272" body background="Images/register_30.gif">
        <asp:ImageButton ID="ImageButton2" runat="server" 
            ImageUrl="~/Images/cancelbtn.gif" PostBackUrl="~/Forms/Main Page.aspx" />
      </td>
  </tr>
  <tr>
    <td height="60" colspan="4" body background="Images/register_32.gif">&nbsp;</td>
    </tr>
  <tr>
    <td colspan="4" height="82" background="Images/register_33.gif" body>&nbsp;</td>
    </tr>
</table>
</div>
    </div>
    </form>
</body>
   
    <div>
    
    </div>
    </form>
</body>
</html>
