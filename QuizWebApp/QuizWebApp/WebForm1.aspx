<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="QuizWebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="True" Font-Size="Medium"></asp:Label><br />
       
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>OptionA</asp:ListItem>
            <asp:ListItem>OPtiONB</asp:ListItem>
            <asp:ListItem>AA</asp:ListItem>
            <asp:ListItem>DD</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Previous" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Next" />
    
    </div>
    </form>
</body>
</html>
