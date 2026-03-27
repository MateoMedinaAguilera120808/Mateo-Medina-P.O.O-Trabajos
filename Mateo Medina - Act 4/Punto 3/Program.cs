using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    internal class Program
    {

        /*3. Realizar un programa que acumule (sume) valores ingresados por teclado hasta
        ingresar el 9999 (no sumar dicho valor, indica que ha finalizado la carga). Imprimir el
        valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.*/

        static void Main(string[] args)
        {
            int valor, sumatotal;
            string linea;

            sumatotal = 0;

            do {
                Console.WriteLine("Ingrese un valor para sumar ");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor != 9999)
                {
                    sumatotal = sumatotal + valor;
                }
                

            }while (valor != 9999);



            Console.WriteLine("El valor acumulado de todo es " + sumatotal);

            if(sumatotal < 0) {
                Console.WriteLine("El valor acumulado es menor a 0");
                    
            } else if(sumatotal == 0){
                Console.WriteLine("El valor acumulado es igual a 0");

            }
            else
            {
                Console.WriteLine("El valor acumulado es mayor a 0");
            } 
            Console.ReadKey();
        }
    }
}
