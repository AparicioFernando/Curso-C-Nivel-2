using System;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();     //creo mi persona. Mi variable p1 es un objeto de tipo "Persona"
            p1.setEdad(20); //llamo a la función (método cuando hablamos de POO) y le setteamos la edad
            Console.WriteLine("La edad de la persona es: " + p1.getEdad());



            Botella b1 = new Botella("Rojo","Plastico");    //al crear el constructor tengo que pasarle los paramentros al crear el objeto
            b1.Capacidad = 200;

            //el color y material solo se cargan una vez y pasan a ser solo lectura

            int algo = b1.Capacidad;


            Perro perro1 = new Perro();

            Console.WriteLine("Ingrese nombre del perro: ");
            perro1.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el color del perro: ");
            perro1.Color = Console.ReadLine();

            Console.WriteLine("Ingrese el origen del perro: ");
            perro1.Origen = Console.ReadLine();

            Console.WriteLine("El perro se llama "+perro1.Nombre+" .El color es: "+perro1.Color+ " .Su origen es: "+perro1.Origen);



            Console.ReadKey();
        }
    }
}
