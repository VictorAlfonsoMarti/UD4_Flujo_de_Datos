using System;

namespace UD4_Ex13
{
    // 13) Modifica la aplicación anterior, para que nos pida el nombre que queremos introducir
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Bienvenido {0}", nombre);
        }
    }
}