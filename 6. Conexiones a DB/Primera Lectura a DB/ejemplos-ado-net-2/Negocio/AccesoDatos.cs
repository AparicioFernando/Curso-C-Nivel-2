using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Negocio
{
    public class AccesoDatos
    {
        //1° le declaro algunos objetos, por ejemplo los que necesito para establecer una conexion 
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector //para tener la posibilidad de leer el lector desde el exterior, no escribirlo
        {
            get { return lector; }
        }

        //2° creo mi construtor, que cuando nace  el objeto acceso a datos:
        public AccesoDatos() 
        {
            conexion=new SqlConnection("server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true");
            comando = new SqlCommand();
        }

        //3° creo una función setear consulta
        public void setearConsulta(string consulta)
        {
            comando.CommandType=System.Data.CommandType.Text;
            comando.CommandText=consulta;
        }
        //4° funcion de ejecutar lectura
        public void ejecutarLectura()
        {
            comando.Connection=conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
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

        //5° funcion para cerrar conexion
        public void cerrarConexion()
        {             
            if (lector != null)             
                lector.Close();
            conexion.Close();

        }
    }
}
