using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class csFormula
    {
        public double resultado = 0;
        public double calcularFormula(int p, int r, int n)
        {
            double r1 = Math.Pow(1 + r, n);
            resultado = p * (  (r * (r1)) / (r1 - 1)  );
            return resultado;
        }
    }
}
