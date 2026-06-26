using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{

    /*
     Actividad 2: Administración de entregas logísticas
        Problema:
        Una empresa de envíos desea registrar sus entregas mediante colaboración de
        clases.
        Crear una clase Paquete con propiedades: código, peso y destino. Crear una clase
        Despachador que contenga una lista de paquetes y un método para registrar nuevos
        paquetes.
        Desde el método Main, instanciar un Despachador, cargar 5 paquetes y mostrar:
         Todos los paquetes registrados.
         Cuántos superan los 10 kg de peso.
         Cuántos tienen destino nacional (por ejemplo, “Argentina”).
     */
    class Paquetes
    {
        protected string codigo;
        protected float peso;
        protected string destino;

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                {
                    codigo = value;
                }
            }
        }
        public float Peso
        {
            get
            {
                return peso;
            }

            set
            {
                peso = value;
            }

        }


        public string Destino
        {
            get
            {
                return destino;
            }

            set { 
            destino = value;
            }

        }

        public Paquetes()
        {
            string linea;
            Console.WriteLine("ingrese el codigo del producto ");
            linea = Console.ReadLine();
            codigo = linea;

            Console.WriteLine("Ingrese el peso del paquete ");
            linea = Console.ReadLine();
            peso = float.Parse(linea);

            Console.WriteLine("Ingrese el destino del producto ");
            linea = Console.ReadLine();
            destino = linea;
        }

    }

     class Despachador
    {
       List <Paquetes> ListaPaquetes = new List <Paquetes>();

        
        public void CargarPaquetes()
        {
            

            for (int i = 0; i < 5; i++ )
            {
                ListaPaquetes.Add(new Paquetes());

            }

        }

        public void MostrarPaquetes()
        {
            Console.WriteLine("Lista de paquetes registrados: ");
            foreach (Paquetes p in ListaPaquetes)
            {
                Console.WriteLine(p.Codigo + " tiene destino en " + p.Destino);
            }
            Console.WriteLine();
        }

        public void MayorA10Kilos()
        {
            foreach (Paquetes pa in ListaPaquetes)
            {

                if (pa.Peso > 10)
                {
                    Console.WriteLine("El pedido " + pa.Codigo + " tiene un peso mayor a 10");
                }

            }
        }

        public void BuscarNacional()
        {
            foreach (Paquetes paq in ListaPaquetes)
            {
                if ( paq.Destino.ToLower() == "argentina")
                {
                    Console.WriteLine("El paquete " + paq.Codigo + " tiene de destino Argentina");
                }
            }

            
        }


        static void Main(string[] args)
        {
            Despachador despachador = new Despachador();
            
            despachador.CargarPaquetes();
            despachador.MostrarPaquetes();
            despachador.MayorA10Kilos();
            despachador.BuscarNacional();

            Console.ReadKey();
            

        }
    }
}
