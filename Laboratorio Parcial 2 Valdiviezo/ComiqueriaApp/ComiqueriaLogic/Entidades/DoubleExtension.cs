using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public static class DoubleExtension
    {

        public static string FormatearPrecio(this double precio, double precio2)
        {
            string retorno = "$";
            int auxPrecio = (int)precio;
            retorno += auxPrecio;
            return retorno;
        }
    }
}
