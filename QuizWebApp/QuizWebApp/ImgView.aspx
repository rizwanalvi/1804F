<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImgView.aspx.cs" Inherits="QuizWebApp.ImgView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="FileUpload1" runat="server" />
      
        <asp:Button ID="Button1" runat="server" Text="Upload" OnClick="Button1_Click" />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CUSTOMERINFOConnectionString %>" SelectCommand="SELECT * FROM [CUSINFO]"></asp:SqlDataSource>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="CUSNAME" HeaderText="CUSNAME" SortExpression="CUSNAME" />
                <asp:TemplateField HeaderText="IMPIC" SortExpression="IMPIC">
                    <EditItemTemplate>
                       
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Image ImageUrl='<%# GetImage(Eval("IMPIC")) %>' runat="server" Height="160" Width="150" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>

