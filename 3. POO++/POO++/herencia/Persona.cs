using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    abstract class Persona  //creo una clase abstracta para que no se pueda usar para crear una instancia de la clase Persona
                            //el tipo de clase "sealed" es para que esa clase no pueda ser heredada
                            // el tipo de clase "static" no es necesario instanciar la clase para usarla, ejemplo Console.writeline() es una clase static
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Legajo { get; set; }
    }
}
