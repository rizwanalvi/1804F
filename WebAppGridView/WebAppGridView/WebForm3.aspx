<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebAppGridView.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                <table class="table">
        <tr>
            <th>Customer id</th>
            
            <th>Customer Name</th>
        </tr>
            </HeaderTemplate>
            <ItemTemplate>
                 <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("CustomerId") %>'></asp:Label>

            </td>
            
            <td>              
                <div class="form-group">
                  <asp:Label ID="Label2" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" Text='<%# Eval("Name") %>' Visible="false"></asp:TextBox>
                    </div>

            </td>
                     <td>
                         <asp:Button ID="Button1" Visible="false" runat="server" Text="Cancel" OnClick="Button1_Click" CssClass="btn btn-sm btn-danger" />
                         <asp:Button ID="Button2" runat="server" Text="Edit" OnClick="LinkButton1_Click" CssClass="btn btn-sm btn-primary" />

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
