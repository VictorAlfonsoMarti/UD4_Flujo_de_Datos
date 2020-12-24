using System;

namespace UD4_Ex3
{
    class Program
    {
        /* 3) Pedir por consola tu nombre y tu edad y mostrar el siguiente mensaje: “Te
        llamas ” <nombre> ” y tienes ” <años> ” años”. */

        static void Main(string[] args)
        {
            Console.WriteLine("¿Nombre?");
            string nombre = Console.ReadLine();

            Console.WriteLine("¿Edad?");
            int edad = Convert.ToInt32(Console.ReadLine()); // Convertimos en int el string que recogemos. 

            Console.WriteLine("Te llamas {0} y tienes {1} años.", nombre, edad);

        }
    }
}
