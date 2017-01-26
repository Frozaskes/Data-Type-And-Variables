using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            for (int num = 2; num <= digit; num++)
            {
                bool primer = true;
                for (int divider = 2; divider <= Math.Sqrt(num); divider++)
                {
                    if (num % divider == 0)
                    {
                        primer = false;
                        break;
                    }
                }
                Console.WriteLine($"{num} -> {primer}");
            }

        }
    }
}
