using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    partial class Arcade
    {
        int record = 5000;

        public void CalcularRecord()
        {
            if (PuntajeMaximo > record)
            {
                record = PuntajeMaximo;

                Console.WriteLine("El puntaje de " + nombrejuego + " ah superado el record");

            }
            else
            {
                Console.WriteLine("El puntaje de " + nombrejuego + " no ah superado el record");
            }

        }

    }
}
