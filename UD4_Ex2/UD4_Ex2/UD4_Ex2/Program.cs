using System;

namespace UD4_Ex2
{
    class Program
    {
        /*2) Pedir por consola un nombre de persona y el nombre de una ciudad (no hace
        falta que sean reales o comprobarlos) y mostrar por pantalla, el siguiente mensaje
        “Hola ” <nombre> ” bienvenido a ” <ciudad>*/


        static void Main(string[] args)
        {

            Console.WriteLine("Hola, escribe tu nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Escribe el nombre de una ciudad: ");
            string ciudad = Console.ReadLine();

            Console.WriteLine("Hola {0}, bienvenido a {1}.", nombre, ciudad);
        }
    }
}
