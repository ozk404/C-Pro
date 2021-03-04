using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    class csVolumen
    {
        double r,h,v;
        public csVolumen()
        {
            r = 0;
            h = 0;
            v = 0;
        }

        public csVolumen(double r, double h)
        {
            this.r = r;
            this.h = h;
        }

        public double calcularVolumen()
        {
            v = Math.PI * ( Math.Pow(r, 2) * h);
            return v;
        }
    }
}
