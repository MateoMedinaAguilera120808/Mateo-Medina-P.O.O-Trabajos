using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    partial class HabitacionesHotel
    {
        int CostoHabitacion;
        public void CalcularPrecio(){

            if (TipoHabitacion == "simple" )
            {

                CostoHabitacion = 5000 * CantidadNoches;

            }else if (TipoHabitacion == "doble")
            {
                CostoHabitacion = 8000 * CantidadNoches;

            }else if (TipoHabitacion == "suite")
            {
                CostoHabitacion = 12000 * CantidadNoches;
            }



        }

        public int ObtenerCosto
        {
            get { return CostoHabitacion; }

            set { CostoHabitacion = value; }
        }


        
    }
}
