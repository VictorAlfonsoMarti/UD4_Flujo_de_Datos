using System;

namespace UD4_Ex16
{
    /* 16) Lee un número por teclado que pida el precio de un producto (puede tener decimales) y
    calcule el precio final con IVA. El IVA será una constante que será del 21%
    */

    class Program
    {
        

        static void Main(string[] args)
        {
            const int iva21 = 21; //Definimos una variable constante. 
        
            Console.WriteLine("Indique el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("El precio final con iva del {0}% es de: {1}", iva21, precio+((precio/100)*iva21));

        }
    }
}
