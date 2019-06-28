<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebAppTemplate.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Home
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:CUSTOMERINFOConnectionString %>" DeleteCommand="DELETE FROM [Customers] WHERE [CustomerId] = @original_CustomerId AND [Name] = @original_Name AND [Country] = @original_Country" InsertCommand="INSERT INTO [Customers] ([Name], [Country]) VALUES (@Name, @Country)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Customers]" UpdateCommand="UPDATE [Customers] SET [Name] = @Name, [Country] = @Country WHERE [CustomerId] = @original_CustomerId AND [Name] = @original_Name AND [Country] = @original_Country">
        <DeleteParameters>
            <asp:Parameter Name="original_CustomerId" Type="Int32" />
            <asp:Parameter Name="original_Name" Type="String" />
            <asp:Parameter Name="original_Country" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Country" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Country" Type="String" />
            <asp:Parameter Name="original_CustomerId" Type="Int32" />
            <asp:Parameter Name="original_Name" Type="String" />
            <asp:Parameter Name="original_Country" Type="String" />
        </UpdateParameters>
</asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
    <asp:FormView ID="FormView1" runat="server" AllowPaging="True" DataSourceID="SqlDataSource1"></asp:FormView>
</asp:Content>
