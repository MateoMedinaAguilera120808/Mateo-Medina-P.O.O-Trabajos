using System;

PUNTO 1


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{

    /*
     1. Sistema de Logística: Envíos por Sucursal
        Una empresa de correo tiene 3 sucursales principales. Cada sucursal procesa una
        cantidad diferente de paquetes por día dependiendo de su demanda.
        ● Definir un vector de tipo string para los nombres de las 3 sucursales.
        ● Definir una matriz irregular donde cada fila sea una sucursal y cada columna
        represente el peso (en kg) de cada paquete enviado.
        ● Métodos:
        1. Cargar los nombres de las sucursales y, para cada una, preguntar cuántos
        paquetes se enviaron hoy para definir el tamaño de su fila.
        2. Cargar el peso de cada paquete.
        3. Imprimir el peso de todos los paquetes organizados por sucursal.
        4. Calcular e informar el peso total despachado por cada sucursal.
        5. Informar cuál es el paquete más pesado de toda la empresa y a qué sucursal
        pertenece.
     
     */

    internal class Logistica
    {
        private string[] sucursales = new string[3];
        private int[][] paquetes = new int[3][];
        private int[] total = new int[3];


        public void cargar()
        {
            string linea;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese el nombre de la sucursal ");
                linea = Console.ReadLine();
                sucursales[i] = linea;

                Console.WriteLine("Cuantos paquetes se enviaron hoy? ");
                linea = Console.ReadLine();
                paquetes[i] = new int[int.Parse(linea)];

                for (int j = 0; j < paquetes[i].Length; j++)
                {
                    Console.WriteLine("Ingrese el peso de cada paquete ");
                    linea = Console.ReadLine();
                    paquetes[i][j] = int.Parse(linea);
                }
            }

        }


        public void imprimir()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(sucursales[i] + " ");

                for (int j = 0; j < paquetes[i].Length; j++)
                {
                    Console.Write(paquetes[i][j] + " ");

                }
                Console.WriteLine();
            }
        }

        public void calcular()
        {
            int suma;

            for (int i = 0; i < 3; i++)
            {
                suma = 0;



                for (int j = 0; j < paquetes[i].Length; j++)
                {
                    suma = suma + paquetes[i][j];

                }

                total[i] = suma;
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("La sucursal " + sucursales[i] + " tiene un total de " + total[i] + " de kilos despachados");



            }



        }

        public void masPesado()
        {
            int Maspesado = paquetes[0][0];
            int aux1 = 0;
            int aux2 = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < paquetes[i].Length; j++)
                {

                    if (paquetes[i][j] > Maspesado)
                    {
                        Maspesado = paquetes[i][j];
                        aux1 = i;
                        aux2 = j;

                    }


                }

            }

            Console.WriteLine("El paquete mas pesado pesa " + paquetes[aux1][aux2] + " y le pertenece a la sucursal " + sucursales[aux1]);







            Console.ReadKey();
        }





        static void Main(string[] args)
        {
            Logistica L = new Logistica();
            L.cargar();
            L.imprimir();
            L.calcular();
            L.masPesado();
        }
    }
}
