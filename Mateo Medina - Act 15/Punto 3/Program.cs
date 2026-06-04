using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{

    /*
     3. Geolocalización de Reservas Naturales
        Un centro de ecología realiza mapeos de biodiversidad para contabilizar el avistamiento de
        especies protegidas en cuadrículas de territorio.
        ● Confeccionar la clase ReservaNatural que tenga como atributos privados el
        NombreReserva y una matriz llamada avistamientos de 3x3 (que representa un
        mapa de coordenadas o sectores de 3 filas y 3 columnas, donde se almacena la
        cantidad de animales avistados en cada sector). El constructor de la clase debe
        cargar por teclado el nombre y rellenar el mapa de avistamientos.
        ● Confeccionar la clase colaboradora CentroEcologico que contenga un vector de 3
        objetos de la clase ReservaNatural.
        La clase CentroEcologico debe implementar los siguientes métodos:
        1. Un constructor que solicite la carga secuencial de las 3 reservas.
        2. Un método que enliste cada reserva junto a la cantidad total de avistamientos que
        registró en toda su superficie (la suma de toda su matriz rectangular).
        3. Un método que determine e informe cuál fue la coordenada o sector específico ([fila,
        columna]) que registró la mayor concentración de avistamientos de toda la red de
        reservas, indicando a qué reserva pertenece.
     
     
     
     
     */

    class ReservaNatural
    {
        private string NombreReserva;
        private int[,] avistamientos = new int[3,3];


        public ReservaNatural()
        {
            string linea;


            Console.WriteLine("Ingrese  el nombre de la reserva");
            linea = Console.ReadLine();
            NombreReserva = linea;

            for (int i = 0; i < avistamientos.GetLength(0); i++) {

                for (int j = 0; j < avistamientos.GetLength(1); j++) { 
                Console.WriteLine("Ingrese los avistamientos que ha tenido");
                    linea = Console.ReadLine();
                    avistamientos[i,j] = int.Parse(linea);
                }

            }
        }

        public string DevolverNombre()
        {
            return NombreReserva;


        }

        public int[,] DevolverMatriz()
        {
            return avistamientos;


        }








    }


    internal class CentroEcologico
    {

        private ReservaNatural[] jaulas = new ReservaNatural[3];


        public CentroEcologico() { 


        jaulas[0] = new ReservaNatural();
        jaulas[1] = new ReservaNatural();
        jaulas [2] = new ReservaNatural();

        }



        public void mostrarJaulas()
        {
            int totalAvistamientos;


            for (int t = 0; t < 3; t++)
            {
                totalAvistamientos = 0;

                Console.Write(jaulas[t].DevolverNombre() + " Tiene un total de avistamientos de ");


                for (int i = 0; i < 3; i++)
                {


                    for (int j = 0; j < 3; j++)
                    {
                        totalAvistamientos = totalAvistamientos + jaulas[t].DevolverMatriz()[i, j];

                    }



                }

                Console.WriteLine(totalAvistamientos);

            }

        }


        public void buscarMayorConcentracion()
        {
            string nombre = "";
            int mayorConcentracion = jaulas[0].DevolverMatriz()[0,0];
            int valor = 0;

            nombre = jaulas[0].DevolverNombre();


            for (int t = 0;t < 3; t++)
            {   


                for(int i = 0;i < 3; i++)
                {

                    for(int j = 0; j < 3; j++)
                    {
                        valor =  jaulas[t].DevolverMatriz()[i, j];



                    }

                    if (mayorConcentracion < valor)
                    {
                        mayorConcentracion = valor;
                        nombre = jaulas[t].DevolverNombre();

                    }


                }

                


            }

            Console.Write("La coordenada con mayor concentracion de avistamientos es en la  jaula " + nombre + " con una cantidad de avistamientos de " + mayorConcentracion) ;


        }





        static void Main(string[] args)
        {
            CentroEcologico CE = new CentroEcologico();
            CE.mostrarJaulas();
            CE.buscarMayorConcentracion();
            Console.ReadKey();

        }
    }
}
