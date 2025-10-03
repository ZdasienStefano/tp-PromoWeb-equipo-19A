using Dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Negocio
{
    internal class ClienteNegocio
    {

        public List <Cliente> Lectura() { 

        List<Cliente> lista = new List<Cliente>();
        AccesoDatos data = new AccesoDatos();
            
            try
            {
                data.SetearConsulta("select Id, Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP from Clientes;");
                data.EjecutarLectura();

                while (data.Lector.Read())
                {
                    Cliente aux = new Cliente();

                    aux.Documento = data.Lector["Documento"] != DBNull.Value
                        ? data.Lector["Documento"].ToString() : "";
                    aux.Nombre = data.Lector["Nombre"] != DBNull.Value
                        ? data.Lector["Nombre"].ToString() : "";
                    aux.IdCliente = data.Lector["Id"] != DBNull.Value
                        ? Convert.ToInt32(data.Lector["Id"]):0;
                    aux.Apellido = data.Lector["Apellido"] != DBNull.Value
                        ? data.Lector["Apellido"].ToString() : "";
                    aux.Email = data.Lector["Email"] != DBNull.Value
                        ? data.Lector["Email"].ToString() : "";
                    aux.Ciudad = data.Lector["Ciudad"] != DBNull.Value
                        ? data.Lector["Ciudad"].ToString() : "";
                    aux.CP = data.Lector["CP"] != DBNull.Value
                        ? Convert.ToInt32(data.Lector["CP"]): 0;
                    aux.Direccion = data.Lector["Direccion"] != DBNull.Value
                        ? data.Lector["Direccion"].ToString() : "";

                    lista.Add(aux);
                }
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.cerrarConexion();
            }

return lista;
        
        }
        
        
        
        }



    

}
