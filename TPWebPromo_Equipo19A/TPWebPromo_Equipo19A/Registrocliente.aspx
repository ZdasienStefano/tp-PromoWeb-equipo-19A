<%@ Page Title="" Language="C#" MasterPageFile="~/MasterWeb.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="TPWebPromo_Equipo19A.CanjeDeCodigo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

  

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container mt5-">
    <div class="row justify-content-center">
        <div class="col-md-11">
            <div class="card shadow p-4">

<div>
<h1 class="text-center mb-4">Ingresá tus datos</h1>
</div>
<div>
<h2 class="col-md-4">DNI</h2>
</div>
<div>
<asp:TextBox ID="TxtDNI" runat="server" CssClass="form-control" Text="" Width="300px" ></asp:TextBox>
</div>

<div class="row fs-1">

    <div class="col-md-4"> Nombre:</div>
    <div class="col-md-4"> Apellido:</div>
    <div class="col-md-4"> Email:</div>
</div>
                <!--  carga nombre apellido email    -->
         <div class="row fs-1 gap-2">

    <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control" Text="" Width="300px" ></asp:TextBox>
    <asp:TextBox ID="TxtApellido" runat="server" CssClass="form-control" Text="" Width="300px" ></asp:TextBox>
    <asp:TextBox ID="TxtEmail" runat="server" CssClass="form-control" Text="" Width="300px" ></asp:TextBox>
</div>

                 <div></div>


   <div class="row fs-1 align-content-center">

    <div class="col-md-4"> Direccion:</div>
    <div class="col-md-4"> Ciudad:</div>
    <div class="col-md-4"> Codigo Postal:</div>
</div>
                <!--  carga Direccion ciudad CP    -->
         <div class="row fs-1 gap-2">

    <asp:TextBox ID="TxtDireccion" runat="server" CssClass="form-control" Text="" Width="300px" ></asp:TextBox>
    <asp:TextBox ID="TxtCiudad" runat="server" CssClass="form-control" Text="" Width="300px" ></asp:TextBox>
    <asp:TextBox ID="TxtCP" runat="server" CssClass="form-control" Text="" Width="300px" ></asp:TextBox>
</div>


    </div>
    </div>
    </div>
    </div>


   





    <h2>Esta seria el registro de clientes</h2>

</asp:Content>



