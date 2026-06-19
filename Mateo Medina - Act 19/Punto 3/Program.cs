using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3
{

    /*
     3. Armar una clase parcial JuegoArcade.
        En el primer archivo, definir las propiedades NombreJuego, PuntajeMaximo, y
        NivelDificultad (de 1 a 5). Valores cargados desde consola
        En el segundo archivo, implementar un método que indique si un puntaje ingresado
        supera el récord o no.
        Desde Main, simular 4 partidas, mostrar qué jugador rompió el récord de su juego.
     
     */



    class Program
    {
        static void Main(string[] args)
        {


            Arcade Arcadecito1 = new Arcade();
            Console.WriteLine("En el juego " + Arcadecito1.ObtenerNombre + " se obtuvo una puntuacion de " + Arcadecito1.ObtenerPuntaje + " en la dificultad " + Arcadecito1.ObtenerDificultad);
            Arcadecito1.CalcularRecord();

            Arcade Arcadecito2 = new Arcade();
            Console.WriteLine("En el juego " + Arcadecito2.ObtenerNombre + " se obtuvo una puntuacion de " + Arcadecito2.ObtenerPuntaje + " en la dificultad " + Arcadecito2.ObtenerDificultad);
            Arcadecito2.CalcularRecord();

            Arcade Arcadecito3 = new Arcade();
            Console.WriteLine("En el juego " + Arcadecito3.ObtenerNombre + " se obtuvo una puntuacion de " + Arcadecito3.ObtenerPuntaje + " en la dificultad " + Arcadecito3.ObtenerDificultad);
            Arcadecito3.CalcularRecord();

            Arcade Arcadecito4 = new Arcade();
            Console.WriteLine("En el juego " + Arcadecito4.ObtenerNombre + " se obtuvo una puntuacion de " + Arcadecito4.ObtenerPuntaje + " en la dificultad " + Arcadecito4.ObtenerDificultad);
            Arcadecito4.CalcularRecord();

            Console.ReadKey();







        }
    }
}
