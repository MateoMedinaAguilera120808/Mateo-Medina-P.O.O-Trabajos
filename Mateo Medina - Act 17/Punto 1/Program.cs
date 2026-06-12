using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{

    /*
     1. Personal de un Gimnasio (Herencia Simple y Propiedades)
        Confeccionar una clase llamada PersonaGimnasio que tenga como atributos privados el
        Nombre y el DNI (definir sus respectivas propiedades de lectura y escritura). Plantear un
        método para imprimir estos datos básicos.
        Luego, crear una segunda clase llamada Profesor que herede de PersonaGimnasio. Añadir
        un atributo propio llamado Especialidad (con su propiedad correspondiente) y un método
        para imprimir todos los datos del profesor (incluyendo los heredados).
        En el programa principal (Main):
         Definir un objeto de la clase PersonaGimnasio, asignar valores a sus propiedades y
        llamar a su método de impresión.
         Crear un objeto de la clase Profesor, interactuar con sus propiedades y comprobar
        que puede acceder tanto a sus métodos propios como a los de la clase base.
     */

    class PersonaGimnasio
    {
        protected string nombre;
        protected int dni;

        public string Nombre
        {
            set { nombre = value; }

            get { return nombre; }

        }


        public int Dni
        {
            set {  dni = value; }

            get { return dni; }
        }

        public void ImprimirDatos()
        {

            Console.WriteLine(nombre + " " + dni);

        }


    }


    


    internal class ProfesorGimnasio : PersonaGimnasio
    {
        private string Especialidad;

        public string ObtenerEspecialidad
        {

            set { Especialidad = value; }

            get { return Especialidad; }


        }

        public void ImprimirTodo()
        {
            Console.WriteLine(Nombre + " " + Dni + " " + ObtenerEspecialidad);


        }





    
        static void Main(string[] args)
        {

            PersonaGimnasio Persona1 = new PersonaGimnasio();
            Persona1.Nombre = "Jose estudiante";
            Persona1.Dni = 48924709;
            Persona1.ImprimirDatos();


            ProfesorGimnasio Profe = new ProfesorGimnasio();

            Profe.Nombre = "Carlos";
            Profe.Dni = 39027687;
            Profe.ObtenerEspecialidad = "Boxeo";
            Profe.ImprimirDatos();
            Profe.ImprimirTodo();

            Console.ReadKey();



        }
    }
}
