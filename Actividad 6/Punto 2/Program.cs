using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{

    /* 2. Desarrollar una clase que represente un Cuadrado y tenga los siguientes
    métodos: cargar el valor de su lado, imprimir su perímetro y su superficie.*/

    internal class cuadrado
    {
        private int lado, perimetro, superficie;
        private string linea;

        public void cargar()
        {
            Console.WriteLine("ingrese el lado de un cuadrado");
            linea = Console.ReadLine();
            lado = int.Parse(linea);
        }

        public void calcular() { 
        perimetro = lado * 4;
        superficie = lado * lado;
        }

        public void escribir() {
            Console.WriteLine("El lado del cuadrado es " + lado);
            Console.WriteLine("La superficie del cuadrado es " + superficie);
            Console.WriteLine("El perimetro del cuadrado es " + perimetro);
        
        }

            static void Main(string[] args)
        {
            cuadrado cuadrado = new cuadrado();
            cuadrado . cargar();
            cuadrado .calcular();
            cuadrado .escribir();
            Console.ReadKey();

        }
    }
}
