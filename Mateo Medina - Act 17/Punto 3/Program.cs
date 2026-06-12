using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{
    /*
     3. Fábrica de Computadoras (Herencia y Constructores con base)
        Crear una clase base llamada Computadora que contenga los atributos Marca y
        MemoriaRAM (en GB). Definir un constructor que reciba estos dos valores obligatoriamente.
        Luego, definir dos clases derivadas de la clase base:
         Notebook: que añade el atributo propio TamanoPantalla (en pulgadas).
         Escritorio: que añade el atributo propio PotenciaFuente (en Watts).
        Cada una de estas clases derivadas debe poseer su propio constructor, el cual debe recibir
        tanto los atributos específicos como los de la clase base, transfiriendo estos últimos a la
        clase Computadora mediante el uso explícito de la palabra clave base. Instanciar un objeto
        de cada clase derivada en el Main y mostrar la totalidad de sus datos por consola.
     */

    class computadora
    {

        protected string Marca;
        protected int MemoriaRam;


        public computadora(string m , int mr )
        {
            Marca = m;
            MemoriaRam = mr;

        }
    }

    class notebook : computadora
    {

        double pulgadas;

        public notebook(string m, int mr, double p) : base(m, mr)
        {

            pulgadas = p;

            Console.WriteLine("La notebook es de marca " + m + " y su ram es de " + mr + " con una pantalla de " + p + " pulgadas ");

        }
    }






    internal class escritorio : computadora
    {
        int potencia;
        
        public escritorio (string m, int mr, int p) : base (m , mr)
        {
            potencia = p;

            Console.WriteLine("El escritorio es de marca " + m + " y su ram es de " + mr + " con una potencia en watts de " + p  );
        }




        static void Main(string[] args)
        {
            notebook Notebook = new notebook("Lenovo" , 8 , 16.5);
            escritorio Escritorio = new escritorio("Red Dragon" , 32, 600);
            Console.ReadKey();
        }
    }
}
