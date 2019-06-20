using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CICDTools
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate <= 1)
                return false;
            if (candidate == 2) return true;
            return Enumerable.Range(1, candidate).Where(x => candidate % x == 0)
                             .SequenceEqual(new[] { 1, candidate });
        }
    }
}
