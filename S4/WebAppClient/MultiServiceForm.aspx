<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MultiServiceForm.aspx.cs" Inherits="WebAppClient.MultiServiceForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnCallSvc" runat="server" OnClick="btnCallSvc_Click" Text="Call Service" />
        <asp:Label ID="lblRes" runat="server" Text="Result here"></asp:Label>
    
    </div>
    </form>
</body>
</html>
