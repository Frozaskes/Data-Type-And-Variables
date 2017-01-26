using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit1 = int.Parse(Console.ReadLine());
            int digit2 = int.Parse(Console.ReadLine());

            var temp = digit1;

            Console.WriteLine("Before: \n a = {0}\n b = {1}", digit1, digit2);
            Console.WriteLine("After: \n a = {0}\n b = {1}", digit2, temp);

        }
    }
}
