using System;

namespace UD4_Ex19
{
    // 19) Muestra los números del 1 al 100 (ambos incluidos) divisibles entre 2 y 3. Utiliza el bucle que desees.

    class Program
    {
        static void Main(string[] args)
        {
            for (int x=0; x<=100; x++)
            {
                if ((x % 2) == 0 || (x % 3) == 0)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
