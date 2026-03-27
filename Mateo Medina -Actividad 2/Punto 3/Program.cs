using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{

    //3. Se ingresa por teclado un número positivo de uno o dos dígitos (1..99) mostrar un mensaje indicando si el número tiene uno o dos dígitos.(Tener en cuenta que condición debe cumplirse para tener dos dígitos, un número entero)


    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            string linea;


            Console.Write("Ingrese un numero ");
            linea = Console.ReadLine();
            valor1 = int.Parse(linea);

            if (valor1 > 9 && valor1 <= 99)
            {
                Console.Write("El numero tiene 2 digitos");
            }
            else
            {
                Console.Write("El numero tiene 1 digito");
            }


            Console.ReadKey();
        }

    }
}
