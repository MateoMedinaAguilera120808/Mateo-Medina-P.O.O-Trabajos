using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{

    /*
     
    3. Competencia de Atletismo
    Plantear una clase llamada Atleta que tenga como atributos privados el Nombre y el TiempoSegundos (tiempo que tardó en completar una carrera). Definir un constructor para ingresar ambos datos.
    Luego, crear una clase llamada Carrera que administre 3 objetos de la clase Atleta como atributos de la clase.
    Definir los siguientes métodos en la clase Carrera:
    Un constructor que cargue los datos de los 3 atletas de la carrera.
    Un método que imprima los nombres de los atletas junto con sus marcas de tiempo.
    Un método que calcule e imprima el tiempo promedio de la carrera.
    Un método que informe el nombre del atleta ganador de la carrera (aquel que completó la prueba en el menor tiempo).
    Un método que muestre a los atletas que superaron el promedio.

     */


    class atleta
    {
        private string Nombre;
        private float TiempoSegundos;


        public atleta()
        {
            string linea;

            Console.WriteLine("Ingrese el nombre del atleta ");
            linea = Console.ReadLine();
            Nombre = linea;

            Console.WriteLine("Ingrese el tiempo que hizo el atleta");
            linea = Console.ReadLine();
            TiempoSegundos = float.Parse(linea);

        }

        public string obtenernombre()
        {
            return Nombre;
        }

        public float tiempoSegundos()
        {

            return TiempoSegundos;

        }

    }



    internal class Carrera
    {
        private atleta atleta1, atleta2, atleta3;
        float promedio = 0;

        public Carrera()
        {
            atleta1 = new atleta();
            atleta2 = new atleta();
            atleta3 = new atleta();

        }

        public void imprimirdatos()
        {
            Console.WriteLine(atleta1.obtenernombre() + " " + atleta1.tiempoSegundos());
            Console.WriteLine(atleta2.obtenernombre() + " " + atleta2.tiempoSegundos());
            Console.WriteLine(atleta3.obtenernombre() + " " + atleta3.tiempoSegundos());


        }

        public void calcularpromedio()
        {
            float sumatotal = 0; 
            

            sumatotal = sumatotal + atleta1.tiempoSegundos() + atleta2.tiempoSegundos() + atleta3.tiempoSegundos();

            promedio = sumatotal / 3;
            Console.WriteLine("El promedio de tiempo de la carrera es de " + promedio);

        }


        public void ganador()
        {

            if (atleta1.tiempoSegundos() < atleta2.tiempoSegundos() && atleta1.tiempoSegundos() < atleta3.tiempoSegundos())
            {
                Console.WriteLine("El atleta " + atleta1.obtenernombre() + " es el ganador");

            } else if (atleta2.tiempoSegundos() < atleta1.tiempoSegundos() && atleta2.tiempoSegundos() < atleta3.tiempoSegundos())
            {
                Console.WriteLine("El atleta " + atleta2.obtenernombre() + " es el ganador");

            } else if (atleta3.tiempoSegundos() < atleta1.tiempoSegundos() && atleta3.tiempoSegundos() < atleta2.tiempoSegundos())
            {
                Console.WriteLine("El atleta " + atleta3.obtenernombre() + " es el ganador");

            }
            else
            {
                Console.WriteLine("Hay un empate");
            }


        }

        public void superarpromedio()
        {

            if (atleta1.tiempoSegundos() < promedio)
            {
                Console.WriteLine("El atleta " + atleta1.obtenernombre() + " supero el promedio");
            }

            if (atleta2.tiempoSegundos() < promedio)
            {
                Console.WriteLine("El atleta " + atleta2.obtenernombre() + " supero el promedio");
            }

            if (atleta3.tiempoSegundos() < promedio)
            {
                Console.WriteLine("El atleta " + atleta3.obtenernombre() + " supero el promedio");
            }

        }




        static void Main(string[] args)
        {
            Carrera c = new Carrera();
            c.imprimirdatos();
            c.calcularpromedio();
            c.ganador();
            c.superarpromedio();
            Console.ReadKey();
        }
    }
}
