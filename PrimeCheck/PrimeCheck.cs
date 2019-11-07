using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeCheck
{
    class PrimeCheck
    {
        public bool IsPrimeNumber(int num)
        {
            if (num < 2)
                return false;

            if (num == 2)
                return true;

            for (var i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
        
            return true;
        }
    }
}
