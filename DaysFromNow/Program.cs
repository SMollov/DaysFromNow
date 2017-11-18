using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysFromNow
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;
            Console.WriteLine("The date now is "+ now);
            Console.Write("Type 'days', 'hours', 'seconds' or 'years' : ");
            var input = Console.ReadLine();

            if (input == "days")
            {
                Console.Write("Enter Days : ");
                var number = ulong.Parse(Console.ReadLine());
                DateTime add = now.AddDays(number);
                Console.WriteLine("After {0} days, the date will be {1}" ,number ,add.ToString("dd/MM/yyyy"));
            }

            if (input == "hours")
            {
                Console.Write("Enter Hours : ");
                var number = ulong.Parse(Console.ReadLine());
                DateTime add = now.AddHours(number);
                Console.WriteLine("After {0} hours, the date will be {1}", number, add.ToString());
            }
            if (input == "years")
            {
                Console.Write("Enter Years : ");
                var number = int.Parse(Console.ReadLine());
                DateTime add = now.AddYears(number);
                Console.WriteLine("After {0} years, the date will be {1}", number, add.ToString("dd/MM/yyyy"));
            }
            if (input == "seconds")
            {
                Console.Write("Enter Seconds : ");
                var number = ulong.Parse(Console.ReadLine());
                DateTime add = now.AddSeconds(number);
                Console.WriteLine("After {0} seconds, the date will be {1}", number, add.ToString("dd/MM/yyyy"));
            }


            Console.ReadLine();

            
        }
    }
}
