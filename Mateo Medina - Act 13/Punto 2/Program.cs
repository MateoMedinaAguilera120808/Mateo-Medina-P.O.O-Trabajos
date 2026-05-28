using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{

    /*
     2. Implementar la clase operaciones. Se deben cargar dos valores enteros en el
        constructor, calcular su suma, resta, multiplicación y división, cada una en un
        método, imprimir dichos resultados.
     
     
     */



    internal class operaciones
    {
        private int num1;
        private int num2;
        public operaciones()
        {
            string linea;
            Console.WriteLine("Ingrese el primer numero:");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("Ingrese el segundo numero:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
        }
        public void suma()
        {
            Console.WriteLine("La suma es: " + (num1 + num2));
        }
        public void resta()
        {
            Console.WriteLine("La resta es: " + (num1 - num2));
        }
        public void multiplicacion()
        {
            Console.WriteLine("La multiplicacion es: " + (num1 * num2));
        }
        public void division()
        {
            
                Console.WriteLine("La division es: " + (num1 / num2));
            }
            
        
    
        static void Main(string[] args)
        {            
            operaciones o = new operaciones();
            o.suma();
            o.resta();
            o.multiplicacion();
            o.division();
            Console.ReadKey();
        }
    }
}
