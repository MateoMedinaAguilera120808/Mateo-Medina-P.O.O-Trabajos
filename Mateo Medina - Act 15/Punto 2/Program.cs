using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{

    /*
     2. Logística de Puerto Espacial
        Una estación de acoplamiento registra el peso de los contenedores transportados en las
        bodegas de carga de las naves espaciales que llegan al puerto.
        ● Crear la clase NaveEspacial que contenga únicamente el atributo privado
        NombreNave y su constructor para cargarlo.
        ● Crear la clase colaboradora PuertoControl que contenga:
        ○ Un vector de 3 objetos de la clase NaveEspacial.
        ○ Una matriz irregular de tipo double llamado pesoContenedores, donde
        cada fila representa a una nave, el tamaño de la fila es la cantidad de
        bodegas que posee esa nave, y los valores almacenados son los pesos (en
        toneladas) de los contenedores que transporta cada bodega.

        En PuertoControl, definir los siguientes métodos:

        1. Un constructor que cargue los nombres de las 3 naves, pregunte para cada una
        cuántas bodegas activas posee (para definir el tamaño de su fila en la matriz
        irregular) y cargue el peso del contenedor asignado a cada bodega.
        2. Un método que muestre en pantalla el detalle de los pesos cargados por cada nave
        espacial.
        3. Un método que identifique e informe qué nave transporta el contenedor individual
        más pesado de todo el puerto espacial (el valor máximo absoluto de la matriz
        irregular).
        4. Un método que indique el nombre de la nave que transporta menor peso acumulado
        total (la suma de todos sus contenedores).
     
     
     
     */

    class NaveEspacial
    {
        private string NombreNave;



        public NaveEspacial()
        {
            string linea;

            Console.WriteLine("Ingrese el nombre de la nave:");
            linea = Console.ReadLine();
            NombreNave = linea;

        }

        public string devolverNombre()
        {
            return NombreNave;
        }

    }


    internal class PuertoControl
    {
        NaveEspacial[] naves = new NaveEspacial[3];

        double[][] pesoContenedores = new double[3][];




        public PuertoControl()
        {
            string linea;

            naves[0] = new NaveEspacial();
            naves[1] = new NaveEspacial();
            naves[2] = new NaveEspacial();

            for (int i = 0; i < naves.Length; i++)
            {
                Console.WriteLine("Cuantas bodegas tiene la nave " + naves[i].devolverNombre() + "?");
                linea = Console.ReadLine();
                pesoContenedores[i] = new double[int.Parse(linea)];
            }

            for (int i = 0; i < pesoContenedores.Length; i++)
            {

                for (int j = 0; j < pesoContenedores[i].Length; j++)
                {
                    Console.WriteLine("Ingrese el peso del contenedor de la nave " + naves[i].devolverNombre() + " en la bodega " + (j + 1) + ":");
                    linea = Console.ReadLine();
                    pesoContenedores[i][j] = double.Parse(linea);
                }


            }


        }



        public void MostrarDatosNave()
        {

            for (int i = 0; i < naves.Length; i++)
            {

                Console.WriteLine("Nave: " + naves[i].devolverNombre() + " ");

                for (int j = 0; j < pesoContenedores[i].Length; j++)
                {
                    Console.WriteLine("Bodega " + (j + 1) + ": " + pesoContenedores[i][j] + " toneladas");

                }



            }
        }

        public void ContenedorMasPesado()
        {
            double MasPesado = pesoContenedores[0][0];
            int aux = 0;

            for (int i = 0; i < pesoContenedores.Length; i++)
            {
                for (int j = 0; j < pesoContenedores[i].Length; j++)
                {
                    if (pesoContenedores[i][j] > MasPesado)
                    {
                        MasPesado = pesoContenedores[i][j];
                        aux = i;
                    }
                }
            }
            Console.WriteLine("El contenedor más pesado es de la nave " + naves[aux].devolverNombre() + " con un peso de " + MasPesado + " toneladas.");
        }



        public void MenorPesoAcumulado()
        {


            double menorpeso = 0;
            string nave = "";


            for (int j = 0; j < pesoContenedores[0].Length; j++)
            {
                menorpeso = menorpeso + pesoContenedores[0][j];
            }


            for (int i = 0; i < naves.Length; i++)
            {
                double pesoacumulado = 0;

                for (int j = 0; j < pesoContenedores[i].Length; j++)
                {

                    pesoacumulado = pesoacumulado + pesoContenedores[i][j];



                }

                if (pesoacumulado < menorpeso)
                {
                    menorpeso = pesoacumulado;
                    nave = naves[i].devolverNombre();
                }


            }

            Console.WriteLine("La nave con menor peso total es " + nave + " con un peso de " + menorpeso + " toneladas.");


        }







        static void Main(string[] args)
        {
            PuertoControl puerto = new PuertoControl();
            puerto.MostrarDatosNave();
            puerto.ContenedorMasPesado();
            puerto.MenorPesoAcumulado();
            Console.ReadKey();


        }
    }
}
