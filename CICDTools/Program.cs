using System;

namespace CICDTools
{
    class Program
    {
        static void Main(string[] args)
        {
            var isPrime = new NumberService().IsPrime(789);
            //var isOdd = new NumberService().IsOdd(789);
        }
    }
}
