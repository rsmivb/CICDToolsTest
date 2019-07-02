using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CICDTools
{
    public class NumberService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate <= 1)
                return false;
            if (candidate == 2) return true;
            return Enumerable.Range(1, candidate).Where(x => candidate % x == 0)
                             .SequenceEqual(new[] { 1, candidate });
        }
        //public bool IsOdd(int number)
        //{
        //    if (number % 2 == 0) return true;
        //    return false;
        //}
    }
}
