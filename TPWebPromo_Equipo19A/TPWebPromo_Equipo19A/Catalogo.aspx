<%@ Page Title="Catalogo" Language="C#" MasterPageFile="~/MasterWeb.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="TPWebPromo_Equipo19A.Catalogo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Esta seria el catalogo de articulos</h2>
    <div class="row row-cols-1 row-cols-md-3 g-4">

        <% foreach (Dominio.Articulo Art in ListaArticulos)
            { %>
                 <div class="col">
                <div class="card">
                <img src="<%: Art.Url.UrlImagen %>" class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title"><%: Art.Nombre %></h5>
                    <p class="card-text"><%: Art.Descripcion %></p>
                </div>
                    </div>
                </div>

        <%
           }


            %>
        
 
    </div>
</asp:Content>
