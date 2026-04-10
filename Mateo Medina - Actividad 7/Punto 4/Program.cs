using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    /*
     Cargar un vector de 10 elementos y verificar posteriormente si el mismo está
     ordenado de menor a mayor y de mayor a menor.
     */



    internal class programa    

    {

        private int[] vector;

        public void cargar()
        {
            string linea;

            vector = new int[10];

            for (int i = 0; i < 10; i++)
            {



                Console.WriteLine("Ingrese los valores del vector");
                linea = Console.ReadLine();
                vector[i] = int.Parse(linea);
            }
        }

            public void calcular()
        {
            bool ascendente = true;
            bool descendente = true;

            for (int f = 0; f < 9; f++)
            {

                if (vector[f] > vector[f+1])
                {
                    ascendente = false;
                }

                if (vector[f] < vector[f + 1])
                {
                    descendente = false;
                }

            }

            if(ascendente == true){
                Console.WriteLine("El vector esta ordenado de menor a mayor ");
                
            }else if(descendente == true){
                Console.WriteLine("El vector esta ordenado de mayor a menor ");
                
            } else
            {
                Console.WriteLine("El vector no esta ordenado");
                
            }
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
