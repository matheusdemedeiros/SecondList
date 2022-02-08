using System;

namespace SecondList.ConsoleApp
{
    /*
    Faça um algoritmo que leia os valores A, B, C e imprima na tela se a
    soma de A + B é menor que C.
    */
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Informe o valor de A: ");
            decimal a = decimal.Parse(Console.ReadLine());

            Console.Write("Informe o valor de B: ");
            decimal b = decimal.Parse(Console.ReadLine());

            Console.Write("Informe o valor de C: ");
            decimal c = decimal.Parse(Console.ReadLine());

            if((a + b) > c)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nA soma de (A + B) é maior que C.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nA soma de (A + B) é menor que C.");
                Console.ResetColor();
            }

            Console.ReadLine();
        }
    }
}
