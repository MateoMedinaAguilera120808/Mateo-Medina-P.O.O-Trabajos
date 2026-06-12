using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    /*
     2. Catálogo de Películas (Encapsulación, Validación y Composición)
        Plantear una clase llamada Pelicula y otra clase llamada Catalogo.
        La clase Pelicula debe tener como atributos privados: Titulo, DuracionMinutos y Calificacion
        (un puntaje del 1 al 5). Definir las propiedades necesarias para acceder a estos atributos,
        asegurando mediante validaciones lógicas que:
         La duración en minutos sea estrictamente mayor a cero (0).
         La calificación se encuentre únicamente en el rango de 1 a 5 (de lo contrario, asignar
        un valor por defecto de 1).
        La clase Catalogo debe contener internamente un vector capaz de almacenar 3 objetos de
        la clase Pelicula. Definir un método dentro de Catalogo para mostrar por pantalla todas las
        películas ordenadas de mayor a menor en base a su duración. Además, el método debe
        informar el título de la película con mejor calificación y cuál es la película más corta del
        catálogo.
     */

    class Pelicula
    {
        private string Titulo;
        private int DuracionMinutos;
        private int Calificacion;

        public Pelicula()
        {
            string linea;


            Console.WriteLine("ingrese el nombre de la pelicula ");
            linea = Console.ReadLine();
            Titulo = linea;


            do
            {
                Console.WriteLine("Cuanto dura esta pelicula?");
                linea = Console.ReadLine();
                DuracionMinutos = int.Parse(linea);
            }
            while (DuracionMinutos <= 0);
                
            


                Console.WriteLine("Cuanta puntuacion le da a la pelicula? (Entre 1 y 5, sino, sera 1 por defecto)");
                linea = Console.ReadLine();
                Calificacion = int.Parse(linea);

                if (int.Parse(linea) < 1 || int.Parse(linea) > 5)
                {

                    Calificacion = 1;

                }


            
            }

        public string ObtenerTitulo
        {
            set {  Titulo = value; }
            get { return Titulo; }


        }

        public int ObtenerDuracion
        {
            set { DuracionMinutos = value;  }
            get { return DuracionMinutos; }

        }

        public int ObtenerCalificacion
        {
            set {  Calificacion = value; }
            get {  return  Calificacion; }

        }

        public void imprimirDatos()
        {
            Console.WriteLine("El titulo de la pelicula es " + Titulo);
            Console.WriteLine("La duracion de la pelicula es " + DuracionMinutos);
            Console.WriteLine("La Calificacion de la pelicula es " + Calificacion);
        }


    }


    internal class Catalogo
    {
        Pelicula[] Pelis = new Pelicula[3];
        Pelicula[] ordenado = new Pelicula[3];

        public Catalogo()
        {
            Pelis[0] = new Pelicula();
            Pelis[1] = new Pelicula();
            Pelis[2] = new Pelicula();

            for (int i = 0; i < Pelis.Length; i++)
            {
                ordenado[i] = Pelis[i];
            }


        }

        public void Ordenar()
        {
            Pelicula aux;

            for (int i = 0; i < ordenado.Length - 1; i++)
            {
                for(int j = 0; j < ordenado.Length -1 - i; j++)
                {
                    if (ordenado[j].ObtenerDuracion < ordenado[j+1].ObtenerDuracion )
                    {
                        aux = ordenado[j];
                        ordenado[j] = ordenado[j + 1];
                        ordenado[j + 1] = aux;

                    }

                }



            }
            
            for(int i = 0; i < ordenado.Length; i++) {
                ordenado[i].imprimirDatos();
                Console.WriteLine();
            }

            Console.WriteLine();

        }

        public void MenorDuracion()
        {
            Console.WriteLine("La pelicula con menor duracion es " + ordenado[2].ObtenerTitulo);


        }

        public void MejorPelicula()
        {
            int MejorCal = Pelis[0].ObtenerCalificacion;
            int aux = 0;

            for (int i = 1; i < Pelis.Length; i++)
            {
                if (Pelis[i].ObtenerCalificacion > MejorCal)
                {
                    MejorCal = Pelis[i].ObtenerCalificacion;
                    aux = i;
                }
            }

            Console.WriteLine("La pelicula con  mejor nota es " + Pelis[aux].ObtenerTitulo + " con una calificacion de " + MejorCal) ;

        }

        static void Main(string[] args)
        {
            Catalogo Catalogo = new Catalogo();
            Catalogo.Ordenar();
            Catalogo.MenorDuracion();
            Catalogo.MejorPelicula();
            Console.ReadKey();


        }
    }
}
