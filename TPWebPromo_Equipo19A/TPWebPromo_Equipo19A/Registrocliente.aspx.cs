using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPWebPromo_Equipo19A
{
    public partial class Registrocliente : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LblMensaje.Visible = false;
            }

            ArticuloNegocio negocio = new ArticuloNegocio();
            ListaArticulos = negocio.Lectura();
        }


        protected void TxtDNI_TextChanged(object sender, EventArgs e)
        {
            string DNI = TxtDNI.Text;
            if (string.IsNullOrWhiteSpace(DNI))
            {
                Response.Write("<script>alert('Por favor ingrese un código.');</script>");
                return;
            }



            try
            {
                ClienteNegocio negocio = new ClienteNegocio();
                List<Cliente> clientes = negocio.Lectura();

                Cliente encontrado = clientes.FirstOrDefault(v => v.Documento == DNI);

                if (encontrado != null)
                {
                    TxtNombre.Text = encontrado.Nombre;
                    TxtApellido.Text = encontrado.Apellido;
                    TxtCiudad.Text = encontrado.Ciudad;
                    TxtEmail.Text = encontrado.Email;
                    TxtDireccion.Text = encontrado.Direccion;
                    TxtCP.Text = encontrado.CP.ToString();
                    LblMensaje.Visible = false; // Oculta el mensaje si existe

                    HabilitarCampos(true);
                }
                else
                {
                    LblMensaje.Text = "DNI no encontrado. Podés completar tus datos para participar.";
                    LblMensaje.CssClass = "text-warning";
                    LblMensaje.Visible = true;

                    LimpiarCampos();
                    HabilitarCampos(true);
                }
            }
            catch
            {
                LblMensaje.Text = "Ocurrió un error inesperado.";
                LblMensaje.Visible = true;
            }




        }

        protected void BtnParticipar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TxtNombre.Text) ||
                string.IsNullOrWhiteSpace(TxtApellido.Text) ||
                string.IsNullOrWhiteSpace(TxtEmail.Text) ||
                string.IsNullOrWhiteSpace(TxtCiudad.Text) ||
                string.IsNullOrWhiteSpace(TxtDireccion.Text) ||
                string.IsNullOrWhiteSpace(TxtCP.Text))
            {
                LblMensaje.Text = "Por favor completá todos los campos antes de continuar.";
                LblMensaje.Visible = true;
                return;
            }

            try
            {
                Cliente nuevo = new Cliente();

                nuevo.Documento = TxtDNI.Text;
                nuevo.Nombre = TxtNombre.Text;
                nuevo.Apellido = TxtApellido.Text;
                nuevo.Email = TxtEmail.Text;
                nuevo.Direccion = TxtDireccion.Text;
                nuevo.Ciudad = TxtCiudad.Text;
                nuevo.CP = int.Parse(TxtCP.Text);

                ClienteNegocio negocio = new ClienteNegocio();


                if (negocio.ValidacionxDNI(nuevo.Documento))
                {
                    LblMensaje.Text = "El cliente con ese DNI ya está registrado.";
                    LblMensaje.CssClass = "text-warning";
                    LblMensaje.Visible = true;
                    return;
                }


                negocio.Agregar(nuevo);

                LblMensaje.Text = "¡Participación registrada con éxito!";
                LblMensaje.CssClass = "text-success";
                LblMensaje.Visible = true;
            }
            catch
            {
                LblMensaje.Text = "Error al registrar la participación.";
                LblMensaje.Visible = true;
            }
        }


        
        private void HabilitarCampos(bool estado)
        {
            TxtNombre.Enabled = estado;
            TxtApellido.Enabled = estado;
            TxtEmail.Enabled = estado;
            TxtDireccion.Enabled = estado;
            TxtCiudad.Enabled = estado;
            TxtCP.Enabled = estado;
        }

        private void LimpiarCampos()
        {
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtEmail.Text = "";
            TxtDireccion.Text = "";
            TxtCiudad.Text = "";
            TxtCP.Text = "";
        }


    }
}