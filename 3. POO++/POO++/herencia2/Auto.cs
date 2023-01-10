using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia2
{
    internal class Auto:Vehiculo
    {
        public Auto() 
        {
            Chasis= new Chasis();   //constructor de Chasis
        }

        public string Anio { get; set; }

        public string Modelo { get; set; }

        public string Color { get; set; }

        public Motor Motor { get; set; }    //el auto va a terner un objeto del tipo Motor como propiedad-------------Agregación

        public Chasis Chasis { get; }   //el auto nace con chasis, puedo obtener la info del chasis (get) pero no puedo setearle info------------composición

        //Composicion

        //Agregación: puedo crear el auto y luego agregarle el motor
    }
}
