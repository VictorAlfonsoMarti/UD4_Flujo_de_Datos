using System;

namespace UD4_Ex10
{
    class Program
    {
        // 10) Recorre los números del 1 al 100. Muestra los números pares o divisibles entre 3.
        static void Main(string[] args)
        {
            for (int x = 0; x < 100; x++)
            {
                if (x % 2 == 0 || x % 3 == 0) // Pares o divisibles entre 3
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
