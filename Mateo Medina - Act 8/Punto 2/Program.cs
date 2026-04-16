using Punto_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    internal class ordenarPaises
    {

        /*
         2. Definir un vector donde almacenar los nombres de 5 países. Confeccionar el
            algoritmo de ordenamiento alfabético.
         */

        private string[] paises = new string[5];
        private string[] ordenado = new string[5];


        public void Cargar()
        {
            string linea; ;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el nombre de un pais");
                linea = Console.ReadLine();
                paises[i] = linea;
            }
        }

        public void Ordenar()
        {
           
            for (int i = 0; i < paises.Length; i++)
            {
                ordenado[i] = paises[i];
            }

            
            for (int i = 0; i < ordenado.Length - 1; i++)
            {
                for (int j = 0; j < ordenado.Length - 1 - i; j++)
               
                {
                    if (string.Compare(ordenado[j], ordenado[j + 1], ignoreCase: true) > 0)
                    {
                        
                        string aux = ordenado[j];
                        ordenado[j] = ordenado[j + 1];
                        ordenado[j + 1] = aux;
                    }
                }
            }

            
            Console.WriteLine("Paises ordenados alfabéticamente:");
            for (int i = 0; i < ordenado.Length; i++)
            {
                Console.WriteLine(ordenado[i]);
            }
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
        ordenarPaises op = new ordenarPaises();
        op.Cargar();
        op.Ordenar();


}
    }
}
