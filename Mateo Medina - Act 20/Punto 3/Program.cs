using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{

    /*
     Actividad 3: Estadísticas de visitas a zonas arqueológicas
        Problema:
        Un instituto de arqueología desea registrar las visitas semanales a 3 zonas
        arqueológicas durante 4 semanas.
        Plantear una matriz de 3x4 donde las filas representan las zonas y las columnas los
        días. Luego:
         Calcular el total de visitas por zona y almacenarlo en un vector.
         Mostrar los datos en forma tabular.
         Agregar estos resultados a una lista llamada zonasVisitadas que contenga
        nombres de zonas y total de visitas.
         Determinar cuál fue la zona más visitada.
     */



    public class ZonaResultado
    {
        string nombre;
        int total;


        public string Nombre
        {   
            get { return nombre; }
            set { nombre = value; }
        }

        public int Total
        {
            set { total = value; }
            get { return total; }
        }

        public ZonaResultado(string Nombre, int Total)
        {
            nombre = Nombre;
            total = Total;

        }

    }

        class zonasArqueologicas
        {
            int[,] Zonas = new int[3, 4];
            int[] TotalVisitas = new int[3];
            string[] NombresZonas = new string[3];
            string linea;


            public int[] Totalvisitas
            {
                get
                {
                    return TotalVisitas;
                }
            }

            public string[] NombreZonas
            {

                get
                {
                    return NombresZonas;
                }
            }


            public zonasArqueologicas()
            {

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("ingrese el nombre de la zona");
                    linea = Console.ReadLine();
                    NombresZonas[i] = linea;
                    for (int j = 0; j < 4; j++)
                    {
                        Console.WriteLine("Ingrese las visitas que se le hizo a la zona " +( i + 1));
                        linea = Console.ReadLine();
                        Zonas[i, j] = int.Parse(linea);
                    }

                }

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {

                        TotalVisitas[i] = TotalVisitas[i] + Zonas[i, j];

                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    Console.Write(NombresZonas[i] + " | ");
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(Zonas[i, j] + " | ");

                    }
                    Console.WriteLine();
                }

            }



            static void Main(string[] args)
            {
                List<ZonaResultado> ListaZonas = new List<ZonaResultado>();
                zonasArqueologicas Zonas = new zonasArqueologicas();
                string Nombre;
                int Total;

                for (int i = 0; i < 3; i++)
                {
                    Nombre = Zonas.NombreZonas[i];
                    Total = Zonas.Totalvisitas[i];

                    ZonaResultado NuevaZona = new ZonaResultado(Nombre, Total);

                    ListaZonas.Add(NuevaZona);

                }

                if (ListaZonas[0].Total > ListaZonas[1].Total && ListaZonas[0].Total > ListaZonas[2].Total)
                {
                    Console.WriteLine("La zona " + ListaZonas[0].Nombre + " es la mas visitada");
                }
                else if (ListaZonas[1].Total > ListaZonas[0].Total && ListaZonas[1].Total > ListaZonas[2].Total)
                {
                    Console.WriteLine("La zona " + ListaZonas[1].Nombre + " es la mas visitada");
                }
                else if (ListaZonas[2].Total > ListaZonas[0].Total && ListaZonas[2].Total > ListaZonas[1].Total)
                {
                    Console.WriteLine("La zona " + ListaZonas[2].Nombre + " es la mas visitada");
                }
                else
                {
                    Console.WriteLine("Ninguna es mas visitada que la otra");
                }




            Console.ReadKey();








            }
        }
    
}
