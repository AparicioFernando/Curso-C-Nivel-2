using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono telefono1 = new Telefono("Nokia", "1100");

            Console.WriteLine(telefono1.Marca);
            Console.WriteLine(telefono1.Modelo);

            telefono1.NumeroTelefonico = "3516797937";
            telefono1.CodigoOperador = 2;

            Console.WriteLine("=====================================================================");

            Console.WriteLine("El teléfono numero: " + telefono1.NumeroTelefonico + " tiene como Código de Operador el " + telefono1.CodigoOperador + ". La marca es: " + telefono1.Marca + " y el modelo es: " + telefono1.Modelo);

            Console.WriteLine(telefono1.Llamar());
            Console.WriteLine(telefono1.Llamar("Dario"));

            Console.ReadKey();

        }
    }
}
