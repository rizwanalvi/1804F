<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppGridView.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="OnCancelEdit" OnRowEditing="OnRowEdit" OnRowUpdating="OnUpdate" PageSize="2" CssClass="table">
             
         <Columns>
             <asp:TemplateField HeaderText="Customer ID" >
                 <EditItemTemplate>
                      <asp:Label ID="Label02" runat="server" Text='<%# Bind("CustomerId") %>'></asp:Label>
                 </EditItemTemplate>
                 <ItemTemplate>
                     <asp:Label ID="Label2" runat="server" Text='<%# Bind("CustomerId") %>'></asp:Label>
                 </ItemTemplate>
             </asp:TemplateField>
             <asp:TemplateField HeaderText="Customer Name">
                 <EditItemTemplate>
                     <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
                 </EditItemTemplate>
                 <ItemTemplate>
                     <asp:Label ID="Label1" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                 </ItemTemplate>
             </asp:TemplateField>
             <asp:TemplateField>
                 <ItemTemplate>
                     <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Edit">Edit</asp:LinkButton>
                 </ItemTemplate>
                 <EditItemTemplate>
                     <asp:LinkButton ID="LinkButton2" runat="server" CommandName="Cancel">Cancel</asp:LinkButton>
                     <asp:LinkButton ID="LinkButton3" runat="server" CommandName="Update">Update</asp:LinkButton>

                 </EditItemTemplate>
             </asp:TemplateField>
         </Columns>
        </asp:GridView>
    </div>
       
       
            
           
           
      
    </form>
   
</body>
</html>
