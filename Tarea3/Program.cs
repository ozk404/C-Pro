using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    class Program
    {
        public static void Limpiar()
        {
            System.Console.Clear();
        }
        public static void Pause()
        {
            Console.Write("\nPresiona una tecla para continuar . . . ");
            Console.ReadKey();
        }

        public static void ViajeEstudios()
        {
            int a = 0;
            Limpiar();
            Console.WriteLine("Bienvenido a la opción para calcular un vieje\n");
            Console.Write("Ingrese la cantidad de alumnos: ");
            a = Int32.Parse(Console.ReadLine());
            csPagoAutobus Cant = new csPagoAutobus(a);
            Console.WriteLine("\nEl precio total del viaje para " + a + " Alumnos es: "+ Cant.calcularPagoAutobus());
            Console.WriteLine("El precio unitario del viaje para " + a + " Alumnos es: " + Cant.calcularPagoIndividual());
        }

        public static void PersonaMenor()
        {
            Dictionary<string, int> Personas = new Dictionary<string, int>(); //Diccionario que guarda los datos
            Limpiar();
            Console.WriteLine("Bienvenido a la opción para calcular la persona con menor edad\n");
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("\nIngrese el nombre de la persona numero " + i + ": ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese la edad de la persona numero " + i + ": ");
                int edad = Int32.Parse(Console.ReadLine());
                Personas.Add(nombre, edad);
            }
            csEdad Eda = new csEdad(Personas);
            Console.WriteLine("\n\n"+ Eda.calcularEdad());

        }
        public static void EnteroTipo()
        {
            int numero = 0;
            Limpiar();
            Console.WriteLine("Bienvenido a la opción para determinar el tipo de numero\n");
            Console.Write("Ingrese el numero entero: ");
            numero = Int32.Parse(Console.ReadLine());
            csEntero Tipo = new csEntero(numero);
            Console.WriteLine("\nEl Numero " + numero + " es de tipo: " + Tipo.calcularPositivo());

        }       
        public static void VolumenCilindro()
        {
            double r = 0, h=0;
            Limpiar();
            Console.WriteLine("Bienvenido a la opción para determinar el volumen de un cilindro\n");
            Console.Write("Ingrese el radio (Valor de r): ");
            r = double.Parse(Console.ReadLine());
            Console.Write("\nIngrese el radio (Valor de h): ");
            h = double.Parse(Console.ReadLine());
            csVolumen Volumen = new csVolumen(r,h);
            Console.WriteLine("\nEl Volumen del cilindro es: "+Volumen.calcularVolumen());
        }
        public static void MCD()
        {
            int n = 0;
            Limpiar();
            Console.WriteLine("Bienvenido a la opción para determinar el MCD\n");
            Console.Write("Ingrese un numero entero: ");
            n = Int32.Parse(Console.ReadLine());
            csMCD MCD = new csMCD(n);
            Console.WriteLine("\nLa serie de numeros del MCD de "+n+" es:\n");
            foreach (var item in MCD.calcularMCD())
            {
                Console.Write(item + ", ");
            }
            Console.Write("= MCD(" + n+")");
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            Menu();
        }


        static void Menu()
        {
            int opc; //Opcion del Menu
            do
            {
                Limpiar();
                Console.WriteLine("************************************");
                Console.WriteLine("Bienvenido a la tarea 3");
                Console.WriteLine("************************************\n");
                Console.WriteLine("Selecciona una opcion:\n");
                Console.WriteLine("1) Viaje de estudios,");
                Console.WriteLine("2) Nombre y edad de 3 personas");
                Console.WriteLine("3) Entero positivo o negativo");
                Console.WriteLine("4) Volumen de un Cilindro");
                Console.WriteLine("5) Maximo Comun Divisor de un numero");
                Console.WriteLine("6) Salir del programa\n");
                Console.Write("Escribe el numero de tu eleccion:  ");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        ViajeEstudios();
                        break;
                    case 2:
                        PersonaMenor();
                        break;
                    case 3:
                        EnteroTipo();
                        break;
                    case 4:
                        VolumenCilindro();
                        break;
                    case 5:
                        MCD();
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

