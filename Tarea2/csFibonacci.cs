using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class csFibonacci
    {
        public List<int> listadoFibo = new List<int>();
        public List<int> calcularFibonacci(int limite)
        {

            int a = 0, b = 1, c;
            listadoFibo.Add(0);
            for (int i = 0; i < limite-1; i++)
            {
                c = a;
                a = b;
                b = c + a;
                listadoFibo.Add(a);
            }

            return listadoFibo;
        }
    }
}
