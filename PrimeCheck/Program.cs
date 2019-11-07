using System;

namespace PrimeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your number:");
            int num = int.Parse(Console.ReadLine());

            PrimeCheck primecheck = new PrimeCheck();
            primecheck.IsPrimeNumber(num);

            bool write = primecheck.IsPrimeNumber(num);
            Console.WriteLine(write);
        }
    }
}
