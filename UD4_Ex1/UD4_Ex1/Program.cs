using System;

namespace UD4_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Crear 3 variables numéricas con el valor que tu quieras y en otra variable
            numérica guardar el valor de la suma de las 3 anteriores. Mostrar por consola.*/

            int a = 1;
            int b = 2;
            int c = 3;
            int suma = a + b + c;

            Console.WriteLine("Variables: a={0}, b={1}, c={2}. La suma de las tres es {3}", a, b, c, suma);

        }
    }
}
