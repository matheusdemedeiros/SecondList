using System;

namespace SecondListQ3.ConsoleApp
{
    /*
        O IMC – Índice de Massa Corporal é um critério da Organização Mundial
        de Saúde para dar uma indicação sobre a condição de peso de uma pessoa
        adulta
        • A fórmula é IMC = peso / (altura) ²
        • Elabore um algoritmo que leia o peso e a altura de um adulto e mostre
        sua condição de acordo com a tabela abaixo.
        
        IMC em adultos Condição
        * Abaixo de 18,5 Abaixo do peso
        * Entre 18,5 e 25 Peso normal
        * Entre 25 e 30 Acima do peso
        * Acima de 30 obeso
     */


    internal class Program
    {
        static void Main(string[] args)
        {
            decimal weight, height, imc;
            bool isPositive = false;
            do
            {
                Console.Write("Informe o seu peso: ");
                weight = decimal.Parse(Console.ReadLine());

                Console.Write("Informe a sua altura: ");
                height = decimal.Parse(Console.ReadLine());

                if (weight > 0 && height > 0)
                {
                    isPositive = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Os valores informadoss devem ser todos positivos!!\n" +
                        "Tente novamente");
                    Console.ResetColor();
                    continue;
                }

            } while (isPositive == false);

            imc = weight / (height * height);

            if (imc < 18.5m)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ABAIXO DO PESO!!");
                Console.ResetColor();
            }
            else if (imc >= 18.5m && imc < 25m)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PESO NORMAL!!");
            }
            else if (imc >= 25m && imc < 30m)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ACIMA DO PESO!!");
                Console.ResetColor();
            }
            else if (imc >= 30m){ 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("OBESO!!");
                Console.ResetColor();
            }
        }
    }
}