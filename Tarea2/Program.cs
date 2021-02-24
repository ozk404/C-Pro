using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu(); 
        }
        public static void Limpiar()
        {
            System.Console.Clear();
        }
        public static void Pause()
        {
            Console.Write("\nPresiona una tecla para continuar . . . ");
            Console.ReadKey();
        }

        public static void NumerosPerfectos()
        {
            Limpiar();
            int a;
            Console.WriteLine("Bienvenido a la opcion para calcular Numeros Perfecto");
            Console.Write("Ingrese un número entero: ");
            a = Convert.ToInt32(Console.ReadLine());
            csPerfecto npf = new csPerfecto();
            if (npf.calcularPerfecto(a) == true){Console.WriteLine("\n" + a + " Es perfecto");}
            else{Console.WriteLine("\n" + a + " No es perfecto");}

        }

        public static void Semana() {
            Limpiar();
            int dia;
            Console.WriteLine("Bienvenido a la opcion para calcular el Dia de la Semana");
            Console.Write("Ingrese un número entre 1 y 7: ");
            dia = Convert.ToInt32(Console.ReadLine());
            if (dia >= 1 && dia <= 7) { 
            csSemana sem = new csSemana();
            Console.WriteLine("\n" + dia + " Equivale al dia "+ sem.calcularDia(dia));
            }else { Console.WriteLine("\nNo se ingreso un numero valido"); }
        }

        public static void Fibonacci()
        {
            Limpiar();
            int limit;
            Console.WriteLine("Bienvenido a la opcion para calcular la serie Fibonacci");
            Console.Write("Ingresa limite de la serie fibonacci: ");
            limit = Convert.ToInt32(Console.ReadLine());
            csFibonacci fibo = new csFibonacci();
            Console.WriteLine("\nLa serie es la siguiente:\n");
            foreach (var item in fibo.calcularFibonacci(limit))
            {
                Console.Write(item + ", ");
            }
        }

        public static void Formula()
        {
            Limpiar();
            int p, r, n;
            Console.WriteLine("Bienvenido a la opcion para calcular la formula");
            Console.Write("Ingrese el valor de P: ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIngrese el valor de r: ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIngrese el valor de n: ");
            n = Convert.ToInt32(Console.ReadLine());
            csFormula formula = new csFormula();
            double cla = formula.calcularFormula(p, r, n);
            Console.WriteLine("El resultado de la formula es: "+cla);
        }

        public static void Bisiesto()
        {
            Limpiar();
            int age;
            Console.WriteLine("Bienvenido a la opcion para calcular si un año es bisiesto");
            Console.Write("Ingresa año a calcular: ");
            age = Convert.ToInt32(Console.ReadLine());
            csBisiesto bis = new csBisiesto();
            bool calcuBis = bis.calcularBisiesto(age);
            if (calcuBis == true) { Console.WriteLine("\nEl año (" + age + ") es Bisiesto"); }
            else { Console.WriteLine("\nEl año (" + age + ") No es Bisiesto"); }
        }
   

        static void Menu()
        {
            int opc; //Opcion del Menu
            do
            {


                Limpiar();
                Console.WriteLine("************************************");
                Console.WriteLine("Bienvenido a la tarea 2");
                Console.WriteLine("************************************\n");
                Console.WriteLine("Selecciona una opcion:\n");
                Console.WriteLine("1) Numeros Perfectos");
                Console.WriteLine("2) Semana estructurada");
                Console.WriteLine("3) Fibbonacci");
                Console.WriteLine("4) Desarrollo de Formula");
                Console.WriteLine("5) Año bisiesto");
                Console.WriteLine("6) Salir del programa\n");
                Console.Write("Escribe el numero de tu eleccion:  ");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        NumerosPerfectos();
                        break;
                    case 2:
                        Semana();
                        break;
                    case 3:
                        Fibonacci();
                        break;
                    case 4:
                        Formula();
                        break;
                    case 5:
                        Bisiesto();
                        break;
                    case 6:
                        Limpiar();
                        Console.WriteLine("El programa ha finalizado correctamente");
                        break;
                }
                Pause();
            } while (opc != 6);
        }


    }
}


