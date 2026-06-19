using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    partial class Libro
    {

        public void Resumen()
        {

            Console.Write("El libro se llama " + Titulo + " y su autor es " + Autor + " ");
            if (Paginas > 10)
            {
                Console.WriteLine("Y es un libro largo, de " + Paginas);
            }else
            {
                Console.WriteLine("Y es un libro corto, de " + Paginas);
            }

        }


    }
}
