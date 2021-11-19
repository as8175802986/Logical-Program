using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problems
{
    class PerfectNumbers
    {
        public void Check(int number)
        {

            List<int> storeElement = new List<int>();
            int i = 1;
            int sum = 0;
            while (i < number)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                    storeElement.Add(i);
                }
                i++;
            }
            if (sum == number)
            {
                Console.WriteLine(" Is a Perfect Number");
                foreach (int k in storeElement)
                    Console.WriteLine(k);
            }
            else
            {
                Console.WriteLine("Not a Perfect Number");
                storeElement.Clear();
            }
        }
    }
}
