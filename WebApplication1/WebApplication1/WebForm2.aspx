<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="scripts/jquery-3.4.1.js"></script>
    <script>
        $(function () {
                        alert('On Load');
        });


        function CallButton01(e) {
            e.preventDefault();
            $(function () {

                alert('');
            });
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClientClick="CallButton01(event)" />
    </div>
    </form>
</body>
</html>
