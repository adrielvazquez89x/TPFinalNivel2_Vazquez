using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MarcasNegocio
    {
        public List<Marca> listarMarcas()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("Select Descripcion, Id from Marcas");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Nombre = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }
                                
                return lista;
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

        public void agregarMarca(Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta($"Insert into MARCAS (Descripcion) values ('{marca.Nombre}')");
                datos.ejecutarLectura();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {
                datos.cerrarConexion();
            }
        }

        public void eliminarMarca(string nombre)
        {

            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setConsulta($"delete from MARCAS where Descripcion = '{nombre}'");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
    }
}
