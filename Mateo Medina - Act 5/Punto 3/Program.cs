using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
            a) La cantidad de valores ingresados negativos.
            b) La cantidad de valores ingresados positivos.
            c) La cantidad de múltiplos de 15.
            d) El valor acumulado de los números ingresados que son pares.*/

            int valor, cant_neg, cant_pos, cant_multp, acumulado;
            string linea;

            cant_pos = 0;
            cant_neg = 0;
            cant_multp = 0;
            acumulado = 0;


            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese 10 valores enteros ");
                linea = Console.ReadLine();
                valor = int.Parse(linea);

                if (valor % 15 == 0)
                {
                    Console.WriteLine("El valor es multiplo de 15 ");
                    cant_multp = cant_multp + 1;


                }
                else if (valor > 0)
                {
                    if(valor % 2 == 0 ){
                        acumulado = acumulado + valor;
                    }
                    
                    Console.WriteLine("El valor es positivo ");
                    cant_pos = cant_pos + 1;

                    
                }
                else
                {
                    Console.WriteLine("El valor es negativo ");
                    cant_neg = cant_neg + 1;
                }

                


            }

            Console.WriteLine("La cantidad de multiplos de 15 es " + cant_multp);

            Console.WriteLine("La cantidad de positivos es " + cant_pos);

            Console.WriteLine("La cantidad de negativos es " + cant_neg);

            Console.WriteLine("La acumulacion total de pares es de " + acumulado);



            Console.ReadKey();
        }
    }
}
