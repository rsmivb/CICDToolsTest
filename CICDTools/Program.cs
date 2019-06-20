using System;

namespace CICDTools
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeService primeService = new PrimeService();

            var candidateToPrime = 789;
            var result = primeService.IsPrime(candidateToPrime) ? "is" : "isn't";

            Console.WriteLine($"Number {candidateToPrime} {result} prime.");
        }
    }
}
