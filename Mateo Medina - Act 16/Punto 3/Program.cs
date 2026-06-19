using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{

    /*
     3. Crear una clase base Vehículo que contenga atributos marca y
        velocidadMaxima.
        Definir dos clases derivadas: Auto y Moto, que hereden de Vehículo. Cada
        una debe tener un constructor que reciba los valores de los atributos base
        mediante la palabra clave base, y un atributo propio (cantidadPuertas en
        Auto, cilindrada en Moto).
        Crear un objeto de cada clase y mostrar todos sus datos por consola.
     
     
     */
    class vehiculo
    {
        protected string marca;
        protected float velocidadMaxima;


        





        public string DevolverMarca
        {
            set
            {
                marca = value;
            }

            get
            {
                return marca;
            }



        }

        public float VelocidadMaxima{


            set
            {
                velocidadMaxima = value;
            }

            get
            {

                return velocidadMaxima;
            }



        }
        public vehiculo()
        {
            string linea;

            Console.WriteLine("Ingrese la marca del vehiculo ");
            linea = Console.ReadLine();
            marca = linea;

            Console.WriteLine("Ingrese la velocidad maxima capaz del vehiculo ");
            linea = Console.ReadLine();
            velocidadMaxima = float.Parse(linea);


        }


    }

    class motos : vehiculo
    {
         int cilindrada;

        


       

        public int obtenerCilindrada
        {
            set {
                cilindrada = value;
            }

            get { 
            return cilindrada;
            }
        }

        public motos()
        {
            string linea;




            Console.WriteLine("Ingrese la cilindrada de la moto ");
            linea = Console.ReadLine();
            cilindrada = int.Parse(linea);

        }

        public void imprimir()
        {

            Console.WriteLine("La moto es de marca " + marca + " y tiene una velocidad maxima de " + velocidadMaxima + " y tiene " + cilindrada + " de cilindrada ");



        }

    }





    internal class autos : vehiculo
    {

         int cantPuertas;
        

       


        public int obtenerCantPuertas
        {
            set
            {
                cantPuertas = value;
            }
            get
            {

                return cantPuertas;
            }


        }

        public autos()
        {
            string linea;



            Console.WriteLine("Ingrese la cantidad de puertas del auto ");
            linea = Console.ReadLine();
            cantPuertas = int.Parse(linea);


        }

        public void imprimir()
        {
            Console.WriteLine("El auto es de marca " + marca + " y tiene una velocidad maxima de " + velocidadMaxima + " y tiene " + cantPuertas + " puertas ");


        }


        static void Main(string[] args)
        {

            motos base1 = new motos();
            autos base2 = new autos();
            Console.WriteLine("Moto = ");
            base1.imprimir();

            Console.WriteLine();

            Console.WriteLine("Auto = ");
            base2.imprimir();


            Console.ReadKey();


        }
    }
}
