using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    partial class Libro
    {
        private string Titulo;
        private string Autor;
        private int Paginas;

        

            public string ObtenerTitulo
        {

            get { return Titulo; }

            set { Titulo = value; }

        }


            public string ObtenerAutor
        {
            get { return Autor; }
            set { Autor = value; }

        }
            
            public int ObtenerPaginas
        {

            get { return Paginas; }
            set { Paginas = value; }

        }

        public Libro()
        {
            string linea;

            Console.WriteLine("Ingrese el titulo del libro ");
            linea = Console.ReadLine();
            Titulo = linea;

            Console.WriteLine("Ingrese el nombre del autor ");
            linea = Console.ReadLine();
            Autor = linea;

            Console.WriteLine("Ingrese la cantidad de paginas de libro ");
            linea = Console.ReadLine();
            Paginas = int.Parse(linea);

            if (Paginas < 10)
            {
                do
                {
                    Console.WriteLine("La cantidad debe de ser mayor a 10 ");
                    linea = Console.ReadLine();
                    Paginas = int.Parse(linea);

                } while (Paginas < 10);

            }
        }
    }
}
