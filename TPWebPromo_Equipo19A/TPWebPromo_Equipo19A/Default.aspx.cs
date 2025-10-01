using System;
using Negocio;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace TPWebPromo_Equipo19A
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
           /*
            string Valor = TextBox1.Text;

            if (string.IsNullOrWhiteSpace(Valor))
            {
                Response.Write("<script>alert('Por favor ingrese un código.');</script>");
                return;
            }


            {
                try
                {

                    AccesoDatos datos = new AccesoDatos();
                    string consulta = "INSERT INTO Vouchers (Codigo) VALUES ('" + codigo + "')";
                    datos.SetearConsulta(consulta);
                    datos.EjecutarAccion();
                    Response.Write("<script>alert('Código guardado exitosamente.');</script>");

                }
                catch (Exception ex)
                {
                    Response.Write("<script> alert(Error: " + ex.Message + "');</script>");

                }





            
            }
            */
        }
    }
}