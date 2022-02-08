using System;

namespace SecondListQ4ConsoleApp
{

    /*
     Faça um algoritmo para receber um número qualquer e informar na
     tela se é par ou ímpar.
    */
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um valor (pode ser negativo): ");
            int value = int.Parse(Console.ReadLine());

            if(value % 2 == 0){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("O número informado é PAR!!");
                Console.ResetColor();
            }else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O número informado é ÍMPAR!!");
                Console.ResetColor();
            }
                    

        }
    }
}
