<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmLogin.aspx.cs" Inherits="WebService_Prueba.FrmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link href="CSS/Estilos.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body style="background-color:#337ab7">
    <div class="container well contenedor">
        <div class="row">
            <div class="col-xs-12" >
                <h2>Iniciar Sesión</h2>
            </div>
        </div>
        <form runat="server" class="form-horizontal">
            <asp:ScriptManager ID="smLogin"  runat="server"></asp:ScriptManager>

            <div class="form-group">
                <asp:Label ID="lblCedula" runat="server"  Text="Login" CssClass="control-label col-sm-2"></asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtLogin" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox>
                </div>
            </div>
            
            <div class="form-group">
                <asp:Label ID="lblClave" runat="server" Text="Clave" CssClass="control-label col-sm-2"></asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtClave" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                </div>
            </div>
            
            <div class="form-group">
                <%--OnClick="Iniciar_Click"--%>
                <asp:Button ID="btnIniciar" runat="server" Text="Iniciar Sesión" OnClick="Iniciar_Click"  CssClass="form-control btn btn-primary" />
                <%--<asp:LinkButton ID="lnkRegistro" runat="server"  CausesValidation="false">Registrate aquí</asp:LinkButton>--%>
                <%--OnClick="lnkRegistro_Click"--%>
            </div>

        </form>

    </div>

</body>
</html>
