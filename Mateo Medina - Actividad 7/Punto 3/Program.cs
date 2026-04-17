using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    /*
     3. Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas de
        un videojuego. El programa debe:
        Mostrar la puntuación más alta y la más baja.
        Calcular el promedio de puntuación.
        Contar cuántas veces superó los 500 puntos.
     */

    internal class programa
    {
        private int[] puntuaciones;

        public void cargar()
        {
            puntuaciones = new int[6];
            string linea;

            for (int i = 0; i<6; i++) { 
            Console.WriteLine("Ingrese su puntuacion");
            linea = Console.ReadLine();
            puntuaciones[i] = int.Parse(linea);
            
            }

        }

        public void calcular()
        {
            int suma = 0;
            float promedio = 0;
            int superar500 = 0;
            int masAlta = 0;
            int masBaja = puntuaciones[0];


            for (int i = 0; i < 6; i++)
            {

                suma = suma + puntuaciones[i];

                if (masAlta < puntuaciones[i])
                {
                    masAlta = puntuaciones[i];
                }
                else if (masBaja > puntuaciones[i])
                {
                    masBaja = puntuaciones[i];
                }

                if (puntuaciones[i] > 500)
                {
                    superar500++;
                }

            }



            promedio = suma / 6;

            Console.WriteLine("La puntuacion mas alta es " + masAlta + " y la puntuacion mas baja fue " + masBaja);
            Console.WriteLine("El promedio de la puntuacion fue de " + promedio);
            Console.WriteLine("Se supero la puntuacion 500 en " + superar500 + " ocasiones ");




            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            programa programa = new programa();
            programa.cargar();
            programa.calcular();
        }
    }
}
