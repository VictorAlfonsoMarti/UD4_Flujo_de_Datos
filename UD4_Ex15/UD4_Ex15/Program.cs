using System;

namespace UD4_Ex15
{
    /* 15) Lee un número por teclado e indica si es divisible entre 2 (resto = 0). Si no lo es, también
    debemos indicarlo */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Número divisible entre 2? Introduce el número:  ");
            int num = Convert.ToInt32(Console.ReadLine());

            if ((num % 2) == 0)
            {
                Console.WriteLine("Sí");
            }
            else
            {
                Console.WriteLine("No");
            }
        
        }
    }
}
