using System;

namespace UD4_Ex11
{
    class Program
    {
        /* 11) Declara 2 variables numéricas (con el valor que desees), he indica cual es mayor de los
        dos.Si son iguales indicarlo también.Ves cambiando los valores para comprobar que
        funciona.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Número 1: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Número 2: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine("{0} es más grande", x);
            }
            else if (x < y)
            {
                Console.WriteLine("{0} es más grande", y);
            }
            else
            {
                Console.WriteLine("Los dos números son iguales");
            }

        }
    }
}
