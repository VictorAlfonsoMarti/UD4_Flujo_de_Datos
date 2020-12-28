using System;

namespace UD4_Ex4
{
    class Program
    {
        // 4) Pedir dos números al usuario por teclado y decir que número es el mayor.
        static void Main(string[] args)
        {
            Console.WriteLine("Número 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Número 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} es más alto que {1}", Math.Max(num1, num2), Math.Min(num1, num2)); 
        }
    }
}
