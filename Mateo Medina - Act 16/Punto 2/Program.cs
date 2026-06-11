using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    /*
     2. Plantear una clase Producto y otra clase Inventario.
        La clase Producto debe tener como atributos privados el nombre, precio y
        stock. Definir propiedades para acceder a estos atributos, asegurando que el
        stock no pueda ser negativo y el precio sea mayor a cero.
        La clase Inventario debe contener 3 objetos de la clase Producto. Definir un
        método para mostrar todos los productos ordenados de menor a mayor en
        base al precio, además, mostrar el producto más caro y más barato del
        inventario.
     
     */

    class Producto
    {

        private string nombre;
        private float precio;
        private int stock;

        public Producto()
        {
            string linea;


            Console.WriteLine("Ingrese el nombre del producto ");
            linea = Console.ReadLine();
            nombre = linea;

          
      
            for (int i = 0; i < 1;) {

                Console.WriteLine("Ingrese el precio de ese producto ");
                linea = Console.ReadLine();

                if ( float.Parse(linea) <= 0) {

                Console.WriteLine("El precio no puede ser menor o igual a 0 , ingrese de nuevo  ");
            }
            else { 
            precio = float.Parse(linea);
                    i++;
            }

            }
            for (int i = 0; i < 1;)
            {
                Console.WriteLine("Ingrese la cantidad de stock que tiene ese producto ");
                linea = Console.ReadLine();

                if(int.Parse(linea) < 0){
                    Console.WriteLine("No se puede tener stock en negativo, ingrese de nuevo ");
                }
                else
                {
                    stock = int.Parse(linea);
                    i++;

                }
            }

        }

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

        public float Precio
        {
            set 
            {
            precio = value;
            }
            get 
            {
            return precio;
            }

        }

        public int Stock
        {
            set 
            {
            stock = value;
            }
            get 
            {
                return stock;
            }


        }

    }




    internal class Inventario 
    {
        private Producto[] productos ;
            
        public Inventario()
        {

            productos = new Producto[3];


            for (int i = 0; i < 3; i++)
            {
                productos[i] = new Producto();

            }

        }



        public void ordenarMenorMayor()
        {
            Producto aux;

            

            for(int i = 0;i < productos.Length - 1; i++)
            {

                for(int j = 0;j < 3 - i - 1; j++)
                {
                    if (productos[j].Precio > productos[j+1].Precio)
                    {
                        aux = productos[j];
                        productos[j] = productos[j+1];
                        productos[j + 1] = aux;
                    }

                }

            }



            Console.WriteLine("El orden de los productos esta de menor a mayor: ");

            for (int i = 0; i < productos.Length; i++)
            {



                Console.WriteLine(productos[i].Nombre + " | " +  productos[i].Precio + " | " + productos[i].Stock );

            }
            


        }

        public void MostrarBaratoCaro()
        {
            float comparador = productos[0].Precio;
            float comparador2 = productos[0].Precio;
            int aux = 0;
            int aux2 = 0;

            for (int i = 0; i < productos.Length; i++)
            {

                if (productos[i].Precio < comparador)
                {
                    comparador = (productos[i].Precio);
                    aux = i;
                } 
                
                if (productos[i].Precio > comparador2)
                {
                    comparador2 = productos[i].Precio;
                    aux2 = i;
                }

            }

            Console.WriteLine("El producto mas caro es el " + productos[aux2].Nombre);
            Console.WriteLine("El producto mas barato es el " + productos[aux].Nombre);


        }










        static void Main(string[] args)
        {


            Inventario inventario = new Inventario();

            inventario.ordenarMenorMayor();
            inventario.MostrarBaratoCaro();
            Console.ReadKey();

        }
    }
}
