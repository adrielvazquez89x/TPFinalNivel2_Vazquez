using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ArticulosNegocio
    {
        public List<Articulo> listarArticulos()
        {
            List<Articulo> listaArticulos = new List<Articulo>();

            AccesoDatos datos = new AccesoDatos();

            datos.setConsulta("Select A.Id, Codigo, Nombre, A.Descripcion, IdCategoria, IdMarca, ImagenUrl, Precio, M.Descripcion Marca, C.Descripcion Categoria from ARTICULOS A, MARCAS M, CATEGORIAS C where  A.IdMarca = M.Id And A.IdCategoria = C.Id");
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
                auxiliar.Tipo = new Categoria();
                auxiliar.Tipo.Descripcion = (string)datos.Lector["Categoria"];
                auxiliar.UrlImg = (string)datos.Lector["ImagenUrl"];
                auxiliar.Precio = (decimal)datos.Lector["Precio"];

                listaArticulos.Add(auxiliar);
            }
            datos.cerrarConexion();

            return listaArticulos;
        }

        public void agregarArticulo(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("");
            }
            catch (Exception)
            {

                throw;
            }

            
        }
    }
}
