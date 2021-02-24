using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class csSemana
    {
        string retorno = "";
        public string calcularDia(int dia)
        {
            switch (dia)
            {
                case 1:
                    retorno = "Lunes";
                    break;
                case 2:
                    retorno = "Martes";
                    break;
                case 3:
                    retorno = "Miercoles";
                    break;
                case 4:
                    retorno = "Jueves";
                    break;
                case 5:
                    retorno = "Viernes";
                    break;
                case 6:
                    retorno = "Sabados";
                    break;
                case 7:
                    retorno = "Domingos";
                    break;
                default:
                    retorno = "No Valido";
                    break;
            }

            return retorno;
        }
    }
}
