using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    /*
     4. Se realiza una evaluación a 6 docentes por parte de sus alumnos. Se registran
        sus nombres y puntajes promedio obtenidos (de 1 a 10).
        Cargar sus datos en vectores paralelos, mostrar docente con calificación más
        alta y más baja, ordenar los vectores de mayor a menor de acuerdo con la
        calificación y mostrar en pantalla la cantidad de docentes que aprobaron y
        desaprobaron (tomando como base que se aprueba con una nota mayor o igual
        a 6)
     */


    internal class Evaluacion
    {

        private string[] docentes = new string[6];
        private int[] notas = new int[6];
        private string[] ordenadoDoc = new string[6];
        private int[] ordenaNot = new int[6];
        string linea;
        
        private int contador1= 0;
        private int contador2= 0;


        public void cargar()
        {
            for (int i = 0; i < docentes.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del docente");
                linea = Console.ReadLine();
                docentes[i] = linea;

                
                Console.WriteLine("Ingrese la nota del docente");
                linea = Console.ReadLine();
                notas[i] = int.Parse(linea);

                if (notas[i] > 10 || notas[i] < 1) {
                    Console.WriteLine("El numero debe de ser entre 1 y 10, ingrese uno nuevo");
                    linea = Console.ReadLine();
                    notas[i] = int.Parse(linea);
                }


            }

        }

        public void calcular()
        {
            int mayor = notas[0];
            int menor = notas[0];


            for (int i = 0; i < docentes.Length; i++)
            {
                ordenadoDoc[i] = docentes[i];
                ordenaNot[i] = notas[i];

            }


            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] > mayor)
                {
                    mayor = notas[i];
                    contador1 = i;

                } else if (notas[i] < menor)
                {
                    menor = notas[i];
                    contador2 = i;


                }

            }




            for (int i = 0; i < ordenadoDoc.Length - 1; i++)
            {
                for (int j = 0; j < ordenaNot.Length - 1 - i; j++)
                {
                    if (ordenaNot[j] < ordenaNot[j + 1]) {
                        int aux = ordenaNot[j];
                        string aux2 = ordenadoDoc[j];

                        ordenaNot[j] = ordenaNot[j + 1];
                        ordenadoDoc[j] = ordenadoDoc[j + 1];

                        ordenaNot[j + 1] = aux;
                        ordenadoDoc[j + 1] = aux2;

                    }
                }


            }

            for (int i = 0; i < docentes.Length; i++)
            {
                if (notas[i] >= 6)
                {
                    Console.WriteLine("El docente " + ordenadoDoc[i] + " esta aprobado con " + ordenaNot[i]);

                }
                else
                {
                    Console.WriteLine("El docente " + ordenadoDoc[i] + " esta desaprobado con " + ordenaNot[i]);
                }

            }

            Console.WriteLine("El docente con la mayor nota es " + docentes[contador1] + " con una nota de " + mayor); 
            Console.WriteLine("El docente con la menornota es " + docentes[contador2] + " con una nota de " + menor );


            




            Console.ReadKey();

        }

        







        static void Main(string[] args)
        {

            Evaluacion ev = new Evaluacion();
            ev.cargar();
            ev.calcular();
        }
    }
}
