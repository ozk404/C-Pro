using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    class csSigma
    {
        public int n;
        public double sigma;
        public csSigma() // Constructor por defecto en caso de no enviar parametros
        {
            n = 0;
        }

        public csSigma(int n) // Constructor con parametros 
        {
            this.n = n;

        }

        static double factorial(double numero) //este metodo va a devolver un factorial
        {
            double i, acumulador;
            acumulador = 1;
            for (i = 1; i <= numero; i++) { acumulador *= i; }
            return acumulador;
        }

        public double calcularResultadoFormula(int i)
        {
                //la formula es ( 5^n * n! ) / ( 3^n ( n+1 )! ) 
                double numerador = (Math.Pow(5, i) * (factorial(i)));
                double dedominador = (Math.Pow(3, i) * (factorial(i + 1)));
                double resultado = numerador / dedominador; 
                sigma += resultado;  // Esta variable hara la sumatoria de cada uno de los resultados
            return resultado;
        }

        public double calcularSigma()
        {
            return sigma; // retornamos el valor de la sumatoria anterior (sigma)
        }

    }
}
