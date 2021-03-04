using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    class csPagoAutobus
    {
        public int alumnos = 0;
        public double precioUnitario = 0;
        public double precioTotal = 0;

        public csPagoAutobus() // Constructor Default
        {
            alumnos = 0;
            precioUnitario = 0;
            precioTotal = 0;
        }

        public csPagoAutobus(int alumnos) // Constructor con parametro
        {
            this.alumnos = alumnos;
            if (this.alumnos >= 100) { precioUnitario = 65; }
            else if (this.alumnos >= 50 && this.alumnos < 100) { precioUnitario = 70; }
            else if (this.alumnos >= 30 && this.alumnos < 50) { precioUnitario = 95; }
            else if (this.alumnos >= 1 && this.alumnos < 30) { precioUnitario = 4000 / this.alumnos; }
            precioTotal = precioUnitario * this.alumnos;
        }

        public double calcularPagoAutobus()
        {
            return precioTotal;
        }

        public double calcularPagoIndividual()
        {
            return precioUnitario;
        }
    }

}
