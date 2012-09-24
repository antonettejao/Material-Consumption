<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Supply Information2.aspx.cs" Inherits="Material_Consumption.Forms.Supply_Information2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <body bgcolor="#000000">
<div align="center">
  <table width="1350" height="800" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td width="353" height="299" background="" body><table width="1350" height="800" border="0" cellpadding="0" cellspacing="0">
      <br />
      <tr>
        <td colspan="3" background="../Images/tabbed_01.gif" body class="style1" >
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" 
            Font-Names="Garamond" Font-Size="Large" 
            PostBackUrl="~/Forms/Main Page.aspx">[LOG OUT]</asp:LinkButton>
        &nbsp;&nbsp; </td>
      </tr>
      <tr>
        <td height="238" colspan="3" background="../Images/tabbed_02.gif" body>
            <br />
            <br />
            <br />
            <br />
            <br />
            .<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            &nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton1" runat="server" 
                ImageUrl="~/Images/homebtn.gif" Height="50px" Width="262px" 
                PostBackUrl="~/Forms/Homepage1.aspx" />
            <asp:ImageButton ID="ImageButton2" runat="server" 
                ImageUrl="~/Images/supplybtn.gif" Height="50px" Width="262px" 
                PostBackUrl="~/Forms/Supply.aspx" />
            <asp:ImageButton ID="ImageButton3" runat="server" 
                ImageUrl="~/Images/orderbtn.gif" Height="50px" Width="262px" 
                PostBackUrl="~/Forms/Order.aspx" />
            <asp:ImageButton ID="ImageButton4" runat="server" 
                ImageUrl="~/Images/inventorybtn.gif" Height="50px" Width="262px" 
                PostBackUrl="~/Forms/Inventory.aspx" />
          </td>
      </tr>
      <tr>
        <td width="353" height="532" background="../Images/tabbed_03.gif" body 
              align="center">
            &nbsp;<br />
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton11" runat="server" 
                ImageUrl="~/Images/botones (1).gif" />
&nbsp; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;
            <asp:ImageButton ID="ImageButton12" runat="server" 
                ImageUrl="~/Images/BOTOWNES (2).gif" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton13" runat="server" 
                ImageUrl="~/Images/BOTOWNES (3).gif" />
            &nbsp; 
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <br />
            &nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        <td width="997" height="532" background="../Images/tabbed_04.gif" body>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" 
                Font-Names="LuzSans-Book" Font-Size="X-Large" Text="Supply Name:"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="Name" runat="server" Height="28px" Width="350px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <br />
            <asp:ImageButton ID="ImageButton14" runat="server" 
                ImageUrl="~/Images/addbtn.gif" onclick="ImageButton14_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton15" runat="server" 
                ImageUrl="~/Images/deletebtn.gif" onclick="ImageButton15_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton16" runat="server" 
                ImageUrl="~/Images/updatebtn.gif" onclick="ImageButton16_Click" />
&nbsp;&nbsp;&nbsp; 
            <asp:ImageButton ID="ImageButton17" runat="server" 
                ImageUrl="~/Images/view.gif" onclick="ImageButton17_Click" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Supply ID"></asp:Label>
            <asp:TextBox ID="sid" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Search" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" BackColor="White" 
                BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                Font-Names="LuzSans-Book">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
            <br />
          </td>
      </tr>
      </table></td>  
  </table>
    </div>
    </form>
</body>
</html>
