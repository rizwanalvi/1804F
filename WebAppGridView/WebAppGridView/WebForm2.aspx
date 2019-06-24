<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebAppGridView.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">

    </title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="Repeater1" runat="server" >
             <HeaderTemplate>
                 <table class="table">
            <tr>
                <th>Customer Id</th>
                <th>Customer Name</th>

            </tr>
            </HeaderTemplate>
            <ItemTemplate>
                 <tr>
                <td> <asp:Label ID="Label3" runat="server" Text='<%# Eval("CustomerId") %>'></asp:Label></td>
                <td> <asp:Label ID="Label4" runat="server" Text='<%# Eval("Name") %>'></asp:Label></td>
                <td>
                    <asp:LinkButton ID="LinkButton4" runat="server" CssClass="btn btn-primary">Edit</asp:LinkButton></td>

            </tr>
               
            </ItemTemplate>
            <FooterTemplate>
                  </table>
            </FooterTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
