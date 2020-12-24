using System;

namespace UD4_Ex22
{
    class Program
    {
        /* 22) Escribe una aplicación con un String que contenga una contraseña cualquiera. Después
            se te pedirá que introduzcas la contraseña, con 3 intentos. Cuando aciertes ya no pedirá mas
            la contraseña y mostrara un mensaje diciendo “Enhorabuena”. Piensa bien en la condición
            de salida (3 intentos y si acierta sale, aunque le queden intentos).
        */
        static void Main(string[] args)
        {
            string pass = "1234";
            int intentos = 3;

            do
            {
                Console.WriteLine("Escribe tu contraseña. Intentos restantes: {0} ", intentos);
                string entrada = Console.ReadLine();

                if (entrada.Equals(pass)) // Comprobamos coincidencia.
                {
                    Console.WriteLine("Enhorabuena");
                    break; // Salimos del programa
                }
                else
                {
                    Console.WriteLine("ERROR: Contraseña incorrecta.");
                    intentos--; // Restamos 1 a los intentos restantes.
                }

            } while (intentos != 0);

            if (intentos == 0) Console.WriteLine("Cuenta Bloqueada, contacte con el administrador."); // Si no quedan intentos, bloqueamos la cuenta. 
        }
    }
}
