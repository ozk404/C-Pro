using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    class csMCD
    {
        public int numero;
        public List<int> Lista = new List<int>();

        public csMCD()
        {
            numero = 0;
        }

        public csMCD(int numero)
        {
            this.numero = numero;
        }

        public List<int> calcularMCD()
        {          
            int cn = 2;
            do
            {
              if (numero % cn == 0) { numero /= cn; Lista.Add(cn);} else { cn++; }
            } while (numero!=1);
            return Lista;
        }

    }
}
