<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmInfoClima.aspx.cs" Inherits="WebService_Prueba.FrmInfoClima" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <link href="CSS/Estilos.css" rel="stylesheet" />
    <%--<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-select@1.13.9/dist/css/bootstrap-select.min.css"/>--%>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap-select@1.13.9/dist/js/bootstrap-select.min.js"></script>

     <style>
        .tabla-alternar tbody tr th, .tabla-alternar thead tr th {
            background-color: #5D7B9D;
            color: white;
            border-right: 1px solid white;
        }

        .tabla-alternar {
            font-size: small;
        }


            .tabla-alternar tbody tr:hover td {
                background-color: #86b2e0 !important;
            }

            .tabla-alternar tbody tr td {
                border-color: #EBE9EA;
            }

            .tabla-alternar > tbody > tr:nth-of-type(odd) {
                background-color: #F7F6F3;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HiddenField runat="server" ID="hdfclimaID" />
        <section class="container">
            <div class="content-body">
                <div class="row">
                    <div class="row">
                        <div class="col-md-4">
                            <h2 class="title">
                                <asp:Label ID="lblTitulo" runat="server" Text="Informacion del clima"></asp:Label>
                            </h2>
                        </div>
                    </div>
                    <div class="col-md-12" style="text-align: right; padding-top: 20px">
                        <asp:Button Text="Nuevo" ID="btnNuevo" CssClass="btn btn-primary btn-sm" Width="120px" runat="server" OnClick="btnNuevo_Click" />
                        <asp:Button Text="Guardar" ID="btnGuardar" CssClass="btn btn-primary btn-sm" Width="120px" runat="server" OnClick="btnGuardar_Click" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-2">
                        <asp:Label ID="LblFecha" runat="server" Text="Fecha"></asp:Label>
                        <div class="form-group">
                            <asp:TextBox ID="txtFecha" runat="server" ToolTip="Por Favor seleccione una fecha" DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MM/yyyy" CssClass="form-control input-sm" TextMode="Date"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="Vlda1" runat="server" ControlToValidate="txtFecha" ValidationGroup="Clima">
                            </asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="col-md-3">
                        <asp:Label ID="lblCiudad" runat="server" Text="Ciudad"></asp:Label>
                        <div class="form-group">
                            <asp:TextBox ID="txtCiudad" MaxLength="49" ToolTip="Por Favor digite una ciudad" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="Vlda2" runat="server" ControlToValidate="txtCiudad" ValidationGroup="Clima">
                            </asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="col-md-3">
                        <asp:Label ID="lblEstado" runat="server" Text="Estado Clima"></asp:Label>
                        <div class="form-group">
                            <asp:TextBox ID="txtEstado" MaxLength="49" runat="server" ToolTip="Por Favor digite el estado del clima" CssClass="form-control input-sm"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="Vlda3" runat="server" ControlToValidate="txtEstado" ValidationGroup="Clima">
                            </asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="col-md-3">
                        <asp:Label ID="lblTemp" runat="server" Text="Temperatura"></asp:Label>
                        <div class="form-group">
                            <asp:TextBox ID="txtTemp" MaxLength="3" runat="server" ToolTip="Por Favor digite la temperatura del clima" CssClass="form-control input-sm"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="Vlda4" runat="server" ControlToValidate="txtTemp" ValidationGroup="Clima">
                            </asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12" style="padding-top: 10px">
                        <asp:Panel ID="Panel1" runat="server" Height="250px" ScrollBars="None">
                            <asp:GridView ID="gvrRejilla" Width="100%" runat="server" AutoGenerateColumns="False"
                                EmptyDataText="No hay registros con esa coincidencia en el sistema" DataKeyNames="Id_CLIMA" CssClass="tabla-alternar" OnRowCommand="gvrRejilla_RowCommand">
                                <Columns>
                                    <asp:BoundField DataField="FECHA_CLIMA" HeaderText="Fecha"></asp:BoundField>
                                    <asp:BoundField DataField="CIUDAD_CLIMA" HeaderText="Ciudad"></asp:BoundField>
                                    <asp:BoundField DataField="ESTADO_CLIMA" HeaderText="Estado clima"></asp:BoundField>
                                    <asp:BoundField DataField="TEMPERATURA_CLIMA" HeaderText="Temperatura"></asp:BoundField>
                                    <asp:TemplateField HeaderText="" ShowHeader="False" HeaderStyle-Width="100">
                                        <ItemStyle CssClass="text-right" />
                                        <ItemTemplate>
                                            <asp:LinkButton CssClass="btn btn-primary btn-xs" Style="text-decoration: none" ID="lkbSeleccionar" Width="100%" CommandArgument='<%# Eval("Id_CLIMA")%>' CommandName="Seleccionar"
                                                runat="server" ValidationGroup="-1" ToolTip="Seleccionar para actualizar datos de este Registro"><span class="glyphicon glyphicon-pencil"></span> Modificar</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>    
                                    <asp:TemplateField HeaderText="" ShowHeader="False" HeaderStyle-Width="100">
                                        <ItemStyle CssClass="text-right" />
                                        <ItemTemplate>
                                            <asp:LinkButton CssClass="btn btn-primary btn-xs" Style="text-decoration: none" Width="100%" ID="btnEliminarGrv" CommandArgument='<%# Eval("Id_CLIMA")%>' CommandName="Eliminar"
                                                runat="server" ValidationGroup="-1" ToolTip="Seleccionar para eliminar datos de este Registro"><span class="glyphicon glyphicon-trash"></span> Eliminar</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <HeaderStyle />
                            </asp:GridView>
                        </asp:Panel>
                    </div>
                </div>
            </div>


        </section>
    </form>
    <script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
</body>
</html>
<script>
    function extendedValidatorUpdateDisplay(obj) {
        // Appelle la méthode originale
        if (typeof originalValidatorUpdateDisplay === "function") {
            originalValidatorUpdateDisplay(obj);
        }
        // Récupère l'état du control (valide ou invalide) 
        // et ajoute ou enlève la classe has-error
        var control = document.getElementById(obj.controltovalidate);
        if (control) {
            var isValid = true;
            for (var i = 0; i < control.Validators.length; i += 1) {
                if (!control.Validators[i].isvalid) {
                    isValid = false;
                    break;
                }
            }
            if (isValid) {
                $(control).closest(".form-group").removeClass("has-error");
                $(control).closest(".form-group").addClass("has-success");
            } else {
                $(control).closest(".form-group").addClass("has-error");
                $(control).closest(".form-group").removeClass("has-success");
            }
        }
    }
    // Remplace la méthode ValidatorUpdateDisplay
    var originalValidatorUpdateDisplay = window.ValidatorUpdateDisplay;
    window.ValidatorUpdateDisplay = extendedValidatorUpdateDisplay;
</script>
