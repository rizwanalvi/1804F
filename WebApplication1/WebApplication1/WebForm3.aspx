<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="scripts/jquery-3.4.1.js" ></script>
    <script>
        function CallAFunction(e) {
            e.preventDefault();
            //var data = $('#<%= TextBox1.ClientID %>').val();
            //var data01 = $('#<%= DropDownList1.ClientID %>').val();
            //alert(data01);
          //  $('#<%= TextBox1.ClientID %>').val(data01);

            $.ajax({
                type: "POST",
                url: "WebForm3.aspx/IsLeapYear",
                data: '{year:"'+$('#<%= TextBox1.ClientID %>').val()+'"}',
                contentType:"application/json;charset=utf-8",
                dataType:"json",
                    success:function(response){
                        if (response.d) {
                            $('#<%= Label1.ClientID %>').text("Is a Leap Year");
                            alert('');
                        }
                        else {

                           $('#<%= Label1.ClientID %>').text("Is not a Leap Year");
                        }
                    },
             failure:function(response){
            
                 alert('error');
            }
            });

        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server">
            
            <asp:ListItem>Apple</asp:ListItem>
            <asp:ListItem>Mango</asp:ListItem>
            <asp:ListItem>Orange</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> 
        <asp:Button ID="Button1" runat="server" Text="Button" OnClientClick="CallAFunction(event)" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
