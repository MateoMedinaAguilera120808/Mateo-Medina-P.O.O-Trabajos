using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    /*
     2. Control de Vuelos
        Plantear una clase llamada Pasajero que tenga los atributos privados: Nombre, DNI y EquipajeKilos (peso del equipaje en kg). En su constructor, solicitar la carga de estos tres datos.
        Luego, confeccionar una clase llamada Vuelo que administre un vector de 4 objetos de la clase Pasajero. Su constructor debe inicializar el vector y solicitar la carga por teclado de cada uno de los 4 pasajeros.
        Agregar los siguientes métodos en la clase Vuelo:
        Un método que muestre un listado completo con los datos de todos los pasajeros del vuelo.
        Un método que calcule y muestre el peso total de equipaje que transporta el avión (la suma de todos los pesos).
        Un método que informe si algún pasajero excede el límite permitido de equipaje (mayor a 23 kg), imprimiendo su nombre y su DNI.

     
     */



    class Pasajero
    {
        private string nombre;
        private int DNI;
        private float EquipajeKilos;

        public Pasajero()
        {
            string linea;

            Console.WriteLine("Ingrese el nombre del pasajero ");
            linea = Console.ReadLine();
            nombre = linea;
            Console.WriteLine("Ingrese su DNI ");
            linea = Console.ReadLine();
            DNI = int.Parse(linea);
            Console.WriteLine("Ingrese el peso de su equipaje ");
            linea = Console.ReadLine();
            EquipajeKilos = float.Parse(linea);
        }

        public string obtenernombre()
        {
            return nombre;
        }

        public int obtenerdni()
        {
            return DNI;
        }

        public float obtenerpeso()
        {

            return EquipajeKilos;
        }


    }


    class Vuelo
    {
        private Pasajero[] Pasajero = new Pasajero[4];


        public Vuelo()
        {
            for (int i = 0; i < 4; i++)
            {
                Pasajero[i] = new Pasajero();
            }
        }



        public void mostrardatos()
        {

            for(int i = 0;i < 4; i++)
            {
                Console.Write(Pasajero[i].obtenernombre() + " ");
                Console.Write(Pasajero[i].obtenerdni() + " ");
                Console.WriteLine(Pasajero[i].obtenerpeso());

            }
            
        }

        public void calcularpesototal()
        {
            float pesototal = 0 ;


            for (int i = 0; i < 4; i++)
            {
                pesototal = pesototal + Pasajero[i].obtenerpeso();


            }

            Console.WriteLine("El peso total por parte de los pasajeros fue de " + pesototal);
        }



        public void calcularexcedente()
        {

            for (int i = 0; i < 4; i++)
            {
                if (Pasajero[i].obtenerpeso() > 23) {

                    Console.WriteLine("El pasajero " + Pasajero[i].obtenernombre() + " de dni " + Pasajero[i].obtenerdni() + " se excede del peso ");
                
                }

            }

        }




        static void Main(string[] args)
        {
            Vuelo v = new Vuelo();
            v.mostrardatos();
            v.calcularpesototal();
            v.calcularexcedente();
            Console.ReadKey();



        }
    }
}
