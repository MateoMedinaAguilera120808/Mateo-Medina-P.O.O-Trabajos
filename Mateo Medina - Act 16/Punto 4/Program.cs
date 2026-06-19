using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    /*
     4. Armar tres clases: Animal, Mamífero y Perro.
        La clase Animal debe tener un atributo especie.
        La clase Mamífero, que hereda de Animal, debe tener un atributo
        tipoAlimentacion.
        La clase Perro, que hereda de Mamífero, debe tener un atributo nombre.
        Cada clase debe tener un constructor que reciba los datos correspondientes
        y los imprima indicando a qué clase pertenecen. Los datos deben ser
        asignados previamente
        Crear un objeto de la clase Perro y verificar la ejecución en cadena de los
        constructores.
     
     */

    class Animal
    {
        protected string especie;

      


        public string obtenerEspecie { 
        
            set {
                especie = value; 
            }

            get {
                return especie;
            }

        }
        public Animal()
        {

            especie = "BullDog";

            Console.WriteLine("Animal : ");
            Console.WriteLine("Su especie es " + especie);
            Console.WriteLine("Esta informacion esta sacada de la clase Animal ");
            Console.WriteLine();
        }


    }

    class mamifero : Animal
    {
        protected string TipoDeAlimentacion;

        public mamifero()
        {
            TipoDeAlimentacion = "Omnivora";
            Console.WriteLine("Su dieta es " + TipoDeAlimentacion);
            Console.WriteLine("Dieta pertenece a la clase mamifero ");
            Console.WriteLine();
        }

      


    }



    internal class Perro : mamifero
    {
        string Nombre;

        public Perro()
        {

            Nombre = "Perrinho";
            Console.WriteLine("Su nombre es " + Nombre);
            Console.WriteLine("El nombre esta sacado de la clase Perro ");
            Console.WriteLine();
        }

       
        

        static void Main(string[] args)
        {

            Perro perro = new Perro();

            
            
            
            Console.ReadKey();


        }
    }
}
