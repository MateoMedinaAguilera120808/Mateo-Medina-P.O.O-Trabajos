using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    internal class ExamenCocina
    {

        /*
         3. Academia de Gastronomía: Recetario Dinámico
            Un chef instructor evalúa a 3 alumnos en un examen final. Cada alumno debe presentar
            una cantidad distinta de platos (uno presenta 2 platos, otro 4 y otro 3).
            ● Definir un vector para los nombres de los alumnos.
            ● Definir una matriz irregular para cargar el puntaje obtenido (0 a 100) en cada plato
            presentado.
            ● Métodos:
            1. Cargar nombres y definir el tamaño de las filas según la cantidad de platos
            de cada alumno.
            2. Cargar los puntajes de cada plato validando que estén entre 0 y 100.
            3. Mostrar el listado de alumnos y el puntaje de cada uno de sus platos.
            4. Calcular el puntaje promedio de cada alumno e informar si está Aprobado
            (promedio >= 70) o Reprobado
            5. Determinar quién obtuvo el puntaje individual más alto en un solo plato (el
            valor máximo de la matriz).

         }*/
        
        private string[] alumnos = new string[3];
        private string[][] platos = new string[3][];
        private int[][] puntajes = new int[3][];


        public void determinar()
        {
            platos[0] = new string[2];
            platos[1] = new string[4];
            platos[2] = new string[3];

            puntajes[0] = new int[2];
            puntajes[1] = new int[4];
            puntajes[2] = new int[3];

        }

        public void cargar()
        {
            string linea;

            for (int i = 0; i < alumnos.Length; i++)
            {

                Console.WriteLine("Ingrese el nombre del alumno ");
                linea = Console.ReadLine();
                alumnos[i] = linea;

                for (int j = 0; j < platos[i].Length; j++)
                {
                    Console.WriteLine("Ingrese el nombre de su plato ");
                    linea = Console.ReadLine();
                    platos[i][j] = linea;

                    Console.WriteLine("Y cuanto puntaje tiene este plato? ");
                    linea = Console.ReadLine();

                    
                    if(int.Parse(linea) > 0 && int.Parse(linea) <= 100) { 

                        puntajes[i][j] = int.Parse(linea);

                    }
                    else
                    {
                        Console.WriteLine("El valor no puede ser menor a 0 ni mayor a 100, se termina la funcion");
                        return;  
                    }

                }


            }




        }

        public void imprimir()
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.Write("Alumno: " + alumnos[i] + " | ");

                for (int j = 0; j < platos[i].Length; j++)
                {
                    Console.Write(" Plato: " + platos[i][j] + " Puntaje: " + puntajes[i][j] + " | ");
                }

                Console.WriteLine();
            }
        }

        public void calcular()
        {
            
            float promedio = 0;


            for (int i = 0; i < alumnos.Length; i++)
            {
                int suma = 0;

                for (int j = 0; j < platos[i].Length; j++)
                {
                    suma = suma + puntajes[i][j];
                }

                promedio = suma / platos[i].Length;

                if (promedio >= 70)
                {
                    Console.WriteLine("El alumno " + alumnos[i] + " esta aprobado con un promedio de " + promedio);

                }
                else if (promedio < 70)
                {
                    Console.WriteLine("El alumno " + alumnos[i] + " esta desaprobado con un promedio de " + promedio);


                }

            }

            
        }

        public void valorAlto() { 
            int masAlto = puntajes[0][0];
            int nombre = 0;
            int plato = 0;

            for(int i = 0;i < alumnos.Length; i++)
            {
                for(int j = 0; j < platos[i].Length; j++)
                {
                    if (puntajes[i][j] > masAlto)
                    {
                        masAlto = puntajes[i][j];
                        nombre = i;
                        plato = j;
                    }

                }


            }

            Console.WriteLine("El puntaje mas alto es " + masAlto + " del alumno " + alumnos[nombre] + " con el plato " + platos[nombre][plato]);



            Console.ReadKey();


        }





        static void Main(string[] args)
        {
            ExamenCocina EC = new ExamenCocina();
            EC.determinar();
            EC.cargar();
            EC.imprimir();
            EC.calcular();
            EC.valorAlto();
        }
    }
}
