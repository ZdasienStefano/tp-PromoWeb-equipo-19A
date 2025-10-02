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
using Dominio;
using System.Web.Services.Description;

namespace TPWebPromo_Equipo19A
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            
            string Valor = TextBox1.Text;

            if (string.IsNullOrWhiteSpace(Valor))
            {
                Response.Write("<script>alert('Por favor ingrese un código.');</script>");
                return;
            }


            {
                try
                {
                    List<Voucher> vouchers;
                    voucherNegocio negocio = new voucherNegocio();
                    vouchers = negocio.Lectura();
                    bool encontrado = false;

                    foreach (var v in vouchers)
                    {
                        if(v.CodVaucher == Valor)
                        {
                            Response.Redirect("Catalogo.aspx?voucher=" + Valor);
                            encontrado = true;
                            return;
                        }
                    }

                    if (!encontrado)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('El voucher no existe o ya fue canjeado');", true);
                    }

                }
                catch (Exception ex)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Error: " + ex.Message + "');", true);

                }

          
            
            }
            
        }
    }
}