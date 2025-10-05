using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloNegocio
    {

        public List<Articulo> Lectura()
        {
            List<Articulo> Lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, I.ImagenUrl FROM ARTICULOS A LEFT JOIN IMAGENES I ON A.Id = I.IdArticulo;");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IdArticulo = datos.Lector["Id"] != DBNull.Value
                                    ? Convert.ToInt32(datos.Lector["Id"])
                                     : 0;
                    aux.Codigo = datos.Lector["Codigo"] != DBNull.Value
                                    ? datos.Lector["Codigo"].ToString()
                                        : ""; ;
                    aux.Nombre = datos.Lector["Nombre"] != DBNull.Value
                                     ? datos.Lector["Nombre"].ToString()
                                        : "";
                    aux.Descripcion = datos.Lector["Descripcion"] != DBNull.Value
                                        ? datos.Lector["Descripcion"].ToString()
                                        : "";
                    aux.Url = new Imagen();
                    aux.Url.UrlImagen = datos.Lector["ImagenUrl"] != DBNull.Value
                                        ? datos.Lector["ImagenUrl"].ToString()
                                        : "";
                    Lista.Add(aux);

                }
                return Lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

    }

}

