using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            var gender = Console.ReadLine();
            ulong id = ulong.Parse(Console.ReadLine());
            int payeN = int.Parse(Console.ReadLine());

            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            if (gender == "f")
            {
                Console.WriteLine("Gender: f");
            }
            else if(gender == "m")
                Console.WriteLine("Gender: m");
            Console.WriteLine("Personal ID: {0}", id);
            Console.WriteLine("Unique Employee number: {0}",payeN);
        }
    }
}
