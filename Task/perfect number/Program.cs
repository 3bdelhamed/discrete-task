using System;

namespace PerfectNumberRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lower bound of the range: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the upper bound of the range: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The perfect numbers in the range are: ");
            for (int i = n1; i <= n2; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }

                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
