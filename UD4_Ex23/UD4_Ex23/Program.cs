using System;

namespace UD4_Ex23
{
    /*
     * 23) Crea una aplicación llamada CalculadoraInversa, nos pedirá 2 operandos (int) y un signo
        aritmético (String), según este último se realizara la operación correspondiente. Al final
        mostrara el resultado en un cuadro de dialogo.
        Los signos aritméticos disponibles son:
        +: suma los dos operandos.
        -: resta los operandos.
        *: multiplica los operandos.
        /: divide los operandos, este debe dar un resultado con decimales (double)
        ^: 1º operando como base y 2º como exponente.
        %: módulo, resto de la división entre operando1 y operando2.

     */
    class CalculadoraInversa
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "Bienvenido a tu calculadora: \n" +
                                "Introducir dígito: ");

            int x = Convert.ToInt32(Console.ReadLine()); // recogemos el primer numero

            Console.WriteLine("Qué operación quieres hacer? \n" +

                              "Los signos aritméticos disponibles son:\n" +
                                "+ : suma los dos operandos.\n" +
                                "- : resta los operandos.\n" +
                                "* : multiplica los operandos.\n" +
                                "/ : divide los operandos, este debe dar un resultado con decimales(double)\n" +
                                "^ : 1º operando como base y 2º como exponente.\n" +
                                "% : módulo, resto de la división entre operando1 y operando2.\n"
                              
                              );

            string op = Console.ReadLine(); // recogemos la operacion

            Console.WriteLine("Introducir dígito: ");
            int y = Convert.ToInt32(Console.ReadLine()); // recogemos el segundo numero

            switch (op)// comprobamos la operacion deseada y calculamos en cada caso.
            {
                case "+":
                    Console.WriteLine(x+y);
                    break;
                case "-":
                    Console.WriteLine(x - y);
                    break;
                case "*":
                    Console.WriteLine(x * y);
                    break;
                case "/":
                    Console.WriteLine(x / y);
                    break;
                case "^":
                    Console.WriteLine(Math.Pow(x,y));
                    break;
                case "%":
                    Console.WriteLine(x % y);
                    break;
            }
        }
    }
}
