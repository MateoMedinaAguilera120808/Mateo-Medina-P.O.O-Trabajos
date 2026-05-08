using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{

    /*
     1. Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como
    dato las temperaturas medias mensuales de dichos paises.
    Se pide ingresar el nombre del país y seguidamente las tres temperaturas medias
    mensuales.
    Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en
    memoria.
    a. Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
    b. Imprimir los nombres de las paises y las temperaturas medias mensuales de las
    mismas.
    c. Calcular la temperatura media trimestral de cada país.
    d. Imprimir los nombres de los paises y las temperaturas medias trimestrales.
    e. Imprimir el nombre del país con la temperatura media trimestral mayor.



     */


    internal class Temperatura_Trimestral
    {
        private string[,] paises = new string[4,1] ;
        private int[,] temperaturas = new int[4,3] ;
        
        private float[] promedioTri = new float [4];

        public void cargar()
        {
            string linea;


            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese el nombre del pais");
                linea= Console.ReadLine();
                paises[i, 0] = linea;

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Ingrese las temperaturas trimestrales de cada pais");
                    linea = Console.ReadLine();
                    temperaturas[i, j] = int.Parse(linea);


                }

            }

        }

        public void Imprimir()
        {
            




            for (int i = 0; i < 4; i++)
            {
                Console.Write(paises[i, 0] + " ");

                for (int j = 0; j < 3; j++)
                {
                    Console.Write(temperaturas[i, j] + " ");

                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
            public void promediar() {

            int suma;

            for (int i = 0; i < 4; i++)
            {
                suma = 0;

                for (int j = 0; j < 3; j++)
                {
                    suma = suma + temperaturas[i, j];

                }

                promedioTri[i] = suma / 3;


            }

            for (int i = 0; i < 4; i++)
            {
                Console.Write(paises[i, 0] + " " + promedioTri[i]);

                
                Console.WriteLine();
            }
            Console.WriteLine();

            float masgrande = promedioTri[0];
            int aux = 0;

            for (int i = 0; i < 4; i++){

                if (masgrande < promedioTri[i])
                {
                    masgrande = promedioTri[i];
                    aux = i;

                }

            }

            Console.WriteLine("El pais con el promedio mas grande es " + paises[aux,0] + " Con un promedio de " + masgrande);

            Console.ReadKey();
        


        }

        static void Main(string[] args)
        {
            Temperatura_Trimestral TT = new Temperatura_Trimestral();
            TT.cargar();
            TT.Imprimir();
            TT.promediar();


        }
    }
}
