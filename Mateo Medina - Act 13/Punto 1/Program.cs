using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Punto_1
{

    /*
     1. Confeccionar una clase que represente un empleado. Definir como atributos su
        nombre y su sueldo. En el constructor cargar los atributos y luego en otro
        método imprimir sus datos y por último uno que imprima un mensaje si debe
        pagar impuestos (si el sueldo supera a 3000)

     */


    internal class empleado
    {
        private string nombre;
        private int sueldo;
        public empleado()
        {
            string linea;

            Console.WriteLine("Ingrese el nombre del empleado:");
            linea = Console.ReadLine();
            nombre = linea;

            Console.WriteLine("Ingrese el sueldo del empleado:");
            linea = Console.ReadLine();
            sueldo = int.Parse(linea);
        }
        public void imprimirDatos()
        {
            Console.WriteLine("El trabajador se llama " + nombre + " y cobra " + sueldo);
        }
        public void verificarImpuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("Debe pagar impuestos.");
            }
            else
            {
                Console.WriteLine("No debe pagar impuestos.");
            }
        }
    
    
        static void Main(string[] args)
        {
        empleado em = new empleado();
        em.imprimirDatos();
        em.verificarImpuestos();
        Console.ReadKey();

    }
    }
}
