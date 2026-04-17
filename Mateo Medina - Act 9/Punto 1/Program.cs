using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    /*
     * 1. Se desea desarrollar un programa que permita registrar los nombres y las
        calificaciones de 6 estudiantes. Luego de cargar los datos, se debe mostrar el
        nombre del estudiante con la nota más alta, junto con su nota. Al igual que el
        estudiante con la nota más baja. Informar si hay estudiantes con la misma nota
        máxima o mínima.
     * 
     */


    internal class Notas
    {
        private string[] estudiantes = new string[6];
        private int[] notas = new int[6];
        private int contador = 0;
        private int contador2 = 0;


        public void Cargar()
        {
            string linea;

            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del estudiante ");
                linea = Console.ReadLine();
                estudiantes[i] = linea;
                Console.WriteLine("Ingrese la nota del estudiante ");
                linea = Console.ReadLine();
                notas[i] = int.Parse(linea);
            }


        }

        public void Mostrar()
        {
            int masGrande = notas[1];
            int masChico = notas[1];

            for (int i = 0; i < notas.Length; i++)
            {

                if (notas[i] > masGrande)
                {
                    masGrande = notas[i];
                    contador = i;

                }
                else if (notas[i] < masChico)
                {

                    masChico = notas[i];
                    contador2 = i;

                }


            }

            Console.WriteLine("El alumno con nota mas alta es " + estudiantes[contador] + " y su nota fue " + masGrande);
            Console.WriteLine("El alumno con menos nota fue " + estudiantes[contador2] + " y su nota fue " + masChico);

            for (int i = 0; i < notas.Length; i++)
            {
                //puse el && != a contador porque asi excluye al que ya esta guardado como mas grande y mas chico

                if (notas[i] == masGrande && i != contador)
                {
                    Console.WriteLine("Hay un estudiante con la misma nota mas alta, que es " + estudiantes[i]);
                    

                } else if (notas[i] == masChico && i != contador2) {

                    Console.WriteLine("Hay un estudiante con la misma nota mas baja, que es " + estudiantes[i]);
                }
            }

            Console.ReadKey();
        }


            static void Main(string[] args)
            {
                Notas notas = new Notas();
                notas.Cargar();
                notas.Mostrar();

            }
        }
    }

