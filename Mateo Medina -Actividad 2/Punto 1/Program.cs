using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    internal class Program
    {

        //1. Realizar un programa que lea por teclado dos números, si el primero es mayor al segundo informar su suma y diferencia, en caso contrario informar el producto y la división del primero respecto al segundo.


        static void Main(string[] args)
        {
           int valor1,valor2,suma,resta,division,multiplicacion;
            string linea;



            Console.Write("Ingrese el primer valor ");
            linea = Console.ReadLine();
            valor1= int.Parse(linea);


            Console.Write("Ingrese el segundo valor ");
            linea = Console.ReadLine();
            valor2 = int.Parse(linea);


            if (valor1 > valor2){
                suma = valor1 + valor2;
                resta = valor1 - valor2;
                Console.Write("La suma de los 2 valores es " + suma + " y la resta de los mismos es " + resta);

            }else { 
                multiplicacion = valor1 * valor2;
                division = valor2 / valor1;
                Console.Write("El producto de los 2 numeros es " + multiplicacion + " Y la division del primero respecto al segundo da " +  division);
            }


            Console.ReadKey(); 
        }
    }
}
