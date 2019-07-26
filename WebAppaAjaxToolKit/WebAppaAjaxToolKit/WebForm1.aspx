<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppaAjaxToolKit.WebForm1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        
        <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
        
        
        <ajaxtoolkit:autocompleteextender id="TextBox2_AutoCompleteExtender"
            runat="server" behaviorid="TextBox2_AutoCompleteExtender"
            delimitercharacters="" servicepath=""
            targetcontrolid="TextBox2" servicemethod="GetSearch">
        </ajaxtoolkit:autocompleteextender>
    </div>
    </form>
</body>
</html>
