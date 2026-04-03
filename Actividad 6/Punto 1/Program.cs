using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    /*1.Desarrollar una clase que represente un punto en el plano y tenga los
        siguientes métodos: cargar los valores de x e y, imprimir en que cuadrante se
        encuentra dicho punto (concepto matemático, primer cuadrante si x e y son positivas
        , si x&lt;0 e y&gt;0 segundo cuadrante, etc.)*/




    internal class plano
    {
        private int x, y;
        private string linea;

        public void Cargar()
        {
            Console.WriteLine("Ingrese el valor de x:");
            linea = Console.ReadLine();
            x = int.Parse(linea);
            Console.WriteLine("Ingrese el valor de y:");
            linea = Console.ReadLine();
            y = int.Parse(linea);
        }

        public void calcular()
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("El punto se encuentra en el primer cuadrante");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("El punto se encuentra en el segundo cuadrante");

            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("El punto se encuentra en el tercer cuadrante");
            }
            else
            {
                Console.WriteLine("El punto se encuentra en el cuarto cuadrante");

            }

            
        }


                static void Main(string[] args){

                plano plano = new plano();
                plano . Cargar();
                plano . calcular();
                Console.ReadKey();
        }
    }
}
