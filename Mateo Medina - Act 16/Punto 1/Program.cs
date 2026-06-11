using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{

    /*
     1. Confeccionar una clase Persona que tenga como atributos el nombre y la
        edad (definir las propiedades para poder acceder a dichos atributos). Definir
        un método para imprimirlos. Plantear una segunda clase Empleado que
        herede de la clase Persona. Añadir un atributo sueldo ( y su propiedad) y el
        método para imprimir su sueldo. Definir un objeto de la clase Persona y
        llamar a sus métodos y propiedades. También crear un objeto de la clase
        Empleado y llamar a sus métodos y propiedades.
     
     */

    class persona
    {
        protected string nombre;
        protected int edad;


        public string Nombre
        {

             set
            {
                nombre = value;

            }

            get
            {

                return nombre;
            }

        }

        public int Edad
        {

             set 
            { 
                edad = value; 
            
            }
            get 
            {
                
                return edad; 
            }

        }


        public void imprimir()
        {
            Console.WriteLine(nombre + " tiene una edad de " + edad);

        }



    }



    internal class Empleado : persona
    {

        public float sueldo;

        public float Sueldo
        {

            set
            {
                 sueldo = value;

            }
            get
            {
                return sueldo;

            }

        }


        public void imprimirSueldo()
        {
            Console.WriteLine("Su sueldo es " + sueldo);

        }



        static void Main(string[] args)
        {
            persona persona1 = new persona();
            persona1.Nombre = "Jose";
            persona1.Edad = 17;
            persona1.imprimir();

            Empleado persona2 = new Empleado();
            persona2.nombre = "Carlos";
            persona2.edad = 17;
            persona2.sueldo = 4000;
            persona2.imprimir();
            persona2.imprimirSueldo();

            Console.ReadKey();


        }
    }
}
