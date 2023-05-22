using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBar
{
    class myClass
    {
        private static int total;

        public static void addRule(int input, string output)
        {
            for (var n = 1; n <= total; n++)
            {
                var isDivisible = false;

                if ((n % input) == 0)
                {
                    Console.Write(output);
                    isDivisible = true;
                }

                if (isDivisible)
                    Console.WriteLine();
                else
                    Console.WriteLine(n);
            }
        }
        static void Main()
        {
            Console.WriteLine("Please insert data will showing :");
            var data = Console.ReadLine();
            total = int.Parse(data);
            Console.WriteLine("Please insert input rules :");
            var input = Console.ReadLine();
            Console.WriteLine("Please insert output rules :");
            var output = Console.ReadLine();
            addRule(int.Parse(input), output);
            Console.ReadLine();
        }
    }
}