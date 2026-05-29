using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{

    /*
     4. Inventario de Sucursales 
        Plantear una clase llamada Articulo que tenga como atributos privados el NombreArticulo, el Precio y el StockActual. El constructor de la clase debe cargar estos atributos por teclado.
        Confeccionar otra clase llamada Sucursal que contenga un vector de 3 objetos de la clase Articulo. El constructor de Sucursal debe pedir el nombre o número de la sucursal y realizar la carga de los 3 artículos.
        Implementar en la clase Sucursal los siguientes métodos:
        Un método que imprima la lista de los artículos junto con su valor total en inventario (Precio * Stock).
        Un método que busque y muestre el nombre del artículo más caro del local.
        Un método que verifique e indique qué artículos de la sucursal requieren reposición urgente (aquellos cuyo stock sea menor o igual a 5 unidades).

     */


    class Articulo
    {
        private string NombreArticulo;
        private float Precio;
        private int StockActual;


        public Articulo()
        {
            string linea;

            Console.WriteLine("Ingrese el nombre del producto ");
            linea = Console.ReadLine();

            NombreArticulo = linea;

            Console.WriteLine("ingrese el precio del producto ");
            linea = Console.ReadLine();
            Precio = float.Parse(linea);

            Console.WriteLine("Ingrese el stock anual que tenga el producto ");
            linea = Console.ReadLine();
            StockActual = int.Parse(linea);

        }

        public string obtenernombre()
        {
            return NombreArticulo;

        }

        public float obtenerprecio()
        {
            return Precio;
        }

        public int obtenerstock()
        {
            return StockActual;
        }

    }


    internal class Sucursal
    {
        private int SucursalActual;
        private Articulo[] articulo = new Articulo[3];


        public Sucursal()
        {
            string linea;

            Console.WriteLine("Ingrese el numero de sucursal actual");
            linea = Console.ReadLine();
            SucursalActual = int.Parse(linea);

            for (int i = 0; i < 3; i++)
            {
                articulo[i] = new Articulo();

            }
        }

        public void imprimirdatos()
        {

            for (int i = 0;i < 3; i++)
            {
                Console.WriteLine(articulo[i].obtenernombre() + " | precio de " +articulo[i].obtenerprecio() + " | stock de " +  articulo[i].obtenerstock() + " | precio total de " + articulo[i].obtenerstock() * articulo[i].obtenerprecio());

            }

        }


        public void buscarcaro()
        {
            float mascaro = articulo[0].obtenerprecio();
            int aux = 0;

            for(int i = 0; i < 3; i++)
            {
                if (articulo[i].obtenerprecio() > mascaro)
                {
                    mascaro = articulo[i].obtenerprecio();
                    aux = i;
                }

            }

            Console.WriteLine("El objeto mas caro es " + articulo[aux].obtenernombre() + " con un valor de " + mascaro);

        }
        

        public void calcularreposicion()
        {
            for(int i = 0; i < 3 ; i++)
            {
                if (articulo[i].obtenerstock() <= 5)
                {
                    Console.WriteLine("El articulo " + articulo[i].obtenernombre() + " necesita re-stock urgente" );
                }

            }

        }

        static void Main(string[] args)
        {
            Sucursal suc = new Sucursal();
            suc.imprimirdatos();
            suc.buscarcaro();
            suc.calcularreposicion();
            Console.ReadKey(); 





        }
    }
}
