using System;

namespace UD4_Ex20
{
    /* 20) Realiza una aplicación que nos pida un número de ventas a introducir, después nos
    pedirá tantas ventas por teclado como número de ventas se hayan indicado. Al final
    mostrara la suma de todas las ventas. Piensa que es lo que se repite y lo que no.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántas ventas has hecho?");
            int numVentas = Convert.ToInt32(Console.ReadLine());
            int totalVentas = 0;

            for (int x=0; x<numVentas; x++)
            {
                Console.WriteLine("Introduce el precio del producto nº{0}", x+1); //x+1 para indicar nº correcto de producto y no 0 al primero, 1 al segundo, etc.
                totalVentas = totalVentas + Convert.ToInt32(Console.ReadLine()); //sumamos la venta al total de ventas que teníamos con antelación.
            }

            Console.WriteLine("La suma total de las ventas es de {0} euros.", totalVentas);
        }
    }
}
