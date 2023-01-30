using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ElementoNegocio
    {
        public List<Elemento> listar()
        {
			List<Elemento> lista=new List<Elemento>();
			AccesoDatos datos= new AccesoDatos();	//aca nace un objeto que tiene un lector, un comando y una conexion, el comando y conexion tienen
													// instancia y ademas tiene la cadena de conexion configurada 
			try
			{
				datos.setearConsulta("Select Id, Descripcion From ELEMENTOS");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Elemento aux= new Elemento();
					aux.Id = (int)datos.Lector["Id"];
					aux.Descripcion = (string)datos.Lector["Description"];

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
    }
}
