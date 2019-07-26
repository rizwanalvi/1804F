<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication1.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <ajaxToolkit:AutoCompleteExtender runat="server" ServicePath="" DelimiterCharacters="" BehaviorID="TextBox1_AutoCompleteExtender" TargetControlID="TextBox1" ID="TextBox1_AutoCompleteExtender" ServiceMethod="SearchData" MinimumPrefixLength="2"></ajaxToolkit:AutoCompleteExtender>
    </div>
    </form>
</body>
</html>
