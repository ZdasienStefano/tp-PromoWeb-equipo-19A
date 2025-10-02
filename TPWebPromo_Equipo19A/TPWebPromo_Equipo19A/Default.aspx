<%@ Page Title="Canje" Language="C#" MasterPageFile="~/MasterWeb.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPWebPromo_Equipo19A.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">

        <div class="col-4"></div>
        <div class="col">
            <div style="font-family:Dubai">

            <h1> Promo ¡¡¡GANA!!! </h1>

            </div>
            <div style="font-family:Tahoma";>
                <h3>Ingresa el codigo de tu voucher</h3>
            </div>

            <div>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" Text="XXXXXXXXXX" Style="width: 300px"></asp:TextBox>
            </div>

            <div class="d-grid gap-2 d-md-block">
                <asp:Button ID="btnSiguiente" runat="server" CssClass="btn btn-success btn-lg shadow-sm" Text="Siguiente" Style="width: 120px" OnClick="btnSiguiente_Click"></asp:Button>
            </div>

        </div>
        <div class="col-4"></div>

    </div>


</asp:Content>
