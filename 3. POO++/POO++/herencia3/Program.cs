using System;
using System.Collections.Generic;

namespace herencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato g1= new Gato();
            g1.Nombre = "Pepe";

            Perro p1= new Perro();

            Console.WriteLine(g1.comunicarse());
            Console.WriteLine(p1.comunicarse());

            List<Animal> animales= new List<Animal>();

            animales.Add(g1);
            animales.Add(p1);
            animales.Add(new Pez());
            animales.Add(new Canario());
            animales.Add(new Aguila());
            animales.Add(new Gato());

            List<Flyable> listaVoladores = new List<Flyable>(); //creo una lista con la interfaz, en donde agrego animales que pueden volar debido a que le agregamos la interfaz 
                                                                //a la clase. Un perro no puede volar entonces no deja que se agregue por ejemplo, porque en la arquitectura de clase
                                                                //que diseñamos, los perros no vuelan

            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Aguila());

            //foreach (Animal item in animales)
            //{
            //    Console.WriteLine(item.comunicarse());
            //}


            //POLIMORFISMO: la característica que tiene los objetos de ante el mismo estímulo comportarse de manera distinta. El estímulo es ""comunicarse" y por medio de la
            //sobreescritura reacciona distinto de acuerdo al animal

            Animal a1 = g1;

            Gato g8 = (Gato)a1; //con esto obligo a que el compilador ne cree un objeto gato, asegurandole que a1 es un gato. De lo contrario no lo crea porque no sabe
                                //si a1 es un gato o cualquier otro animal

            

            Console.ReadKey();
        }
    }
}
