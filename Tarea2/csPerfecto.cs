using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea2
{
    class csPerfecto
    {
        public bool Perfecto = false; 
        public bool calcularPerfecto(int n)
        {
            int cn =0;
            for (int i = 1; i <= n/2; i++)
            {
                if (n % i == 0){cn += i;}
            }
            if (cn == n){ Perfecto = true;}
            else{ Perfecto = false;} 
            return Perfecto;
        }
    }

}

