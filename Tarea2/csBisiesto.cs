using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class csBisiesto
    {
        bool esBisiesto = false;
        public bool calcularBisiesto(int age)
        {
            if (age % 4 == 0 && (age % 100 != 0 || age % 400 == 0)){esBisiesto = true;}
            else{esBisiesto = false;}
            return esBisiesto;
        }
    }
}
