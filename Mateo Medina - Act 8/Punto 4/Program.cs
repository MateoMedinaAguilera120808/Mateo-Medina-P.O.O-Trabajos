using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    /*
     4. Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
        habitantes de este. Ordenar alfabéticamente e imprimir los resultados. Por último
        ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir
        nuevamente.
     */


    internal class Paralelos
    {
        private int[] CantidadHabitantes = new int[5];
        private string[] Paises = new string[5];
        private string[] OrdenadoPa = new string[5];
        private int[] OrdenadoCant = new int[5];


        string linea;
        public void Cargar()
        {
            for(int i = 0; i < Paises.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del pais");
                linea = Console.ReadLine();
                Paises[i] = linea;
                Console.WriteLine("Ingrese la cantidad de habitantes del mismo ");
                linea = Console.ReadLine();
                CantidadHabitantes[i] = int.Parse(linea);
            }
        }


        public void Calcular()
        {

            for (int i = 0; i < Paises.Length; i ++)
            {
                OrdenadoCant[i] = CantidadHabitantes[i];
                OrdenadoPa[i] = Paises[i];
            }



            for (int i =0; i<Paises.Length - 1 ; i++)
            {
                for (int f = 0; f < Paises.Length - 1 - i; f++ ) {


                    if (string.Compare(OrdenadoPa[f], OrdenadoPa[f + 1], ignoreCase: true) > 0)
                    {

                        string aux = OrdenadoPa[f];
                        OrdenadoPa[f] = OrdenadoPa[f + 1];
                        OrdenadoPa[f + 1] = aux;
                    }

                    if (OrdenadoCant[f] < OrdenadoCant[f + 1])
                    {
                        int aux = OrdenadoCant[f];
                        OrdenadoCant[f] = OrdenadoCant[f + 1];
                        OrdenadoCant[f + 1] = aux;

                    }


                
                }
                
            }


            for (int i = 0; i < Paises.Length; i++) {
                Console.WriteLine(OrdenadoPa[i]);
            }
            for (int i = 0; i < Paises.Length; i++)
            {
                Console.WriteLine(OrdenadoCant[i]);
            }

            
            Console.ReadKey();
        }



        static void Main(string[] args)
        {
            Paralelos Pl = new Paralelos();
            Pl.Cargar();
            Pl.Calcular();

        }
    }
}
