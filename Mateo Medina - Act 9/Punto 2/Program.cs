using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    /*
        2. Una empresa registra los nombres de sus 5 vendedores y el total de ventas
        realizadas por cada uno en un mes. Cargar los nombres y ventas en dos
        vectores paralelos, ordenar los datos de mayor a menor según las ventas,
        imprimir la lista ordenada con nombre y monto de la venta, e informar quien fue
        el que menos vendió de los 5 empleados.
     
     */


    internal class empresa
    {
        private string[] vendedores = new string[5];
        private int[] ventas = new int[5];
        private string[] ordenadoVendedores = new string[5];
        private int[] ventasOrdenadas = new int[5];


        public void cargar()
        {
            string linea;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el nombre de un vendedor ");
                linea = Console.ReadLine();
                vendedores[i] = linea;
                Console.WriteLine("Ingrese tambien las ventas de este vendedor ");
                linea = Console.ReadLine();
                ventas[i] = int.Parse(linea);

            }
        }

        public void calcular()
        {
            int aux = 0;
            string aux2;

            for (int i = 0; i < vendedores.Length; i++)
            {
                ordenadoVendedores[i] = vendedores[i];
                ventasOrdenadas[i] = ventas[i]; 
            }

            for (int i = 0; i < vendedores.Length - 1 ; i++)
            {
                for (int j = 0; j < vendedores.Length - 1 - i; j++)
                {
                    if (ventasOrdenadas[j] < ventasOrdenadas[j + 1])
                    {
                        aux = ventasOrdenadas[j];
                        ventasOrdenadas[j] = ventasOrdenadas[j + 1];
                        ventasOrdenadas[j + 1] = aux;

                        aux2 = ordenadoVendedores[j];
                        ordenadoVendedores[j] = ordenadoVendedores[j + 1];
                        ordenadoVendedores[j + 1] = aux2; 
                    }

                }


            }

            for (int i = 0; i < vendedores.Length; i++) {

                Console.WriteLine(ordenadoVendedores[i] + "  " + ventasOrdenadas[i]);
            }


            Console.WriteLine("El empleado que menos vendio fue " + ordenadoVendedores[4] + " con ventas iguales a " + ventasOrdenadas[4]);


            Console.ReadKey();
        }



        static void Main(string[] args)
        {
            empresa emp = new empresa();
            emp.cargar();
            emp.calcular();

        }
    }
}
