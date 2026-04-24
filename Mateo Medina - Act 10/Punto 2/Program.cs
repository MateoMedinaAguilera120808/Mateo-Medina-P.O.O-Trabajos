using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{

    /*
    Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la
    primer fila con la segunda. Imprimir luego la matriz. 
     */



    internal class CambiarFila
    {

        private int[,] mat;
        private int filas;
        private int columnas;



        public void cargar()
        {
            string linea;
            string linea2;

            Console.WriteLine("Ingrese cuantas filas quiere que tenga la matriz ");
            linea = Console.ReadLine();
            Console.WriteLine("Ingrese cuantas columnas quiere que tenga la matriz ");
            linea2 = Console.ReadLine();
            filas = int.Parse(linea);
            columnas = int.Parse(linea2);

            mat = new int[filas,columnas];


            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine("Ingrese los valores para la matriz ");
                    linea = Console.ReadLine();
                    mat[i,j] = int.Parse(linea);
                }

            }


        }

        public void calcular()
        {
            int aux;


            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(mat[i, j] + " ");

                }
                Console.WriteLine();

            }
            
            Console.WriteLine() ;





            for (int i = 0; i < columnas; i++)
            {
                aux = mat[0, i];
                mat[0, i] = mat[1,i];
                mat[1, i] = aux;
            }

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(mat[i, j] + " ");

                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }


        static void Main(string[] args)
        {
            CambiarFila cf = new CambiarFila();
            cf.cargar();
            cf.calcular();
            
        }
    }
}
