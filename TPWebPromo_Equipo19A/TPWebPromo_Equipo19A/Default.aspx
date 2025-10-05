<%@ Page Title="Canje" Language="C#" MasterPageFile="~/MasterWeb.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPWebPromo_Equipo19A.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">

        <div class="col-4"></div>
        <div class="col">
            <div id="caja-promo">
            <h1 id="letra-promo"> ¡Promo Ganá! </h1>
            </div>
            <div id="ingreso-voucher">
                <h3> Ingresa el codigo de tu voucher </h3>
            </div>

            <div id="div-textbox" class="d-flex flex-column align-items-center gap-3">
    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control input-voucher"  placeholder="XXXXXXXXXX" Width="300px">
    </asp:TextBox>

    <asp:Button ID="btnSiguiente" runat="server" CssClass="btn btn-success btn-lg shadow-sm boton-siguiente" Text="Siguiente" Width="120px"  OnClick="btnSiguiente_Click">
    </asp:Button>
        </div>

        </div>
        <div class="col-4"></div>
         </div>


</asp:Content>
