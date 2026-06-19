using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    partial class HabitacionesHotel
    {
        private string NombreCliente;
        private int CantidadNoches;
        private string TipoHabitacion;

        

        public string ObtenerNombre
        {
            get { return NombreCliente; }
            set { NombreCliente = value; }
        }

        public int ObtenerCantNoches
        {
            get { return CantidadNoches; }
            set { CantidadNoches = value; }
        }

        public string ObtenerTipo
        {
            get { return TipoHabitacion; }
            set { TipoHabitacion = value; }
        }
        public HabitacionesHotel()
        {
            string Linea;

            Console.WriteLine("Ingrese el nombre del cliente");
            Linea = Console.ReadLine();
            NombreCliente = Linea;

            Console.WriteLine("Ingrese la cantidad de noches de su estadía ");
            Linea = Console.ReadLine();
            CantidadNoches = int.Parse(Linea);

            if (CantidadNoches <= 0)
            {
                do
                {
                    Console.WriteLine("Debe de ser una cantidad mayor a 0, ingrese de nuevo");
                    Linea = Console.ReadLine();
                    CantidadNoches = int.Parse(Linea);

                } while (CantidadNoches == 0);

            }

            Console.WriteLine("Ingrese su tipo de Habitacion (Simple , Doble o Suite)");
            Linea = Console.ReadLine();
            TipoHabitacion = Linea.ToLower();

            if (TipoHabitacion != "simple" && TipoHabitacion != "doble" && TipoHabitacion != "suite")
            {

                do
                {
                    Console.WriteLine("El tip de habitacion solo puede ser simple, doble o suite, elija");
                    Linea = Console.ReadLine();
                    TipoHabitacion = Linea.ToLower();

                } while(TipoHabitacion != "simple" && TipoHabitacion != "doble" && TipoHabitacion != "suite");
            }
        }
    }
}
