using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que lea los lados de n triángulos, e informar:
             De cada uno de ellos, qué tipo de triángulo es: equilátero (tres lados
            iguales), isósceles (dos lados iguales), o escaleno (ningún lado igual)
            b) Cantidad de triángulos de cada tipo.
            c) Tipo de triángulo que posee menor cantidad.*/

            int lado1, lado2, lado3, cant_isoc, cant_eq, cant_esc, cont;
            string linea;
            cant_eq = 0;
            cant_esc = 0;
            cant_isoc = 0;


            Console.Write("Cuantos triangulos quiere ingresar? ");
            linea = Console.ReadLine();
            cont = int.Parse(linea);


            for (int i = 0; i < cont; i++)
            {

                Console.Write("Ingresar el primer lado de un triangulo ");
                linea = Console.ReadLine();
                lado1 = int.Parse(linea);

                Console.Write("Ingrese el segundo lado del triangulo");
                linea = Console.ReadLine();
                lado2 = int.Parse(linea);

                Console.Write("Ingrese el tercer lado del triangulo");
                linea = Console.ReadLine();
                lado3 = int.Parse(linea);

                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("El triangulo es Equilatero");
                    cant_eq = cant_eq + 1;

                }
                else
                {
                    if (lado1 == lado2 && lado2 != lado3 || lado2 ==lado3 && lado3 != lado1)
                    {

                        Console.WriteLine("El triangulo es Isóceles");
                        cant_isoc = cant_isoc + 1;
                    }else if(lado1 != lado2 && lado2 != lado3 ){
                            Console.WriteLine("El triangulo es Escaleno");
                            cant_esc = cant_esc + 1;

                        }
                        

                    }


                }

                Console.WriteLine("La cantidad de triangulos Equilateros es de " + cant_eq);

                Console.WriteLine("La cantidad de triangulos Isóceles es de  " + cant_isoc);

                Console.WriteLine("La cantidad de triangulos Escalenos es de " + cant_esc);

                if (cant_eq < cant_esc && cant_eq < cant_isoc)
                {
                    Console.WriteLine("El triangulo con menor cantidad es el equilatero, con " + cant_eq);
                }
                else if (cant_isoc < cant_eq && cant_isoc < cant_esc)
                {
                    Console.WriteLine("El triangulo con menor cantidad es el Isóceles, con " + cant_isoc);
                }
                else if (cant_esc < cant_eq && cant_esc < cant_isoc)
                {
                    Console.WriteLine("El triangulo con menor cantidad es el escaleno, con " + cant_esc);

                }
                else
                {
                    Console.WriteLine("No hay un triangulo con menor cantidad");
                }

                Console.ReadKey();
            }
        }
    }

