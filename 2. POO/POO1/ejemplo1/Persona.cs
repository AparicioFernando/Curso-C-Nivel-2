using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Persona
    {
        //Persona: edad, sueldo, nombre
        //ATRIBUTOS O MIEMBROS
        //son las variables que nos van a permitir guardar la informacion de esa persona

        private int edad;
        private float sueldo;   //estos son los datos que conforman a mi persona
        private string nombre;

        //Los atributos de una clase tienen que cumplir una caracteristica que es encapsulamiento, por el cual dice que un miembro de una clase no puede ser
        //accedido desde el exterior. Pero vamos a contar con mecanismos que nos permitan tanto leer como escribir los atributos, pero hay que invocar al mecanismo,
        //por lo que es un acceso indirecto al dato

        //MODIFICADORES DE VISIBILIDAD
        //Palabras reservadas para calificar un atributo, funcion o clase como público o privado principalmente entre otros. Público con acceso, Privado sin acceso

        //MECANISMOS PARA ACCEDER A LOS ATRIBUTOS
        public void setEdad(int e)  //funcipon para settear la edad que recibe como parámetro
        {
            edad = e;
        }
        //este método no devuelve nada, solo escribe la edad y le asigna lo que recibe desde el exterior

        //METODO PARA LEER LOS ATRIBUTOS
        public int getEdad() 
        {
            return edad;
        }
        //este método no recibe nada, solo obtiene el contenido de "edad" y lo retorna.

    }

}
