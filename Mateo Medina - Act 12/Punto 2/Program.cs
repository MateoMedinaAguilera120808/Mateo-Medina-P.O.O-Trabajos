using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    internal class Cine
    {

        /*
         2. Gestión de Complejo de Cine
        Un cine tiene 4 salas con diferentes capacidades de espectadores (la Sala 1 tiene 10
        asientos, la Sala 2 tiene 15, la Sala 3 tiene 8 y la Sala 4 tiene 12).
        ● Definir una matriz irregular de 4 filas para representar los asientos.
        ● Métodos:
        1. Inicializar la matriz con los tamaños de las salas mencionadas (sin
        intervención del operador).
        2. Crear un método de Venta de Entradas que permita cargar la edad del
        espectador en un asiento específico (fila y columna).
        3. Imprimir el mapa de ocupación de las salas indicando la edad del espectador
        en cada asiento.
        4. Calcular cuántos menores de edad (menos de 18 años) hay en cada sala.
        5. Informar cuál es el promedio de edad de los espectadores de todo el
        complejo.
         
         */

        private int[][] salas = new int[4][];


        public void cargar()
        {
            salas[0] = new int[10];
            salas[1] = new int[15];
            salas[2] = new int[8];
            salas[3] = new int[12];

        }

        public void entradas()
        {
            string linea;
            int aux1 = 0;
            int aux2 = 0;
            int edad;
            int cantEnt = 0;

            for (int i = 0; i < salas.Length; i++)
            {


                for (int j = 0; j < salas[i].Length; j++)
                {

                    salas[i][j] = 0;
                }
            }

            for (int i = 0; i < salas.Length; i++)
            {
                Console.WriteLine("Sala " + i + " ");

                for (int j = 0; j < salas[i].Length; j++)
                {

                    Console.Write("|" + salas[i][j] + "|");


                }

                Console.WriteLine();
                Console.WriteLine();
            }






            Console.WriteLine("Cuantas entradas querria comprar? ");
            linea = Console.ReadLine();
            cantEnt = int.Parse(linea);




            for (int i = 0; i < (cantEnt); i++)
            {

                Console.WriteLine("Elija la sala ");
                linea = Console.ReadLine();
                aux1 = int.Parse(linea);

                Console.WriteLine("Elija el Asiento  ");
                linea = Console.ReadLine();
                aux2 = int.Parse(linea);

                Console.WriteLine("Por ultimo, ingrese su edad ");
                linea = Console.ReadLine();
                edad = int.Parse(linea);

                salas[aux1][aux2] = edad;

            }

            for (int i = 0; i < salas.Length; i++)
            {

                for (int j = 0; j < salas[i].Length; j++)
                {

                    Console.Write("|" + salas[i][j] + "|");


                }

                Console.WriteLine();
                Console.WriteLine();
            }



        }

        public void menores()
        {

            int[] CantMen = new int[4];



            for (int i = 0; i < salas.Length; i++)
            {

                for (int j = 0; j < salas[i].Length; j++)
                {
                    if (salas[i][j] < 18 && salas[i][j] > 0)
                    {
                        CantMen[i]++;

                    }

                }
            }

            for (int i = 0; i < CantMen.Length; i++)
            {
                Console.WriteLine("Sala " + i + " tiene " + CantMen[i] + " menores de edad.");
            }
        }

        public void promedio()
        {
            int cont = 0;
            int suma = 0;
            float promedio;
            for (int i = 0; i < salas.Length; i++)
            {
                for (int j = 0; j < salas[i].Length; j++)
                {
                    if (salas[i][j] > 0)
                    {
                        cont++;
                        suma = suma + salas[i][j];
                    }
                }
            }
            promedio = suma / cont;
            Console.WriteLine("El promedio de edad de los espectadores es: " + promedio);

            Console.ReadKey();
        }



        static void Main(string[] args)
        {
            Cine C = new Cine();
            C.cargar();
            C.entradas();
            C.menores();
            C.promedio();

        }
    }
}
