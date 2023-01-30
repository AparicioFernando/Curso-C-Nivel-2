using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;        //agrego esta librería para conexion a BD

namespace winform_app
{
    //Clase para crear lo métodos de acceso a datos para lo pokemon
    internal class PokemonNegocio
    {
        public List<Pokemon> listar()   //agrupamos lo pokemon en una lista- Esto es un método que devuelve una lista de pokemons
        {
            List<Pokemon> lista = new List<Pokemon>();  //creamos la lista

            //2° Creamos un objeto del tipo sql conexion para conectarme
            SqlConnection conexion = new SqlConnection();

            //3° Una vez que me conecte voy a necesitar realizar acciones, para ello declaro el objeto comando
            SqlCommand comando= new SqlCommand();

            //4° finalmente voy a tener un set de datos, eso lo voy a guardar en un lector que se llama:
            SqlDataReader lector;   //no le genero una instancia porque cuando realice la lectura voy a tener la instancia de un objeto

            // 1° vamos a manejar las excepciones
            try
            {
                //5° ahora tengo que configurar la cadena de conexion
                conexion.ConnectionString = "Fernando\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
                /* 
                 Server: donde vamos a guardar
                 database: a que base nos vamos a conectar
                 integrated security: seguridad para entrar a la BD sin usuario y contraseña; caso contrario seria integrated security=false; usuario=lalala; password=lalala
                */

                //6° ahora tengo que configurar el comando
                comando.CommandType = System.Data.CommandType.Text;
                // configuro el comando de accion, esta va a ser de lectura, esta lo hago mandando desde aca la sentencia sql que quiero ejecutar
                // Al comando le voy a decir de que tipo tiene que ser, hay 3 tipo.
                //text: tipo texto
                //storeProcedure: tipo procedimiento almacenado,
                //tableDirect: tipo enlace directo con la tabla
                //7° Ahora le decimos cual va ser el texto
                comando.CommandText = "Select Numero, Nombre, Descripcion from POKEMONS"; //pegamos la consulta hecha en SQL
                comando.Connection = conexion; //lo siguiente es decirle a comando.Connection que ejecute ese comando en "conexion" que esta establecida en el renglon 30

                //8° abro la conexion
                conexion.Open();

                //9° realizo la lectura
                lector=comando.ExecuteReader(); //esto da como resultado un SQL DataReader que lo guardo en la variable "lector"

                //HASTA ACA YO TENGO LOS DATOS EN LA VARIABLE "LECTOR"

                //10° ahora a leer la variable lector

                while (lector.Read())   // Si hay un registro devuelve TRUE
                {
                    Pokemon aux = new Pokemon();    //creo un pokemon auxiliar
                                                    //lo comienzo a cargar con los datos del lector de ese registro 
                    aux.Numero = lector.GetInt32(0);
                    //EXPLICO:para asignar algo que traigo del lector uso: lector.GetInt32(0). Es int porque nuestra columna de Numero en SQL es tipo Int
                    // entonces para el lector lo tengo que obtener como un Int32, este es el comun, el Int 16 es el short y el Int 54 es el long.
                    //entre los () va el indice dentro de la pseudotabla que armamos Numero(0), Nombre(1) y Descripcion(2)

                    //OTRA FORMA
                    aux.Nombre = (string)lector["Nombre"];  //Con esto trae todo pero se le aclara antes que tipo de dato es  +PRACTICO
                    aux.Descripcion = (string)lector["Descripcion"];

                    lista.Add(aux);
                }

                conexion.Close();

                return lista;   //el método devuelve la lista y apunta al primer registro
            }
            catch (Exception ex)
            {
                    
                throw ex;
            }

            
        }
    }
}
