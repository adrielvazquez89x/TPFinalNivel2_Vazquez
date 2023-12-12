﻿using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ArticulosNegocio
    {
        //Aca va el CRUD de los articulos
        public List<Articulo> listarArticulos()
        {
            List<Articulo> listaArticulos = new List<Articulo>();

            AccesoDatos datos = new AccesoDatos();

            datos.setConsulta("Select A.Id, Codigo, Nombre, A.Descripcion, IdCategoria, IdMarca, ImagenUrl, Precio, M.Descripcion Marca, C.Descripcion Categoria from ARTICULOS A, MARCAS M, CATEGORIAS C where  A.IdMarca = M.Id And A.IdCategoria = C.Id And CODIGO NOT LIKE '%(BAJA)%'");
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
                datos.setConsulta($"Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdCategoria, IdMarca, ImagenUrl, Precio) values ('{nuevo.Codigo}', '{nuevo.Nombre}','{nuevo.Descripcion}', {nuevo.Tipo.Id},{nuevo.Fabricante.Id},'{nuevo.UrlImg}',{nuevo.Precio})");
                datos.ejecutarLectura();
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

        public void modificarArticulo(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta($"update ARTICULOS set Codigo = '{articulo.Codigo}', Nombre = '{articulo.Nombre}', Descripcion = '{articulo.Descripcion}', ImagenUrl = '{articulo.UrlImg}', Precio = @precio, IdCategoria = {articulo.Tipo.Id}, IdMarca = {articulo.Fabricante.Id} where Id = {articulo.Id}");
                datos.setParams("precio", articulo.Precio);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void eliminarArticulo(Articulo articulo)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setConsulta($"update ARTICULOS set Codigo = '{articulo.Codigo} (BAJA)' where Id = {articulo.Id}");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
