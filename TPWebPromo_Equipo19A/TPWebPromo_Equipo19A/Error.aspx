<%@ Page Title="" Language="C#" MasterPageFile="~/MasterWeb.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="TPWebPromo_Equipo19A.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="text-center mt-5">
        <h1 class="text-danger fw-bold"> ❌ El Codigo de voucher es invalido o ya fue canjeado</h1>
        <h2>Por favor, revisa tu código e intenta nuevamente. </h2>
        <a href="Default.aspx" class="btn btn-primary mt-3">Volver al inicio</a>
    </div>
</asp:Content>