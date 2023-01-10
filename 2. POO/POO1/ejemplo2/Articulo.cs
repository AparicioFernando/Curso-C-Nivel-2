using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Articulo
    {
        /*
            -Código Articulo (3 digitos no correlativos)
            -Precio
            -Código de Marca (1 al 10)
        
        private int codArticulo;
        private float precio;
        private int codMarca;
        */

        public int CodigoArticulo { get; set; }
        public int Precio { get; set; }

        private int codMarca;
        public int CodigoMarca
        { 
            get { return codMarca; }
            set 
            { 
                if (codMarca>0 && codMarca<11)
                    codMarca = value; 
                else
                    codMarca = -1;
            }
        }
    }
}
