using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {
        //CONSTRUCTOR: es un metodo que se crea al inicio, cuando creo el objeto esto se ejecuta automaticamente, ya sea para atributos fijos o metodos automáticos
        public Botella(string color, string material)       //recibe parámetros y tiene algo de lógica
        {
            this.color = color;
            this.material = material;
        }
        //SOBRECARGAR EL CONSTRUCTOR: puedo cargar de nuevo el constructor pero con diferente categorias 
        public Botella() { }        //no recibe parámetro y no tiene lógica

        //CON ESTOS AMBOS CASOS PUEDO CREAR UN OBJETOS CON ATRIBUTOS INICIALES O CARGALOS YO MANUALMENTE 

        ~Botella() //DESTRUCTOR: se limpian los espacios en memoria que se estén utilizando, en .NET esto lo hace automaticamente el Garbage Collector, pero
                   //si queremos eliminar algo en paticular lo podemos señalar en el destructor
        {
            //la lógica...
        }

        //Capacidad, Color, Material
        private int capacidad;
        private string color;
        private string material;


        //PROPIEDAD

        public int Capacidad        //Con esto remplazo lo que hice en Persona
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
    }
}
