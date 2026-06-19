using Punto_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{

    /*
     3.

        Crear una clase base llamada SondaExploradora que contenga los atributos Modelo (string) y
        AutonomiaMinutos (int). Definir un constructor que reciba estos dos valores como parámetros y
        realice su asignación.
        Luego, definir dos clases derivadas de la clase base:
        ● SondaSubmarina: que añade el atributo propio PresionMaximaAtm (int, presión máxima
        soportada en atmósferas).
        ● RoverTerrestre: que añade el atributo propio CantidadRuedas (int).
        Cada una de estas clases derivadas debe poseer su propio constructor. El mismo debe recibir
        tanto el atributo específico como los heredados de la clase base, transfiriendo estos últimos a la
        clase SondaExploradora mediante el uso explícito de la palabra clave base.
        En el método Main, instanciar un objeto de cada clase derivada y mostrar la totalidad de sus
        parámetros unificados por consola.
     */

    class SondaExploradora
    {
        protected string Modelo;

        protected int AutonomiaMinutos;

        public SondaExploradora(string M, int A)
        {
            Modelo = M;
            AutonomiaMinutos = A;

        }

        public void imprimirDatos()
        {
            Console.WriteLine("El modelo de la sonda es " + Modelo + " y su autonomia en minutos es de " + AutonomiaMinutos);
        }


    }


    class SondaSubmarina : SondaExploradora
    {
        private int PresionMaximaAtm;

        public SondaSubmarina(string M, int A, int P) : base(M, A)
        {
            PresionMaximaAtm = P;
        }

        public void ImprimirPresion()
        {
            Console.WriteLine("Su presion es de " + PresionMaximaAtm);
        }

    }


    internal class RoverTerrestre : SondaExploradora
    {

        int CantidadRuedas;

        public RoverTerrestre(string M, int A, int C) : base(M, A) {
        
            CantidadRuedas = C;



        }

        public void ImprimirRuedas() {

            Console.WriteLine("Su cantidad de ruedas es de " + CantidadRuedas);
        
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Sonda Exploradora");
            SondaExploradora sondita = new SondaExploradora("jose", 35 );
            sondita.imprimirDatos();
            Console.WriteLine();

            Console.WriteLine("Sonda Submarina");
            SondaSubmarina sonditasub = new SondaSubmarina("maria", 65 , 40);
            sonditasub .imprimirDatos();
            sonditasub.ImprimirPresion();
            Console.WriteLine();

            Console.WriteLine("Rover terrestre :");
            RoverTerrestre rovertito = new RoverTerrestre("robert", 120, 4);
            rovertito.imprimirDatos();
            rovertito.ImprimirRuedas();
            Console.WriteLine();
            Console.ReadKey();



        }
    }

}