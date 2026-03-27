using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    internal class Program
    {


        //2. Se ingresan seis notas de un alumno, si el promedio es mayor o igual a siete mostrar un mensaje "Promocionado"


        static void Main(string[] args)
        {
            int nota1, nota2, nota3, nota4, nota5, nota6;
            float promedio;
            string linea;


            Console.Write("Poner la primera nota ");
            linea = Console.ReadLine();
            nota1 = int.Parse(linea);

            Console.Write("Poner la segunda nota ");
            linea = Console.ReadLine();
            nota2= int.Parse(linea);

            Console.Write("Poner la tercera nota ");
            linea = Console.ReadLine();
            nota3 = int.Parse(linea);

            Console.Write("Poner la cuarta nota ");
            linea = Console.ReadLine();
            nota4 = int.Parse(linea);

            Console.Write("Poner la quinta nota ");
            linea = Console.ReadLine();
            nota5 = int.Parse(linea);

            Console.Write("Poner la sexta nota ");
            linea = Console.ReadLine();
            nota6 = int.Parse(linea);



            promedio = (nota1 + nota2 + nota3 + nota4 + nota5 + nota6) / 6;

            if (promedio >= 7)
            {
                Console.Write("El promedio del alumno es " + promedio + " por lo que esta promocionado");
            }
            else
                Console.Write("No aprobo");

            Console.ReadKey();

        }
    }
}
