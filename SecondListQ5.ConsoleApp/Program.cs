using System;
using System.Text.RegularExpressions;

namespace SecondListQ5.ConsoleApp
{
    /*
     Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem
     iguais deverá se somar os dois, caso contrário multiplique A por B.
     Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma
     variável C e mostrar seu conteúdo na tela.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c;
            string operacao;
            bool isNumber = false;

            do
            {

                Console.Write("Informe o primeiro valor inteiro: ");
                string inputA = Console.ReadLine();
                Console.Write("Informe o segundo valor inteiro: ");
                string inputB = Console.ReadLine();

                if (Regex.IsMatch(inputA, @"^[0-9]+$") && Regex.IsMatch(inputB, @"^[0-9]+$"))
                {
                    a = int.Parse(inputA);
                    b = int.Parse(inputB);
                    isNumber = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("DESCULPE AMIGO(A), MAS SÒ PODEM SER INFORMADOS " +
                        "NÚMEROS!!\nTENTE NOVAMENTE!!");
                    Console.ResetColor();
                    continue;
                }

            } while (isNumber == false);

            if (a == b)
            {
                c = a + b;
                operacao = "SOMA";
            }
            else
            {
                c = a * b;
                operacao = "MULTIPLICACAO";
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Valor da variável C: {0}", c);
            Console.WriteLine("\nA operação aritimética realizada foi: {0};", operacao);
            Console.ResetColor();

        }
    }
}
