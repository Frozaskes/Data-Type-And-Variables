using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());

            string bi = Convert.ToString(digit, 2).ToUpper();
            string hex = Convert.ToString(digit, 16).ToUpper();

            Console.WriteLine(hex);
            Console.WriteLine(bi);
        
        }
    }
}
