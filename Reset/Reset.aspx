<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title>Reset Password</title>
</head>
<body>
    Email Address:
<asp:TextBox ID="txtEmail" runat="server" Width = "250" />
<br />
<asp:Label ID="lblMessage" runat="server" />
<br />
<asp:Button Text="Send" runat="server" OnClick="SendEmail" />
</body>
</html>