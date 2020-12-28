using System;

namespace UD4_Ex5
{
    class Program
    {
        /* 5) Pedir el nombre de la semana al usuario y decirle si es fin de semana o no. En
        caso de error, indicarlo.*/

        static void Main(string[] args)
        {
            Console.WriteLine("Día de la Semana: ");
            string dia = Console.ReadLine();

            switch (dia)
            {
                case "sabado":
                case "domingo":
                    Console.WriteLine("¡Es fin de semana!");
                    break;
                case "lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine("No es fin de semana... :S");
                    break;
                default:
                    Console.WriteLine("Qué diantres has escrito????");
                    break;
            }
        }
    }
}