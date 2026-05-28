using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{

    /*
         3. Plantear una clase Club y otra clase Socio.
            La clase Socio debe tener los siguientes atributos privados: nombre y la
            antigüedad en el club (en años). En el constructor pedir la carga del nombre y
            su antigüedad. La clase Club debe tener como atributos 3 objetos de la clase
            Socio. Definir una responsabilidad para imprimir el nombre del socio con mayor
            antigüedad en el club.
         
         */


    class socio
    {
        private string nombre;
        private int antiguedad;
        public socio()
        {
            string linea;
            Console.WriteLine("Ingrese el nombre del socio:");
            linea = Console.ReadLine();
            nombre = linea;
            Console.WriteLine("Ingrese la antiguedad del socio:");
            linea = Console.ReadLine();
            antiguedad = int.Parse(linea);
        }
        public string sacarNombre()
        {
            return nombre;
        }
        public int sacarAntiguedad()
        {
            return antiguedad;
        }
    
    }

    class club
    {
        private socio socio1, socio2, socio3;

        public club() { 

        socio1 = new socio();
        socio2 = new socio();
        socio3 = new socio();

        }

        public void MayorAntiguedad()
        {
            socio mayor = socio1;

            if (socio2.sacarAntiguedad() > mayor.sacarAntiguedad() && socio2.sacarAntiguedad() > socio3.sacarAntiguedad())
            {
                Console.WriteLine("El socio con mayor antiguedad es: " + socio2.sacarNombre());

            }
            else if (socio3.sacarAntiguedad() > mayor.sacarAntiguedad() && socio3.sacarAntiguedad() > socio2.sacarAntiguedad())
            {
                Console.WriteLine("El socio con mayor antiguedad es: " + socio3.sacarNombre());
            }
            else
            {
                Console.WriteLine("El socio con mayor antiguedad es: " + socio1.sacarNombre());

            }

        }
        static void Main(string[] args)
        {
                club club = new club();
                club.MayorAntiguedad();
            Console.ReadKey();
        }
    }
}
