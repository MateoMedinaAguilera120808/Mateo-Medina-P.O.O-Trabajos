using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_1
{

    /*
     1. Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
        El valor acumulado de todos los elementos del vector.
        El valor acumulado de los elementos del vector que sean mayores a 36.
        Cantidad de valores mayores a 50.
     */


    internal class programa
    {
        private int[] valores;
        private int mayores50 = 0;
        private int suma36 = 0;
        
        

        public void Cargar()
        {
            valores = new int [8];
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("ingrese un valor ");
                string linea;
                linea = Console.ReadLine();
                valores[i] = int.Parse(linea);




            }
        }

        public void sumaTotal() {

            int suma = 0;

            for (int f = 0; f < 8; f++)
            {
                suma = suma + valores[f];

                if (valores[f] > 36)
                {
                    suma36 = suma36 + valores[f];


                }

                if (valores[f] > 50)
                {
                    mayores50++;
                }
            }
        

            Console.WriteLine("El total de suma de los valores es " + suma );
            Console.WriteLine("La suma total de valores MAYORES  a 36 es de " + suma36);
            Console.WriteLine("La cantidad de valores mayores a 50 es de " + mayores50);
            Console.ReadKey();
        
        }

        

            



        static void Main(string[] args)
        {
            programa programa = new programa();
            programa.Cargar();
            programa.sumaTotal();

        }
    }
}
