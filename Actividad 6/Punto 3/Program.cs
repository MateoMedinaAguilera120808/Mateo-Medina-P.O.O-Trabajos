using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    /*3. Confeccionar una clase que represente un empleado. Definir como atributos su
        nombre y su sueldo. Confeccionar los métodos para la carga, otro para imprimir
        sus datos y por último uno que imprima un mensaje si debe pagar impuestos
        (si el sueldo supera a 3000).*/



    internal class empleado
    {
        private int sueldo;
        private string nombre,linea;

        public void cargar()
        {
            Console.WriteLine("Ingrese el nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo del empleado");
            linea = Console.ReadLine();
            sueldo = int.Parse(linea);
        }

        


        public void imprimir()
        {
            Console.WriteLine("El nombre del empleado es: " + nombre);
            Console.WriteLine("El sueldo del empleado es: " + sueldo);
        }

        public void calcular()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("El empleado debe pagar impuestos");
            }
            else
            {
                Console.WriteLine("El empleado no debe pagar impuestos");
            }
        }

        static void Main(string[] args)
        {
            empleado empleado = new empleado();

            empleado . cargar();
            empleado . imprimir(); 
            empleado . calcular();
            Console.ReadKey();  


        }
    }
}
