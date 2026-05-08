using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{

    /*
     3. Confeccionar una clase para administrar los días que han faltado los 3 empleados de una
        empresa.
        Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz
        irregular para cargar los días que han faltado cada empleado (cargar el número de día que
        faltó)
        Cada fila de la matriz representa los días de cada empleado.
        a. Mostrar los empleados con la cantidad de inasistencias.
        b. Cuál empleado faltó menos días.
     
     */



    internal class Inasistencias
    {

        private string[] empleado = new string[3];
        private int[][] diasFaltados;
        

        public void cargar()
        {
            string linea;
            diasFaltados = new int[3][];

            for (int i = 0; i < empleado.Length; i++)
            {
                Console.WriteLine("Ingrese los nombres de cada trabajador");
                linea = Console.ReadLine();
                empleado[i] = linea;

                Console.WriteLine("Cuantas veces ha faltado este trabajador? ");
                linea = Console.ReadLine();

                diasFaltados[i] = new int[int.Parse(linea)];

                for (int j = 0; j < diasFaltados[i].Length; j++)
                {
                    Console.WriteLine("Ingrese la fecha del dia que falto ");
                    linea = Console.ReadLine();
                    diasFaltados[i][j] = int.Parse(linea);


                }
            }
        }

        public void imprimir()
        {

            for (int i = 0; i < empleado.Length; i++)
            {
                Console.Write(empleado[i] + " ");

                for (int j = 0; j < diasFaltados[i].Length; j++)
                {
                    Console.Write(diasFaltados[i][j] + " ");


                }

                Console.WriteLine();
            }

            if (diasFaltados[0].Length < diasFaltados[1].Length && diasFaltados[0].Length < diasFaltados[2].Length)
            {
                Console.WriteLine("El empleado " + empleado[0] + " tiene una menor cantidad de faltas");

            }
            else if (diasFaltados[1].Length < diasFaltados[0].Length && diasFaltados[1].Length < diasFaltados[2].Length)
            {

                Console.WriteLine("El empleado " + empleado[1] + " tiene una menor cantidad de faltas");
            }
            else
            {
                Console.WriteLine("El empleado " + empleado[2] + " tiene una menor cantidad de faltas");
            }

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
                Inasistencias I = new Inasistencias();
                I.cargar();
                I.imprimir();

        }
    }
}
