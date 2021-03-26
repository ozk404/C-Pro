using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
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

        public static void abecedario()
        {
            string[] abc = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] vectorGuardaLetras = new string[abc.Length];
            Limpiar();
            Console.WriteLine("Bienvenido al menu del abecedeario");
            for (int i = 0; i < abc.Length; i++)
            {
                vectorGuardaLetras[i] = abc[i];
                Console.WriteLine(vectorGuardaLetras[i] + " guardado en espacio " + i);
            }


            Console.WriteLine("\nLas letras asignadas al vector son: ");
            for (int i = 0; i < vectorGuardaLetras.Length; i++)
            {
                Console.WriteLine(vectorGuardaLetras[i] + " asignado en espacio " + i);

            }
        }


        public static void notas()
        {
            int[,] notas = new int[4, 5];
            Limpiar();
            Console.WriteLine("Bienvenido al menu de asignacion de notas");
            Console.WriteLine("Se asignaran las notas de las siguientes asignaturas: ");
            Console.WriteLine("\n1) Matematica\n2)Inglés\n3)Programación\n4)Sociales\n5)Fisica");
            Pause();
            Limpiar();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Limpiar();
                    Console.WriteLine("Ingrese la nota " + (j + 1) + " del Curso " + (i + 1) + "\n");
                    Console.Write("Escribe la nota:  ");
                    int noxt = Convert.ToInt32(Console.ReadLine());
                    notas[j, i] = noxt;
                }
            }
            int pgn = 0;
            Limpiar();
            Console.WriteLine("Las notas ingresadas son las siguientes:\n");
            for (int i = 0; i < 5; i++)
            {
                int ac = 0;
                Console.WriteLine("Curso " + (i + 1) + ": ");
                Console.WriteLine("Nota 1\tNota 2\tNota 3\tNota 4\t\tPromedio:");
                for (int j = 0; j < 4; j++)
                {
                    ac += notas[j, i];
                    Console.Write(notas[j, i]);
                    Console.Write("\t");
                }
                int promedio = ac / 4;
                pgn += promedio;
                Console.Write("\t" + promedio);
                Console.WriteLine("\n\n");
            }
            pgn = pgn / 5;
            Console.WriteLine("Promedio General (5 clases 4 unidades): "+pgn+"\n");
        }

        public static void paresimpares()
        {
            int[] pares = new int[54];
            int[] inpares = new int[50];
            Limpiar();
            Console.WriteLine("Bienvenido al menu de numeros pares e impares");
            Pause();
            int np = 0, ni = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i%2==0){ pares[np] = i; np++; }
                else { inpares[ni] = i; ni++; }
            }
            Limpiar();
            Console.WriteLine("Numeros: pares:");
            for (int i = 0; i < 50; i++)
            {
                if (i % 10 == 0) { Console.Write("\n"); }
                Console.Write(pares[i]+"\t");
            }
            Console.WriteLine("");
            Console.WriteLine("\n\nNumeros: inpares:");
            for (int i = 0; i < 50; i++)
            {
                if (i % 10 == 0) { Console.Write("\n"); }
                Console.Write(inpares[i] + "\t");
            }


        }
        public static void matriz5()
        {
            int[,] nums = new int[5, 5];
            Limpiar();
            Console.WriteLine("Bienvenido al menu de matriz 5x5");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Limpiar();
                    Console.WriteLine("Ingrese un numero para la columna " + (j + 1) + " Fila " + (i + 1) + "\n");
                    Console.Write("Escribe el numero:  ");
                    int noxt = Convert.ToInt32(Console.ReadLine());
                    nums[j, i] = noxt;
                }
            }
            int sumf = 0, sumc = 0;
            Limpiar();
            Console.WriteLine("Las sumatorias son las siguientes:\n");
            Console.WriteLine("\tCol 1\tCol 2\tCol 3\tCol 4\tCol 5\tSuma Col\tSuma Fila");
            
            for (int i = 0; i < 5; i++) 
            {
                Console.Write("Fila "+(i+1)+"\t");
                for (int j = 0; j < 5; j++)
                {
                    sumc += nums[j, i];
                    sumf += nums[i, j];
                    Console.Write(nums[i, j]);
                    Console.Write("\t");
                }
                Console.Write("\t" + sumc);
                Console.Write("\t" + sumf);
                sumf = 0; sumc = 0;
                Console.WriteLine("\n");
            }

        }


        public static void multiplicar()
        {
            int[,] tabs = new int[10, 10];
            Limpiar();
            Console.WriteLine("Las Tablas son las siguientes:\n");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tabs[i, j] = ( (i+1) * (j+1) );
                }
            }
            Console.WriteLine("Numero\tTabla 1\tTabla 2\tTabla 3\tTabla 4\tTabla 5\tTabla 6\tTabla 7\tTabla 8\tTabla 9\tTabla 10");
            for (int i = 0; i < 10; i++){
                Console.Write((i+1)+ "\t");
                for (int j = 0; j < 10; j++) {
                    Console.Write(tabs[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine("\n");

        }
    }

static void Menu()
        {
            int opc; //Opcion del Menu
            do
            {


                Limpiar();
                Console.WriteLine("************************************");
                Console.WriteLine("Bienvenido a la tarea 4");
                Console.WriteLine("************************************\n");
                Console.WriteLine("Selecciona una opcion:\n");
                Console.WriteLine("1) Abecedario");
                Console.WriteLine("2) Asignacion de notas");
                Console.WriteLine("3) Numeros pares e Impares");
                Console.WriteLine("4) Matriz de 5x5");
                Console.WriteLine("5) Tablas de multiplicar");
                Console.WriteLine("6) Salir\n");
                Console.Write("Escribe el numero de tu eleccion:  ");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        abecedario();
                        break;
                    case 2:
                        notas();
                        break;
                    case 3:
                        paresimpares();
                        break;
                    case 4:
                        matriz5();
                        break;
                    case 5:
                        multiplicar();
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

