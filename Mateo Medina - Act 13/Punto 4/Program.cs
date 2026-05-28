using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{

    /*
     4. Plantear una clase Alumno que tenga los atributos privados: nombre y un
        vector de 4 notas. Definir un constructor que solicite el ingreso del nombre del
        alumno y sus 4 calificaciones.
        Luego, confeccionar una clase Curso que contenga un vector de 3 objetos
        Alumno.
        Agregar los siguientes métodos:
        a) Un método que imprima el nombre de cada alumno y su promedio.
        b) Un método que muestre el nombre del alumno con el promedio más
        alto.
        c) Un método que indique qué alumnos tienen al menos una nota
        desaprobada (nota menor a 6)
     */

    class Alumno
    {
        private string nombre;
        private int[] notas = new int[4];

        public Alumno()
        {
            string linea;

            Console.WriteLine("Ingrese el nombre del alumno:");
            linea = Console.ReadLine();
            nombre = linea;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese la nota " + (i + 1) + ":");
                linea = Console.ReadLine();
                notas[i] = int.Parse(linea);
            }
        }

        public string obtenerNombre()
        {
            return nombre;
        }

        public int[] obtenerNotas() { 
        
            return notas;

        }

    }




    class Curso
    {
        private Alumno[] alumnos;

        public Curso() {


            //aca establezco el tamaño del vector de alumnos, pero no los creo, por eso el for

            alumnos = new Alumno[3];

            for (int i = 0;i < alumnos.Length; i++)
            {
                alumnos[i] = new Alumno();
            }

        }

        public void imprimirAlumnos()
        {

            for (int j = 0; j < alumnos.Length; j++) { 
            Console.WriteLine(alumnos[j].obtenerNombre()); 

            for (int i = 0; i < alumnos[j].obtenerNotas().Length ; i++)
            {
                Console.WriteLine(alumnos[j].obtenerNotas()[i]);
            }

            }

        }


        public void alumnoConPromedioMasAlto()
        {

            float[] promedio = new float[3];
            

            for (int j = 0; j < alumnos.Length; j++)
            {
                int sumanotas = 0;

                for (int i = 0; i < alumnos[j].obtenerNotas().Length; i++)

                {
                    sumanotas += alumnos[j].obtenerNotas()[i];
                }
                promedio[j] = sumanotas / alumnos[j].obtenerNotas().Length;

            }



            if (promedio[0] > promedio[1] && promedio[0] > promedio[2])
            {
                Console.WriteLine("El alumno con mayor promedio es " + alumnos[0].obtenerNombre());

            }
            else if (promedio[1] > promedio[0] && promedio[1] > promedio[2])
            {

                Console.WriteLine("El alumno con mayor promedio es " + alumnos[1].obtenerNombre());
            }
            else
            {
                Console.WriteLine("El alumno con mayor promedio es " + alumnos[2].obtenerNombre());

            }



        }


        public void alumnosConNotaDesaprobada() {

            

            for (int j = 0; j < alumnos.Length; j++)
            {
                bool desaprobada = false;

                for (int i = 0; i < alumnos[j].obtenerNotas().Length; i++)
                {
                    if (alumnos[j].obtenerNotas()[i] < 6)
                    {
                        desaprobada = true;
                    }

                    
                }

                if (desaprobada) { 

                Console.WriteLine("El alumno " + alumnos[j].obtenerNombre() + " tiene una nota desaprobada.");
                }
            }



        }




            static void Main(string[] args){
            Curso curso = new Curso();
            curso.imprimirAlumnos();
            curso.alumnoConPromedioMasAlto();
            curso.alumnosConNotaDesaprobada();
            Console.ReadKey();

        }
    }
}
