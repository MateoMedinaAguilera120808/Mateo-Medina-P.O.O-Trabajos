using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos
            muestre la tabla de multiplicar del mismo (los primeros 13 términos)
            Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el
            39.*/

            int valor, multiplos;
            string linea;
            multiplos = 0;

            Console.Write("Ingrese un valor del 1 al 10 ");
            linea = Console.ReadLine();
            valor = int.Parse(linea);

            for (int i = 1; i <= 13; i++)
            {
                multiplos = valor * i;
                Console.WriteLine(multiplos);
            }

            Console.ReadKey();
        }
    }
}
