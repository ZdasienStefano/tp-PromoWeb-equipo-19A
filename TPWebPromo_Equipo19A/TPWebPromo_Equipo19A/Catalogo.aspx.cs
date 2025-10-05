using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPWebPromo_Equipo19A
{
    public partial class Catalogo : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    LblMensaje.Visible = false;
            //}

            ArticuloNegocio negocio = new ArticuloNegocio();
            ListaArticulos = negocio.Lectura();
        }


        



    }


}