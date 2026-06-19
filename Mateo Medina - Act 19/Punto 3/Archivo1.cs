using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    partial class Arcade
    {
        private string nombrejuego;
        private int PuntajeMaximo;
        private int NivDif;

        public string ObtenerNombre
        {
            get { return nombrejuego; }
            set { nombrejuego = value; }
        }

        public int ObtenerPuntaje
        {
            get { return PuntajeMaximo; }
            set { PuntajeMaximo = value; }

        }

        public int ObtenerDificultad
        {
            get { return NivDif; }
            set { NivDif = value; }
        }

        public Arcade()
        {
            string linea;

            Console.WriteLine("Ingrese el nombre del juego");
            linea = Console.ReadLine();
            nombrejuego=linea;

            Console.WriteLine("Ingrese su puntaje maximo");
            linea = Console.ReadLine();
            PuntajeMaximo = int.Parse(linea);

            Console.WriteLine("ingrese el nivel de dificultad (entre 1 y 5)");
            linea = Console.ReadLine();
            NivDif = int.Parse(linea);

            if (NivDif < 1 || NivDif > 5)
            {
                do
                {
                    Console.WriteLine("Entre 1 y 5 dije");
                    linea = Console.ReadLine();
                    NivDif = int.Parse(linea);

                } while (NivDif < 1 || NivDif > 5);

            }

        }
    }
}
