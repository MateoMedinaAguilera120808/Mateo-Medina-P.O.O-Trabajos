using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    internal class Matrices
    {
        /*
         1- Crear una matriz de 2 filas y 5 columnas. Realizar la carga de
        componentes por columna (es decir primero ingresar toda la primer
        columna, luego la segunda columna y así sucesivamente)
        Imprimir luego la matriz.
         
         
         
         */



        private int[,] mat;

        public void cargar()
        {
            string linea;
            mat = new int[2,5];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++) { 
                    Console.WriteLine("Ingrese valores para la matriz");
                    linea = Console.ReadLine();
                    mat[i,j]= int.Parse(linea);
                }
            }

        }


        public void imprimir()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(mat[i, j] + " ");

                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
                Matrices m = new Matrices();
                m.cargar();
                m.imprimir();



        }
    }
}
