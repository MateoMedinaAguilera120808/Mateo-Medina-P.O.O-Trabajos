using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    internal class Program
    {

        /* 1. En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y
        $500, realizar un programa que lea los sueldos que cobra cada empleado e
        informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más
        de $300. Además el programa deberá informar el importe que gasta la empresa
        en sueldos al personal.*/

        static void Main(string[] args)
        {
            int cant_emp, cant_emp_mas, cant_emp_men, importe, sueldo, cont;
            string linea;

            
            cant_emp_men = 0;
            cant_emp_mas = 0;
            cont = 0;

            importe = 0;

            Console.WriteLine("Ingrese la cantidad de empleados ");
            linea = Console.ReadLine();
            cant_emp = int.Parse(linea);


            while (cont < cant_emp)
            {
                Console.WriteLine("Ingrese el sueldo del empleado entre 100 y 500 ");
                linea = Console.ReadLine();
                sueldo = int.Parse(linea);
                importe = importe + sueldo;
                cont = cont + 1;


                if (sueldo <= 300)
                {
                    Console.WriteLine("El empleado cobra 300 o menos ");
                    cant_emp_men = cant_emp_men + 1;
                } else
                {
                    Console.WriteLine("El empleado cobra mas de 300 ");
                    cant_emp_mas = cant_emp_mas + 1;
                }
            }


            Console.WriteLine("El total de dinero dado a los empleados es de " + importe);

            Console.WriteLine("La cantidad de empleados que cobran entre 100 y 300 es de " + cant_emp_men);

            Console.WriteLine("La cantidad de empleados que cobran mas de 300 es de " + cant_emp_mas);


            Console.ReadKey();
        }
    }
}