using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        protected static int origRow;
        protected static int origCol;
        protected static void Pos(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Limpiar();
                Console.WriteLine(e.Message);
            }
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

        static void Triangulos()
        {
            int a = 0, b = 0, c = 0;
            Limpiar();
            Console.WriteLine("Bienvenido a la clasificacion de los triangulos");
            Console.Write("Ingrese el lado A del triangulo: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIngrese el lado B del triangulo: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIngrese el lado C del triangulo: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a == b && b == c)
            {
                Console.WriteLine("El triangulo es: Equilatero");
            } else if ((a == b && b != c) || (a != b && b == c) || (a != b && b != c && a == c))
            {
                Console.WriteLine("El triangulo es: Isoseles");
            } else {
                Console.WriteLine("El triangulo es: Escaleno");
            }
        }

        static void CuotaLaboral()
        {
            double a = 0, b = 0, c = 0, d = 0;
            Limpiar();
            Console.WriteLine("Bienvenido a el calculo de cuota Laboral");
            Console.Write("Ingrese su salario neto mensual: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = (a * 0.0483); // Cuota Laboral
            c = (a * 0.01); // Cuota Patronal
            d = (a - (b + c)); // Salario Liquido
            Console.WriteLine("La couta laboral es de: Q" + b);
            Console.WriteLine("La couta patronal es de: Q" + c);
            Console.WriteLine("El sueldo liquido de Q" + d);
        }

        static void NumeroIntermedio()
        {
            int a = 0, b = 0, c = 0;
            int enme = 0;
            Limpiar();
            Console.WriteLine("Bienvenido al Numero Intermedio");
            Console.Write("Ingrese el primer Numero: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo Numero: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el tercer Numero: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (b > a && a > c || c > a && a > b)
            {
                enme = a;
            }
            if (a > b && b > c || c > b && b > a)
            {
                enme = b;
            }
            if (a > c && c > b || b > c && c > a)
            {
                enme = c;
            }
            Console.WriteLine("\nEl numero intermedio es: "+enme);
        }

        static void FormulaNR()
        {
            Limpiar();
            int n, r, nnrr;
            long nr = 1, fn = 1, fr = 1, tot;
            Console.WriteLine("Bienvenido a Formula de Notacion Matematica");
            Console.Write("Ingrese el valor para n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el valor para r: ");
            r = Convert.ToInt32(Console.ReadLine());
            if (n > 0 && r > 0) {
            nnrr = n - r;
            for (int i = 1; i <= nnrr; i++) { nr *= i; }
            for (int i = 1; i <= n; i++) { fn *= i; }
            for (int i = 1; i <= r; i++) { fr *= i; }
            tot = (fn / (fr * nr) );
            Console.WriteLine("Resultado de la formula n!/r! (n-r)! : "+tot);
            }
            else
            {
            Console.WriteLine("Los datos ingresados no son validos");
            }
        }

        static void noINE() { 
            Limpiar();
            int a = 0;
            string clas = "";
            Console.WriteLine("Bienvenido a la clasificacion del INE");
            Console.Write("Ingrese una edad para clasificar ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                if (a <= 5) { clas = "Bebe"; }
                else if (a >= 6 && a <= 12) { clas = "Niño"; }
                else if (a >= 13 && a <= 17) { clas = "Adolecente"; }
                else if (a >= 18 && a <= 50) { clas = "Adulto"; }
                else if (a >= 51) { clas = "Anciano"; }
                Console.WriteLine("La categoria de la edad "+a+" es: "+clas);
            }
            else
            {
                Console.WriteLine("El dato ingresado no es valido");
            }
        }

        static void Tablas()
        {
            Limpiar();
            Console.WriteLine("Bienvenido a las tablas de multiplicar:\n\n");
            int tbs;
            for (int i = 1; i <= 10; i++) //Contador de tabla actual
            {
                for (int ij = 1; ij <= 10; ij++) //Contador de tabla actual hasta 10
                {
                    tbs = ij * i;
                    Console.WriteLine(i + " * " + ij + " = " + tbs);
                }
                Console.WriteLine("____________________________________________"); // Separador
            }
        }

        static void Equipos(){
            string no1, no2;
            int p1, p2;
            Limpiar();
            Console.WriteLine("Bienvenido al menu de Equipos de futbol:\n\n");
            Console.Write("Ingrese el nombre del equipo 1: ");
            no1 = Console.ReadLine();
            Console.Write("\nIngrese el punteo del equipo 1: ");
            p1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIngrese el nombre del equipo 2: ");
            no2 = Console.ReadLine();
            Console.Write("\nIngrese el punteo del equipo 2: ");
            p2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(no1 + " (" + p1 + ") vs " + no2 + "(" + p2 + ")");
            if (p1 > p2){ Console.WriteLine("Ganador: " + no1 + " (" + p1 + ")");   }
            else if (p2 > p1){ Console.WriteLine("Ganador: " + no2 + " (" + p2 + ")"); }
            else{ Console.WriteLine(no1 + " y " + no2 + " Empataron"); }
        }


        static void Billetes()
        {
            int b1, b5, b10, b20, b50, b100, cant;
            Limpiar();
            Console.WriteLine("Bienvenido a la opcion de cuenta de Billetes:\n\n");
            Console.Write("Ingrese el monto a desglozar en billetes: ");
            cant = Convert.ToInt32(Console.ReadLine());
            b100 = (cant - cant % 100) / 100; // Total de billetes de 100
            b50 = (cant - cant % 50) / 50;// Total de billetes de 50
            b20 = (cant - cant % 20) / 20;// Total de billetes de 20
            b10 = (cant - cant % 10) / 10;// Total de billetes de 10
            b5 = (cant - cant % 5) / 5;// Total de billetes de 5
            b1 = cant; // Total de billetes de 1
            Console.WriteLine("Billetes de 100 Quetzales: " +b100);
            Console.WriteLine("Billetes de 50 Quetzales: " + b50);
            Console.WriteLine("Billetes de 20 Quetzales: " + b20);
            Console.WriteLine("Billetes de 10 Quetzales: " + b10);
            Console.WriteLine("Billetes de 5 Quetzales: " + b5);
            Console.WriteLine("Billetes de 1 Quetzales: " + b1);


        }

        static void SueldoTrab()
        {
            string no;
            double h, hn = 8, he, ph, tot, tothe, totf;
            Limpiar();
            Console.WriteLine("Bienvenido al menu de Sueldo de un trabajador    :\n\n");
            Console.Write("Ingrese el nombre del Trabajador: ");
            no = Console.ReadLine();
            Console.Write("\nIngrese las horas trabajadas el dia de hoy: ");
            h = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIngrese el pago por Hora individual: ");
            ph = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Estos son los datos del trabajador "+no);
            Console.WriteLine("Horas trabajadas totales: "+h);
            
            if (h > hn) {
                he = (h - hn);
                tot = (hn * ph);
                tothe = (he * ph)*1.5;
                totf = tot + tothe;
                Console.WriteLine("Horas en jornada: " + hn + "hrs | Total efectivo: Q"+tot );
                Console.WriteLine("Horas extras (1.5): " + he + "hrs | Total efectivo: Q" + tothe); 
                Console.WriteLine("Total a pagar: " + totf);
            }
            else
            {
                tot = (h * ph);
                Console.WriteLine("Horas en jornada: " + h + "hrs | Total: Q" + tot);
                Console.WriteLine("Total a pagar: " + tot);
            }

        }

        static void Sumatoria()
        {
            int forxdec;
            decimal forx, sm = 0;
            Limpiar();
            Console.WriteLine("Bienvenido a la Sumatoria:");
            Console.WriteLine("A continuacion se le dara una visualizacion de la formula Sigma(1/n(n+2)\n");
            for (int i = 1; i <= 4; i++) {
                forx = 1m / ((i * (i + 2)));
                forxdec = i * (i + 2); // Dedominador de la fraccion
                Console.WriteLine("Si n=" + i + ", la formula queda como 1/(" + i + "*(" + i + "+2))");
                Console.WriteLine("Resultado entero: " + forx);
                Console.WriteLine("Resultado en fraccion: 1/" + forxdec + "\n\n");
                sm += forx;
            }
            Console.WriteLine("Resultado de la sumatoria total: " + sm );

        }


            static void Menu()
        {
            int opc; //Opcion del Menu
            do
            {


                Limpiar();
                Console.WriteLine("************************************");
                Console.WriteLine("Bienvenido a la tarea 1");
                Console.WriteLine("************************************\n");
                Console.WriteLine("Selecciona una opcion:\n");
                Console.WriteLine("1) Clasificacion Triangulos");
                Console.WriteLine("2) Couta Laboral");
                Console.WriteLine("3) Numero Intermedio");
                Console.WriteLine("4) Formula Notacion Matematica (N y R)");
                Console.WriteLine("5) Billetes de 100");
                Console.WriteLine("6) Clasificacion INE");
                Console.WriteLine("7) Sueldo diario de un trabajador");
                Console.WriteLine("8) Formula de una sumatoria");
                Console.WriteLine("9) Equipos de Futbol");
                Console.WriteLine("10) Tablas de multiplicar");
                Console.WriteLine("11) Salir del programa\n");
                Console.Write("Escribe el numero de tu eleccion:  ");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Triangulos();
                        break;
                    case 2:
                        CuotaLaboral();
                        break;
                    case 3:
                        NumeroIntermedio();
                        break;
                    case 4:
                        FormulaNR();
                        break;
                    case 5:
                        Billetes();
                        break;
                    case 6:
                        noINE();
                        break;
                    case 7:
                        SueldoTrab();
                        break;
                    case 8:
                        Sumatoria();
                        break;
                    case 9:
                        Equipos();
                        break;
                    case 10:
                        Tablas();
                        break;
                    case 11:
                        Limpiar();
                        Console.WriteLine("El programa ha finalizado correctamente");
                        break;
                }
                Pause();
            } while (opc != 11);
    }

    }



}
