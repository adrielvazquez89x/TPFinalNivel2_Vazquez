using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace negocio
{
    public class AccesoDatos
    {
        //Declaramos los atributos en private.
        private SqlConnection conexion;
        private SqlCommand comando; 
        private SqlDataReader lector;

        // Declaramos las props de acceso
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        //Creamos el constructor
        public AccesoDatos()
        {
            //Acá, asignamos la data para la conexión. 
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database = CATALOGO_DB; integrated security = true");
            comando = new SqlCommand(); // Nuevo objeto para mas adelante.
        }

        public void setConsulta(string consulta)
        {
            //Tipo de consulta, text.
            comando.CommandType = System.Data.CommandType.Text;
            //Consulta recibida por parámetro.
            comando.CommandText = consulta;

        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;

            //Siempre que quiera interactuar la DB, tengo que usar try/catch
            try
            {
                conexion.Open(); //Abrimos la conexión
                lector = comando.ExecuteReader(); //Ejecuta el Lector,
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void setParams(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void cerrarConexion()
        {
            if(lector != null)
            {
                lector.Close();
                conexion.Close();
            }
        }
    }
}
