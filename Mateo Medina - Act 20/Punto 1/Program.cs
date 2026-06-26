using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    /*
     Actividad 1: Sistema de control de vuelos
        Problema:
        Una aerolínea administra los vuelos programados mediante un sistema orientado a
        objetos.
        Plantear una clase base Vuelo que contenga como propiedades: número de vuelo,
        destino y duración en horas. Luego definir una clase derivada VueloInternacional que
        herede de Vuelo e incluya una propiedad adicional llamada paisDestino.
        Crear una lista de objetos de tipo VueloInternacional, cargar 5 vuelos con sus datos
        desde consola y luego:
         Mostrar los vuelos registrados y el país de destino.
         Informar cuál es el vuelo con mayor duración.
         Mostrar el orden de ejecución de los constructores.
     */


    class Vuelo
    {
        protected int NumVuelo;
        protected string Destino;
        protected float DuracionHoras;

        public int numero
        {
            get { return NumVuelo; }
            
        }

        public string destino
        {
            get { return Destino; }
        }

        public float duracion
        {
            get { return DuracionHoras;  }
        }

        public Vuelo(int n, string d, float o)
        {
            NumVuelo = n;
            Destino = d;
            DuracionHoras = o;
            Console.WriteLine("El constructor de vuelo se activo primero");
            Console.WriteLine();
        }


    }



     class VueloInternacional : Vuelo
    {
        private string paisDestino;
        

        public string pais
        {
            get { return paisDestino; }
        }

        public VueloInternacional(int n, string d, float o, string p) : base(n, d, o)
        {
            paisDestino = p;

            Console.WriteLine("El constructor de VueloInternacional se activo segundo ");
            Console.WriteLine();
        }
      


        static void Main(string[] args)
        {


            List<VueloInternacional> ListaVuelos = new List<VueloInternacional>();

            for (int i = 0; i < 5; i++)
            {
                string linea;
                Console.WriteLine("Ingrese el numero de vuelo");
                linea = Console.ReadLine();
                int n = int.Parse(linea);

                Console.WriteLine("Ingrese el destino");
                linea = Console.ReadLine();
                string d = linea;

                Console.WriteLine("Ingrese la duracion en horas");
                linea = Console.ReadLine();
                float o = float.Parse(linea);

                Console.WriteLine("Ingrese el PAIS de destino");
                linea = Console.ReadLine();
                string p = linea;

                VueloInternacional NuevoVuelo = new VueloInternacional(n, d, o, p);

                ListaVuelos.Add(NuevoVuelo);

            }

            foreach (VueloInternacional v in ListaVuelos)
            {
                Console.WriteLine("El numero de vuelo es " + v.numero + " y su destino es " + v.pais);
                Console.WriteLine();
            }

            float duracionComp = ListaVuelos[0].duracion;
            int vueloLargo = 0;

            foreach (VueloInternacional d in ListaVuelos)
            {
                if (d.duracion > duracionComp)
                {
                    duracionComp = d.duracion;
                    vueloLargo = d.numero;
                }

            }

            Console.WriteLine("El vuelo con la duracion mas larga es el " + vueloLargo + " con una duracion de " + duracionComp);

            Console.ReadKey();
        }
    }
}
