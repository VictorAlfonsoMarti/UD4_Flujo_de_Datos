using System;

namespace UD4_Ex9
{
    // 9) Recorre los números del 1 al 100. Muestra los números pares. Usar el tipo de bucle que quieras.
    class Program
    {
        static void Main(string[] args)
        {
            for (int x=0; x<100; x++)
            {
                if ((x%2)==0) // Revisamos si es par
                {
                    Console.WriteLine(x);
                }

            }
        }
    }
}
