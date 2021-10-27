using System;

namespace W02L08
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////
            Console.WriteLine("Program 01");
            int count = 0;
            int allPrimes = 0;
            Console.WriteLine("Prime numbers in a range 0-100: ");
            for (int prime = 2; prime < 101; prime++)
            {
                count = 0;
                if (prime > 1)
                    for (int j = 2; j < prime; j++)
                    {
                        if (prime % j == 0)
                        {
                            count = 1;
                            break;
                        }
                    }
                if (count == 0)
                {
                    allPrimes++;
                    Console.WriteLine(prime);
                }
            }
            Console.WriteLine("The number of primes in the interval 0-100: " + allPrimes);

            ///////////////////////////////////////////////////////////////////
            Console.WriteLine("\nProgram 02: = Even numbers: 0-500");
            int a = 0;
            do
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }
                a++;
            } while (a <= 500);

            ///////////////////////////////////////////////////////////////////
            Console.WriteLine("\nProgram 03: = Ciąg Fibonacciego");
            int a1 = 0;
            int b = 1;
            int n = 10;

            for (int i = 0; i < n; i++)
            {
                b = a1 + b;
                a1 = b - a1;
                Console.WriteLine(a1);
            }

            ///////////////////////////////////////////////////////////////////
            Console.WriteLine("\nProgram 04: Piramida liczb");

            int verse;
            int position;
            int start = 1;
            Console.WriteLine("Please me some number:");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            for (verse = 1; verse <= end; verse++)
            {
                for (position = 1; position < verse + 1; position++)
                {
                    if (start <= end)
                    {
                        Console.Write(start++ + " ");
                    }
                }
                Console.Write("\n");
            }

            ///////////////////////////////////////////////////////////////////
            Console.WriteLine("\nProgram 05: liczby do 3 potęgi");
            int numbers;
            int powValue;
            for (numbers = 0; numbers <= 20; numbers++)
            {
                powValue = (int)Math.Pow(numbers, 3);
                Console.WriteLine(numbers + " =>> " + powValue);
            }

            ///////////////////////////////////////////////////////////////////
            Console.WriteLine("\nProgram 06: Sum according to the formula");

            double result = 0;
            for (double i = 1; i <= 20; i++)
            {
                result = (1 / i) + result;
            }
            Console.WriteLine(result);

            ///////////////////////////////////////////////////////////////////
            Console.WriteLine("\nProgram 07: Diament:");
            Console.WriteLine("Give me a number:");

            int line = Convert.ToInt32(Console.ReadLine());

            //01
            for (int i = 1; i <= line; i++)
            {

                for (int j = 1; j <= (line - i); j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k < i * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //02
            for (int i = line - 1; i >= 1; i--)
            {

                for (int j = 1; j <= (line - i); j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k < i * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            ///////////////////////////////////////////////////////////////////
            Console.WriteLine("\nProgram 08 Reverse word");
            string sign = "";
            string reverse = "";
            int length;
            Console.WriteLine("Enter a Word");
            sign = Console.ReadLine();
            length = sign.Length - 1;
            while (length >= 0)
            {
                reverse = reverse + sign[length];
                length--;
            }
            Console.WriteLine("Reverse word:  " + reverse);

            ///////////////////////////////////////////////////////////////////
            Console.Write("\nProgram 09 Liczba dziesiętna: ");
            int liczbaDziesietna = int.Parse(Console.ReadLine());

            int reszta;
            string wynik = string.Empty;
            while (liczbaDziesietna > 0)
            {
                reszta = liczbaDziesietna % 2;
                liczbaDziesietna /= 2;
                wynik = reszta.ToString() + wynik;
            }
            Console.WriteLine("Liczba binarna:  {0}", wynik);

            ///////////////////////////////////////////////////////////////////
            Console.WriteLine("\nProgram 10 Najmniejsza wspólna wielokrotność");
            int firstNumber;
            int secondNumber;
            int multiple;
            Console.WriteLine("Give first number:");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Give second number:");
            secondNumber = int.Parse((Console.ReadLine()));
            while (firstNumber != secondNumber)
            {
                if (firstNumber > secondNumber)
                {
                    firstNumber -= secondNumber;
                }
                else
                {
                    secondNumber -= firstNumber;
                }
            }
            multiple = firstNumber * secondNumber / firstNumber;
            Console.WriteLine("Wielokrotność =" + multiple);
            Console.ReadKey();
        }
    }
}
