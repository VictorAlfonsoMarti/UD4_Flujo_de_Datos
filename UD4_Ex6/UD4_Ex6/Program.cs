using System;

namespace UD4_Ex6
{
    class Program
    {
        /* 6) Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar
        (efectivo o tarjeta) si la forma de pago es mediante tarjeta, pedir el numero de
        cuenta (inventado)*/

        static void Main(string[] args)
        {
            int precio = 0;
            string pago;
            int tarjeta;
            Boolean pagoCompletado = false;
            
            while (pagoCompletado == false) //Mientras no se confirme el pago
            {
                Console.WriteLine("Introduce el precio del producto: ");
                precio = Convert.ToInt32(Console.ReadLine());
                
                if (precio > 0) // Si el precio es correcto 
                {
                    Console.WriteLine("¿Cómo quieres pagar? efectivo || tarjeta ");
                    pago = Console.ReadLine();
                    while (pago != "efectivo" && pago != "tarjeta")
                    {
                        Console.WriteLine("Error: escribe 'efectivo' o 'tarjeta' para pagar.");
                        // Volvemos a pedir que nos introduzca el método de pago. 
                        Console.WriteLine("¿Cómo quieres pagar? efectivo || tarjeta ");
                        pago = Console.ReadLine();
                    };
                    // Pedimos nºcuenta si paga por tarjeta
                    if (pago == "tarjeta")
                    {
                        Console.WriteLine("Introduzca el número de tarjeta: ");
                    }
                    // Confirmamos el pago
                    pagoCompletado = true;
                }
                else // Si el precio es inferior a 0
                {
                    Console.WriteLine("Error, el valor tiene que ser numérico y positivo");
                }
            }
        }
    }
}
