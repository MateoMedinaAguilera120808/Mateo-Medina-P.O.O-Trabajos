using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{

    /*
     2.
        Plantear una clase llamada CriaturaMarina y otra clase llamada HabitatAcuatico.
        La clase CriaturaMarina debe tener como atributos privados: Especie (string),
        ProfundidadOptima (int, en metros) y NivelSalinidad (un valor de 1 a 100). Definir las
        propiedades necesarias para acceder a estos atributos asegurando mediante validaciones que:
        ● La profundidad óptima sea estrictamente mayor a cero (0).
        ● El nivel de salinidad se encuentre únicamente en el rango de 1 a 100 (de lo contrario,
        asignar un valor por defecto de 35, que representa la salinidad promedio del océano).
        La clase HabitatAcuatico debe contener como atributo un vector capaz de almacenar 3 objetos
        de la clase CriaturaMarina. Definir un método dentro de HabitatAcuatico para cargar las 3
        criaturas y otro método para mostrar todas las criaturas ordenadas de menor a mayor en base
        a su profundidad óptima. Además, el programa debe informar la especie que requiere el mayor
        nivel de salinidad para sobrevivir.
     */

    class CriaturaMarina
    {
        private string Especie;

        private int ProfundidadOptima;

        private int NivelSalinidad;

        public CriaturaMarina()
        {
            string linea;
            Console.WriteLine("Ingrese la especie de un animal");
            linea = Console.ReadLine();
            Especie = linea;

            Console.WriteLine("Ingrese la profundidad optima para esta especie ");
            linea = Console.ReadLine();
            ProfundidadOptima = int.Parse(linea);


            if (ProfundidadOptima <= 0)
            {
                do
                {
                    Console.WriteLine("La profundidad debe de ser mayor a 0  ");
                    linea = Console.ReadLine();
                    ProfundidadOptima = int.Parse(linea);

                } while (ProfundidadOptima <= 0);

            }


            Console.WriteLine("Ingrese el nivel de salinidad necesaria para su supervivencia (Entre 1 y 100)");
            linea = Console.ReadLine();
            NivelSalinidad = int.Parse(linea);

            if (NivelSalinidad < 1 || NivelSalinidad > 100)
            {
                NivelSalinidad = 35;
            }
        }

        public string ObtenerEspecie
        {
            set { Especie = value; }

            get { return Especie; }
        }

        public int ObtenerProfundidad
        {
            set { ProfundidadOptima = value; }

            get { return ProfundidadOptima; }


        }

        public int ObtenerSalinidad
        {
            set {  NivelSalinidad = value;}

            get {  return NivelSalinidad; }
        }

    }
    internal class HabitatAcuatico
    {
        CriaturaMarina[] Criaturas = new CriaturaMarina[3];

        public HabitatAcuatico() {

            Criaturas[0] = new CriaturaMarina();
            Criaturas[1] = new CriaturaMarina();
            Criaturas[2] = new CriaturaMarina();
        }


        public void imprimirCriaturas()
        {
            for (int i = 0; i < Criaturas.Length; i++)
            {
                Console.WriteLine(Criaturas[i].ObtenerEspecie);
                Console.WriteLine(Criaturas[i].ObtenerProfundidad);
                Console.WriteLine(Criaturas[i].ObtenerSalinidad);
                Console.WriteLine();
            }

        }

        public void MenoraMayor()
        {
            CriaturaMarina aux;

            CriaturaMarina[] ordenado = new CriaturaMarina[3];

            ordenado[0] = Criaturas[0];
            ordenado[1] = Criaturas[1];
            ordenado[2] = Criaturas[2];

            for (int i = 0; i < ordenado.Length - 1; i++)
            {

                for (int j = 0; j < ordenado.Length - 1 - i; j++)
                {
                    if (ordenado[j].ObtenerProfundidad > ordenado[j + 1].ObtenerProfundidad)
                    {
                        aux = ordenado[j];

                        ordenado[j] = ordenado[j + 1];
                        ordenado[j + 1] = aux;

                    }

                }

            }

            Console.WriteLine("Criaturas ordenada de menor profundidad a mayor");

            for (int i = 0;i< ordenado.Length; i++) {
                Console.Write(ordenado[i].ObtenerEspecie + " ");
                Console.WriteLine(ordenado[i].ObtenerProfundidad);

            }
        }

        public void CalcularMayorSalinidad()
        {
            int mayorSalinidad = Criaturas[0].ObtenerSalinidad;
            int aux = 0;

            for (int i = 0; i < Criaturas.Length; i++)
            {
                if (Criaturas[i].ObtenerSalinidad > mayorSalinidad)
                {
                    aux = i;
                    mayorSalinidad = Criaturas[i].ObtenerSalinidad;
                }

            }

            Console.WriteLine("La criatura que necesita mayor salinidad para sobrevivir es " + Criaturas[aux].ObtenerEspecie + " con una salinidad de " + mayorSalinidad);

        }

        static void Main(string[] args)
        {
            HabitatAcuatico habitatsito = new HabitatAcuatico();
            habitatsito.imprimirCriaturas();
            habitatsito.MenoraMayor();
            habitatsito.CalcularMayorSalinidad();
            Console.ReadKey();
        }
    }
}
