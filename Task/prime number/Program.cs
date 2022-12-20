// See https:using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lower bound:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the upper bound:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Prime numbers between {n1} and {n2}:");
            for (int i = n1; i <= n2; i++)
            {
                if (CheckPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool CheckPrime(int num)
        {
            if(num == 2) return true;
            if(num <2 ||num%2==0) return false;

            for (int i = 3; i < Math.Sqrt(num); i+=2)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
