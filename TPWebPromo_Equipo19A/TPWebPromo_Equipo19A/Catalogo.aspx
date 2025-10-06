<%@ Page Title="Catalogo" Language="C#" MasterPageFile="~/MasterWeb.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="TPWebPromo_Equipo19A.Catalogo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Esta seria el catalogo de articulos</h2>
    <div class="row row-cols-1 row-cols-md-3 g-4">

        <% foreach (var Art in ListaArticulos) { %>
    <div class="col mb-4">
        <div class="card shadow-sm h-100" style="border-radius: 12px; overflow: hidden;">
            
            <div id="carousel<%= Art.IdArticulo %>" class="carousel slide" data-bs-ride="false">
                <div class="carousel-inner">
                    <% for (int i = 0; i < Art.Imagenes.Count; i++) { %>
                        <div class="carousel-item <%= i == 0 ? "active" : "" %>">
                            <img src="<%= Art.Imagenes[i] %>" class="d-block w-100" alt="Imagen del artículo" 
     style="height:200px; object-fit: contain; background-color: #f8f9fa;">
                        </div>
                    <% } %>
                </div>
                <button class="carousel-control-prev" type="button" data-bs-target="#carousel<%= Art.IdArticulo %>" data-bs-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                </button>
                <button class="carousel-control-next" type="button" data-bs-target="#carousel<%= Art.IdArticulo %>" data-bs-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                </button>
            </div>

          
            <div class="card-body d-flex flex-column">
                <h5 class="card-title"><%= Art.Nombre %></h5>
                <p class="card-text text-truncate" style="max-height: 3em;"><%= Art.Descripcion %></p>

                
                <a href='RegistroCliente.aspx?voucher=<%= Request.QueryString["voucher"] %>&IdArticulo=<%= Art.IdArticulo %>' 
                   class="btn btn-primary mt-auto w-100" 
                   style="border-radius: 8px; font-weight: 500; transition: transform 0.2s;">
                   Elegir
                </a>
            </div>
        </div>
    </div>
<% } %>
        
 
    </div>
</asp:Content>
