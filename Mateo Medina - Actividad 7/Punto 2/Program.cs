using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    internal class programa
    {

        /*
         2. Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
        elementos. Obtener la suma de los dos vectores, dicho resultado guardarlo en un
        tercer vector del mismo tamaño. Sumar componente a componente.
         */

        private int[] vector1;
        private int[] vector2;
        private int[] vectorRes;

        public void Cargar()
        {
            vector1 = new int[4];
            vector2 = new int[4];

            string linea;
            for(int i = 0;i<4; i++){ 
                Console.WriteLine("Ingrese un valor para el primer vector");
                linea = Console.ReadLine();
                vector1[i] = int.Parse(linea);
            }

            for (int f = 0; f < 4; f++)
            {
                Console.WriteLine("Ingrese un valor para el segundo vector");
                linea = Console.ReadLine();
                vector2[f] = int.Parse(linea);

            }

        }

        public void sumar()
        {
            vectorRes = new int[4];

            
            for (int i = 0; i < 4; i++)
            {
                vectorRes[i] = vector1[i] + vector2[i];
            }


            
            
        }

        public void mostrar()
        {
            for (int i = 0; i < vectorRes.Length; i++)
            {
                Console.WriteLine("Los Resultados de las sumas de los valores son " + vectorRes[i]);
            }

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            programa programa = new programa();

            programa.Cargar(); 
            programa.sumar();
            programa.mostrar();
        
        }
    }
}
