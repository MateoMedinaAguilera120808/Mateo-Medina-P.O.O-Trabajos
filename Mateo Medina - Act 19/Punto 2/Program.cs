using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{

    /*
     2. Crear una clase parcial Libro.
        En el primer archivo, declarar las propiedades Título, Autor y Páginas. Validar que la
        cantidad de páginas sea mayor a 10. Valores cargados desde consola
        En el segundo archivo, agregar un método Resumen() que muestre el título, autor y
        si el libro es corto (menos de 100 páginas) o largo.
        Desde la clase principal, cargar 2 libros y mostrar cuál es el más extenso.
     */


    class Program
    {

        static void Main(string[] args)
        {
            Libro librito1 = new Libro();
            Libro librito2 = new Libro();

            librito1.Resumen();
            librito2.Resumen();

            if (librito1.ObtenerPaginas > librito2.ObtenerPaginas)
            {
                Console.WriteLine("El libro " + librito1.ObtenerTitulo + " es mas extenso");
            }else
            {
                Console.WriteLine("El libro " + librito2.ObtenerTitulo + " es el mas extenso ");
            }

            Console.ReadKey();
        }
    }
}
