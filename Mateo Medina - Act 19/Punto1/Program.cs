using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    class Program
    {

        /*
         1. Plantear una clase parcial ReservaHotel.
            En el primer archivo, definir las propiedades NombreCliente, CantidadNoches y
            TipoHabitacion (puede ser “Simple”, “Doble” o “Suite”), validando que la cantidad de
            noches sea mayor a 0. Estos valores son cargados desde la consola.
            En el segundo archivo, agregar un método que calcule el total a pagar según la
            habitación elegida (por ejemplo: Simple = $5000, Doble = $8000, Suite = $12000 por
            noche).
            Desde la clase principal, cargar 3 reservas y mostrar cuál cliente pagará más.
         */



        static void Main(string[] args)
        {
            HabitacionesHotel Hab1 = new HabitacionesHotel();
            Hab1.CalcularPrecio();
            HabitacionesHotel Hab2 = new HabitacionesHotel();
            Hab2.CalcularPrecio();
            HabitacionesHotel Hab3 = new HabitacionesHotel();
            Hab3.CalcularPrecio();

            if (Hab1.ObtenerCosto > Hab2.ObtenerCosto && Hab1.ObtenerCosto > Hab3.ObtenerCosto)
            {
                Console.WriteLine("El cliente " + Hab1.ObtenerNombre + " Es el que pagara mas, teniendo una habitacion " + Hab1.ObtenerTipo + " con un precio de " + Hab1.ObtenerCosto);

            }else if (Hab2.ObtenerCosto > Hab1.ObtenerCosto && Hab2.ObtenerCosto > Hab3.ObtenerCosto)
            {
                Console.WriteLine("El cliente " + Hab2.ObtenerNombre + " Es el que pagara mas, teniendo una habitacion " + Hab2.ObtenerTipo + " con un precio de " + Hab2.ObtenerCosto);

            }else if (Hab3.ObtenerCosto > Hab2.ObtenerCosto && Hab3.ObtenerCosto > Hab1.ObtenerCosto)
            {
                Console.WriteLine("El cliente " + Hab3.ObtenerNombre + " Es el que pagara mas, teniendo una habitacion " + Hab3.ObtenerTipo + " con un precio de " + Hab3.ObtenerCosto);

            }else
            {
                Console.WriteLine("No hay un cliente que haya pagado mas");
            }



            Console.ReadKey();


        }
    }
}
