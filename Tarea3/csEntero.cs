using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    class csEntero
    {
        int numero;
     public csEntero() // Asignacion de valores por defecto
        {
            numero = 0;
        }
        public csEntero(int numero) // Asignacion de valores por defecto
        {
            this.numero = numero;
        }

        public string calcularPositivo()
        {
            string tipoNumero = "";
            if (numero > 0) { tipoNumero = "Positivo"; }
            else if (numero < 0) { tipoNumero = "Negativo"; }
            else{ tipoNumero = "Neutro"; }
            return tipoNumero;
        }
    }
}
