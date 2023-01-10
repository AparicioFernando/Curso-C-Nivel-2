using System;
using System.Collections.Generic;

namespace herencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehiculo>Auto>AutoDeportivo>AutoUrbano
            //>Camioneta
            //>Moto



            //COLECCIONES: TIPO SET, TIPO DICCIONARIOS Y TIPO LISTA

            Vehiculo v1= new Vehiculo();
            Camioneta c1= new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();

            c1.Color = "Amarillo";
            c2.Color = "Rojo";
            c3.Color = "Blanca";


            //CREAR LISTA

            List<Camioneta> listaCamonetas = new List<Camioneta>();        //Creo un objeto lista de Camioneta. Creo una lista del tipo "clase Camioneta" para agregar objetos creados con Camioneta
            
            //Agregar Objeto a la lista
            
            listaCamonetas.Add(c1);     // de esta manera la lista ya tiene un objeto dentro
            listaCamonetas.Add (c2);
            listaCamonetas.Add (c3);

            //Saber cuantos objetos tengo en la lista
            Console.WriteLine("La cantidad de camionetas es: " + listaCamonetas.Count);

            //Mostrar un elemento de ese listado

            Console.WriteLine("El color de la camioneta 2 es: "+listaCamonetas[1].Color);

            //Cambiamos color de camioneta

            listaCamonetas[1].Color = "Negro";
            Console.WriteLine("El color de la camioneta 2 es: " + listaCamonetas[1].Color);

            //Eliminar objeto de la lista

            listaCamonetas.Remove(c3);
            Console.WriteLine("La cantidad de camionetas es: " + listaCamonetas.Count);

            //Mostrar todas las camionetas. Recorrer la lista con un ciclo

            foreach (Camioneta item in listaCamonetas)
            {
                Console.WriteLine("Color: "+item.Color);
            }




        }
    }
}
