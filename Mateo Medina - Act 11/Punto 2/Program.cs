using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    /*
     2. Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la
    primer fila, 2 columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila
    (crearla sin la intervención del operador)
    Realizar la carga por teclado e imprimir posteriormente.
     
     
     */

    internal class Irregular
    {
        private int[][] matriz;





        public void cargar() {

            matriz = new int[5][];
            matriz[0] = new int[1];
            matriz[1] = new int[2];
            matriz[2] = new int[3];
            matriz[3] = new int[4];
            matriz[4] = new int[5];

            string linea;

        for(int i = 0; i < matriz.Length; i++){

                for(int j = 0; j < matriz[i].Length; j++){
                    Console.WriteLine("Ingrese un valores para la matriz ");
                    linea = Console.ReadLine();
                    matriz[i][j] = int.Parse(linea);
                }
            
            }

        }


        public void imprimir() {

            for (int i = 0; i < matriz.Length; i++) {

                for (int j = 0; j < matriz[i].Length; j++) {

                    Console.Write(matriz[i][j] + " ");
                
                }

                Console.WriteLine();
            
            }


            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Irregular I = new Irregular();
            I .cargar ();
            I . imprimir();

        }
    }
}
