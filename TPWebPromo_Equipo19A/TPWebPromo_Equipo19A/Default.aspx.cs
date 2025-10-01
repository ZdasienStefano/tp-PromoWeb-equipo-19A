using System;
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

            string conexion = ConfigurationManager.ConnectionStrings["PROMOS_DB"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conexion))
            {
                try
                {
                    var Canje = new CanjeDeCodigo();
                    con.Open();
                    string query = "insert into VOUCHERS (Codigo) VALUES (@Codigo)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue(Canje, Valor);
                    cmd.ExecuteNonQuery();

                    Response.Write("<script> alert('¡Codigo canjeado exitosamente!');</script>");
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