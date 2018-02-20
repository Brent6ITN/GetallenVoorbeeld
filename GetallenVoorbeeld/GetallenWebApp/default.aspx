<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="GetallenWebApp._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GGD</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Zoek GGD:<br />
            <br />
            Getal1:
            <asp:TextBox ID="txtgetal1" runat="server"></asp:TextBox>
            <br />
            <br />
            Getal2:
            <asp:TextBox ID="txtgetal2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnZoek" runat="server" OnClick="btnZoek_Click" Text="Button" />
            <br />
            <br />
            <asp:Label ID="lblUitvoer" runat="server" Text="uitvoer"></asp:Label>
        </div>
    </form>
</body>
</html>
