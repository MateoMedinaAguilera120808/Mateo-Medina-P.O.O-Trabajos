using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{

    /*4. Implementar la clase operaciones. Se deben cargar dos valores enteros,
        calcular su suma, resta, multiplicación y división, cada una en un método,
        imprimir dichos resultados.*/

    internal class operaciones 
    {

        private int valor1,valor2,multiplicacion,division,suma,resta;
        private string linea;


        public void cargar()
        {
            Console.WriteLine("Ingrese un valor entero");
            linea = Console.ReadLine();
            valor1 = int.Parse(linea);

            Console.WriteLine("Ingrese un segundo valor entero");
            linea = Console.ReadLine();
            valor2 = int.Parse(linea);

        }

        public void sumar()
        {
            suma = valor1 + valor2;
            
        }

        public void restar()
        {
           resta = valor1 - valor2;
            
        }

        public void multiplicar()
        {
            multiplicacion = valor1 * valor2;
            
        }

        public void dividir() {
            division = valor1 / valor2;
        
        }

        public void imprimir()
        {
            Console.WriteLine("La suma de los valores es: " + suma);
            Console.WriteLine("La resta de los valores es: " + resta);
            Console.WriteLine("La multiplicación de los valores es: " + multiplicacion);
            Console.WriteLine("La división de los valores es: " + division);
        }

        static void Main(string[] args)
        {
            operaciones operaciones = new operaciones();
            operaciones . cargar();
            operaciones.sumar();
            operaciones.restar();
            operaciones.multiplicar();
            operaciones.dividir();
            operaciones.imprimir();
            Console.ReadKey();  

        }
    }
}
