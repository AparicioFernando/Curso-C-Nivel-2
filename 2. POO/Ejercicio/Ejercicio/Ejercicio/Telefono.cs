using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Telefono
    {
        public Telefono(string modelo, string marca) 
        { 
            this.Modelo = modelo;
            this.Marca = marca;
        }
        public string Modelo { get;}
        public string Marca { get;}
        public string NumeroTelefonico { get; set; }
    
        private int codigoOperador;        
       
        public int CodigoOperador
        {
            get { return codigoOperador;}
            set {
                if (value > 0 && value<4)
                    codigoOperador = value;
                else
                    codigoOperador = -1;
            }              
                
        }
        public string Llamar()
        { return "Realizando llamada"; }

        public string Llamar(string contacto)
        {
            return "Realizando llamada a " + contacto;
        }


    }
}
