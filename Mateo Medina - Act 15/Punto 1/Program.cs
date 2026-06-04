using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{

    /*
    1. Monitoreo Clínico de Pacientes
    En una sala de cuidados intensivos, se requiere realizar un seguimiento constante del ritmo
    cardíaco de los pacientes.
    ● Plantear una clase llamada Paciente que tenga como atributos privados:
    1. Nombre (de tipo string).
    2. Una matriz llamada ritmoCardiaco de tamaño 3x4 (representando los
    registros de pulsaciones tomados durante 3 días diferentes, en 4 momentos
    clave de cada día: mañana, mediodía, tarde y noche).
    3. El constructor de Paciente debe pedir su nombre y solicitar la carga por
    teclado de las 12 lecturas cardíacas.

    ● Confeccionar la clase colaboradora SalaMonitoreo que administre un vector de 3
    objetos de la clase Paciente. Su constructor debe inicializar el vector y solicitar la
    carga de los 3 pacientes. Implementar los siguientes métodos dentro de
    SalaMonitoreo:
    1. Un método que imprima la grilla de lecturas cardíacas completa de cada
    paciente organizada por día y momento.
    2. Un método que calcule e imprima el promedio de pulsaciones de cada
    paciente a lo largo de todo su monitoreo.
    3. Un método que verifique si algún paciente registró un evento de taquicardia
    severa (cualquier lectura individual que sea estrictamente mayor a 120
    pulsaciones), mostrando por consola su nombre y la lectura detectada.
    
    */


    class paciente
    {
        private string nombre;
        private int[,] ritmoCardiaco = new int[3, 4];

        public paciente()
        {
            string linea;

            Console.WriteLine("Ingrese el nombre del paciente ");
            linea = Console.ReadLine();
            nombre = linea;

            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("dia " + (i + 1));

                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Ingrese las pulsaciones del paciente durante el dia (mañana mediodia tarde y noche) ");
                    linea = Console.ReadLine();
                    ritmoCardiaco[i, j] = int.Parse(linea);
                }

            }

        }

        public string obtenernombre()
        {
            return nombre;
        }
        

        public int[,] obtenerritmoCardiaco()
        {
            return ritmoCardiaco;
        }

    }


    internal class SalaMonitoreo
    {
        private paciente[] paciente = new paciente[3];

        public SalaMonitoreo() { 
        
            for(int i = 0;i < 3; i++)
            {
                paciente[i] = new paciente();

            }
        
        
        }



        public void Lectura()
        {
            for (int t = 0; t < 3; t ++) {

                Console.WriteLine(paciente[t].obtenernombre() + " : ");

                
                for (int i = 0;i < 3; i++){
                    Console.Write("dia " + (i + 1) + " | ");

                    for (int j = 0;j < 4; j++)
                {
                        Console.Write((paciente[t].obtenerritmoCardiaco())[i, j] + " | " );
                }

                    Console.WriteLine();
                    Console.WriteLine();
            }

            }
        }

        public void calcularpromedio()
        {



            for (int t = 0; t < 3; t++)
            {
                float promedio = 0;
                float sumatotal = 0;

                for (int j = 0; j < 3; j++)
                {



                    for (int i = 0; i < 4; i++)
                    {

                        sumatotal = sumatotal + paciente[t].obtenerritmoCardiaco()[j, i];


                    }




                }

                promedio = sumatotal / 12;

                Console.WriteLine("El paciente " + paciente[t].obtenernombre() + " tiene un promedio cardiaco de " + promedio);

            }
            }

        public void taquicardia()
        {
            int aux1 = 0;
            int aux2 = 0;

            for(int t = 0;t < 3; t++)
            {
                bool taquicardia = false;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j ++)
                    {
                        if(paciente[t].obtenerritmoCardiaco()[i, j] > 120)
                        {
                            taquicardia = true;
                            aux1 = i;
                            aux2 = j;
                        }

                    }


                }

                if (taquicardia)
                {
                    Console.WriteLine("¡El paciente " + paciente[t].obtenernombre() + " tuvo una taquicardia de " + paciente[t].obtenerritmoCardiaco()[aux1,aux2] + "!");
                }

            }



        }



        static void Main(string[] args)
        {
            SalaMonitoreo Sm = new SalaMonitoreo();
            Sm.Lectura();
            Sm.calcularpromedio();
            Sm.taquicardia();

        }
    }
}
