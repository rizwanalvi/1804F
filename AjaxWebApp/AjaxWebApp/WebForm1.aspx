<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AjaxWebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CUSTOMERINFOConnectionString %>" DeleteCommand="DELETE FROM [CUSINFO] WHERE [ID] = @ID" InsertCommand="INSERT INTO [CUSINFO] ([CUSNAME], [IMPIC]) VALUES (@CUSNAME, @IMPIC)" SelectCommand="SELECT * FROM [CUSINFO] WHERE ([ID] = @ID)" UpdateCommand="UPDATE [CUSINFO] SET [CUSNAME] = @CUSNAME, [IMPIC] = @IMPIC WHERE [ID] = @ID">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="CUSNAME" Type="String" />
                <asp:Parameter Name="IMPIC" Type="Object" />
            </InsertParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="ID" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="CUSNAME" Type="String" />
                <asp:Parameter Name="IMPIC" Type="Object" />
                <asp:Parameter Name="ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="ID" DataValueField="ID" Height="20px" Width="135px">
        </asp:DropDownList>
        <br />
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:CUSTOMERINFOConnectionString %>" SelectCommand="SELECT * FROM [CUSINFO]"></asp:SqlDataSource>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="CUSNAME" HeaderText="CUSNAME" SortExpression="CUSNAME" />
            </Columns>
        </asp:GridView>
               
 
                           </ContentTemplate>
             
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click" />
            </Triggers>
             
        </asp:UpdatePanel>
        <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1" DisplayAfter="3000">
            <ProgressTemplate>
                <div>Wating....</div> 
            </ProgressTemplate>
        </asp:UpdateProgress>
      
        <asp:Button ID="Button1" runat="server" Text="Button"  />
    </div>
    </form>
</body>
</html>
