using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4. En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada
            cuenta corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe
            finalizar al ingresar un valor negativo en el número de cuenta.
            Se pide confeccionar un programa que lea los datos de las cuentas corrientes e
            informe:
            a) De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo
            que:
            Estado de la cuenta:
            ○ “Acreedor” si el saldo es &gt;0.
            ○ “Deudor” si el saldo es &lt;0.
            ○ “Nulo” si el saldo es =0.
            b) La suma total de los saldos acreedores.*/



            int saldo, num_cuenta, sumaTotal;
            string linea, datos, estado_cuenta;
            sumaTotal = 0;
            datos = "";
            saldo = 0;

            do {
                Console.WriteLine("Ingrese su numero de cuenta, para finalizar ingrese un numero negativo ");
                linea = Console.ReadLine();
                num_cuenta = int.Parse(linea);

                if (num_cuenta > 0) {
                    Console.WriteLine("Ingrese el saldo de su cuenta ");
                    linea = Console.ReadLine();
                    saldo = int.Parse(linea);


                if (saldo < 0)
                {
                    


                    Console.WriteLine("El estado de la cuenta es deudor ");
                    estado_cuenta = "deudor";

                } else if (saldo == 0) {
                    Console.WriteLine("El estado de la cuenta es nulo ");
                    estado_cuenta = "nulo";
                }
                else
                {
                    Console.WriteLine("El estado de la cuenta es Acreedor ");
                    sumaTotal = sumaTotal + saldo;
                    estado_cuenta = "acreedor";

                }

                datos += "El numero de cuenta es: " + num_cuenta + " Y su saldo es: " + saldo + " Y su estado de cuenta es: " + estado_cuenta + " \n ";

                }


            } while (num_cuenta > 0);

            Console.WriteLine(datos);

            Console.WriteLine("La suma total de los saldos acreedores es de " + sumaTotal);

            Console.ReadKey();
        }
    }
}
