 using System;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input  a number(integer): ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine("Sum of the digits you entered is: " + sum);
            Console.WriteLine("Thank you");

        }
    }
}
