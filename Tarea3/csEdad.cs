using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    class csEdad
    {
        public Dictionary<string, int> Personas = new Dictionary<string, int>();

        public csEdad()
        {
            for (int i = 0; i < 3; i++) { Personas.Add("No valido",0); } // Valores Default Nombres
        }
        public csEdad(Dictionary<string, int> Personas)  // Asignacion de datos al diccionario
        {
            foreach (KeyValuePair<string, int> Dato in Personas)
            {
                this.Personas.Add(Dato.Key, Dato.Value);
            }

        }

        public string calcularEdad()
        {
            int mn = Personas.Values.ElementAt(0);
            string nm = Personas.Keys.ElementAt(0);
            foreach (KeyValuePair<string, int> Dato in Personas)
            {
                if (Dato.Value < mn) { mn = Dato.Value; nm = Dato.Key; }
                
            }
            return "La persona con nombre " + nm + " es la menor con "+mn+" años";
        }



    }
}
