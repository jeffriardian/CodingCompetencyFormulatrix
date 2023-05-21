using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBar
{
    class myClass
    {

        public static void showData(int data, int input, string output)
        {
            for (var n = 1; n <= data; n++)
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
    }

    class Foobar
    {
        static void Main()
        {
            Console.WriteLine("Please insert data will showing :");
            var data = Console.ReadLine();
            Console.WriteLine("Please insert input rules :");
            var input = Console.ReadLine();
            Console.WriteLine("Please insert output rules :");
            var output = Console.ReadLine();
            myClass.showData(int.Parse(data), int.Parse(input), output);
            Console.ReadLine();
        }
    }
}