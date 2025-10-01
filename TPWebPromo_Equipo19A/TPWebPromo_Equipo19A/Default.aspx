<%@ Page Title="Canje" Language="C#" MasterPageFile="~/MasterWeb.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPWebPromo_Equipo19A.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1> Promo ¡¡¡GANA!!! </h1>
    <div>
        <h2>Ingresa el codigo de tu voucher</h2>
    </div>
    
    <div>
 <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" Text="XXXXXXXXXX" Style="Width:300px"></asp:TextBox>
    </div>

    <div>
   <asp:button ID="btnSiguiente" runat="server" CssClass="btn btn-success" Text="Siguiente" Style="Width:100px" OnClick="btnSiguiente_Click"> </asp:button>  
    </div>

    <!-- <h1>Primera vesion de la web</h1> -->








</asp:Content>
