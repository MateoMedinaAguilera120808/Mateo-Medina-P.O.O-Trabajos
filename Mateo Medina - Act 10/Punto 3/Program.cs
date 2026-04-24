using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{

    /*
     3- Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir los
    cuatro valores que se encuentran en los vértices de la misma (mat[0][0]
    etc.) 
     */


    internal class MostrarVertices
    {
        private int[,] mat;
        private int filas;
        private int columnas;

        public void cargar()
        {
            string linea;
            

            Console.WriteLine("Ingrese la cantidad de filas que quiere para la matriz ");
            linea= Console.ReadLine();
            filas = int.Parse(linea);
            Console.WriteLine("Ingrese la cantidad de columnas que quiere para la matriz ");
            linea = Console.ReadLine();
            columnas  = int.Parse(linea);
            mat = new int[filas, columnas];


            for (int i= 0; i < filas; i++)
            {
                for (int j= 0; j < columnas; j++)
                {
                    Console.WriteLine("Ingrese valores para la matriz");
                    linea = Console.ReadLine();
                    mat[i,j] = int.Parse(linea);

                }

            }
        }


        public void imprimir()
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(mat[i, j] + " ");

                }
                Console.WriteLine();

            }

            Console.WriteLine() ;


            Console.Write(mat[0, 0] + " ");
            Console.WriteLine(mat[0,columnas - 1 ]);
            Console.Write(mat[filas - 1,0] + " ");
            Console.WriteLine(mat[filas - 1,columnas - 1]);




        }

        static void Main(string[] args)
        {
            MostrarVertices mv = new MostrarVertices();
            mv.cargar();
            mv.imprimir();

        }
    }
}
