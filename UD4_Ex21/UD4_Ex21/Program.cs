using System;

namespace UD4_Ex21
{
    // 21) Crea una aplicación que nos pida un día de la semana y que nos diga si es un día laboral o no. Usa un switch para ello
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un día de la semana.");
            string dia = Console.ReadLine();

            switch (dia)
            {
                case "lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine("No es fin de semana.");
                    break;
                case "sabado":
                case "domingo":
                    Console.WriteLine("Es fin se semana.");
                    break;
                default:
                    Console.WriteLine("El dia introducido es incorrecto.");
                    break;
            }
        }
    }
}
