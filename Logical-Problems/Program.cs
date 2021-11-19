using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the Logical Program Press- 1-Fibonacci Series, 2-Coupan Number, 3-Perfect Number, 4-Prime Number ,5-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the length of the Fibonacci Series: ");
                        int length = Convert.ToInt32(Console.ReadLine());
                        FibonacciSeries fc = new FibonacciSeries();
                        fc.Series(length);
                        break;
                    case 2:
                        Console.Write("How many numbers you wants to generate :");
                        int N = Convert.ToInt32(Console.ReadLine());
                        CouponNumbers cn = new CouponNumbers();
                        cn.Calculation(N);
                        break;
                    case 3:
                        Console.Write("Enter the number :");
                        int number = Convert.ToInt32(Console.ReadLine());
                        PerfectNumbers pn = new PerfectNumbers();
                        pn.Check(number);
                        break;
                    case 4:
                        Console.WriteLine("Enter the Number to Check it's a Prime Number or not");
                        int num = Convert.ToInt32(Console.ReadLine());
                        PrimeNumbers prn = new PrimeNumbers();
                        prn.Check(num);
                        break;

                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}
