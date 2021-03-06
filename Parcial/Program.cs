using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    class Program
    {
        public static void Limpiar()
        {
            System.Console.Clear();
        }

        static void Sigma()
        {
            int n = 0;
            double sigma = 0;
            Console.WriteLine("Se resolvera la ecuación matemática de Convergencia o Divergencia");
            Console.WriteLine("Esta operacion incluye un sigma con una repeticion de 1 hasta el infinito");
            Console.Write("\nIngrese cuantas operaciones desea realizar (valor de n): ");
            n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nLa formula a resolver es la siguiente: ( 5^n * n! ) / ( 3^n ( n+1 )! )\n");
            csSigma formula = new csSigma(n);
            for (int i = 1; i <= n; i++)
            {
                double resultado = formula.calcularResultadoFormula(i); // Hacemos el llamado al metodo dentro de la clase
                string operacion = "Si n=" + i + " Entonces: ( 5^" + i + " * " + i + "! ) / ( 3^" + i + " * ( " + i + "+1 )! )";
                Console.WriteLine(operacion + " = " + resultado);
            }
            sigma = formula.calcularSigma();
            Console.WriteLine("\n-----------------------------------------------------------------------------------------");
            Console.WriteLine("El resultado de la sumatoria de los resultados (sigma) es: " + sigma);
            Console.WriteLine("-----------------------------------------------------------------------------------------\n");
        }

        static void Main(string[] args)
        {
            int opc = 1;
            do
            {
                Limpiar();
                Console.WriteLine("Bienvenido al examen parcial");
                Sigma();
                Console.WriteLine("\nPresione 1 para realizar otra formula o presione cualquier otro numero para salir.");
                Console.Write("¿Que opcion desea tomar?: ");
                opc = Int32.Parse(Console.ReadLine());
            } while (opc == 1);
        }
    }
}
