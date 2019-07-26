<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="scripts/jquery-3.4.1.js"></script>
    <script>
        $(function () {
            $('#btnClick').click(function () {

              alert($('#<%= TextBox1.ClientID %>').val());
            });
        });

        function TestCall(e) {
            e.preventDefault();
            $(function () {

                  alert($('#<%= TextBox1.ClientID %>').val());
            });
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input type="button" name="name" id="btnClick" value="Click Me" />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button"  OnClientClick="TestCall(event)"/>
    </div>
    </form>
</body>
</html>
