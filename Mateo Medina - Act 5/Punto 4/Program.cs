using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4. Se cuenta con la siguiente información:
            ● Las edades de 20 estudiantes del turno mañana.
            ● Las edades de 30 estudiantes del turno tarde.
            ● Las edades de 15 estudiantes del turno noche.
            Las edades de cada estudiante deben ingresarse por teclado.
            a) Obtener el promedio de las edades de cada turno (tres promedios)
            b) Imprimir dichos promedios (promedio de cada turno)
            c) Mostrar por pantalla un mensaje que indique cuál de los tres turnos tiene un
            promedio de edades menor.*/

            int valor,promedio_ma, promedio_no, promedio_ta,acumulador_ma,acumulador_no,acumulador_ta;
            string linea;
            acumulador_ma = 0;
            acumulador_no = 0;
            acumulador_ta = 0;

            for (int  i = 0; i < 20; i++) { 
            Console.WriteLine("Ingrese las edades de los alumnos de la mañana ");
            linea = Console.ReadLine();
            valor= int.Parse(linea);
                acumulador_ma = acumulador_ma + valor;
                
            }
            for (int k = 0; k < 30; k++)
            {
                Console.WriteLine("Ingrese las edades de los alumnos de la tarde ");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                acumulador_ta = acumulador_ta + valor;
            }

            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine("Ingrese las edades de los alumnos de la noche ");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                acumulador_no = acumulador_no + valor;
            }

            promedio_ma = acumulador_ma / 20;
            promedio_ta = acumulador_ta / 30;
            promedio_no = acumulador_no / 10;

            Console.WriteLine("el promedio de edad de la mañana es de " + promedio_ma);

            Console.WriteLine("el promedio de edad de la tarde es de " + promedio_ta);

            Console.WriteLine("el promedio de edad de la noche es de " + promedio_no);

            if(promedio_ma < promedio_ta && promedio_ma < promedio_no){
                Console.WriteLine("El promedio menor es el de la mañana");

            }else if(promedio_ta < promedio_ma  && promedio_ta < promedio_no){
                Console.WriteLine("El promedio menor es el de la tarde");
            }
            else
            {
                Console.WriteLine("El promedio menor es el de la noche");
            }

        Console.ReadKey();

        }
    }
}
