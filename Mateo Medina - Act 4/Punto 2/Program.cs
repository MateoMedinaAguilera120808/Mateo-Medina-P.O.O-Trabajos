using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    internal class Program
    {

        /* 2. Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc.
        (No se ingresan valores por teclado)*/



        static void Main(string[] args)
        {
            int cont, terminos, i;
            i = 0;
            cont = 25;
            terminos = 11;

            while (i < cont)
            {
                Console.WriteLine(terminos);
                i = i + 1;
                terminos = terminos + 11;


            }

            Console.ReadKey();
        }
    }
}