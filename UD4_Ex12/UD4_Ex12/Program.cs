using System;

namespace UD4_Ex12
{
    /* 12) Declara un String que contenga tu nombre, después muestra un mensaje de bienvenida
    por consola. Por ejemplo: si introduzco “Fernando”, me aparezca “Bienvenido Fernando”.
    */
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Victor";
            Console.WriteLine("Bienvenido {0}", nombre);
        }
    }
}
