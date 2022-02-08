using System;

namespace SecondListQ2
{
    /*
    Escreva um algoritmo que leia três valores inteiros e diferentes e 
    mostre-os em ordem decrescente.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isDifferent = false;
            decimal value1, value2, value3, max1 = 0, max2 = 0, max3 = 0;
            do
            {
                Console.Write("Informe o primeiro valor: ");
                value1 = decimal.Parse(Console.ReadLine());
                Console.Write("Informe o segundo valor: ");
                value2 = decimal.Parse(Console.ReadLine());
                Console.Write("Informe o terceiro valor: ");
                value3 = decimal.Parse(Console.ReadLine());

                if (value1 != value2 && value1 != value3 && value2 != value3)
                {
                    isDifferent = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Os valores informadoss devem ser todos diferentes!!\n" +
                        "Tente novamente");
                    Console.ResetColor();
                    continue;
                }

            } while (isDifferent == false);
            
            if(value1 >= value2 && value1 >= value3)
            {
                max1 = value1;
                
                if(value2 >= value3)
                {
                    max2 = value2;
                    max3 = value3;

                }
                else
                {
                    max2 = value3;
                    max3 = value2;
                }
            }else if (value2 >= value1 && value2 >= value3)
            {
                max1 = value2;

                if (value1 >= value3)
                {
                    max2 = value1;
                    max3 = value3;

                }
                else
                {
                    max2 = value3;
                    max3 = value1;
                }
            }
            else if (value3 >= value2 && value3 >= value1)
            {
                max1 = value3;

                if (value1 >= value2)
                {
                    max2 = value1;
                    max3 = value2;

                }
                else
                {
                    max2 = value2;
                    max3 = value1;
                }
            }

            Console.WriteLine("\n========================================");
            Console.WriteLine("EXIBINDO OS VALORES EM ORDEM DECRESCENTE");
            Console.WriteLine("Primeiro : {0};", max1);
            Console.WriteLine("Segundo  : {0};", max2);
            Console.WriteLine("terceiro : {0};", max3);



        }
    }
}
