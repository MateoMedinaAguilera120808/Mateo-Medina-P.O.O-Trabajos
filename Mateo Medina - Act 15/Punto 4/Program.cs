using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{

    /*
     4. Línea de Ensamblaje Robótico
        En una planta de fabricación automatizada, cada robot industrial realiza tareas de
        ensamblaje complejas divididas en operaciones secundarias de duración variable.
        ● Diseñar la clase RobotEnsamblador que tenga como atributos privados:
        1. ModeloRobot.
        2. Una matriz irregular de tipo float (float[][] tiemposOperacion) donde cada
        fila representa una de las 4 fases principales del proceso (Estructura,
        Cableado, Pintura y Testeo), y cada columna los segundos que demoró en
        completar las distintas subtareas de esa fase (por ejemplo, en la fase de
        Estructura el robot puede tener 3 sub-tareas, pero en la de Testeo solo tiene
        1).
        3. El constructor de RobotEnsamblador debe pedir su modelo, preguntar para
        cada una de las 4 fases de fabricación cuántas sub-tareas requirió realizar

        (definiendo el tamaño de cada fila) y cargar la duración en segundos de cada
        una de ellas.

        ● Diseñar la clase colaboradora PlantaIndustrial que gestione a 3 objetos de la clase
        RobotEnsamblador. Implementar en PlantaIndustrial:
        1. Un constructor que cargue la información de los 3 robots instalados en la
        planta.
        2. Un método que muestre un reporte detallado con los tiempos de operación
        de cada robot fase por fase.
        3. Un método que calcule el promedio general de tiempo por tarea de cada
        robot y declare al &quot;Robot más Eficiente&quot; (aquel que registre el promedio de
        tiempo por operación más bajo de la planta).
     
     */

    class RobotEnsamblador
    {
        private int ModeloRobot;
        private float[][] tiemposOperacion;

        public RobotEnsamblador()
        {

            tiemposOperacion = new float[4][];

            string linea;

            Console.WriteLine("Ingrese el modelo del robot");
            linea = Console.ReadLine();
            ModeloRobot = int.Parse(linea);

            for (int i = 0; i < tiemposOperacion.Length; i++)
            {
                Console.WriteLine("Cuantas sub-Tareas realizo este robot? ");
                linea = Console.ReadLine();
                tiemposOperacion[i] = new float[int.Parse(linea)];

                
                
                    for (int j = 0; j < tiemposOperacion[i].Length; j++)
                    {
                        Console.WriteLine("Ingrese la duracion de la sub-tarea ");
                        linea = Console.ReadLine();
                        tiemposOperacion[i][j] = float.Parse(linea);


                    }

                

            }
        }
        
            public int devolverModelo()
            {
            return ModeloRobot;

            }

            public float[][] devolverMatriz()
        {

            return tiemposOperacion;
        }
        




    }


    internal class PlantaIndustrial
    {
        private RobotEnsamblador[] Robots = new RobotEnsamblador[3];


        PlantaIndustrial()
        {
            Robots[0] = new RobotEnsamblador();
            Robots[1] = new RobotEnsamblador();
            Robots[2] = new RobotEnsamblador();
            



        }


        public void MostrarRobots()
        {

            for (int i = 0; i < Robots.Length; i++)
            {

                Console.WriteLine("Modelo del robot es: " + Robots[i].devolverModelo());


                for (int t = 0; t < Robots[i].devolverMatriz().Length; t++)
                {


                    for (int j = 0; j < Robots[i].devolverMatriz()[t].Length; j++)
                    {
                        Console.Write("Tiempo: " + Robots[i].devolverMatriz()[t][j] + " ");


                    }

                    Console.WriteLine();



                }


            }
        }

        public void CalcularPromedio()
        {
            float suma = 0;
            
            float promedio = 0;
            
            int divisor = 0;

            int modelo = Robots[0].devolverModelo();

            for (int j = 0; j < Robots[0].devolverMatriz().Length; j++)
            {


                for (int k = 0; k < Robots[0].devolverMatriz()[j].Length; k++)
                {
                    suma = suma + Robots[0].devolverMatriz()[j][k];
                    divisor++;


                }



            }

            promedio = suma / divisor;

            for (int i = 1; i < Robots.Length; i++) {

                float promedio2 = 0;
                float suma2 = 0;
                int divisor2 = 0;

                for (int j = 0; j < Robots[i].devolverMatriz().Length; j++) {


                    for (int k = 0; k < Robots[i].devolverMatriz()[j].Length; k++) {

                        suma2 = suma2 + Robots[i].devolverMatriz()[j][k];
                        divisor2++;
                    
                    }


                
                }

                promedio2 = suma2 / divisor2;

                if (promedio2 < promedio) {
                
                    promedio = promedio2;
                    modelo = Robots[i].devolverModelo();
                
                }



            }


            Console.WriteLine("El Robot con mayor promedio es el " + modelo + " con un promedio de " + promedio );

        }



        static void Main(string[] args)
        {
            PlantaIndustrial PI = new PlantaIndustrial();
            PI.MostrarRobots();
            PI.CalcularPromedio();
            Console.ReadKey();



        }
    }
}
