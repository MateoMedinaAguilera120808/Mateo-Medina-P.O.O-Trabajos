using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    /*
     3. Se registran los nombres de 5 atletas y sus tiempos (en segundos) en una
        carrera de 100 metros. El programa debe cargar los datos en dos vectores
        paralelos, calcular y mostrar el promedio de los tiempos, mostrar el nombre del
        atleta con mejor y peor tiempo, y mostrar los nombres de quienes superaron el
        promedio.
     */


    internal class carrera
    {
        private string[] atletas= new string[5];
        private float[] tiempos = new float[5];
        string linea;
        float promedio = 0;
        private string elMejor;
        private string elPeor;
        int contador = 0;
        int contador2 = 0;
        


        public void cargar()
        {
            for (int i = 0; i < atletas.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre de un atleta");
                linea = Console.ReadLine();
                atletas[i] = linea;
                Console.WriteLine("Ingrese el tiempo del atleta");
                linea = Console.ReadLine();
                tiempos[i] = float.Parse(linea);

            }


        }

        public void calcular()
        {
            float suma = 0;
            float peor = tiempos[0];
            float mejor = tiempos[0];


            for (int i = 0; i < atletas.Length; i++)
            {
                suma = suma + tiempos[i];

            }

            promedio = suma / tiempos.Length;


            for (int i = 0; i < tiempos.Length; i++)
            {
                if (tiempos[i] < mejor)
                {
                    contador = i;
                    mejor = tiempos[i];
                }

                else if (tiempos[i] > peor)
                {
                    peor = tiempos[i];
                    contador2 = i;
                }

            }

            Console.WriteLine("El atleta con mejor tiempo es " + atletas[contador] + " con un tiempo de " + mejor );
            Console.WriteLine("El atleta con peor tiempo es " + atletas[contador2] + " con un tiempo de " + peor );
            Console.WriteLine("El promedio fue de " + promedio);

            for (int i = 0; i < atletas.Length; i++)
            {
                if (tiempos[i] < promedio)
                {
                    

                    Console.WriteLine("El atleta " + atletas[i] + " hizo un mejor tiempo que el promedio");

                }

            }

            Console.ReadKey();

        }


        static void Main(string[] args)
        {
            carrera car = new carrera();
            car.cargar();
            car.calcular();
            
        }
    }
}
