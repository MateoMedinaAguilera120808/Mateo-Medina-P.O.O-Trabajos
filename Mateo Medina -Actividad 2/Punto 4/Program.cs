using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{

    //4. Se cargan por teclado tres números distintos.Mostrar por pantalla el mayor de ellos.


    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3,mayor;
            string linea;


            Console.Write("ingrese un numero ");
            linea= Console.ReadLine();  
            numero1= int.Parse(linea);


            Console.Write("ingrese un numero distinto ");
            linea = Console.ReadLine();
            numero2=int.Parse(linea);

           
            

            Console.Write("Ingrese otro numero diferente ");
            linea = Console.ReadLine();
            numero3 = int.Parse(linea);
            

            if (numero1>numero2 && numero1>numero3){
                mayor = numero1;
                Console.Write("El numero mas grande es " + mayor);

            }else
            {
                if(numero2>numero1 && numero2 >numero3){
                    mayor = numero2;
                    Console.Write("El numero mas grande es " + mayor);

                }
                else
                {
                    mayor = numero3;
                    Console.Write("El numero mas grande es " + mayor);
                }
            }

            Console.ReadKey();

        }
    }
}
