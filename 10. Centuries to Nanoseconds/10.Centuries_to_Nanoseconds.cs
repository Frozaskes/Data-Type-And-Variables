using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            ulong days = (ulong)(years * 365.2422);
            ulong hours = 24 * days;
            ulong min = 60 * hours;
            ulong seconds = 60 * min;
            ulong milliseconds = 1000 * seconds;
            ulong microSec = 1000 * milliseconds;
            ulong nanoSec = 1000 * microSec;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds {6} microseconds = {7} nanoseconds", 
                              centuries, years, days, hours, min, seconds, microSec, nanoSec); 




        }
    }
}
