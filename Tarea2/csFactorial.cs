using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programación_OO
{
    class csFactorial
    {
        //campos o atributos 
        public double numero;


        //contructor
        public csFactorial(double n)           //llenando la clase con un dato //función de parametro o valor
        {
            this.numero = n;                 //se le asignada el campo o atributo que tiene la clase, en este caso NUMERO
        }

        //metodos -- funciones //encapsulamiento (public, private, protected) //encargado de dar una respuesta
        public double factorial()               //este metodo va a devolver un double como respuesta //función de parametro o valor
        {
            double i, acumulador;
            acumulador = 1;


            for (i = 1; i <= numero; i++)
            {
                acumulador = acumulador * i;
            }

            return acumulador; //Devuelve las respuestas
        }



    }
}
