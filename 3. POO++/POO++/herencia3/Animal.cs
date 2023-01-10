using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    internal class Animal
    {
        public virtual string comunicarse() //para que un metodo se pueda sobreescribir tiene que ser "public virtual"
        {
            return "ruido... ruido...";
        }
    }
}
