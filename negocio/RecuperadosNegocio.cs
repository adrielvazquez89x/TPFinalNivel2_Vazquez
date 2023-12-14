using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace negocio
{
    public class RecuperadosNegocio
    {
        public List<Articulo> listaRecuperar()
        {
            List<Articulo> listaRecuperados = new List<Articulo>();
            
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("Select A.Id, Codigo, Nombre, A.Descripcion, IdCategoria, IdMarca, ImagenUrl, Precio, M.Descripcion Marca, C.Descripcion Categoria from ARTICULOS A, MARCAS M, CATEGORIAS C where  A.IdMarca = M.Id And A.IdCategoria = C.Id And CODIGO LIKE '%(BAJA)%'");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo auxiliar = new Articulo();
                    auxiliar.Id = (int)datos.Lector["Id"];
                    auxiliar.Codigo = (string)datos.Lector["Codigo"];
                    auxiliar.Nombre = (string)datos.Lector["Nombre"];
                    auxiliar.Descripcion = (string)datos.Lector["Descripcion"];
                    auxiliar.Fabricante = new Marca();
                    auxiliar.Fabricante.Nombre = (string)datos.Lector["Marca"];
                    auxiliar.Fabricante.Id = (int)datos.Lector["IdMarca"];
                    auxiliar.Tipo = new Categoria();
                    auxiliar.Tipo.Descripcion = (string)datos.Lector["Categoria"];
                    auxiliar.Tipo.Id = (int)datos.Lector["IdCategoria"];
                    auxiliar.UrlImg = (string)datos.Lector["ImagenUrl"];
                    auxiliar.Precio = Math.Round((decimal)datos.Lector["Precio"], 2); // Redondea a dos decimales

                    listaRecuperados.Add(auxiliar);
                }

                return listaRecuperados;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void restaurarRegistro(int id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta($"update ARTICULOS set Codigo = REPLACE (Codigo, '(BAJA)', '') where id = {id};");
                datos.ejecutarAccion();
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
