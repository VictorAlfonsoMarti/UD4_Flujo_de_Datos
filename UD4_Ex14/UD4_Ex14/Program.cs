using System;

namespace UD4_Ex14
{
    /* 14) Haz una aplicación que calcule el área de un circulo (pi*R2). El radio se pedirá por
    teclado (recuerda pasar de String a double). Usa la constante PI y el método pow de Math.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para calcualr el área de un circulo. Introduce el radio: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * Math.Pow(radio, 2); //Llamamos al número pi y lo multiplicamos por el radio al cuadrado.

            Console.WriteLine("El área es: {0}", area);

        }
    }
}
