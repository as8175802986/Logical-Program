using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problems
{
    class PrimeNumbers
    {
        public void Check(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % 2 == 1)
                {
                    Console.WriteLine("The Given Number is Prime Number");
                    break;
                }
                else
                {
                    Console.WriteLine("The Given Number is Not a Prime Number");
                    break;
                }
            }
        }
    }
}
