using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    internal class imprimirMenor
    /*
         1. Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro
        del vector.
     */

    {

        private int[] vector;

        public void cargar()
        {
            
            string linea;
            Console.WriteLine("Ingrese la distancia del vector: ");
            linea = Console.ReadLine();
            vector = new int[int.Parse(linea)];

            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Ingrese un valor para el vector ");
                linea = Console.ReadLine();
                vector[i] = int.Parse(linea);

                for (int j = 0; j < i; j++)
                {
                    if (vector[j] == vector[i])
                    {
                        Console.WriteLine("Ese valor ya fue ingresado anteriormente.");

                    }

                }
            }
        }
        public void calcular()
        {

            int menor = vector[0];

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] < menor)
                {
                    menor = vector[i];
                }

            }


            Console.WriteLine("El valor menor es " + menor);

            Console.ReadKey();
        }

        


        static void Main(string[] args)
        {

            imprimirMenor imp = new imprimirMenor();
            imp.cargar();
            imp.calcular();
        }
    }
}
