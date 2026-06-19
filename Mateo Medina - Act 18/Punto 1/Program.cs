using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    /*
     1.
        Confeccionar una clase llamada DispositivoEnergia que tenga como atributos privados el
        CodigoIdentificador (string) y la GeneracionKwh (double, que representa los Kilowatts-hora
        generados). Definir sus respectivas propiedades de lectura y escritura, validando que la
        generación no sea un valor negativo (en caso de serlo, asignarle 0). Plantear un método para
        imprimir estos datos básicos.
        Luego, crear una segunda clase llamada PanelSolar que herede de DispositivoEnergia. Añadir
        un atributo propio privado llamado AreaMetros (double, que representa la superficie del panel
        en metros cuadrados) con su propiedad correspondiente (validando que sea mayor a cero).
        Implementar un método para imprimir todos los datos del panel, incluyendo los heredados.
        En el programa principal (Main):
        ● Crear un objeto de la clase DispositivoEnergia, ingresar valores y probar su impresión.
        ● Crear un objeto de la clase PanelSolar, cargar sus datos por consola y comprobar que
        puede acceder tanto a sus propiedades heredadas como a las propias para realizar la
        muestra de información.
     */

    class DispositivoEnergia {

        protected string CodigoIdentificador;
        protected double GeneracionKwh;

        



        public string ObtenerCodigo
        {
            set
            {
                CodigoIdentificador = value;
            }


            get
            {
                return CodigoIdentificador;
            }

        }
    
        public double ObtenerKw
        {
            set
            {
                GeneracionKwh = value;
            }

            get
            {

                return GeneracionKwh;
            }

        }

        public DispositivoEnergia()
        {
            string linea;


            Console.WriteLine("Ingrese el codigo identificador del dispositivo");
            linea = Console.ReadLine();
            CodigoIdentificador = linea;

            Console.WriteLine("Ingrese la generacion de KiloWats por hora ");
            linea = Console.ReadLine();
            GeneracionKwh = double.Parse(linea);

            if (GeneracionKwh < 0)
            {
                GeneracionKwh = 0;
            }

        }

        public void Imprimir()
        {

           

            Console.WriteLine("El codigo identificador es " + CodigoIdentificador + " Y su generacion de KW por hora es de " + GeneracionKwh);

        }


    }


    internal class PanelSolar : DispositivoEnergia
    {
        private double AreaMetros;

        

        public double ObtenerArea
        {
            set
            {
                AreaMetros = value;

            }

            get {
            
            return AreaMetros;
            }

        }

        public PanelSolar()
        {
            string linea;


            Console.WriteLine("Ingrese el tamaño del dispositivo");
            linea = Console.ReadLine();
            AreaMetros = double.Parse(linea);

            if (AreaMetros <= 0)
            {
                do
                {
                    Console.WriteLine("El tamaño del dispositivo no puede ser 0 o menor, ingrese de nuevo");
                    linea = Console.ReadLine();
                    AreaMetros = double.Parse(linea);
                } while (AreaMetros <= 0);
            }

        }


        public void ImprimirArea()
        {
            Console.WriteLine("El area del dispositivo es de " + AreaMetros);
        }


        static void Main(string[] args)
        {
            DispositivoEnergia dispositivito = new DispositivoEnergia();
            
            dispositivito.Imprimir();

            PanelSolar Panelito = new PanelSolar();

            Panelito.Imprimir();
            Panelito.ImprimirArea();

            Console.ReadKey();


        }
    }
}
