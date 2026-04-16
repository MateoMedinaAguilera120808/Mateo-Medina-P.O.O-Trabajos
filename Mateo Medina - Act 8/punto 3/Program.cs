using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{
    /*
     
     3. Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector
        (el orden lo pueden elegir ustedes).
     */

    internal class Ordenador
    {

        private int[] vector;
        private int[] ordenado;
        

        public void cargar()
        {
            string linea;

            Console.WriteLine("Ingrese la distancia del vector: ");
            linea = Console.ReadLine();
            vector = new int[int.Parse(linea)];
            ordenado = new int[int.Parse(linea)];

            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Ingrese un valor para el vector ");
                linea = Console.ReadLine();
                vector[i] = int.Parse(linea);
            }


        }

        public void Ordenar() {

            for (int i = 0; i < vector.Length; i++)
            {
                ordenado[i] = vector[i];
            }


            for (int i = 0; i < ordenado.Length - 1; i++)
            {
                for (int j = 0; j < ordenado.Length - 1 - i; j++)
                {
                    if (ordenado[j] > ordenado[j + 1])
                    {
                        int aux = ordenado[j];
                        ordenado[j] = ordenado[j + 1];
                        ordenado[j + 1] = aux;
                    }
                }
            


        }

            for (int i = 0; i < ordenado.Length; i++)
            {
                Console.WriteLine(ordenado[i]);
            }
        
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            Ordenador or = new Ordenador();
            or.cargar();
            or.Ordenar();

        }
    }
}
